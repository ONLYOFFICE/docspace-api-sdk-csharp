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
    /// The request parameters for tracking SMTP (Simple Mail Transfer Protocol) operation status.
    /// </summary>
    [DataContract(Name = "SmtpOperationStatusRequestsDto")]
    public partial class SmtpOperationStatusRequestsDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmtpOperationStatusRequestsDto" /> class.
        /// </summary>
        /// <param name="completed">Specifies whether the SMTP operation has finished processing..</param>
        /// <param name="id">The unique identifier for tracking the SMTP operation..</param>
        /// <param name="error">The error message if the SMTP operation encountered issues..</param>
        /// <param name="status">The current state of the SMTP operation..</param>
        /// <param name="percents">The progress indicator showing completion percentage of the operation..</param>
        public SmtpOperationStatusRequestsDto(bool completed = default, string id = default, string error = default, string status = default, int percents = default)
        {
            this.Completed = completed;
            this.Id = id;
            this.Error = error;
            this.Status = status;
            this.Percents = percents;
        }

        /// <summary>
        /// Specifies whether the SMTP operation has finished processing.
        /// </summary>
        /// <value>Specifies whether the SMTP operation has finished processing.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "completed", EmitDefaultValue = true)]
        public bool Completed { get; set; }

        /// <summary>
        /// The unique identifier for tracking the SMTP operation.
        /// </summary>
        /// <value>The unique identifier for tracking the SMTP operation.</value>
        /*
        <example>{some-random-guid}</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The error message if the SMTP operation encountered issues.
        /// </summary>
        /// <value>The error message if the SMTP operation encountered issues.</value>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// The current state of the SMTP operation.
        /// </summary>
        /// <value>The current state of the SMTP operation.</value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// The progress indicator showing completion percentage of the operation.
        /// </summary>
        /// <value>The progress indicator showing completion percentage of the operation.</value>
        /*
        <example>0</example>
        */
        [DataMember(Name = "percents", EmitDefaultValue = false)]
        public int Percents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SmtpOperationStatusRequestsDto {\n");
            sb.Append("  Completed: ").Append(Completed).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Percents: ").Append(Percents).Append("\n");
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
