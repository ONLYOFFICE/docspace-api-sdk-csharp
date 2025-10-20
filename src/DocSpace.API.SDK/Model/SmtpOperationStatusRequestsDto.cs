// (c) Copyright Ascensio System SIA 2025
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

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
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
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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
