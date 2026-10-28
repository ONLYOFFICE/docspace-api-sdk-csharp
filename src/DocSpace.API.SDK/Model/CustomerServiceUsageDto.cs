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
    /// What one wallet service was consumed and cost over the requested period, added up rather than listed.
    /// </summary>
    [DataContract(Name = "CustomerServiceUsageDto")]
    public partial class CustomerServiceUsageDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerServiceUsageDto" /> class.
        /// </summary>
        /// <param name="service">The stable key of the service, which is what the &#x60;serviceName&#x60; filter of this operation matches on and  what &#x60;GET api/2.0/portal/payment/walletservice&#x60; looks a service up by..</param>
        /// <param name="title">The service name in the portal language, for printing rather than matching..</param>
        /// <param name="serviceUnit">What &#x60;totalQuantity&#x60; counts, in the portal language. AI consumption is reported in tokens here rather  than in the AI credits the service is sold in, so it does not line up with the price list..</param>
        /// <param name="currency">The currency &#x60;totalAmount&#x60; and &#x60;price&#x60; are expressed in, as a three-letter ISO 4217 code..</param>
        /// <param name="totalQuantity">How many units of the service were consumed over the period, in the unit named by &#x60;serviceUnit&#x60;..</param>
        /// <param name="totalAmount">What that consumption cost over the period. It is what was actually charged, so it can differ from  &#x60;price&#x60; times &#x60;totalQuantity&#x60; when the price changed inside the period..</param>
        /// <param name="operationCount">How many separate charges the total was added up from. The charges themselves are in  &#x60;GET api/2.0/portal/payment/customer/operations&#x60;..</param>
        /// <param name="price">What one unit of the service costs today, not what it cost during the period. It is &#x60;0&#x60; when the service  is no longer on the installation&#39;s price list..</param>
        /// <param name="subscription">Whether the service is billed as a standing subscription rather than per unit consumed. It is derived  from today&#39;s price list, so it describes the service as it is sold now..</param>
        public CustomerServiceUsageDto(string service = default, string title = default, string serviceUnit = default, string currency = default, int totalQuantity = default, double totalAmount = default, int operationCount = default, double price = default, bool subscription = default)
        {
            this.Service = service;
            this.Title = title;
            this.ServiceUnit = serviceUnit;
            this.Currency = currency;
            this.TotalQuantity = totalQuantity;
            this.TotalAmount = totalAmount;
            this.OperationCount = operationCount;
            this.Price = price;
            this.Subscription = subscription;
        }

        /// <summary>
        /// The stable key of the service, which is what the &#x60;serviceName&#x60; filter of this operation matches on and  what &#x60;GET api/2.0/portal/payment/walletservice&#x60; looks a service up by.
        /// </summary>
        /// <example>disk-storage</example>
        [DataMember(Name = "service", EmitDefaultValue = true)]
        public string Service { get; set; }

        /// <summary>
        /// The service name in the portal language, for printing rather than matching.
        /// </summary>
        /// <example>Additional disk storage</example>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// What &#x60;totalQuantity&#x60; counts, in the portal language. AI consumption is reported in tokens here rather  than in the AI credits the service is sold in, so it does not line up with the price list.
        /// </summary>
        /// <example>GB</example>
        [DataMember(Name = "serviceUnit", EmitDefaultValue = true)]
        public string ServiceUnit { get; set; }

        /// <summary>
        /// The currency &#x60;totalAmount&#x60; and &#x60;price&#x60; are expressed in, as a three-letter ISO 4217 code.
        /// </summary>
        /// <example>USD</example>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// How many units of the service were consumed over the period, in the unit named by &#x60;serviceUnit&#x60;.
        /// </summary>
        /// <example>100</example>
        [DataMember(Name = "totalQuantity", EmitDefaultValue = false)]
        public int TotalQuantity { get; set; }

        /// <summary>
        /// What that consumption cost over the period. It is what was actually charged, so it can differ from  &#x60;price&#x60; times &#x60;totalQuantity&#x60; when the price changed inside the period.
        /// </summary>
        /// <example>49.99</example>
        [DataMember(Name = "totalAmount", EmitDefaultValue = false)]
        public double TotalAmount { get; set; }

        /// <summary>
        /// How many separate charges the total was added up from. The charges themselves are in  &#x60;GET api/2.0/portal/payment/customer/operations&#x60;.
        /// </summary>
        /// <example>2</example>
        [DataMember(Name = "operationCount", EmitDefaultValue = false)]
        public int OperationCount { get; set; }

        /// <summary>
        /// What one unit of the service costs today, not what it cost during the period. It is &#x60;0&#x60; when the service  is no longer on the installation&#39;s price list.
        /// </summary>
        /// <example>0.14</example>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public double Price { get; set; }

        /// <summary>
        /// Whether the service is billed as a standing subscription rather than per unit consumed. It is derived  from today&#39;s price list, so it describes the service as it is sold now.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "subscription", EmitDefaultValue = true)]
        public bool Subscription { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerServiceUsageDto {\n");
            sb.Append("  Service: ").Append(Service).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  ServiceUnit: ").Append(ServiceUnit).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  TotalQuantity: ").Append(TotalQuantity).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  OperationCount: ").Append(OperationCount).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Subscription: ").Append(Subscription).Append("\n");
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
