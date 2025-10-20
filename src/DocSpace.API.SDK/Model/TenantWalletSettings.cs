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
    /// The tenant wallet settings.
    /// </summary>
    [DataContract(Name = "TenantWalletSettings")]
    public partial class TenantWalletSettings : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantWalletSettings" /> class.
        /// </summary>
        /// <param name="enabled">Specifies whether automatic top-up for the tenant wallet is enabled..</param>
        /// <param name="minBalance">The minimum wallet balance at which automatic top-up will be triggered. Must be between 5 and 1000..</param>
        /// <param name="upToBalance">The maximum wallet balance at which automatic top-up will be triggered. Must be between 6 and 5000..</param>
        /// <param name="currency">The three-character ISO 4217 currency symbol..</param>
        /// <param name="lastModified">The date and time when the tenant wallet settings were last modified..</param>
        public TenantWalletSettings(bool enabled = default, int minBalance = default, int upToBalance = default, string currency = default, DateTime lastModified = default)
        {
            this.Enabled = enabled;
            this.MinBalance = minBalance;
            this.UpToBalance = upToBalance;
            this.Currency = currency;
            this.LastModified = lastModified;
        }

        /// <summary>
        /// Specifies whether automatic top-up for the tenant wallet is enabled.
        /// </summary>
        /// <value>Specifies whether automatic top-up for the tenant wallet is enabled.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// The minimum wallet balance at which automatic top-up will be triggered. Must be between 5 and 1000.
        /// </summary>
        /// <value>The minimum wallet balance at which automatic top-up will be triggered. Must be between 5 and 1000.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "minBalance", EmitDefaultValue = false)]
        public int MinBalance { get; set; }

        /// <summary>
        /// The maximum wallet balance at which automatic top-up will be triggered. Must be between 6 and 5000.
        /// </summary>
        /// <value>The maximum wallet balance at which automatic top-up will be triggered. Must be between 6 and 5000.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "upToBalance", EmitDefaultValue = false)]
        public int UpToBalance { get; set; }

        /// <summary>
        /// The three-character ISO 4217 currency symbol.
        /// </summary>
        /// <value>The three-character ISO 4217 currency symbol.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// The date and time when the tenant wallet settings were last modified.
        /// </summary>
        /// <value>The date and time when the tenant wallet settings were last modified.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "lastModified", EmitDefaultValue = false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenantWalletSettings {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  MinBalance: ").Append(MinBalance).Append("\n");
            sb.Append("  UpToBalance: ").Append(UpToBalance).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // MinBalance (int) maximum
            if (this.MinBalance > (int)1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinBalance, must be a value less than or equal to 1000.", new [] { "MinBalance" });
            }

            // MinBalance (int) minimum
            if (this.MinBalance < (int)5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MinBalance, must be a value greater than or equal to 5.", new [] { "MinBalance" });
            }

            // UpToBalance (int) maximum
            if (this.UpToBalance > (int)5000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UpToBalance, must be a value less than or equal to 5000.", new [] { "UpToBalance" });
            }

            // UpToBalance (int) minimum
            if (this.UpToBalance < (int)6)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UpToBalance, must be a value greater than or equal to 6.", new [] { "UpToBalance" });
            }

            yield break;
        }
    }


}
