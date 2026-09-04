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
    /// Represents a price of the service.
    /// </summary>
    [DataContract(Name = "ServicePriceInfo")]
    public partial class ServicePriceInfo : IValidatableObject
    {

        /// <summary>
        /// The time unit the price is bound to.
        /// </summary>
        [DataMember(Name = "timeUnit", EmitDefaultValue = false)]
        public PriceTimeUnit? TimeUnit { get; set; }

        /// <summary>
        /// The price status.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public PriceStatus? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ServicePriceInfo" /> class.
        /// </summary>
        /// <param name="id">The price unique identifier..</param>
        /// <param name="accountNumber">The account number..</param>
        /// <param name="serviceId">The service ID..</param>
        /// <param name="timeUnit">The time unit the price is bound to..</param>
        /// <param name="costPrice">The cost price..</param>
        /// <param name="extraCharge">The extra charge added to the cost price..</param>
        /// <param name="servicePrice">The resulting service price..</param>
        /// <param name="quota">The quota the price is set for..</param>
        /// <param name="timeBound">The period the price is effective in..</param>
        /// <param name="status">The price status..</param>
        /// <param name="created">The date and time when the price was created..</param>
        /// <param name="discountCategoryId">The discount category ID..</param>
        /// <param name="discountCategory">The discount category..</param>
        public ServicePriceInfo(int id = default, int accountNumber = default, int serviceId = default, PriceTimeUnit? timeUnit = default, double costPrice = default, double extraCharge = default, double servicePrice = default, double? quota = default, TimeBound timeBound = default, PriceStatus? status = default, DateTime created = default, int? discountCategoryId = default, DiscountCategory discountCategory = default)
        {
            this.Id = id;
            this.AccountNumber = accountNumber;
            this.ServiceId = serviceId;
            this.TimeUnit = timeUnit;
            this.CostPrice = costPrice;
            this.ExtraCharge = extraCharge;
            this.ServicePrice = servicePrice;
            this.Quota = quota;
            this.TimeBound = timeBound;
            this.Status = status;
            this.Created = created;
            this.DiscountCategoryId = discountCategoryId;
            this.DiscountCategory = discountCategory;
        }

        /// <summary>
        /// The price unique identifier.
        /// </summary>
        /// <example>12345</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The account number.
        /// </summary>
        /// <example>1010</example>
        [DataMember(Name = "accountNumber", EmitDefaultValue = false)]
        public int AccountNumber { get; set; }

        /// <summary>
        /// The service ID.
        /// </summary>
        /// <example>12345</example>
        [DataMember(Name = "serviceId", EmitDefaultValue = false)]
        public int ServiceId { get; set; }

        /// <summary>
        /// The cost price.
        /// </summary>
        /// <example>1500.75</example>
        [DataMember(Name = "costPrice", EmitDefaultValue = false)]
        public double CostPrice { get; set; }

        /// <summary>
        /// The extra charge added to the cost price.
        /// </summary>
        /// <example>1500.75</example>
        [DataMember(Name = "extraCharge", EmitDefaultValue = false)]
        public double ExtraCharge { get; set; }

        /// <summary>
        /// The resulting service price.
        /// </summary>
        /// <example>1500.75</example>
        [DataMember(Name = "servicePrice", EmitDefaultValue = false)]
        public double ServicePrice { get; set; }

        /// <summary>
        /// The quota the price is set for.
        /// </summary>
        /// <example>100</example>
        [DataMember(Name = "quota", EmitDefaultValue = true)]
        public double? Quota { get; set; }

        /// <summary>
        /// The period the price is effective in.
        /// </summary>
        [DataMember(Name = "timeBound", EmitDefaultValue = false)]
        public TimeBound TimeBound { get; set; }

        /// <summary>
        /// The date and time when the price was created.
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public DateTime Created { get; set; }

        /// <summary>
        /// The discount category ID.
        /// </summary>
        /// <example>12345</example>
        [DataMember(Name = "discountCategoryId", EmitDefaultValue = true)]
        public int? DiscountCategoryId { get; set; }

        /// <summary>
        /// The discount category.
        /// </summary>
        [DataMember(Name = "discountCategory", EmitDefaultValue = false)]
        public DiscountCategory DiscountCategory { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ServicePriceInfo {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AccountNumber: ").Append(AccountNumber).Append("\n");
            sb.Append("  ServiceId: ").Append(ServiceId).Append("\n");
            sb.Append("  TimeUnit: ").Append(TimeUnit).Append("\n");
            sb.Append("  CostPrice: ").Append(CostPrice).Append("\n");
            sb.Append("  ExtraCharge: ").Append(ExtraCharge).Append("\n");
            sb.Append("  ServicePrice: ").Append(ServicePrice).Append("\n");
            sb.Append("  Quota: ").Append(Quota).Append("\n");
            sb.Append("  TimeBound: ").Append(TimeBound).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  DiscountCategoryId: ").Append(DiscountCategoryId).Append("\n");
            sb.Append("  DiscountCategory: ").Append(DiscountCategory).Append("\n");
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
