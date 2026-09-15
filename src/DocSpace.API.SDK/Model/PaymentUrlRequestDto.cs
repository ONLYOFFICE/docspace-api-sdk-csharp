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
    /// The plan being bought and the two pages the hosted checkout returns the buyer to.
    /// </summary>
    [DataContract(Name = "PaymentUrlRequestDto")]
    public partial class PaymentUrlRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentUrlRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentUrlRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentUrlRequestDto" /> class.
        /// </summary>
        /// <param name="backUrl">The absolute address the hosted checkout page sends the buyer back to when the purchase is abandoned. It has  to be a well-formed URL and is carried into the checkout page as it is given, so it must be reachable by the  buyer rather than by the portal. (required).</param>
        /// <param name="successUrl">The absolute address the hosted checkout page sends the buyer to once the payment provider accepts the  purchase. Reaching it says the provider took the money, not that the portal has already been switched to the  new plan, so a client that lands here reads the plan back rather than assuming it. (required).</param>
        /// <param name="quantity">The plan being bought, as a single pair of the plan name and the number of units of it. The key is the &#x60;name&#x60;  of a monthly, non-wallet quota from &#x60;GET api/2.0/portal/payment/quotas&#x60;, and the value is how many  administrators the plan is to cover, which has to be greater than zero. Exactly one pair is accepted; yearly  and wallet products are refused with 400, and wallet services are bought through  &#x60;PUT api/2.0/portal/payment/updatewallet&#x60; instead. (required).</param>
        public PaymentUrlRequestDto(string backUrl = default, string successUrl = default, Dictionary<string, int> quantity = default)
        {
            // to ensure "backUrl" is required (not null)
            if (backUrl == null)
            {
                throw new ArgumentNullException("backUrl is a required property for PaymentUrlRequestDto and cannot be null");
            }
            this.BackUrl = backUrl;
            // to ensure "successUrl" is required (not null)
            if (successUrl == null)
            {
                throw new ArgumentNullException("successUrl is a required property for PaymentUrlRequestDto and cannot be null");
            }
            this.SuccessUrl = successUrl;
            // to ensure "quantity" is required (not null)
            if (quantity == null)
            {
                throw new ArgumentNullException("quantity is a required property for PaymentUrlRequestDto and cannot be null");
            }
            this.Quantity = quantity;
        }

        /// <summary>
        /// The absolute address the hosted checkout page sends the buyer back to when the purchase is abandoned. It has  to be a well-formed URL and is carried into the checkout page as it is given, so it must be reachable by the  buyer rather than by the portal.
        /// </summary>
        /// <example>https://example.com/payment/back</example>
        [DataMember(Name = "backUrl", IsRequired = true, EmitDefaultValue = true)]
        public string BackUrl { get; set; }

        /// <summary>
        /// The absolute address the hosted checkout page sends the buyer to once the payment provider accepts the  purchase. Reaching it says the provider took the money, not that the portal has already been switched to the  new plan, so a client that lands here reads the plan back rather than assuming it.
        /// </summary>
        /// <example>https://example.com/payment/success</example>
        [DataMember(Name = "successUrl", IsRequired = true, EmitDefaultValue = true)]
        public string SuccessUrl { get; set; }

        /// <summary>
        /// The plan being bought, as a single pair of the plan name and the number of units of it. The key is the &#x60;name&#x60;  of a monthly, non-wallet quota from &#x60;GET api/2.0/portal/payment/quotas&#x60;, and the value is how many  administrators the plan is to cover, which has to be greater than zero. Exactly one pair is accepted; yearly  and wallet products are refused with 400, and wallet services are bought through  &#x60;PUT api/2.0/portal/payment/updatewallet&#x60; instead.
        /// </summary>
        /// <example>{"admin":1}</example>
        [DataMember(Name = "quantity", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, int> Quantity { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentUrlRequestDto {\n");
            sb.Append("  BackUrl: ").Append(BackUrl).Append("\n");
            sb.Append("  SuccessUrl: ").Append(SuccessUrl).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // BackUrl (string) maxLength
            if (this.BackUrl != null && this.BackUrl.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BackUrl, length must be less than 255.", new [] { "BackUrl" });
            }

            // BackUrl (string) minLength
            if (this.BackUrl != null && this.BackUrl.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for BackUrl, length must be greater than 0.", new [] { "BackUrl" });
            }

            // SuccessUrl (string) maxLength
            if (this.SuccessUrl != null && this.SuccessUrl.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SuccessUrl, length must be less than 255.", new [] { "SuccessUrl" });
            }

            // SuccessUrl (string) minLength
            if (this.SuccessUrl != null && this.SuccessUrl.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SuccessUrl, length must be greater than 0.", new [] { "SuccessUrl" });
            }

            yield break;
        }

    }


}
