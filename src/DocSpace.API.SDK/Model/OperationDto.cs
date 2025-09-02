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
    /// Represents an operation.
    /// </summary>
    [DataContract(Name = "OperationDto")]
    public partial class OperationDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationDto" /> class.
        /// </summary>
        /// <param name="date">date.</param>
        /// <param name="service">Service related to the operation..</param>
        /// <param name="description">Brief description of the operation..</param>
        /// <param name="details">Brief details of the operation..</param>
        /// <param name="serviceUnit">Unit of the service..</param>
        /// <param name="quantity">Quantity of the service used..</param>
        /// <param name="currency">The three-character ISO 4217 currency symbol of the operation..</param>
        /// <param name="credit">Credit amount of the operation..</param>
        /// <param name="debit">Debit amount of the operation..</param>
        /// <param name="participantName">Original name of the participant..</param>
        /// <param name="participantDisplayName">Display name of the participant..</param>
        public OperationDto(ApiDateTime date = default, string service = default, string description = default, string details = default, string serviceUnit = default, int quantity = default, string currency = default, double credit = default, double debit = default, string participantName = default, string participantDisplayName = default)
        {
            this.Date = date;
            this.Service = service;
            this.Description = description;
            this.Details = details;
            this.ServiceUnit = serviceUnit;
            this.Quantity = quantity;
            this.Currency = currency;
            this.Credit = credit;
            this.Debit = debit;
            this.ParticipantName = participantName;
            this.ParticipantDisplayName = participantDisplayName;
        }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public ApiDateTime Date { get; set; }

        /// <summary>
        /// Service related to the operation.
        /// </summary>
        /// <value>Service related to the operation.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "service", EmitDefaultValue = true)]
        public string Service { get; set; }

        /// <summary>
        /// Brief description of the operation.
        /// </summary>
        /// <value>Brief description of the operation.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Brief details of the operation.
        /// </summary>
        /// <value>Brief details of the operation.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "details", EmitDefaultValue = true)]
        public string Details { get; set; }

        /// <summary>
        /// Unit of the service.
        /// </summary>
        /// <value>Unit of the service.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "serviceUnit", EmitDefaultValue = true)]
        public string ServiceUnit { get; set; }

        /// <summary>
        /// Quantity of the service used.
        /// </summary>
        /// <value>Quantity of the service used.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// The three-character ISO 4217 currency symbol of the operation.
        /// </summary>
        /// <value>The three-character ISO 4217 currency symbol of the operation.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Credit amount of the operation.
        /// </summary>
        /// <value>Credit amount of the operation.</value>
        [DataMember(Name = "credit", EmitDefaultValue = false)]
        public double Credit { get; set; }

        /// <summary>
        /// Debit amount of the operation.
        /// </summary>
        /// <value>Debit amount of the operation.</value>
        [DataMember(Name = "debit", EmitDefaultValue = false)]
        public double Debit { get; set; }

        /// <summary>
        /// Original name of the participant.
        /// </summary>
        /// <value>Original name of the participant.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "participantName", EmitDefaultValue = true)]
        public string ParticipantName { get; set; }

        /// <summary>
        /// Display name of the participant.
        /// </summary>
        /// <value>Display name of the participant.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "participantDisplayName", EmitDefaultValue = true)]
        public string ParticipantDisplayName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperationDto {\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  ServiceUnit: ").Append(ServiceUnit).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Credit: ").Append(Credit).Append("\n");
            sb.Append("  Debit: ").Append(Debit).Append("\n");
            sb.Append("  ParticipantName: ").Append(ParticipantName).Append("\n");
            sb.Append("  ParticipantDisplayName: ").Append(ParticipantDisplayName).Append("\n");
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
