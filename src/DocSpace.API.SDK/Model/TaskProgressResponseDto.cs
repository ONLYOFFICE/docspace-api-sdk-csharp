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
    /// The task progress response parameters.
    /// </summary>
    [DataContract(Name = "TaskProgressResponseDto")]
    public partial class TaskProgressResponseDto : IValidatableObject
    {

        /// <summary>
        /// The status of the distributed task.
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public DistributedTaskStatus Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskProgressResponseDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaskProgressResponseDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskProgressResponseDto" /> class.
        /// </summary>
        /// <param name="id">The task progress ID. (required).</param>
        /// <param name="error">The task progress error message..</param>
        /// <param name="percentage">The percentage of the task progress. (required).</param>
        /// <param name="isCompleted">Specifies if the task peogress is completed or not. (required).</param>
        /// <param name="status">The status of the distributed task. (required).</param>
        public TaskProgressResponseDto(string id = default, string error = default, int percentage = default, bool isCompleted = default, DistributedTaskStatus status = default)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for TaskProgressResponseDto and cannot be null");
            }
            this.Id = id;
            this.Percentage = percentage;
            this.IsCompleted = isCompleted;
            this.Status = status;
            this.Error = error;
        }

        /// <summary>
        /// The task progress ID.
        /// </summary>
        /// <example>task-123456</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The task progress error message.
        /// </summary>
        /// <example>An error occurred during processing</example>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// The percentage of the task progress.
        /// </summary>
        /// <example>75</example>
        [DataMember(Name = "percentage", IsRequired = true, EmitDefaultValue = true)]
        public int Percentage { get; set; }

        /// <summary>
        /// Specifies if the task peogress is completed or not.
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
            sb.Append("class TaskProgressResponseDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
            sb.Append("  IsCompleted: ").Append(IsCompleted).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
