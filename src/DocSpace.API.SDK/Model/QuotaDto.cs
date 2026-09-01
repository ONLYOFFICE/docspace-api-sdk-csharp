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
    /// The quota information.
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
        /// <param name="id">The quota ID. (required).</param>
        /// <param name="title">The quota title..</param>
        /// <param name="price">The price parameters. (required).</param>
        /// <param name="nonProfit">Specifies if the quota is nonprofit or not. (required).</param>
        /// <param name="free">Specifies if the quota is free or not. (required).</param>
        /// <param name="trial">Specifies if the quota is trial or not. (required).</param>
        /// <param name="features">The list of tenant quota features. (required).</param>
        /// <param name="usersQuota">The user quota..</param>
        /// <param name="roomsQuota">The room quota..</param>
        /// <param name="aiAgentsQuota">The ai agent quota..</param>
        /// <param name="tenantCustomQuota">The tenant custom quota..</param>
        /// <param name="dueDate">The due date..</param>
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
        /// The quota ID.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public int Id { get; set; }

        /// <summary>
        /// The quota title.
        /// </summary>
        /// <example>Basic Plan</example>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The price parameters.
        /// </summary>
        [DataMember(Name = "price", IsRequired = true, EmitDefaultValue = true)]
        public PriceDto Price { get; set; }

        /// <summary>
        /// Specifies if the quota is nonprofit or not.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "nonProfit", IsRequired = true, EmitDefaultValue = true)]
        public bool NonProfit { get; set; }

        /// <summary>
        /// Specifies if the quota is free or not.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "free", IsRequired = true, EmitDefaultValue = true)]
        public bool Free { get; set; }

        /// <summary>
        /// Specifies if the quota is trial or not.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "trial", IsRequired = true, EmitDefaultValue = true)]
        public bool Trial { get; set; }

        /// <summary>
        /// The list of tenant quota features.
        /// </summary>
        /// <example>[{"id":"00000000-0000-0000-0000-000000000001","title":"Premium Storage"}]</example>
        [DataMember(Name = "features", IsRequired = true, EmitDefaultValue = true)]
        public List<TenantQuotaFeatureDto> Features { get; set; }

        /// <summary>
        /// The user quota.
        /// </summary>
        [DataMember(Name = "usersQuota", EmitDefaultValue = false)]
        public TenantEntityQuotaSettings UsersQuota { get; set; }

        /// <summary>
        /// The room quota.
        /// </summary>
        [DataMember(Name = "roomsQuota", EmitDefaultValue = false)]
        public TenantEntityQuotaSettings RoomsQuota { get; set; }

        /// <summary>
        /// The ai agent quota.
        /// </summary>
        [DataMember(Name = "aiAgentsQuota", EmitDefaultValue = false)]
        public TenantEntityQuotaSettings AiAgentsQuota { get; set; }

        /// <summary>
        /// The tenant custom quota.
        /// </summary>
        [DataMember(Name = "tenantCustomQuota", EmitDefaultValue = false)]
        public TenantQuotaSettings TenantCustomQuota { get; set; }

        /// <summary>
        /// The due date.
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
