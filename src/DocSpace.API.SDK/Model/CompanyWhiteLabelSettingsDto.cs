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
    /// The company white label settings.
    /// </summary>
    [DataContract(Name = "CompanyWhiteLabelSettingsDto")]
    public partial class CompanyWhiteLabelSettingsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyWhiteLabelSettingsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CompanyWhiteLabelSettingsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyWhiteLabelSettingsDto" /> class.
        /// </summary>
        /// <param name="companyName">The company name. (required).</param>
        /// <param name="site">The company site. (required).</param>
        /// <param name="email">The company email address. (required).</param>
        /// <param name="address">The company address. (required).</param>
        /// <param name="phone">The company phone number. (required).</param>
        /// <param name="isLicensor">Specifies if a company is a licensor or not. (required).</param>
        /// <param name="hideAbout">Specifies if the About page is visible or not. (required).</param>
        /// <param name="isDefault">Specifies if these settings are default or not. (required).</param>
        public CompanyWhiteLabelSettingsDto(string companyName = default, string site = default, string email = default, string address = default, string phone = default, bool isLicensor = default, bool hideAbout = default, bool isDefault = default)
        {
            // to ensure "companyName" is required (not null)
            if (companyName == null)
            {
                throw new ArgumentNullException("companyName is a required property for CompanyWhiteLabelSettingsDto and cannot be null");
            }
            this.CompanyName = companyName;
            // to ensure "site" is required (not null)
            if (site == null)
            {
                throw new ArgumentNullException("site is a required property for CompanyWhiteLabelSettingsDto and cannot be null");
            }
            this.Site = site;
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for CompanyWhiteLabelSettingsDto and cannot be null");
            }
            this.Email = email;
            // to ensure "address" is required (not null)
            if (address == null)
            {
                throw new ArgumentNullException("address is a required property for CompanyWhiteLabelSettingsDto and cannot be null");
            }
            this.Address = address;
            // to ensure "phone" is required (not null)
            if (phone == null)
            {
                throw new ArgumentNullException("phone is a required property for CompanyWhiteLabelSettingsDto and cannot be null");
            }
            this.Phone = phone;
            this.IsLicensor = isLicensor;
            this.HideAbout = hideAbout;
            this.IsDefault = isDefault;
        }

        /// <summary>
        /// The company name.
        /// </summary>
        /// <value>The company name.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "companyName", IsRequired = true, EmitDefaultValue = true)]
        public string CompanyName { get; set; }

        /// <summary>
        /// The company site.
        /// </summary>
        /// <value>The company site.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "site", IsRequired = true, EmitDefaultValue = true)]
        public string Site { get; set; }

        /// <summary>
        /// The company email address.
        /// </summary>
        /// <value>The company email address.</value>
        /*
        <example>Sydney_Roberts4@hotmail.com</example>
        */
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// The company address.
        /// </summary>
        /// <value>The company address.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// The company phone number.
        /// </summary>
        /// <value>The company phone number.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "phone", IsRequired = true, EmitDefaultValue = true)]
        public string Phone { get; set; }

        /// <summary>
        /// Specifies if a company is a licensor or not.
        /// </summary>
        /// <value>Specifies if a company is a licensor or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isLicensor", IsRequired = true, EmitDefaultValue = true)]
        public bool IsLicensor { get; set; }

        /// <summary>
        /// Specifies if the About page is visible or not.
        /// </summary>
        /// <value>Specifies if the About page is visible or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "hideAbout", IsRequired = true, EmitDefaultValue = true)]
        public bool HideAbout { get; set; }

        /// <summary>
        /// Specifies if these settings are default or not.
        /// </summary>
        /// <value>Specifies if these settings are default or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isDefault", IsRequired = true, EmitDefaultValue = true)]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompanyWhiteLabelSettingsDto {\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Site: ").Append(Site).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  IsLicensor: ").Append(IsLicensor).Append("\n");
            sb.Append("  HideAbout: ").Append(HideAbout).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
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
