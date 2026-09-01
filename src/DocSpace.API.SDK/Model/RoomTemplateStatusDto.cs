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
    /// The room template status.
    /// </summary>
    [DataContract(Name = "RoomTemplateStatusDto")]
    public partial class RoomTemplateStatusDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomTemplateStatusDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoomTemplateStatusDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomTemplateStatusDto" /> class.
        /// </summary>
        /// <param name="templateId">The room template ID. (required).</param>
        /// <param name="progress">The progress of the room template creation process. (required).</param>
        /// <param name="error">The error message that is sent when the room template is not created successfully..</param>
        /// <param name="isCompleted">Specifies whether the process of creating the room template is completed. (required).</param>
        public RoomTemplateStatusDto(int templateId = default, double progress = default, string error = default, bool isCompleted = default)
        {
            this.TemplateId = templateId;
            this.Progress = progress;
            this.IsCompleted = isCompleted;
            this.Error = error;
        }

        /// <summary>
        /// The room template ID.
        /// </summary>
        /// <example>123</example>
        [DataMember(Name = "templateId", IsRequired = true, EmitDefaultValue = true)]
        public int TemplateId { get; set; }

        /// <summary>
        /// The progress of the room template creation process.
        /// </summary>
        /// <example>75.5</example>
        [DataMember(Name = "progress", IsRequired = true, EmitDefaultValue = true)]
        public double Progress { get; set; }

        /// <summary>
        /// The error message that is sent when the room template is not created successfully.
        /// </summary>
        /// <example>Template creation failed</example>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// Specifies whether the process of creating the room template is completed.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isCompleted", IsRequired = true, EmitDefaultValue = true)]
        public bool IsCompleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoomTemplateStatusDto {\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  IsCompleted: ").Append(IsCompleted).Append("\n");
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
