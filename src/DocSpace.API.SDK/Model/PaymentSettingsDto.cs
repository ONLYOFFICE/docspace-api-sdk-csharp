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
    /// Where to buy or extend the portal&#39;s subscription, and what the subscription in force looks like.
    /// </summary>
    [DataContract(Name = "PaymentSettingsDto")]
    public partial class PaymentSettingsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSettingsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentSettingsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentSettingsDto" /> class.
        /// </summary>
        /// <param name="salesEmail">The vendor mailbox to write to about buying, extending or changing the subscription, picked for the portal  language. It is not the portal&#39;s own support address. (required).</param>
        /// <param name="feedbackAndSupportUrl">Not populated: nothing fills this field in, so it always comes back empty. The help and support addresses  live in &#x60;externalResources&#x60; of &#x60;GET api/2.0/settings&#x60; instead..</param>
        /// <param name="buyUrl">The vendor page for buying or extending the subscription, chosen for the licence kind the installation was  built for and for the portal language. It is a page for a person to open, not an API to call. (required).</param>
        /// <param name="standalone">Whether this is a server installation someone administers themselves rather than a portal in the cloud,  which decides whether payment means uploading a licence file or a subscription in the vendor&#39;s store. (required).</param>
        /// <param name="currentLicense">The subscription in force, reduced to the two facts a payment page needs. (required).</param>
        /// <param name="max">The largest quantity of a paid item - members, storage - that may be bought in one go, &#x60;999&#x60; unless the  installation configures another cap. It bounds a single purchase, not the total a portal may hold. (required).</param>
        public PaymentSettingsDto(string salesEmail = default, string feedbackAndSupportUrl = default, string buyUrl = default, bool standalone = default, CurrentLicenseInfo currentLicense = default, int max = default)
        {
            // to ensure "salesEmail" is required (not null)
            if (salesEmail == null)
            {
                throw new ArgumentNullException("salesEmail is a required property for PaymentSettingsDto and cannot be null");
            }
            this.SalesEmail = salesEmail;
            // to ensure "buyUrl" is required (not null)
            if (buyUrl == null)
            {
                throw new ArgumentNullException("buyUrl is a required property for PaymentSettingsDto and cannot be null");
            }
            this.BuyUrl = buyUrl;
            this.Standalone = standalone;
            // to ensure "currentLicense" is required (not null)
            if (currentLicense == null)
            {
                throw new ArgumentNullException("currentLicense is a required property for PaymentSettingsDto and cannot be null");
            }
            this.CurrentLicense = currentLicense;
            this.Max = max;
            this.FeedbackAndSupportUrl = feedbackAndSupportUrl;
        }

        /// <summary>
        /// The vendor mailbox to write to about buying, extending or changing the subscription, picked for the portal  language. It is not the portal&#39;s own support address.
        /// </summary>
        /// <example>sales@example.com</example>
        [DataMember(Name = "salesEmail", IsRequired = true, EmitDefaultValue = true)]
        public string SalesEmail { get; set; }

        /// <summary>
        /// Not populated: nothing fills this field in, so it always comes back empty. The help and support addresses  live in &#x60;externalResources&#x60; of &#x60;GET api/2.0/settings&#x60; instead.
        /// </summary>
        /// <example>https://example.com</example>
        [DataMember(Name = "feedbackAndSupportUrl", EmitDefaultValue = true)]
        public string FeedbackAndSupportUrl { get; set; }

        /// <summary>
        /// The vendor page for buying or extending the subscription, chosen for the licence kind the installation was  built for and for the portal language. It is a page for a person to open, not an API to call.
        /// </summary>
        /// <example>https://example.com/buy</example>
        [DataMember(Name = "buyUrl", IsRequired = true, EmitDefaultValue = true)]
        public string BuyUrl { get; set; }

        /// <summary>
        /// Whether this is a server installation someone administers themselves rather than a portal in the cloud,  which decides whether payment means uploading a licence file or a subscription in the vendor&#39;s store.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "standalone", IsRequired = true, EmitDefaultValue = true)]
        public bool Standalone { get; set; }

        /// <summary>
        /// The subscription in force, reduced to the two facts a payment page needs.
        /// </summary>
        [DataMember(Name = "currentLicense", IsRequired = true, EmitDefaultValue = true)]
        public CurrentLicenseInfo CurrentLicense { get; set; }

        /// <summary>
        /// The largest quantity of a paid item - members, storage - that may be bought in one go, &#x60;999&#x60; unless the  installation configures another cap. It bounds a single purchase, not the total a portal may hold.
        /// </summary>
        /// <example>999</example>
        [DataMember(Name = "max", IsRequired = true, EmitDefaultValue = true)]
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
