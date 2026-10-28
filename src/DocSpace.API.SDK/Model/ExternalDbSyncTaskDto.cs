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
    /// The state of the job that exports the collected form data of a form filling room into the external database of the  portal.
    /// </summary>
    [DataContract(Name = "ExternalDbSyncTaskDto")]
    public partial class ExternalDbSyncTaskDto : IValidatableObject
    {

        /// <summary>
        /// How the job ended, or how far it has got: queued, running, finished, cancelled or failed. It is the only field  that separates a successful end from a failed one once &#x60;isCompleted&#x60; is set.
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
        /// <param name="id">The identifier of the job, which stays the same while a job for this room exists and is worth quoting when a  failure has to be traced in the portal logs. Polling is done by room, so the value is not needed to read the  state again. (required).</param>
        /// <param name="error">The message of a failure that stopped the whole job. It is empty while the job is running and after a job that  ended without such a failure; a job that finished with individual forms rejected reports those in &#x60;forms&#x60; and  leaves this field empty..</param>
        /// <param name="percentage">How much of the work is done, from 0 to 100. It advances as the forms of the room are processed one by one, so  it is a usable progress indicator for a room with many forms and jumps straight to the end for a room with  one. (required).</param>
        /// <param name="isCompleted">Whether the job has ended. It is set both for a job that finished its work and for one that stopped on an  error, so this is the flag to poll for, and &#x60;status&#x60; and &#x60;error&#x60; are what tell the two apart. (required).</param>
        /// <param name="status">How the job ended, or how far it has got: queued, running, finished, cancelled or failed. It is the only field  that separates a successful end from a failed one once &#x60;isCompleted&#x60; is set. (required).</param>
        /// <param name="forms">The outcome for every original form of the room, one entry each. The list is empty while the job is running  and is filled in only when the job ends, so it is what to read after &#x60;isCompleted&#x60; turns true; it stays empty  for a room that holds no forms at all. (required).</param>
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
        /// The identifier of the job, which stays the same while a job for this room exists and is worth quoting when a  failure has to be traced in the portal logs. Polling is done by room, so the value is not needed to read the  state again.
        /// </summary>
        /// <example>ExternalDbSyncTask_1_42</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The message of a failure that stopped the whole job. It is empty while the job is running and after a job that  ended without such a failure; a job that finished with individual forms rejected reports those in &#x60;forms&#x60; and  leaves this field empty.
        /// </summary>
        /// <example>Connection refused</example>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// How much of the work is done, from 0 to 100. It advances as the forms of the room are processed one by one, so  it is a usable progress indicator for a room with many forms and jumps straight to the end for a room with  one.
        /// </summary>
        /// <example>75</example>
        [DataMember(Name = "percentage", IsRequired = true, EmitDefaultValue = true)]
        public int Percentage { get; set; }

        /// <summary>
        /// Whether the job has ended. It is set both for a job that finished its work and for one that stopped on an  error, so this is the flag to poll for, and &#x60;status&#x60; and &#x60;error&#x60; are what tell the two apart.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isCompleted", IsRequired = true, EmitDefaultValue = true)]
        public bool IsCompleted { get; set; }

        /// <summary>
        /// The outcome for every original form of the room, one entry each. The list is empty while the job is running  and is filled in only when the job ends, so it is what to read after &#x60;isCompleted&#x60; turns true; it stays empty  for a room that holds no forms at all.
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
