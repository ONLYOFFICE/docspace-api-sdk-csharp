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
    /// A spending limit on the AI services: for the portal as a whole, for every user, or for one user.
    /// </summary>
    [DataContract(Name = "ServiceLimitDto")]
    public partial class ServiceLimitDto : IValidatableObject
    {

        /// <summary>
        /// Whom the limit applies to.
        /// </summary>
        [DataMember(Name = "scope", EmitDefaultValue = false)]
        public ServiceLimitScope? Scope { get; set; }

        /// <summary>
        /// The window the thresholds apply to. A day, week or month resets at the start of the next one in UTC (a week on  Monday), not a fixed time after the first charge; a lifetime limit never resets.
        /// </summary>
        [DataMember(Name = "period", EmitDefaultValue = false)]
        public ServiceLimitPeriod? Period { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceLimitDto" /> class.
        /// </summary>
        /// <param name="id">The service limit ID, used to read, change, switch off or delete the limit. In the list of the users the same  ID repeats for every user the limit for every user applies to..</param>
        /// <param name="serviceGroupName">The limited service group; the AI services are &#x60;ai-services&#x60;..</param>
        /// <param name="customerAccountNumber">The number of the billing account of the portal the limit belongs to..</param>
        /// <param name="scope">Whom the limit applies to..</param>
        /// <param name="userId">The ID of the portal user the limit applies to: the user of a personal limit, or, in the list of the users, the  user a limit for every user applies to. Null for a limit of the portal as a whole, and for a limit for every  user read on its own..</param>
        /// <param name="amountValue">The most money the AI services may cost per period, in &#x60;currency&#x60;; null when the limit has no money threshold..</param>
        /// <param name="currency">The currency &#x60;amountValue&#x60; is expressed in; null when the limit has no money threshold..</param>
        /// <param name="quantityValue">The largest quantity the AI services may consume per period, in &#x60;serviceUnit&#x60;; null when the limit has no  quantity threshold..</param>
        /// <param name="serviceUnit">The unit &#x60;quantityValue&#x60; is expressed in; null when the limit has no quantity threshold..</param>
        /// <param name="period">The window the thresholds apply to. A day, week or month resets at the start of the next one in UTC (a week on  Monday), not a fixed time after the first charge; a lifetime limit never resets..</param>
        /// <param name="periodEnd">The last moment of the current period, in UTC, after which the spending starts over from zero; null for a  lifetime limit, which never resets. Filled for every limit, the limit for every user included, whose spending is  counted per user..</param>
        /// <param name="usageFrom">The moment a lifetime limit counts from, in UTC; null for the other periods..</param>
        /// <param name="enabled">Whether the limit is in force. A switched-off limit no longer restricts the AI services and can be switched  back on..</param>
        /// <param name="created">The date and time when the limit was created, in UTC..</param>
        /// <param name="modified">The date and time when the limit was last changed, in UTC..</param>
        /// <param name="usage">What was spent against the limit in its current period and what is left. Filled for the limit of the portal as  a whole and in the list of the users; null where the spending is not read, such as for a limit read by its ID  or the limit for every user, whose spending is counted per user..</param>
        public ServiceLimitDto(int id = default, string serviceGroupName = default, int customerAccountNumber = default, ServiceLimitScope? scope = default, Guid? userId = default, double? amountValue = default, string currency = default, int? quantityValue = default, string serviceUnit = default, ServiceLimitPeriod? period = default, DateTime? periodEnd = default, DateTime? usageFrom = default, bool enabled = default, DateTime created = default, DateTime modified = default, ServiceLimitUsageDto usage = default)
        {
            this.Id = id;
            this.ServiceGroupName = serviceGroupName;
            this.CustomerAccountNumber = customerAccountNumber;
            this.Scope = scope;
            this.UserId = userId;
            this.AmountValue = amountValue;
            this.Currency = currency;
            this.QuantityValue = quantityValue;
            this.ServiceUnit = serviceUnit;
            this.Period = period;
            this.PeriodEnd = periodEnd;
            this.UsageFrom = usageFrom;
            this.Enabled = enabled;
            this.Created = created;
            this.Modified = modified;
            this.Usage = usage;
        }

        /// <summary>
        /// The service limit ID, used to read, change, switch off or delete the limit. In the list of the users the same  ID repeats for every user the limit for every user applies to.
        /// </summary>
        /// <example>42</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The limited service group; the AI services are &#x60;ai-services&#x60;.
        /// </summary>
        /// <example>ai-services</example>
        [DataMember(Name = "serviceGroupName", EmitDefaultValue = true)]
        public string ServiceGroupName { get; set; }

        /// <summary>
        /// The number of the billing account of the portal the limit belongs to.
        /// </summary>
        /// <example>12345</example>
        [DataMember(Name = "customerAccountNumber", EmitDefaultValue = false)]
        public int CustomerAccountNumber { get; set; }

        /// <summary>
        /// The ID of the portal user the limit applies to: the user of a personal limit, or, in the list of the users, the  user a limit for every user applies to. Null for a limit of the portal as a whole, and for a limit for every  user read on its own.
        /// </summary>
        /// <example>3f2504e0-4f89-11d3-9a0c-0305e82c3301</example>
        [DataMember(Name = "userId", EmitDefaultValue = true)]
        public Guid? UserId { get; set; }

        /// <summary>
        /// The most money the AI services may cost per period, in &#x60;currency&#x60;; null when the limit has no money threshold.
        /// </summary>
        /// <example>50</example>
        [DataMember(Name = "amountValue", EmitDefaultValue = true)]
        public double? AmountValue { get; set; }

        /// <summary>
        /// The currency &#x60;amountValue&#x60; is expressed in; null when the limit has no money threshold.
        /// </summary>
        /// <example>USD</example>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// The largest quantity the AI services may consume per period, in &#x60;serviceUnit&#x60;; null when the limit has no  quantity threshold.
        /// </summary>
        /// <example>1000</example>
        [DataMember(Name = "quantityValue", EmitDefaultValue = true)]
        public int? QuantityValue { get; set; }

        /// <summary>
        /// The unit &#x60;quantityValue&#x60; is expressed in; null when the limit has no quantity threshold.
        /// </summary>
        /// <example>request</example>
        [DataMember(Name = "serviceUnit", EmitDefaultValue = true)]
        public string ServiceUnit { get; set; }

        /// <summary>
        /// The last moment of the current period, in UTC, after which the spending starts over from zero; null for a  lifetime limit, which never resets. Filled for every limit, the limit for every user included, whose spending is  counted per user.
        /// </summary>
        /// <example>2026-10-22T23:59:59.9999999Z</example>
        [DataMember(Name = "periodEnd", EmitDefaultValue = true)]
        public DateTime? PeriodEnd { get; set; }

        /// <summary>
        /// The moment a lifetime limit counts from, in UTC; null for the other periods.
        /// </summary>
        /// <example>2026-10-01T09:12:00Z</example>
        [DataMember(Name = "usageFrom", EmitDefaultValue = true)]
        public DateTime? UsageFrom { get; set; }

        /// <summary>
        /// Whether the limit is in force. A switched-off limit no longer restricts the AI services and can be switched  back on.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// The date and time when the limit was created, in UTC.
        /// </summary>
        /// <example>2026-09-01T10:30:00Z</example>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The date and time when the limit was last changed, in UTC.
        /// </summary>
        /// <example>2026-09-15T08:00:00Z</example>
        [DataMember(Name = "modified", EmitDefaultValue = false)]
        public DateTime Modified { get; set; }

        /// <summary>
        /// What was spent against the limit in its current period and what is left. Filled for the limit of the portal as  a whole and in the list of the users; null where the spending is not read, such as for a limit read by its ID  or the limit for every user, whose spending is counted per user.
        /// </summary>
        [DataMember(Name = "usage", EmitDefaultValue = false)]
        public ServiceLimitUsageDto Usage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServiceLimitDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ServiceGroupName: ").Append(ServiceGroupName).Append("\n");
            sb.Append("  CustomerAccountNumber: ").Append(CustomerAccountNumber).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  AmountValue: ").Append(AmountValue).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  QuantityValue: ").Append(QuantityValue).Append("\n");
            sb.Append("  ServiceUnit: ").Append(ServiceUnit).Append("\n");
            sb.Append("  Period: ").Append(Period).Append("\n");
            sb.Append("  PeriodEnd: ").Append(PeriodEnd).Append("\n");
            sb.Append("  UsageFrom: ").Append(UsageFrom).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Modified: ").Append(Modified).Append("\n");
            sb.Append("  Usage: ").Append(Usage).Append("\n");
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
