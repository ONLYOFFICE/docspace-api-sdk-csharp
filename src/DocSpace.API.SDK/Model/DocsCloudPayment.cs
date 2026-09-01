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
    /// Represents the payment information of a DocsCloud tenant.
    /// </summary>
    [DataContract(Name = "DocsCloudPayment")]
    public partial class DocsCloudPayment : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocsCloudPayment" /> class.
        /// </summary>
        /// <param name="cartId">The cart ID..</param>
        /// <param name="productId">The product ID..</param>
        /// <param name="status">The payment status..</param>
        /// <param name="intervalUnit">The interval unit..</param>
        /// <param name="isYear">Whether the payment interval is yearly..</param>
        /// <param name="isPrepaid">Whether the payment is prepaid..</param>
        /// <param name="quantity">The quantity..</param>
        /// <param name="currency">The three-character ISO 4217 currency symbol of the payment..</param>
        public DocsCloudPayment(string cartId = default, int productId = default, int status = default, int intervalUnit = default, bool isYear = default, bool isPrepaid = default, int quantity = default, string currency = default)
        {
            this.CartId = cartId;
            this.ProductId = productId;
            this.Status = status;
            this.IntervalUnit = intervalUnit;
            this.IsYear = isYear;
            this.IsPrepaid = isPrepaid;
            this.Quantity = quantity;
            this.Currency = currency;
        }

        /// <summary>
        /// The cart ID.
        /// </summary>
        /// <example>CartId</example>
        [DataMember(Name = "cartId", EmitDefaultValue = true)]
        public string CartId { get; set; }

        /// <summary>
        /// The product ID.
        /// </summary>
        /// <example>12345</example>
        [DataMember(Name = "productId", EmitDefaultValue = false)]
        public int ProductId { get; set; }

        /// <summary>
        /// The payment status.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public int Status { get; set; }

        /// <summary>
        /// The interval unit.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "intervalUnit", EmitDefaultValue = false)]
        public int IntervalUnit { get; set; }

        /// <summary>
        /// Whether the payment interval is yearly.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isYear", EmitDefaultValue = true)]
        public bool IsYear { get; set; }

        /// <summary>
        /// Whether the payment is prepaid.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isPrepaid", EmitDefaultValue = true)]
        public bool IsPrepaid { get; set; }

        /// <summary>
        /// The quantity.
        /// </summary>
        /// <example>10</example>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// The three-character ISO 4217 currency symbol of the payment.
        /// </summary>
        /// <example>USD</example>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocsCloudPayment {\n");
            sb.Append("  CartId: ").Append(CartId).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  IntervalUnit: ").Append(IntervalUnit).Append("\n");
            sb.Append("  IsYear: ").Append(IsYear).Append("\n");
            sb.Append("  IsPrepaid: ").Append(IsPrepaid).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
