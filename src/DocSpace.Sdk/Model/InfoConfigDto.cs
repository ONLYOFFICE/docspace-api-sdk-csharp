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
using FileParameter = DocSpace.Sdk.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.Sdk.Client.OpenAPIDateConverter;

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The information config parameters.
    /// </summary>
    [DataContract(Name = "InfoConfigDto")]
    public partial class InfoConfigDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public EditorType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InfoConfigDto" /> class.
        /// </summary>
        /// <param name="favorite">Specifies if the file is favorite or not..</param>
        /// <param name="folder">The folder of the file..</param>
        /// <param name="owner">The file owner..</param>
        /// <param name="sharingSettings">The sharing settings of the file..</param>
        /// <param name="type">type.</param>
        /// <param name="uploaded">The uploaded file..</param>
        public InfoConfigDto(bool? favorite = default, string folder = default, string owner = default, List<AceShortWrapper> sharingSettings = default, EditorType? type = default, string uploaded = default)
        {
            this.Favorite = favorite;
            this.Folder = folder;
            this.Owner = owner;
            this.SharingSettings = sharingSettings;
            this.Type = type;
            this.Uploaded = uploaded;
        }

        /// <summary>
        /// Specifies if the file is favorite or not.
        /// </summary>
        /// <value>Specifies if the file is favorite or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "favorite", EmitDefaultValue = true)]
        public bool? Favorite { get; set; }

        /// <summary>
        /// The folder of the file.
        /// </summary>
        /// <value>The folder of the file.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "folder", EmitDefaultValue = true)]
        public string Folder { get; set; }

        /// <summary>
        /// The file owner.
        /// </summary>
        /// <value>The file owner.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "owner", EmitDefaultValue = true)]
        public string Owner { get; set; }

        /// <summary>
        /// The sharing settings of the file.
        /// </summary>
        /// <value>The sharing settings of the file.</value>
        [DataMember(Name = "sharingSettings", EmitDefaultValue = true)]
        public List<AceShortWrapper> SharingSettings { get; set; }

        /// <summary>
        /// The uploaded file.
        /// </summary>
        /// <value>The uploaded file.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "uploaded", EmitDefaultValue = true)]
        public string Uploaded { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InfoConfigDto {\n");
            sb.Append("  Favorite: ").Append(Favorite).Append("\n");
            sb.Append("  Folder: ").Append(Folder).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
            sb.Append("  SharingSettings: ").Append(SharingSettings).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Uploaded: ").Append(Uploaded).Append("\n");
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
