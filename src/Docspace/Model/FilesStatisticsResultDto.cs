// (c) Copyright Ascensio System SIA 2009-2025
// 
// This program is a free software product.
// You can redistribute it and/or modify it under the terms
// of the GNU Affero General Public License (AGPL) version 3 as published by the Free Software
// Foundation. In accordance with Section 7(a) of the GNU AGPL its Section 15 shall be amended
// to the effect that Ascensio System SIA expressly excludes the warranty of non-infringement of
// any third-party rights.
// 
// This program is distributed WITHOUT ANY WARRANTY, without even the implied warranty
// of MERCHANTABILITY or FITNESS FOR A PARTICULAR  PURPOSE. For details, see
// the GNU AGPL at: http://www.gnu.org/licenses/agpl-3.0.html
// 
// You can contact Ascensio System SIA at Lubanas st. 125a-25, Riga, Latvia, EU, LV-1021.
// 
// The  interactive user interfaces in modified source and object code versions of the Program must
// display Appropriate Legal Notices, as required under Section 5 of the GNU AGPL version 3.
// 
// Pursuant to Section 7(b) of the License you must retain the original Product logo when
// distributing the program. Pursuant to Section 7(e) we decline to grant you any rights under
// trademark law for use of our trademarks.
// 
// All the Product's GUI elements, including illustrations and icon sets, as well as technical writing
// content are licensed under the terms of the Creative Commons Attribution-ShareAlike 4.0
// International. See the License terms at http://creativecommons.org/licenses/by-sa/4.0/legalcode


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = DocSpace.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.Client.OpenAPIDateConverter;

namespace DocSpace.Model
{
    /// <summary>
    /// The file statistics result parameters.
    /// </summary>
    [DataContract(Name = "FilesStatisticsResultDto")]
    public partial class FilesStatisticsResultDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilesStatisticsResultDto" /> class.
        /// </summary>
        /// <param name="myDocumentsUsedSpace">myDocumentsUsedSpace.</param>
        /// <param name="trashUsedSpace">trashUsedSpace.</param>
        /// <param name="archiveUsedSpace">archiveUsedSpace.</param>
        /// <param name="roomsUsedSpace">roomsUsedSpace.</param>
        public FilesStatisticsResultDto(FilesStatisticsFolder myDocumentsUsedSpace = default, FilesStatisticsFolder trashUsedSpace = default, FilesStatisticsFolder archiveUsedSpace = default, FilesStatisticsFolder roomsUsedSpace = default)
        {
            this.MyDocumentsUsedSpace = myDocumentsUsedSpace;
            this.TrashUsedSpace = trashUsedSpace;
            this.ArchiveUsedSpace = archiveUsedSpace;
            this.RoomsUsedSpace = roomsUsedSpace;
        }

        /// <summary>
        /// Gets or Sets MyDocumentsUsedSpace
        /// </summary>
        [DataMember(Name = "myDocumentsUsedSpace", EmitDefaultValue = false)]
        public FilesStatisticsFolder MyDocumentsUsedSpace { get; set; }

        /// <summary>
        /// Gets or Sets TrashUsedSpace
        /// </summary>
        [DataMember(Name = "trashUsedSpace", EmitDefaultValue = false)]
        public FilesStatisticsFolder TrashUsedSpace { get; set; }

        /// <summary>
        /// Gets or Sets ArchiveUsedSpace
        /// </summary>
        [DataMember(Name = "archiveUsedSpace", EmitDefaultValue = false)]
        public FilesStatisticsFolder ArchiveUsedSpace { get; set; }

        /// <summary>
        /// Gets or Sets RoomsUsedSpace
        /// </summary>
        [DataMember(Name = "roomsUsedSpace", EmitDefaultValue = false)]
        public FilesStatisticsFolder RoomsUsedSpace { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FilesStatisticsResultDto {\n");
            sb.Append("  MyDocumentsUsedSpace: ").Append(MyDocumentsUsedSpace).Append("\n");
            sb.Append("  TrashUsedSpace: ").Append(TrashUsedSpace).Append("\n");
            sb.Append("  ArchiveUsedSpace: ").Append(ArchiveUsedSpace).Append("\n");
            sb.Append("  RoomsUsedSpace: ").Append(RoomsUsedSpace).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }


}
