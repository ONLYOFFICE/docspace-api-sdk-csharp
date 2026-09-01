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
    /// The external DB synchronization task parameters.
    /// </summary>
    [DataContract(Name = "ExternalDbSyncTaskDto")]
    public partial class ExternalDbSyncTaskDto : IValidatableObject
    {

        /// <summary>
        /// The status of the synchronization task.
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public DistributedTaskStatus Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalDbSyncTaskDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExternalDbSyncTaskDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalDbSyncTaskDto" /> class.
        /// </summary>
        /// <param name="id">The task ID. (required).</param>
        /// <param name="error">The error message if the synchronization failed..</param>
        /// <param name="percentage">The progress percentage of the synchronization. (required).</param>
        /// <param name="isCompleted">Specifies whether the synchronization is completed or not. (required).</param>
        /// <param name="status">The status of the synchronization task. (required).</param>
        /// <param name="forms">The synchronization results for all original forms in the room. (required).</param>
        public ExternalDbSyncTaskDto(string id = default, string error = default, int percentage = default, bool isCompleted = default, DistributedTaskStatus status = default, List<ExternalDbSyncFormResultDto> forms = default)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for ExternalDbSyncTaskDto and cannot be null");
            }
            this.Id = id;
            this.Percentage = percentage;
            this.IsCompleted = isCompleted;
            this.Status = status;
            // to ensure "forms" is required (not null)
            if (forms == null)
            {
                throw new ArgumentNullException("forms is a required property for ExternalDbSyncTaskDto and cannot be null");
            }
            this.Forms = forms;
            this.Error = error;
        }

        /// <summary>
        /// The task ID.
        /// </summary>
        /// <example>ExternalDbSyncTask_1_42</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The error message if the synchronization failed.
        /// </summary>
        /// <example>Connection refused</example>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// The progress percentage of the synchronization.
        /// </summary>
        /// <example>75</example>
        [DataMember(Name = "percentage", IsRequired = true, EmitDefaultValue = true)]
        public int Percentage { get; set; }

        /// <summary>
        /// Specifies whether the synchronization is completed or not.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isCompleted", IsRequired = true, EmitDefaultValue = true)]
        public bool IsCompleted { get; set; }

        /// <summary>
        /// The synchronization results for all original forms in the room.
        /// </summary>
        /// <example>[{"id":42,"title":"Application.pdf","success":true}]</example>
        [DataMember(Name = "forms", IsRequired = true, EmitDefaultValue = true)]
        public List<ExternalDbSyncFormResultDto> Forms { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalDbSyncTaskDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
            sb.Append("  IsCompleted: ").Append(IsCompleted).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Forms: ").Append(Forms).Append("\n");
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
