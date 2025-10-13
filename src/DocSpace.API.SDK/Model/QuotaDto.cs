// (c) Copyright Ascensio System SIA 2025
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

 
 using DocSpace.API.SDK.Client;
 

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
        /// <param name="title">The quota title. (required).</param>
        /// <param name="price">price (required).</param>
        /// <param name="nonProfit">Specifies if the quota is nonprofit or not. (required).</param>
        /// <param name="free">Specifies if the quota is free or not. (required).</param>
        /// <param name="trial">Specifies if the quota is trial or not. (required).</param>
        /// <param name="features">The list of tenant quota features. (required).</param>
        /// <param name="usersQuota">usersQuota.</param>
        /// <param name="roomsQuota">roomsQuota.</param>
        /// <param name="tenantCustomQuota">tenantCustomQuota.</param>
        /// <param name="dueDate">The due date..</param>
        public QuotaDto(int id = default, string title = default, PriceDto price = default, bool nonProfit = default, bool free = default, bool trial = default, List<TenantQuotaFeatureDto> features = default, TenantEntityQuotaSettings usersQuota = default, TenantEntityQuotaSettings roomsQuota = default, TenantQuotaSettings tenantCustomQuota = default, DateTime? dueDate = default)
        {
            this.Id = id;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for QuotaDto and cannot be null");
            }
            this.Title = title;
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
            this.UsersQuota = usersQuota;
            this.RoomsQuota = roomsQuota;
            this.TenantCustomQuota = tenantCustomQuota;
            this.DueDate = dueDate;
        }

        /// <summary>
        /// The quota ID.
        /// </summary>
        /// <value>The quota ID.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public int Id { get; set; }

        /// <summary>
        /// The quota title.
        /// </summary>
        /// <value>The quota title.</value>
        /*
        <example>legacy_1080p_small_wooden_mouse</example>
        */
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price", IsRequired = true, EmitDefaultValue = true)]
        public PriceDto Price { get; set; }

        /// <summary>
        /// Specifies if the quota is nonprofit or not.
        /// </summary>
        /// <value>Specifies if the quota is nonprofit or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "nonProfit", IsRequired = true, EmitDefaultValue = true)]
        public bool NonProfit { get; set; }

        /// <summary>
        /// Specifies if the quota is free or not.
        /// </summary>
        /// <value>Specifies if the quota is free or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "free", IsRequired = true, EmitDefaultValue = true)]
        public bool Free { get; set; }

        /// <summary>
        /// Specifies if the quota is trial or not.
        /// </summary>
        /// <value>Specifies if the quota is trial or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "trial", IsRequired = true, EmitDefaultValue = true)]
        public bool Trial { get; set; }

        /// <summary>
        /// The list of tenant quota features.
        /// </summary>
        /// <value>The list of tenant quota features.</value>
        [DataMember(Name = "features", IsRequired = true, EmitDefaultValue = true)]
        public List<TenantQuotaFeatureDto> Features { get; set; }

        /// <summary>
        /// Gets or Sets UsersQuota
        /// </summary>
        [DataMember(Name = "usersQuota", EmitDefaultValue = false)]
        public TenantEntityQuotaSettings UsersQuota { get; set; }

        /// <summary>
        /// Gets or Sets RoomsQuota
        /// </summary>
        [DataMember(Name = "roomsQuota", EmitDefaultValue = false)]
        public TenantEntityQuotaSettings RoomsQuota { get; set; }

        /// <summary>
        /// Gets or Sets TenantCustomQuota
        /// </summary>
        [DataMember(Name = "tenantCustomQuota", EmitDefaultValue = false)]
        public TenantQuotaSettings TenantCustomQuota { get; set; }

        /// <summary>
        /// The due date.
        /// </summary>
        /// <value>The due date.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
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
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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
