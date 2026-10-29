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
    /// The spending limit to create on the AI services: for the portal as a whole, for every user, or for one user.
    /// </summary>
    [DataContract(Name = "CreateServiceLimitRequestDto")]
    public partial class CreateServiceLimitRequestDto : IValidatableObject
    {

        /// <summary>
        /// Whom the limit applies to.
        /// </summary>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public ServiceLimitScope? Scope { get; set; }

        /// <summary>
        /// The window the thresholds apply to, in UTC. A day, week or month is calendar-aligned rather than rolling - a  daily limit resets at midnight UTC, a weekly one on Monday - while a lifetime limit counts from its creation and  never resets.
        /// </summary>
        [DataMember(Name = "period", EmitDefaultValue = false)]
        public ServiceLimitPeriod? Period { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateServiceLimitRequestDto" /> class.
        /// </summary>
        /// <param name="scope">Whom the limit applies to..</param>
        /// <param name="userId">The ID of the portal user a personal limit is set for, as returned in &#x60;id&#x60; by the people operations..</param>
        /// <param name="amountValue">The most money the AI services may cost per period, in their currency, which cannot be chosen. Zero blocks the  AI services completely..</param>
        /// <param name="quantityValue">The largest quantity the AI services may consume per period, in their common unit. Zero blocks the AI services  completely..</param>
        /// <param name="period">The window the thresholds apply to, in UTC. A day, week or month is calendar-aligned rather than rolling - a  daily limit resets at midnight UTC, a weekly one on Monday - while a lifetime limit counts from its creation and  never resets..</param>
        public CreateServiceLimitRequestDto(ServiceLimitScope? scope = default, Guid? userId = default, double? amountValue = default, int? quantityValue = default, ServiceLimitPeriod? period = default)
        {
            this.Scope = scope;
            this.UserId = userId;
            this.AmountValue = amountValue;
            this.QuantityValue = quantityValue;
            this.Period = period;
        }

        /// <summary>
        /// The ID of the portal user a personal limit is set for, as returned in &#x60;id&#x60; by the people operations.
        /// </summary>
        /// <example>3f2504e0-4f89-11d3-9a0c-0305e82c3301</example>
        [DataMember(Name = "userId", EmitDefaultValue = true)]
        public Guid? UserId { get; set; }

        /// <summary>
        /// The most money the AI services may cost per period, in their currency, which cannot be chosen. Zero blocks the  AI services completely.
        /// </summary>
        /// <example>50</example>
        [DataMember(Name = "amountValue", EmitDefaultValue = true)]
        public double? AmountValue { get; set; }

        /// <summary>
        /// The largest quantity the AI services may consume per period, in their common unit. Zero blocks the AI services  completely.
        /// </summary>
        /// <example>1000</example>
        [DataMember(Name = "quantityValue", EmitDefaultValue = true)]
        public int? QuantityValue { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateServiceLimitRequestDto {\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  AmountValue: ").Append(AmountValue).Append("\n");
            sb.Append("  QuantityValue: ").Append(QuantityValue).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
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
