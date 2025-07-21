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


 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// Represents a sub-account with a specific currency and amount.
    /// </summary>
    [DataContract(Name = "SubAccount")]
    public partial class SubAccount : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SubAccount" /> class.
        /// </summary>
        /// <param name="currency">The three-character ISO 4217 currency symbol of the sub-account..</param>
        /// <param name="amount">The amount of the sub-account..</param>
        public SubAccount(string currency = default, double amount = default)
        {
            this.Currency = currency;
            this.Amount = amount;
        }

        /// <summary>
        /// The three-character ISO 4217 currency symbol of the sub-account.
        /// </summary>
        /// <value>The three-character ISO 4217 currency symbol of the sub-account.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// The amount of the sub-account.
        /// </summary>
        /// <value>The amount of the sub-account.</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public double Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubAccount {\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
