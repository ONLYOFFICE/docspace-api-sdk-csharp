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
    /// One payment into the portal wallet: when it was made, how much it brought in, how it ended, and whether an  invoice stands behind it.
    /// </summary>
    [DataContract(Name = "DepositDto")]
    public partial class DepositDto : IValidatableObject
    {

        /// <summary>
        /// How the top-up ended. A pending one is still being settled and may change later, so only a completed one has  actually raised the balance.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public OperationStatus? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DepositDto" /> class.
        /// </summary>
        /// <param name="id">The identifier of the top-up, which is what &#x60;GET api/2.0/portal/payment/customer/deposits/{id}/invoice&#x60; takes  to read its invoice..</param>
        /// <param name="date">When the top-up was booked, as an ISO 8601 timestamp that carries its own offset: that of the portal&#39;s time  zone, written as &#x60;Z&#x60; for a portal in UTC - the zone in which &#x60;startDate&#x60; and &#x60;endDate&#x60; without an offset are  read..</param>
        /// <param name="amount">The amount that went into the wallet, in &#x60;currency&#x60;..</param>
        /// <param name="currency">The currency &#x60;amount&#x60; is expressed in, as a three-letter ISO 4217 code - the accounting currency of the  wallet..</param>
        /// <param name="status">How the top-up ended. A pending one is still being settled and may change later, so only a completed one has  actually raised the balance..</param>
        /// <param name="hasInvoice">Whether the billing provider holds an invoice for the payment behind the top-up, which is when  &#x60;GET api/2.0/portal/payment/customer/deposits/{id}/invoice&#x60; can open it. It is &#x60;false&#x60; for a top-up whose  payment came without one, and asking for its invoice then fails with 404..</param>
        public DepositDto(long id = default, ApiDateTime date = default, double amount = default, string currency = default, OperationStatus? status = default, bool hasInvoice = default)
        {
            this.Id = id;
            this.Date = date;
            this.Amount = amount;
            this.Currency = currency;
            this.Status = status;
            this.HasInvoice = hasInvoice;
        }

        /// <summary>
        /// The identifier of the top-up, which is what &#x60;GET api/2.0/portal/payment/customer/deposits/{id}/invoice&#x60; takes  to read its invoice.
        /// </summary>
        /// <example>15342</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public long Id { get; set; }

        /// <summary>
        /// When the top-up was booked, as an ISO 8601 timestamp that carries its own offset: that of the portal&#39;s time  zone, written as &#x60;Z&#x60; for a portal in UTC - the zone in which &#x60;startDate&#x60; and &#x60;endDate&#x60; without an offset are  read.
        /// </summary>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public ApiDateTime Date { get; set; }

        /// <summary>
        /// The amount that went into the wallet, in &#x60;currency&#x60;.
        /// </summary>
        /// <example>100.0</example>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public double Amount { get; set; }

        /// <summary>
        /// The currency &#x60;amount&#x60; is expressed in, as a three-letter ISO 4217 code - the accounting currency of the  wallet.
        /// </summary>
        /// <example>USD</example>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// Whether the billing provider holds an invoice for the payment behind the top-up, which is when  &#x60;GET api/2.0/portal/payment/customer/deposits/{id}/invoice&#x60; can open it. It is &#x60;false&#x60; for a top-up whose  payment came without one, and asking for its invoice then fails with 404.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "hasInvoice", EmitDefaultValue = true)]
        public bool HasInvoice { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DepositDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  HasInvoice: ").Append(HasInvoice).Append("\n");
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
