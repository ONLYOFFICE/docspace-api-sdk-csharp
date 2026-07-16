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
    /// Represents service payment information.
    /// </summary>
    [DataContract(Name = "ServicePayment")]
    public partial class ServicePayment : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ServicePayment" /> class.
        /// </summary>
        /// <param name="operationId">The payment operation ID..</param>
        /// <param name="amount">The balance of the sub-account in the specified currency..</param>
        /// <param name="currency">The three-character ISO 4217 currency symbol..</param>
        /// <param name="quantity">Total quantity of operations..</param>
        /// <param name="subscriptionId">The subscription ID.</param>
        /// <param name="startDate">The subscription start date..</param>
        /// <param name="endDate">The subscription end date..</param>
        public ServicePayment(int operationId = default, double amount = default, string currency = default, int quantity = default, int? subscriptionId = default, DateTime? startDate = default, DateTime? endDate = default)
        {
            this.OperationId = operationId;
            this.Amount = amount;
            this.Currency = currency;
            this.Quantity = quantity;
            this.SubscriptionId = subscriptionId;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        /// <summary>
        /// The payment operation ID.
        /// </summary>
        /// <value>The payment operation ID.</value>
        /*
        <example>12345</example>
        */
        [DataMember(Name = "operationId", EmitDefaultValue = false)]
        public int OperationId { get; set; }

        /// <summary>
        /// The balance of the sub-account in the specified currency.
        /// </summary>
        /// <value>The balance of the sub-account in the specified currency.</value>
        /*
        <example>1500.75</example>
        */
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public double Amount { get; set; }

        /// <summary>
        /// The three-character ISO 4217 currency symbol.
        /// </summary>
        /// <value>The three-character ISO 4217 currency symbol.</value>
        /*
        <example>USD</example>
        */
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Total quantity of operations.
        /// </summary>
        /// <value>Total quantity of operations.</value>
        /*
        <example>10</example>
        */
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// The subscription ID
        /// </summary>
        /// <value>The subscription ID</value>
        /*
        <example>12345</example>
        */
        [DataMember(Name = "subscriptionId", EmitDefaultValue = true)]
        public int? SubscriptionId { get; set; }

        /// <summary>
        /// The subscription start date.
        /// </summary>
        /// <value>The subscription start date.</value>
        /*
        <example>2024-01-15T10:30Z</example>
        */
        [DataMember(Name = "startDate", EmitDefaultValue = true)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The subscription end date.
        /// </summary>
        /// <value>The subscription end date.</value>
        /*
        <example>2024-01-15T10:30Z</example>
        */
        [DataMember(Name = "endDate", EmitDefaultValue = true)]
        public DateTime? EndDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServicePayment {\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  SubscriptionId: ").Append(SubscriptionId).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
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
