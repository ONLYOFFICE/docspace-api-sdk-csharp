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
    /// Represents an operation.
    /// </summary>
    [DataContract(Name = "OperationDto")]
    public partial class OperationDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationDto" /> class.
        /// </summary>
        /// <param name="date">date.</param>
        /// <param name="service">The service related to the operation..</param>
        /// <param name="description">The brief operation description..</param>
        /// <param name="details">The detailed information about the operation..</param>
        /// <param name="serviceUnit">The service unit..</param>
        /// <param name="quantity">The quantity of the service used..</param>
        /// <param name="currency">The three-character ISO 4217 currency symbol of the operation..</param>
        /// <param name="credit">The credit amount of the operation..</param>
        /// <param name="debit">The debit amount of the operation..</param>
        /// <param name="participantName">The participant original name..</param>
        /// <param name="participantDisplayName">The participant display name..</param>
        /// <param name="agentId">AI Agent id..</param>
        /// <param name="agentTitle">AI Agent name..</param>
        public OperationDto(ApiDateTime date = default, string service = default, string description = default, string details = default, string serviceUnit = default, int quantity = default, string currency = default, double credit = default, double debit = default, string participantName = default, string participantDisplayName = default, string agentId = default, string agentTitle = default)
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
            this.AgentId = agentId;
            this.AgentTitle = agentTitle;
        }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public ApiDateTime Date { get; set; }

        /// <summary>
        /// The service related to the operation.
        /// </summary>
        /// <value>The service related to the operation.</value>
        /*
        <example>Storage</example>
        */
        [DataMember(Name = "service", EmitDefaultValue = true)]
        public string Service { get; set; }

        /// <summary>
        /// The brief operation description.
        /// </summary>
        /// <value>The brief operation description.</value>
        /*
        <example>Storage quota increase</example>
        */
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The detailed information about the operation.
        /// </summary>
        /// <value>The detailed information about the operation.</value>
        /*
        <example>Increased storage from 50GB to 100GB</example>
        */
        [DataMember(Name = "details", EmitDefaultValue = true)]
        public string Details { get; set; }

        /// <summary>
        /// The service unit.
        /// </summary>
        /// <value>The service unit.</value>
        /*
        <example>GB</example>
        */
        [DataMember(Name = "serviceUnit", EmitDefaultValue = true)]
        public string ServiceUnit { get; set; }

        /// <summary>
        /// The quantity of the service used.
        /// </summary>
        /// <value>The quantity of the service used.</value>
        /*
        <example>1</example>
        */
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// The three-character ISO 4217 currency symbol of the operation.
        /// </summary>
        /// <value>The three-character ISO 4217 currency symbol of the operation.</value>
        /*
        <example>USD</example>
        */
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// The credit amount of the operation.
        /// </summary>
        /// <value>The credit amount of the operation.</value>
        /*
        <example>99.99</example>
        */
        [DataMember(Name = "credit", EmitDefaultValue = false)]
        public double Credit { get; set; }

        /// <summary>
        /// The debit amount of the operation.
        /// </summary>
        /// <value>The debit amount of the operation.</value>
        /*
        <example>99.99</example>
        */
        [DataMember(Name = "debit", EmitDefaultValue = false)]
        public double Debit { get; set; }

        /// <summary>
        /// The participant original name.
        /// </summary>
        /// <value>The participant original name.</value>
        /*
        <example>Example Name</example>
        */
        [DataMember(Name = "participantName", EmitDefaultValue = true)]
        public string ParticipantName { get; set; }

        /// <summary>
        /// The participant display name.
        /// </summary>
        /// <value>The participant display name.</value>
        /*
        <example>Example Name</example>
        */
        [DataMember(Name = "participantDisplayName", EmitDefaultValue = true)]
        public string ParticipantDisplayName { get; set; }

        /// <summary>
        /// AI Agent id.
        /// </summary>
        /// <value>AI Agent id.</value>
        /*
        <example>123</example>
        */
        [DataMember(Name = "agentId", EmitDefaultValue = true)]
        public string AgentId { get; set; }

        /// <summary>
        /// AI Agent name.
        /// </summary>
        /// <value>AI Agent name.</value>
        /*
        <example>My AI Agent</example>
        */
        [DataMember(Name = "agentTitle", EmitDefaultValue = true)]
        public string AgentTitle { get; set; }

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
            sb.Append("  AgentId: ").Append(AgentId).Append("\n");
            sb.Append("  AgentTitle: ").Append(AgentTitle).Append("\n");
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
