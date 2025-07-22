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
    /// The payment calculation.
    /// </summary>
    [DataContract(Name = "PaymentCalculation")]
    public partial class PaymentCalculation : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCalculation" /> class.
        /// </summary>
        /// <param name="operationId">Unique identifier of the operation..</param>
        /// <param name="amount">The amount of the payment calculation..</param>
        /// <param name="currency">The three-character ISO 4217 currency symbol of the payment calculation..</param>
        /// <param name="quantity">The quantity associated with the payment calculation..</param>
        public PaymentCalculation(long operationId = default, double amount = default, string currency = default, int quantity = default)
        {
            this.OperationId = operationId;
            this.Amount = amount;
            this.Currency = currency;
            this.Quantity = quantity;
        }

        /// <summary>
        /// Unique identifier of the operation.
        /// </summary>
        /// <value>Unique identifier of the operation.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "operationId", EmitDefaultValue = false)]
        public long OperationId { get; set; }

        /// <summary>
        /// The amount of the payment calculation.
        /// </summary>
        /// <value>The amount of the payment calculation.</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public double Amount { get; set; }

        /// <summary>
        /// The three-character ISO 4217 currency symbol of the payment calculation.
        /// </summary>
        /// <value>The three-character ISO 4217 currency symbol of the payment calculation.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// The quantity associated with the payment calculation.
        /// </summary>
        /// <value>The quantity associated with the payment calculation.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentCalculation {\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
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
