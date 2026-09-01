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
    /// Aggregated customer usage statistics for a service over a period.
    /// </summary>
    [DataContract(Name = "CustomerServiceUsageDto")]
    public partial class CustomerServiceUsageDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerServiceUsageDto" /> class.
        /// </summary>
        /// <param name="service">The name of the service..</param>
        /// <param name="title">The title of the service..</param>
        /// <param name="serviceUnit">The unit of measurement for the service..</param>
        /// <param name="currency">The three-character ISO 4217 currency symbol of the amounts..</param>
        /// <param name="totalQuantity">The total number of units consumed..</param>
        /// <param name="totalAmount">The total amount charged for the service..</param>
        /// <param name="operationCount">The number of individual purchase operations..</param>
        /// <param name="price">The price of the service..</param>
        /// <param name="subscription">Indicates whether the service is subscription-based..</param>
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
        /// The name of the service.
        /// </summary>
        /// <example>disk-storage</example>
        [DataMember(Name = "service", EmitDefaultValue = true)]
        public string Service { get; set; }

        /// <summary>
        /// The title of the service.
        /// </summary>
        /// <example>Additional disk storage</example>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The unit of measurement for the service.
        /// </summary>
        /// <example>GB</example>
        [DataMember(Name = "serviceUnit", EmitDefaultValue = true)]
        public string ServiceUnit { get; set; }

        /// <summary>
        /// The three-character ISO 4217 currency symbol of the amounts.
        /// </summary>
        /// <example>USD</example>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// The total number of units consumed.
        /// </summary>
        /// <example>100</example>
        [DataMember(Name = "totalQuantity", EmitDefaultValue = false)]
        public int TotalQuantity { get; set; }

        /// <summary>
        /// The total amount charged for the service.
        /// </summary>
        /// <example>14</example>
        [DataMember(Name = "totalAmount", EmitDefaultValue = false)]
        public double TotalAmount { get; set; }

        /// <summary>
        /// The number of individual purchase operations.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "operationCount", EmitDefaultValue = false)]
        public int OperationCount { get; set; }

        /// <summary>
        /// The price of the service.
        /// </summary>
        /// <example>0.14</example>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public double Price { get; set; }

        /// <summary>
        /// Indicates whether the service is subscription-based.
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
