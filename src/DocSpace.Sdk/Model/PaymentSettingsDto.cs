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
    /// The payment settings parameters.
    /// </summary>
    [DataContract(Name = "PaymentSettingsDto")]
    public partial class PaymentSettingsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSettingsDto" /> class.
        /// </summary>
        /// <param name="salesEmail">The email address for sales inquiries and support..</param>
        /// <param name="feedbackAndSupportUrl">The URL for accessing the feedback and support resources..</param>
        /// <param name="buyUrl">The URL for purchasing or upgrading the product..</param>
        /// <param name="standalone">Indicates whether the system is running in standalone mode..</param>
        /// <param name="currentLicense">currentLicense.</param>
        /// <param name="max">The maximum quota quantity..</param>
        public PaymentSettingsDto(string salesEmail = default, string feedbackAndSupportUrl = default, string buyUrl = default, bool standalone = default, CurrentLicenseInfo currentLicense = default, int max = default)
        {
            this.SalesEmail = salesEmail;
            this.FeedbackAndSupportUrl = feedbackAndSupportUrl;
            this.BuyUrl = buyUrl;
            this.Standalone = standalone;
            this.CurrentLicense = currentLicense;
            this.Max = max;
        }

        /// <summary>
        /// The email address for sales inquiries and support.
        /// </summary>
        /// <value>The email address for sales inquiries and support.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "salesEmail", EmitDefaultValue = true)]
        public string SalesEmail { get; set; }

        /// <summary>
        /// The URL for accessing the feedback and support resources.
        /// </summary>
        /// <value>The URL for accessing the feedback and support resources.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "feedbackAndSupportUrl", EmitDefaultValue = true)]
        public string FeedbackAndSupportUrl { get; set; }

        /// <summary>
        /// The URL for purchasing or upgrading the product.
        /// </summary>
        /// <value>The URL for purchasing or upgrading the product.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "buyUrl", EmitDefaultValue = true)]
        public string BuyUrl { get; set; }

        /// <summary>
        /// Indicates whether the system is running in standalone mode.
        /// </summary>
        /// <value>Indicates whether the system is running in standalone mode.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "standalone", EmitDefaultValue = true)]
        public bool Standalone { get; set; }

        /// <summary>
        /// Gets or Sets CurrentLicense
        /// </summary>
        [DataMember(Name = "currentLicense", EmitDefaultValue = false)]
        public CurrentLicenseInfo CurrentLicense { get; set; }

        /// <summary>
        /// The maximum quota quantity.
        /// </summary>
        /// <value>The maximum quota quantity.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "max", EmitDefaultValue = false)]
        public int Max { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PaymentSettingsDto {\n");
            sb.Append("  SalesEmail: ").Append(SalesEmail).Append("\n");
            sb.Append("  FeedbackAndSupportUrl: ").Append(FeedbackAndSupportUrl).Append("\n");
            sb.Append("  BuyUrl: ").Append(BuyUrl).Append("\n");
            sb.Append("  Standalone: ").Append(Standalone).Append("\n");
            sb.Append("  CurrentLicense: ").Append(CurrentLicense).Append("\n");
            sb.Append("  Max: ").Append(Max).Append("\n");
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
