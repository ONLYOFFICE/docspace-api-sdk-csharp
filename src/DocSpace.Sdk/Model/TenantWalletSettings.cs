/**
 *
 * (c) Copyright Ascensio System SIA 2025
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// TenantWalletSettings
    /// </summary>
    [DataContract(Name = "TenantWalletSettings")]
    public partial class TenantWalletSettings : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantWalletSettings" /> class.
        /// </summary>
        /// <param name="enabled">Enabled.</param>
        /// <param name="minBalance">Minimun balance.</param>
        /// <param name="upToBalance">Up to balance.</param>
        /// <param name="currency">The three-character ISO 4217 currency symbol..</param>
        /// <param name="lastModified">lastModified.</param>
        public TenantWalletSettings(bool enabled = default, int minBalance = default, int upToBalance = default, string currency = default, DateTime lastModified = default)
        {
            this.Enabled = enabled;
            this.MinBalance = minBalance;
            this.UpToBalance = upToBalance;
            this.Currency = currency;
            this.LastModified = lastModified;
        }

        /// <summary>
        /// Enabled
        /// </summary>
        /// <value>Enabled</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Minimun balance
        /// </summary>
        /// <value>Minimun balance</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "minBalance", EmitDefaultValue = false)]
        public int MinBalance { get; set; }

        /// <summary>
        /// Up to balance
        /// </summary>
        /// <value>Up to balance</value>
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
        /// Gets or Sets LastModified
        /// </summary>
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
