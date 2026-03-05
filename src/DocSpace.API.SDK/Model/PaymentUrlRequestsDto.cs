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
    [DataContract(Name = "PaymentUrlRequestsDto")]
    public partial class PaymentUrlRequestsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentUrlRequestsDto" /> class.
        /// </summary>
        /// <param name="backUrl">The URL where the user will be redirected after payment processing..</param>
        /// <param name="quantity">The payment quantity..</param>
        public PaymentUrlRequestsDto(string backUrl = default, Dictionary<string, int> quantity = default)
        {
            this.BackUrl = backUrl;
            this.Quantity = quantity;
        }

        /// <summary>
        /// The URL where the user will be redirected after payment processing.
        /// </summary>
        /// <value>The URL where the user will be redirected after payment processing.</value>
        /*
        <example>https://example.com</example>
        */
        [DataMember(Name = "backUrl", EmitDefaultValue = true)]
        public string BackUrl { get; set; }

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
            sb.Append("class PaymentUrlRequestsDto {\n");
            sb.Append("  BackUrl: ").Append(BackUrl).Append("\n");
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
            yield break;
        }

    }


}
