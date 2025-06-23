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
    /// The document builder task parameters.
    /// </summary>
    [DataContract(Name = "DocumentBuilderTaskDto")]
    public partial class DocumentBuilderTaskDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public DistributedTaskStatus? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentBuilderTaskDto" /> class.
        /// </summary>
        /// <param name="id">The document builder ID..</param>
        /// <param name="error">The error message occured while the document building process..</param>
        /// <param name="percentage">The percentage of the progress of the document building process..</param>
        /// <param name="isCompleted">Specifies whether the document building process is completed or not..</param>
        /// <param name="status">status.</param>
        /// <param name="resultFileId">The result file ID..</param>
        /// <param name="resultFileName">The result file name..</param>
        /// <param name="resultFileUrl">The result file URL..</param>
        public DocumentBuilderTaskDto(string id = default, string error = default, int percentage = default, bool isCompleted = default, DistributedTaskStatus? status = default, Object resultFileId = default, string resultFileName = default, string resultFileUrl = default)
        {
            this.Id = id;
            this.Error = error;
            this.Percentage = percentage;
            this.IsCompleted = isCompleted;
            this.Status = status;
            this.ResultFileId = resultFileId;
            this.ResultFileName = resultFileName;
            this.ResultFileUrl = resultFileUrl;
        }

        /// <summary>
        /// The document builder ID.
        /// </summary>
        /// <value>The document builder ID.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The error message occured while the document building process.
        /// </summary>
        /// <value>The error message occured while the document building process.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// The percentage of the progress of the document building process.
        /// </summary>
        /// <value>The percentage of the progress of the document building process.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "percentage", EmitDefaultValue = false)]
        public int Percentage { get; set; }

        /// <summary>
        /// Specifies whether the document building process is completed or not.
        /// </summary>
        /// <value>Specifies whether the document building process is completed or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isCompleted", EmitDefaultValue = true)]
        public bool IsCompleted { get; set; }

        /// <summary>
        /// The result file ID.
        /// </summary>
        /// <value>The result file ID.</value>
        /*
        <example>{&quot;int&quot;:1234,&quot;string&quot;:&quot;some text&quot;,&quot;boolean&quot;:true}</example>
        */
        [DataMember(Name = "resultFileId", EmitDefaultValue = true)]
        public Object ResultFileId { get; set; }

        /// <summary>
        /// The result file name.
        /// </summary>
        /// <value>The result file name.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "resultFileName", EmitDefaultValue = true)]
        public string ResultFileName { get; set; }

        /// <summary>
        /// The result file URL.
        /// </summary>
        /// <value>The result file URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "resultFileUrl", EmitDefaultValue = true)]
        public string ResultFileUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DocumentBuilderTaskDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
            sb.Append("  IsCompleted: ").Append(IsCompleted).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ResultFileId: ").Append(ResultFileId).Append("\n");
            sb.Append("  ResultFileName: ").Append(ResultFileName).Append("\n");
            sb.Append("  ResultFileUrl: ").Append(ResultFileUrl).Append("\n");
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
