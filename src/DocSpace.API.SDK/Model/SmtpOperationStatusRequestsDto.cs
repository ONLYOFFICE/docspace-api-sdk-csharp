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
    /// The state of the background job that sends the portal SMTP test message.
    /// </summary>
    [DataContract(Name = "SmtpOperationStatusRequestsDto")]
    public partial class SmtpOperationStatusRequestsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SmtpOperationStatusRequestsDto" /> class.
        /// </summary>
        /// <param name="completed">Whether the job has finished. This is the field to poll; the first answer that reports it true also discards  the job, so read &#x60;error&#x60; out of that same answer rather than calling again..</param>
        /// <param name="id">The identifier of the queued job. A portal only ever has one test job at a time, so it names the run rather  than selecting among several..</param>
        /// <param name="error">Why the test failed. It stays empty while the job runs and also once the relay has accepted the message, so  an empty value on a finished job is what success looks like; an unreachable relay is reported here after a  30-second connection timeout rather than as a failed request..</param>
        /// <param name="status">The step the job has reached, in words - &#x60;Connect to host&#x60; or &#x60;Send test message&#x60;, for instance. It is meant  to be shown to a person and is not a fixed set of values to branch on..</param>
        /// <param name="percents">How far the job has got, as a percentage climbing to 100. Reaching 100 says the job ran to the end, not that  the message was accepted - that is what an empty &#x60;error&#x60; says..</param>
        public SmtpOperationStatusRequestsDto(bool completed = default, string id = default, string error = default, string status = default, int percents = default)
        {
            this.Completed = completed;
            this.Id = id;
            this.Error = error;
            this.Status = status;
            this.Percents = percents;
        }

        /// <summary>
        /// Whether the job has finished. This is the field to poll; the first answer that reports it true also discards  the job, so read &#x60;error&#x60; out of that same answer rather than calling again.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "completed", EmitDefaultValue = true)]
        public bool Completed { get; set; }

        /// <summary>
        /// The identifier of the queued job. A portal only ever has one test job at a time, so it names the run rather  than selecting among several.
        /// </summary>
        /// <example>smtp-op-123</example>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Why the test failed. It stays empty while the job runs and also once the relay has accepted the message, so  an empty value on a finished job is what success looks like; an unreachable relay is reported here after a  30-second connection timeout rather than as a failed request.
        /// </summary>
        /// <example>SMTP connection failed.</example>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// The step the job has reached, in words - &#x60;Connect to host&#x60; or &#x60;Send test message&#x60;, for instance. It is meant  to be shown to a person and is not a fixed set of values to branch on.
        /// </summary>
        /// <example>Completed</example>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// How far the job has got, as a percentage climbing to 100. Reaching 100 says the job ran to the end, not that  the message was accepted - that is what an empty &#x60;error&#x60; says.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "percents", EmitDefaultValue = false)]
        public int Percents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
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
