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
    /// The automatic wallet top-up settings of the portal, together with the low-balance warning state the portal keeps  for them.
    /// </summary>
    [DataContract(Name = "TenantWalletSettingsDto")]
    public partial class TenantWalletSettingsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantWalletSettingsDto" /> class.
        /// </summary>
        /// <param name="enabled">Whether the payment method on file is charged automatically when the wallet balance runs low..</param>
        /// <param name="minBalance">The balance below which a top-up is charged, in &#x60;currency&#x60;; 0 while top-up has never been configured..</param>
        /// <param name="upToBalance">The balance a top-up brings the wallet up to, in &#x60;currency&#x60;; 0 while top-up has never been configured..</param>
        /// <param name="currency">The three-letter ISO 4217 code both amounts are expressed in, or &#x60;null&#x60; while top-up has never been configured..</param>
        /// <param name="lowBalanceThreshold">The wallet balance below which the portal sends its low-balance warning. The portal maintains it; it cannot be  set by a request..</param>
        /// <param name="lowBalanceNotified">Whether the low-balance warning has already been sent for the current dip below &#x60;lowBalanceThreshold&#x60;. The  portal maintains it, and switching top-up on re-arms it..</param>
        /// <param name="lastModified">When the settings were last stored; when they were never stored, the moment they were read instead..</param>
        public TenantWalletSettingsDto(bool enabled = default, int minBalance = default, int upToBalance = default, string currency = default, int lowBalanceThreshold = default, bool lowBalanceNotified = default, DateTime lastModified = default)
        {
            this.Enabled = enabled;
            this.MinBalance = minBalance;
            this.UpToBalance = upToBalance;
            this.Currency = currency;
            this.LowBalanceThreshold = lowBalanceThreshold;
            this.LowBalanceNotified = lowBalanceNotified;
            this.LastModified = lastModified;
        }

        /// <summary>
        /// Whether the payment method on file is charged automatically when the wallet balance runs low.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// The balance below which a top-up is charged, in &#x60;currency&#x60;; 0 while top-up has never been configured.
        /// </summary>
        /// <example>10</example>
        [DataMember(Name = "minBalance", EmitDefaultValue = false)]
        public int MinBalance { get; set; }

        /// <summary>
        /// The balance a top-up brings the wallet up to, in &#x60;currency&#x60;; 0 while top-up has never been configured.
        /// </summary>
        /// <example>100</example>
        [DataMember(Name = "upToBalance", EmitDefaultValue = false)]
        public int UpToBalance { get; set; }

        /// <summary>
        /// The three-letter ISO 4217 code both amounts are expressed in, or &#x60;null&#x60; while top-up has never been configured.
        /// </summary>
        /// <example>USD</example>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// The wallet balance below which the portal sends its low-balance warning. The portal maintains it; it cannot be  set by a request.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "lowBalanceThreshold", EmitDefaultValue = false)]
        public int LowBalanceThreshold { get; set; }

        /// <summary>
        /// Whether the low-balance warning has already been sent for the current dip below &#x60;lowBalanceThreshold&#x60;. The  portal maintains it, and switching top-up on re-arms it.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "lowBalanceNotified", EmitDefaultValue = true)]
        public bool LowBalanceNotified { get; set; }

        /// <summary>
        /// When the settings were last stored; when they were never stored, the moment they were read instead.
        /// </summary>
        /// <example>2026-01-01T00:00:00Z</example>
        [DataMember(Name = "lastModified", EmitDefaultValue = false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenantWalletSettingsDto {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  MinBalance: ").Append(MinBalance).Append("\n");
            sb.Append("  UpToBalance: ").Append(UpToBalance).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  LowBalanceThreshold: ").Append(LowBalanceThreshold).Append("\n");
            sb.Append("  LowBalanceNotified: ").Append(LowBalanceNotified).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
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
