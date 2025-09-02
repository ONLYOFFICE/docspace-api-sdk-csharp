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
    /// Parameters of the request for generating the report on client operations
    /// </summary>
    [DataContract(Name = "CustomerOperationsReportRequestDto")]
    public partial class CustomerOperationsReportRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerOperationsReportRequestDto" /> class.
        /// </summary>
        /// <param name="startDate">Start date.</param>
        /// <param name="endDate">End date.</param>
        /// <param name="participantName">Participant name.</param>
        /// <param name="credit">Include credit operations.</param>
        /// <param name="debit">Include debit operations.</param>
        public CustomerOperationsReportRequestDto(DateTime? startDate = default, DateTime? endDate = default, string participantName = default, bool? credit = default, bool? debit = default)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.ParticipantName = participantName;
            this.Credit = credit;
            this.Debit = debit;
        }

        /// <summary>
        /// Start date
        /// </summary>
        /// <value>Start date</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "startDate", EmitDefaultValue = true)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// End date
        /// </summary>
        /// <value>End date</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "endDate", EmitDefaultValue = true)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Participant name
        /// </summary>
        /// <value>Participant name</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "participantName", EmitDefaultValue = true)]
        public string ParticipantName { get; set; }

        /// <summary>
        /// Include credit operations
        /// </summary>
        /// <value>Include credit operations</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "credit", EmitDefaultValue = true)]
        public bool? Credit { get; set; }

        /// <summary>
        /// Include debit operations
        /// </summary>
        /// <value>Include debit operations</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "debit", EmitDefaultValue = true)]
        public bool? Debit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerOperationsReportRequestDto {\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  ParticipantName: ").Append(ParticipantName).Append("\n");
            sb.Append("  Credit: ").Append(Credit).Append("\n");
            sb.Append("  Debit: ").Append(Debit).Append("\n");
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
