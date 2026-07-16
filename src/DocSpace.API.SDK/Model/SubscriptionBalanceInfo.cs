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
    /// The information about the current subscription and its unused balance.
    /// </summary>
    [DataContract(Name = "SubscriptionBalanceInfo")]
    public partial class SubscriptionBalanceInfo : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SubscriptionBalanceInfo" /> class.
        /// </summary>
        /// <param name="totalCost">The total cost of the current billing period (the sum across all subscription items)..</param>
        /// <param name="currency">The three-character ISO 4217 currency symbol of the subscription..</param>
        /// <param name="periodStart">The start of the current billing period..</param>
        /// <param name="periodEnd">The end of the current billing period..</param>
        /// <param name="periodUsedUntil">The boundary of the used part of the period (the moment of the request)..</param>
        /// <param name="daysElapsed">The number of days elapsed since the start of the period (inclusive)..</param>
        /// <param name="remainingBalance">The unused balance of the subscription, in the subscription currency..</param>
        /// <param name="remainingBalanceInWalletCurrency">The unused balance of the subscription, converted to the wallet currency..</param>
        /// <param name="walletCurrency">The three-character ISO 4217 currency symbol of the wallet..</param>
        public SubscriptionBalanceInfo(double totalCost = default, string currency = default, DateTime periodStart = default, DateTime periodEnd = default, DateTime periodUsedUntil = default, int daysElapsed = default, double remainingBalance = default, double remainingBalanceInWalletCurrency = default, string walletCurrency = default)
        {
            this.TotalCost = totalCost;
            this.Currency = currency;
            this.PeriodStart = periodStart;
            this.PeriodEnd = periodEnd;
            this.PeriodUsedUntil = periodUsedUntil;
            this.DaysElapsed = daysElapsed;
            this.RemainingBalance = remainingBalance;
            this.RemainingBalanceInWalletCurrency = remainingBalanceInWalletCurrency;
            this.WalletCurrency = walletCurrency;
        }

        /// <summary>
        /// The total cost of the current billing period (the sum across all subscription items).
        /// </summary>
        /// <value>The total cost of the current billing period (the sum across all subscription items).</value>
        /*
        <example>120.0</example>
        */
        [DataMember(Name = "totalCost", EmitDefaultValue = false)]
        public double TotalCost { get; set; }

        /// <summary>
        /// The three-character ISO 4217 currency symbol of the subscription.
        /// </summary>
        /// <value>The three-character ISO 4217 currency symbol of the subscription.</value>
        /*
        <example>USD</example>
        */
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// The start of the current billing period.
        /// </summary>
        /// <value>The start of the current billing period.</value>
        /*
        <example>2026-06-01T00:00Z</example>
        */
        [DataMember(Name = "periodStart", EmitDefaultValue = false)]
        public DateTime PeriodStart { get; set; }

        /// <summary>
        /// The end of the current billing period.
        /// </summary>
        /// <value>The end of the current billing period.</value>
        /*
        <example>2026-07-01T00:00Z</example>
        */
        [DataMember(Name = "periodEnd", EmitDefaultValue = false)]
        public DateTime PeriodEnd { get; set; }

        /// <summary>
        /// The boundary of the used part of the period (the moment of the request).
        /// </summary>
        /// <value>The boundary of the used part of the period (the moment of the request).</value>
        /*
        <example>2026-06-23T14:35Z</example>
        */
        [DataMember(Name = "periodUsedUntil", EmitDefaultValue = false)]
        public DateTime PeriodUsedUntil { get; set; }

        /// <summary>
        /// The number of days elapsed since the start of the period (inclusive).
        /// </summary>
        /// <value>The number of days elapsed since the start of the period (inclusive).</value>
        /*
        <example>23</example>
        */
        [DataMember(Name = "daysElapsed", EmitDefaultValue = false)]
        public int DaysElapsed { get; set; }

        /// <summary>
        /// The unused balance of the subscription, in the subscription currency.
        /// </summary>
        /// <value>The unused balance of the subscription, in the subscription currency.</value>
        /*
        <example>87.74</example>
        */
        [DataMember(Name = "remainingBalance", EmitDefaultValue = false)]
        public double RemainingBalance { get; set; }

        /// <summary>
        /// The unused balance of the subscription, converted to the wallet currency.
        /// </summary>
        /// <value>The unused balance of the subscription, converted to the wallet currency.</value>
        /*
        <example>87.74</example>
        */
        [DataMember(Name = "remainingBalanceInWalletCurrency", EmitDefaultValue = false)]
        public double RemainingBalanceInWalletCurrency { get; set; }

        /// <summary>
        /// The three-character ISO 4217 currency symbol of the wallet.
        /// </summary>
        /// <value>The three-character ISO 4217 currency symbol of the wallet.</value>
        /*
        <example>USD</example>
        */
        [DataMember(Name = "walletCurrency", EmitDefaultValue = true)]
        public string WalletCurrency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionBalanceInfo {\n");
            sb.Append("  TotalCost: ").Append(TotalCost).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  PeriodStart: ").Append(PeriodStart).Append("\n");
            sb.Append("  PeriodEnd: ").Append(PeriodEnd).Append("\n");
            sb.Append("  PeriodUsedUntil: ").Append(PeriodUsedUntil).Append("\n");
            sb.Append("  DaysElapsed: ").Append(DaysElapsed).Append("\n");
            sb.Append("  RemainingBalance: ").Append(RemainingBalance).Append("\n");
            sb.Append("  RemainingBalanceInWalletCurrency: ").Append(RemainingBalanceInWalletCurrency).Append("\n");
            sb.Append("  WalletCurrency: ").Append(WalletCurrency).Append("\n");
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
