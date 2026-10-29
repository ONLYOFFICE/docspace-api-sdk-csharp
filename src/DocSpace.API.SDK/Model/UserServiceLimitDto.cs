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
    /// The spending limit on the AI services in force for one user: the user&#39;s personal limit, or else the limit for every  user, together with the money the user spent against it in the current period.
    /// </summary>
    [DataContract(Name = "UserServiceLimitDto")]
    public partial class UserServiceLimitDto : IValidatableObject
    {

        /// <summary>
        /// Whether the limit is the user&#39;s own (&#x60;Custom&#x60;) or the limit for every user (&#x60;Global&#x60;) the user falls back to.
        /// </summary>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public ServiceLimitScope? Scope { get; set; }

        /// <summary>
        /// The window the threshold applies to. It resets at the start of the next day, week or month in UTC (a week on  Monday), not a fixed time after the first charge; a lifetime limit never resets.
        /// </summary>
        [DataMember(Name = "period", EmitDefaultValue = false)]
        public ServiceLimitPeriod? Period { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UserServiceLimitDto" /> class.
        /// </summary>
        /// <param name="id">The service limit ID, used to read, change, switch off or delete the limit through the  &#x60;api/2.0/portal/payment/servicelimit&#x60; operations. For the limit for every user it is the same for all users..</param>
        /// <param name="scope">Whether the limit is the user&#39;s own (&#x60;Custom&#x60;) or the limit for every user (&#x60;Global&#x60;) the user falls back to..</param>
        /// <param name="amountValue">The most money the AI services may cost the user per period, in &#x60;currency&#x60;. It is the only threshold a limit on  the AI services has: their services count in different units, so a threshold on a quantity is refused for them..</param>
        /// <param name="amountConsumed">The money the AI services cost the user in the current period, in &#x60;currency&#x60;; 0 when nothing was spent yet,  including a user who has never used the AI services..</param>
        /// <param name="currency">The currency &#x60;amountValue&#x60; and &#x60;amountConsumed&#x60; are expressed in; null when the limit has no money threshold..</param>
        /// <param name="period">The window the threshold applies to. It resets at the start of the next day, week or month in UTC (a week on  Monday), not a fixed time after the first charge; a lifetime limit never resets..</param>
        /// <param name="periodEnd">The moment the current period ends and the spending starts over from zero, in UTC. Null for a lifetime limit,  which never resets..</param>
        public UserServiceLimitDto(int id = default, ServiceLimitScope? scope = default, double? amountValue = default, double amountConsumed = default, string currency = default, ServiceLimitPeriod? period = default, DateTime? periodEnd = default)
        {
            this.Id = id;
            this.Scope = scope;
            this.AmountValue = amountValue;
            this.AmountConsumed = amountConsumed;
            this.Currency = currency;
            this.Period = period;
            this.PeriodEnd = periodEnd;
        }

        /// <summary>
        /// The service limit ID, used to read, change, switch off or delete the limit through the  &#x60;api/2.0/portal/payment/servicelimit&#x60; operations. For the limit for every user it is the same for all users.
        /// </summary>
        /// <example>42</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The most money the AI services may cost the user per period, in &#x60;currency&#x60;. It is the only threshold a limit on  the AI services has: their services count in different units, so a threshold on a quantity is refused for them.
        /// </summary>
        /// <example>40</example>
        [DataMember(Name = "amountValue", EmitDefaultValue = true)]
        public double? AmountValue { get; set; }

        /// <summary>
        /// The money the AI services cost the user in the current period, in &#x60;currency&#x60;; 0 when nothing was spent yet,  including a user who has never used the AI services.
        /// </summary>
        /// <example>12.5</example>
        [DataMember(Name = "amountConsumed", EmitDefaultValue = false)]
        public double AmountConsumed { get; set; }

        /// <summary>
        /// The currency &#x60;amountValue&#x60; and &#x60;amountConsumed&#x60; are expressed in; null when the limit has no money threshold.
        /// </summary>
        /// <example>USD</example>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// The moment the current period ends and the spending starts over from zero, in UTC. Null for a lifetime limit,  which never resets.
        /// </summary>
        /// <example>2026-10-20T23:59:59.9999999Z</example>
        [DataMember(Name = "periodEnd", EmitDefaultValue = true)]
        public DateTime? PeriodEnd { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserServiceLimitDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  AmountValue: ").Append(AmountValue).Append("\n");
            sb.Append("  AmountConsumed: ").Append(AmountConsumed).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  PeriodEnd: ").Append(PeriodEnd).Append("\n");
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
