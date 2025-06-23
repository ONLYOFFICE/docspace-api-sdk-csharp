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
using FileParameter = Docspace.Client.FileParameter;
using OpenAPIDateConverter = Docspace.Client.OpenAPIDateConverter;

namespace Docspace.Model
{
    /// <summary>
    /// The request parameters for deleting file versions.
    /// </summary>
    [DataContract(Name = "DeleteVersionBatchRequestDto")]
    public partial class DeleteVersionBatchRequestDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteVersionBatchRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeleteVersionBatchRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteVersionBatchRequestDto" /> class.
        /// </summary>
        /// <param name="returnSingleOperation">Specifies whether to return only the current operation.</param>
        /// <param name="deleteAfter">Specifies whether to delete a file after the editing session is finished or not..</param>
        /// <param name="fileId">The file ID to delete. (required).</param>
        /// <param name="versions">The collection of file versions to be deleted. (required).</param>
        public DeleteVersionBatchRequestDto(bool returnSingleOperation = default, bool deleteAfter = default, int fileId = default, List<int> versions = default)
        {
            this.FileId = fileId;
            // to ensure "versions" is required (not null)
            if (versions == null)
            {
                throw new ArgumentNullException("versions is a required property for DeleteVersionBatchRequestDto and cannot be null");
            }
            this.Versions = versions;
            this.ReturnSingleOperation = returnSingleOperation;
            this.DeleteAfter = deleteAfter;
        }

        /// <summary>
        /// Specifies whether to return only the current operation
        /// </summary>
        /// <value>Specifies whether to return only the current operation</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "returnSingleOperation", EmitDefaultValue = true)]
        public bool ReturnSingleOperation { get; set; }

        /// <summary>
        /// Specifies whether to delete a file after the editing session is finished or not.
        /// </summary>
        /// <value>Specifies whether to delete a file after the editing session is finished or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "deleteAfter", EmitDefaultValue = true)]
        public bool DeleteAfter { get; set; }

        /// <summary>
        /// The file ID to delete.
        /// </summary>
        /// <value>The file ID to delete.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "fileId", IsRequired = true, EmitDefaultValue = true)]
        public int FileId { get; set; }

        /// <summary>
        /// The collection of file versions to be deleted.
        /// </summary>
        /// <value>The collection of file versions to be deleted.</value>
        /*
        <example>[1234]</example>
        */
        [DataMember(Name = "versions", IsRequired = true, EmitDefaultValue = true)]
        public List<int> Versions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeleteVersionBatchRequestDto {\n");
            sb.Append("  ReturnSingleOperation: ").Append(ReturnSingleOperation).Append("\n");
            sb.Append("  DeleteAfter: ").Append(DeleteAfter).Append("\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  Versions: ").Append(Versions).Append("\n");
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
