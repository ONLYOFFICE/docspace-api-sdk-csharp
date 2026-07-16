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
    /// The request parameters for the payment URL configuration with quantity information.
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
        /// <param name="backUrl">The URL where the user will be redirected after payment cancellation. (required).</param>
        /// <param name="successUrl">The URL where the user will be redirected after successful payment. (required).</param>
        /// <param name="quantity">The payment quantity..</param>
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
            this.Quantity = quantity;
        }

        /// <summary>
        /// The URL where the user will be redirected after payment cancellation.
        /// </summary>
        /// <value>The URL where the user will be redirected after payment cancellation.</value>
        /*
        <example>https://example.com/payment/back</example>
        */
        [DataMember(Name = "backUrl", IsRequired = true, EmitDefaultValue = true)]
        public string BackUrl { get; set; }

        /// <summary>
        /// The URL where the user will be redirected after successful payment.
        /// </summary>
        /// <value>The URL where the user will be redirected after successful payment.</value>
        /*
        <example>https://example.com/payment/success</example>
        */
        [DataMember(Name = "successUrl", IsRequired = true, EmitDefaultValue = true)]
        public string SuccessUrl { get; set; }

        /// <summary>
        /// The payment quantity.
        /// </summary>
        /// <value>The payment quantity.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = true)]
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
