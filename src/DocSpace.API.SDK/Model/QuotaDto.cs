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
    /// A quota - a plan, an add-on or a wallet service - with its price, the features it switches on and their limits.
    /// </summary>
    [DataContract(Name = "QuotaDto")]
    public partial class QuotaDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QuotaDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaDto" /> class.
        /// </summary>
        /// <param name="id">The identifier of the quota, which is what the tariff reports as a quota &#x60;id&#x60; and what a purchase names.  A negative value belongs to a built-in quota rather than one on the price list. (required).</param>
        /// <param name="title">The quota name in the portal language, for printing rather than matching. It is empty when this build  ships no wording for the quota, which is normal for a quota that is not on the public price list..</param>
        /// <param name="price">What the quota costs, in the currency resolved for the request. Its &#x60;value&#x60; is empty for a quota that is  not sold for money, which is what &#x60;free&#x60;, &#x60;trial&#x60; and &#x60;nonProfit&#x60; describe. (required).</param>
        /// <param name="nonProfit">Whether this is the non-profit quota, which is granted rather than bought. A portal on it cannot buy any  other plan, so a catalogue asked for plans returns this one alone. (required).</param>
        /// <param name="free">Whether this is the free quota a portal falls back to when nothing is paid for. It has no end date and  the tightest limits of any quota. (required).</param>
        /// <param name="trial">Whether this is the trial quota, which grants the paid limits for a while and then expires. A trial is not  extended by paying - a plan has to be bought instead. (required).</param>
        /// <param name="features">The features the quota switches on, each with the limit it grants and, on the quota the portal is  actually on, how much of that limit is already used. A feature that is absent is off, so the list is the  whole truth about what the quota includes. (required).</param>
        /// <param name="usersQuota">The per-member storage allowance an administrator has set on top of the quota, and whether it is applied  at all. It describes the live portal rather than this quota, so every entry of a catalogue listing repeats  the same values, and it is empty unless the portal is a server installation or its plan includes  statistics..</param>
        /// <param name="roomsQuota">The same kind of per-room storage override, filled in and read the same way as &#x60;usersQuota&#x60;..</param>
        /// <param name="aiAgentsQuota">The same kind of per-agent storage override for AI agents, filled in and read the same way as  &#x60;usersQuota&#x60;..</param>
        /// <param name="tenantCustomQuota">The storage allowance an administrator has set for the portal as a whole, which caps it below what the  quota grants. Filled in under the same conditions as &#x60;usersQuota&#x60;..</param>
        /// <param name="dueDate">When the quota runs out, in UTC. It is empty on a quota from the catalogue, which has no date until it is  bought, and on a quota that never expires..</param>
        public QuotaDto(int id = default, string title = default, PriceDto price = default, bool nonProfit = default, bool free = default, bool trial = default, List<TenantQuotaFeatureDto> features = default, TenantEntityQuotaSettings usersQuota = default, TenantEntityQuotaSettings roomsQuota = default, TenantEntityQuotaSettings aiAgentsQuota = default, TenantQuotaSettings tenantCustomQuota = default, DateTime? dueDate = default)
        {
            this.Id = id;
            // to ensure "price" is required (not null)
            if (price == null)
            {
                throw new ArgumentNullException("price is a required property for QuotaDto and cannot be null");
            }
            this.Price = price;
            this.NonProfit = nonProfit;
            this.Free = free;
            this.Trial = trial;
            // to ensure "features" is required (not null)
            if (features == null)
            {
                throw new ArgumentNullException("features is a required property for QuotaDto and cannot be null");
            }
            this.Features = features;
            this.Title = title;
            this.UsersQuota = usersQuota;
            this.RoomsQuota = roomsQuota;
            this.AiAgentsQuota = aiAgentsQuota;
            this.TenantCustomQuota = tenantCustomQuota;
            this.DueDate = dueDate;
        }

        /// <summary>
        /// The identifier of the quota, which is what the tariff reports as a quota &#x60;id&#x60; and what a purchase names.  A negative value belongs to a built-in quota rather than one on the price list.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public int Id { get; set; }

        /// <summary>
        /// The quota name in the portal language, for printing rather than matching. It is empty when this build  ships no wording for the quota, which is normal for a quota that is not on the public price list.
        /// </summary>
        /// <example>Basic Plan</example>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// What the quota costs, in the currency resolved for the request. Its &#x60;value&#x60; is empty for a quota that is  not sold for money, which is what &#x60;free&#x60;, &#x60;trial&#x60; and &#x60;nonProfit&#x60; describe.
        /// </summary>
        [DataMember(Name = "price", IsRequired = true, EmitDefaultValue = true)]
        public PriceDto Price { get; set; }

        /// <summary>
        /// Whether this is the non-profit quota, which is granted rather than bought. A portal on it cannot buy any  other plan, so a catalogue asked for plans returns this one alone.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "nonProfit", IsRequired = true, EmitDefaultValue = true)]
        public bool NonProfit { get; set; }

        /// <summary>
        /// Whether this is the free quota a portal falls back to when nothing is paid for. It has no end date and  the tightest limits of any quota.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "free", IsRequired = true, EmitDefaultValue = true)]
        public bool Free { get; set; }

        /// <summary>
        /// Whether this is the trial quota, which grants the paid limits for a while and then expires. A trial is not  extended by paying - a plan has to be bought instead.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "trial", IsRequired = true, EmitDefaultValue = true)]
        public bool Trial { get; set; }

        /// <summary>
        /// The features the quota switches on, each with the limit it grants and, on the quota the portal is  actually on, how much of that limit is already used. A feature that is absent is off, so the list is the  whole truth about what the quota includes.
        /// </summary>
        /// <example>[{"id":"00000000-0000-0000-0000-000000000001","title":"Premium Storage"}]</example>
        [DataMember(Name = "features", IsRequired = true, EmitDefaultValue = true)]
        public List<TenantQuotaFeatureDto> Features { get; set; }

        /// <summary>
        /// The per-member storage allowance an administrator has set on top of the quota, and whether it is applied  at all. It describes the live portal rather than this quota, so every entry of a catalogue listing repeats  the same values, and it is empty unless the portal is a server installation or its plan includes  statistics.
        /// </summary>
        [DataMember(Name = "usersQuota", EmitDefaultValue = false)]
        public TenantEntityQuotaSettings UsersQuota { get; set; }

        /// <summary>
        /// The same kind of per-room storage override, filled in and read the same way as &#x60;usersQuota&#x60;.
        /// </summary>
        [DataMember(Name = "roomsQuota", EmitDefaultValue = false)]
        public TenantEntityQuotaSettings RoomsQuota { get; set; }

        /// <summary>
        /// The same kind of per-agent storage override for AI agents, filled in and read the same way as  &#x60;usersQuota&#x60;.
        /// </summary>
        [DataMember(Name = "aiAgentsQuota", EmitDefaultValue = false)]
        public TenantEntityQuotaSettings AiAgentsQuota { get; set; }

        /// <summary>
        /// The storage allowance an administrator has set for the portal as a whole, which caps it below what the  quota grants. Filled in under the same conditions as &#x60;usersQuota&#x60;.
        /// </summary>
        [DataMember(Name = "tenantCustomQuota", EmitDefaultValue = false)]
        public TenantQuotaSettings TenantCustomQuota { get; set; }

        /// <summary>
        /// When the quota runs out, in UTC. It is empty on a quota from the catalogue, which has no date until it is  bought, and on a quota that never expires.
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [DataMember(Name = "dueDate", EmitDefaultValue = true)]
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuotaDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  NonProfit: ").Append(NonProfit).Append("\n");
            sb.Append("  Free: ").Append(Free).Append("\n");
            sb.Append("  Trial: ").Append(Trial).Append("\n");
            sb.Append("  Features: ").Append(Features).Append("\n");
            sb.Append("  UsersQuota: ").Append(UsersQuota).Append("\n");
            sb.Append("  RoomsQuota: ").Append(RoomsQuota).Append("\n");
            sb.Append("  AiAgentsQuota: ").Append(AiAgentsQuota).Append("\n");
            sb.Append("  TenantCustomQuota: ").Append(TenantCustomQuota).Append("\n");
            sb.Append("  DueDate: ").Append(DueDate).Append("\n");
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
