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
    /// What has been spent against a spending limit in its current period, and what is left.
    /// </summary>
    [DataContract(Name = "ServiceLimitUsageDto")]
    public partial class ServiceLimitUsageDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceLimitUsageDto" /> class.
        /// </summary>
        /// <param name="periodStart">The start of the current period, in UTC..</param>
        /// <param name="periodEnd">The end of the current period, in UTC: the moment the spending starts again from zero. Null for a lifetime  limit, which never resets..</param>
        /// <param name="amountConsumed">The money charged in the current period, in the currency of the limit..</param>
        /// <param name="amountAvailable">The money still available in the current period: the threshold less what was charged and what is reserved for  operations in progress, never below zero. Null when the limit has no money threshold..</param>
        /// <param name="quantityConsumed">The quantity consumed in the current period, in the unit of the limit..</param>
        /// <param name="quantityAvailable">The quantity still available in the current period, never below zero; null when the limit has no quantity  threshold..</param>
        public ServiceLimitUsageDto(DateTime periodStart = default, DateTime? periodEnd = default, double amountConsumed = default, double? amountAvailable = default, int quantityConsumed = default, int? quantityAvailable = default)
        {
            this.PeriodStart = periodStart;
            this.PeriodEnd = periodEnd;
            this.AmountConsumed = amountConsumed;
            this.AmountAvailable = amountAvailable;
            this.QuantityConsumed = quantityConsumed;
            this.QuantityAvailable = quantityAvailable;
        }

        /// <summary>
        /// The start of the current period, in UTC.
        /// </summary>
        /// <example>2026-10-18T00:00:00Z</example>
        [DataMember(Name = "periodStart", EmitDefaultValue = false)]
        public DateTime PeriodStart { get; set; }

        /// <summary>
        /// The end of the current period, in UTC: the moment the spending starts again from zero. Null for a lifetime  limit, which never resets.
        /// </summary>
        /// <example>2026-10-18T23:59:59Z</example>
        [DataMember(Name = "periodEnd", EmitDefaultValue = true)]
        public DateTime? PeriodEnd { get; set; }

        /// <summary>
        /// The money charged in the current period, in the currency of the limit.
        /// </summary>
        /// <example>12.5</example>
        [DataMember(Name = "amountConsumed", EmitDefaultValue = false)]
        public double AmountConsumed { get; set; }

        /// <summary>
        /// The money still available in the current period: the threshold less what was charged and what is reserved for  operations in progress, never below zero. Null when the limit has no money threshold.
        /// </summary>
        /// <example>27.5</example>
        [DataMember(Name = "amountAvailable", EmitDefaultValue = true)]
        public double? AmountAvailable { get; set; }

        /// <summary>
        /// The quantity consumed in the current period, in the unit of the limit.
        /// </summary>
        /// <example>250</example>
        [DataMember(Name = "quantityConsumed", EmitDefaultValue = false)]
        public int QuantityConsumed { get; set; }

        /// <summary>
        /// The quantity still available in the current period, never below zero; null when the limit has no quantity  threshold.
        /// </summary>
        /// <example>750</example>
        [DataMember(Name = "quantityAvailable", EmitDefaultValue = true)]
        public int? QuantityAvailable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceLimitUsageDto {\n");
            sb.Append("  PeriodStart: ").Append(PeriodStart).Append("\n");
            sb.Append("  PeriodEnd: ").Append(PeriodEnd).Append("\n");
            sb.Append("  AmountConsumed: ").Append(AmountConsumed).Append("\n");
            sb.Append("  AmountAvailable: ").Append(AmountAvailable).Append("\n");
            sb.Append("  QuantityConsumed: ").Append(QuantityConsumed).Append("\n");
            sb.Append("  QuantityAvailable: ").Append(QuantityAvailable).Append("\n");
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
