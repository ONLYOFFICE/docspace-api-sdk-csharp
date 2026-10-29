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
    /// The new thresholds and state of an existing service limit.
    /// </summary>
    [DataContract(Name = "UpdateServiceLimitRequestDto")]
    public partial class UpdateServiceLimitRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateServiceLimitRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UpdateServiceLimitRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateServiceLimitRequestDto" /> class.
        /// </summary>
        /// <param name="id">The ID of the service limit, as returned in &#x60;id&#x60; by the operation that created it or by the reads of limits. (required).</param>
        /// <param name="amountValue">The most money the AI services may cost per period, in their currency. Zero blocks the AI services completely..</param>
        /// <param name="quantityValue">The largest quantity the AI services may consume per period, in their common unit. Zero blocks the AI services  completely..</param>
        /// <param name="enabled">Whether the limit is in force: false switches it off at once, true switches it back on..</param>
        public UpdateServiceLimitRequestDto(int id = default, double? amountValue = default, int? quantityValue = default, bool? enabled = default)
        {
            this.Id = id;
            this.AmountValue = amountValue;
            this.QuantityValue = quantityValue;
            this.Enabled = enabled;
        }

        /// <summary>
        /// The ID of the service limit, as returned in &#x60;id&#x60; by the operation that created it or by the reads of limits.
        /// </summary>
        /// <example>42</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public int Id { get; set; }

        /// <summary>
        /// The most money the AI services may cost per period, in their currency. Zero blocks the AI services completely.
        /// </summary>
        /// <example>100</example>
        [DataMember(Name = "amountValue", EmitDefaultValue = true)]
        public double? AmountValue { get; set; }

        /// <summary>
        /// The largest quantity the AI services may consume per period, in their common unit. Zero blocks the AI services  completely.
        /// </summary>
        /// <example>2000</example>
        [DataMember(Name = "quantityValue", EmitDefaultValue = true)]
        public int? QuantityValue { get; set; }

        /// <summary>
        /// Whether the limit is in force: false switches it off at once, true switches it back on.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateServiceLimitRequestDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AmountValue: ").Append(AmountValue).Append("\n");
            sb.Append("  QuantityValue: ").Append(QuantityValue).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
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
            // Id (int) maximum
            if (this.Id > (int)2147483647)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must be a value less than or equal to 2147483647.", new [] { "Id" });
            }

            // Id (int) minimum
            if (this.Id < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, must be a value greater than or equal to 1.", new [] { "Id" });
            }

            // AmountValue (double?) maximum
            if (this.AmountValue > (double?)10000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AmountValue, must be a value less than or equal to 10000.", new [] { "AmountValue" });
            }

            // AmountValue (double?) minimum
            if (this.AmountValue < (double?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for AmountValue, must be a value greater than or equal to 0.", new [] { "AmountValue" });
            }

            // QuantityValue (int?) maximum
            if (this.QuantityValue > (int?)2147483647)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for QuantityValue, must be a value less than or equal to 2147483647.", new [] { "QuantityValue" });
            }

            // QuantityValue (int?) minimum
            if (this.QuantityValue < (int?)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for QuantityValue, must be a value greater than or equal to 0.", new [] { "QuantityValue" });
            }

            yield break;
        }

    }


}
