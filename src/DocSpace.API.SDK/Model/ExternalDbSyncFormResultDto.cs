// (c) Copyright Ascensio System SIA 2026
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.


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
using FileParameter = DocSpace.API.SDK.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.API.SDK.Client.OpenAPIDateConverter;

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// What happened to one original form while the room was being exported to the external database.
    /// </summary>
    [DataContract(Name = "ExternalDbSyncFormResultDto")]
    public partial class ExternalDbSyncFormResultDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalDbSyncFormResultDto" /> class.
        /// </summary>
        /// <param name="id">The file of the original form whose collected data was exported. It is the form itself, not one of the filled  copies, so the same id can be read with the file operations of the portal..</param>
        /// <param name="title">The name of that form file at the moment of the export. It is empty when the form file no longer exists, which  is also the case in which the export of that entry fails..</param>
        /// <param name="success">Whether the data of this form reached the external database. One rejected form does not stop the others, so a  finished job can hold both successful and failed entries..</param>
        /// <param name="error">Why this form was not exported. It is empty for a successful entry, and for a failed one it carries either the  message of the underlying failure or the generic export error of the portal..</param>
        public ExternalDbSyncFormResultDto(int id = default, string title = default, bool success = default, string error = default)
        {
            this.Id = id;
            this.Title = title;
            this.Success = success;
            this.Error = error;
        }

        /// <summary>
        /// The file of the original form whose collected data was exported. It is the form itself, not one of the filled  copies, so the same id can be read with the file operations of the portal.
        /// </summary>
        /// <example>42</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The name of that form file at the moment of the export. It is empty when the form file no longer exists, which  is also the case in which the export of that entry fails.
        /// </summary>
        /// <example>Application.pdf</example>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Whether the data of this form reached the external database. One rejected form does not stop the others, so a  finished job can hold both successful and failed entries.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "success", EmitDefaultValue = true)]
        public bool Success { get; set; }

        /// <summary>
        /// Why this form was not exported. It is empty for a successful entry, and for a failed one it carries either the  message of the underlying failure or the generic export error of the portal.
        /// </summary>
        /// <example>Connection refused</example>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalDbSyncFormResultDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
