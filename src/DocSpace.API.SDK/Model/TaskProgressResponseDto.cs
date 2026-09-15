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
        /// The state of the job: &#x60;Created&#x60; while it waits in the queue, &#x60;Running&#x60; while it works, &#x60;Completed&#x60; once it has  finished on its own, &#x60;Canceled&#x60; after a terminate operation, and &#x60;Failted&#x60; when it stopped on an error, in  which case &#x60;error&#x60; carries the reason.
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
        /// <param name="id">The ID of the queued job. It identifies this run of the job and changes every time the job is started again. (required).</param>
        /// <param name="error">The message of the error that stopped the job. It is empty while the job is running and after a job that  succeeded, and it is the only place where the reason for a failure is reported..</param>
        /// <param name="percentage">The share of the job that is already done, from 0 to 100. (required).</param>
        /// <param name="isCompleted">Specifies whether the job has stopped running. This is the field to poll: true means the job will not change  any more, whether it succeeded, failed or was cancelled, and &#x60;status&#x60; tells which of the three it is. (required).</param>
        /// <param name="status">The state of the job: &#x60;Created&#x60; while it waits in the queue, &#x60;Running&#x60; while it works, &#x60;Completed&#x60; once it has  finished on its own, &#x60;Canceled&#x60; after a terminate operation, and &#x60;Failted&#x60; when it stopped on an error, in  which case &#x60;error&#x60; carries the reason. (required).</param>
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
        /// The ID of the queued job. It identifies this run of the job and changes every time the job is started again.
        /// </summary>
        /// <example>task-123456</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The message of the error that stopped the job. It is empty while the job is running and after a job that  succeeded, and it is the only place where the reason for a failure is reported.
        /// </summary>
        /// <example>An error occurred during processing</example>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// The share of the job that is already done, from 0 to 100.
        /// </summary>
        /// <example>75</example>
        [DataMember(Name = "percentage", IsRequired = true, EmitDefaultValue = true)]
        public int Percentage { get; set; }

        /// <summary>
        /// Specifies whether the job has stopped running. This is the field to poll: true means the job will not change  any more, whether it succeeded, failed or was cancelled, and &#x60;status&#x60; tells which of the three it is.
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
