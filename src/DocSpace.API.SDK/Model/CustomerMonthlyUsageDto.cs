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
    /// What the portal spent from its wallet in one calendar month, added up across every service.
    /// </summary>
    [DataContract(Name = "CustomerMonthlyUsageDto")]
    public partial class CustomerMonthlyUsageDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomerMonthlyUsageDto" /> class.
        /// </summary>
        /// <param name="year">The year the month belongs to. Months are cut in the portal time zone, so a movement at the edge of a  month falls where the portal sees it and not where UTC does..</param>
        /// <param name="month">The month itself, January being 1. Only months that had spending appear at all, so a gap in the list is a  month with nothing in it rather than missing data..</param>
        /// <param name="currency">The currency &#x60;totalAmount&#x60; is expressed in, as a three-letter ISO 4217 code - the accounting currency of  the wallet..</param>
        /// <param name="totalAmount">What the month came to across every service, as a positive amount spent rather than a signed balance..</param>
        /// <param name="operationCount">How many separate movements that total was added up from, for a client that wants to show the weight  behind a figure. The movements themselves are in &#x60;GET api/2.0/portal/payment/customer/operations&#x60;..</param>
        public CustomerMonthlyUsageDto(int year = default, int month = default, string currency = default, double totalAmount = default, int operationCount = default)
        {
            this.Year = year;
            this.Month = month;
            this.Currency = currency;
            this.TotalAmount = totalAmount;
            this.OperationCount = operationCount;
        }

        /// <summary>
        /// The year the month belongs to. Months are cut in the portal time zone, so a movement at the edge of a  month falls where the portal sees it and not where UTC does.
        /// </summary>
        /// <example>2025</example>
        [DataMember(Name = "year", EmitDefaultValue = false)]
        public int Year { get; set; }

        /// <summary>
        /// The month itself, January being 1. Only months that had spending appear at all, so a gap in the list is a  month with nothing in it rather than missing data.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "month", EmitDefaultValue = false)]
        public int Month { get; set; }

        /// <summary>
        /// The currency &#x60;totalAmount&#x60; is expressed in, as a three-letter ISO 4217 code - the accounting currency of  the wallet.
        /// </summary>
        /// <example>USD</example>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// What the month came to across every service, as a positive amount spent rather than a signed balance.
        /// </summary>
        /// <example>199.98</example>
        [DataMember(Name = "totalAmount", EmitDefaultValue = false)]
        public double TotalAmount { get; set; }

        /// <summary>
        /// How many separate movements that total was added up from, for a client that wants to show the weight  behind a figure. The movements themselves are in &#x60;GET api/2.0/portal/payment/customer/operations&#x60;.
        /// </summary>
        /// <example>3</example>
        [DataMember(Name = "operationCount", EmitDefaultValue = false)]
        public int OperationCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomerMonthlyUsageDto {\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Month: ").Append(Month).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  OperationCount: ").Append(OperationCount).Append("\n");
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
