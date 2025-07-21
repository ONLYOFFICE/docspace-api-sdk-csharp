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


 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
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
        /// <param name="companyName">The company name..</param>
        /// <param name="site">The company site..</param>
        /// <param name="email">The company email address..</param>
        /// <param name="address">The company address..</param>
        /// <param name="phone">The company phone number..</param>
        /// <param name="isLicensor">Specifies if a company is a licensor or not..</param>
        /// <param name="isDefault">Specifies if company white label settings are default or not..</param>
        public CompanyWhiteLabelSettingsDto(string companyName = default, string site = default, string email = default, string address = default, string phone = default, bool isLicensor = default, bool isDefault = default)
        {
            this.CompanyName = companyName;
            this.Site = site;
            this.Email = email;
            this.Address = address;
            this.Phone = phone;
            this.IsLicensor = isLicensor;
            this.IsDefault = isDefault;
        }

        /// <summary>
        /// The company name.
        /// </summary>
        /// <value>The company name.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "companyName", EmitDefaultValue = true)]
        public string CompanyName { get; set; }

        /// <summary>
        /// The company site.
        /// </summary>
        /// <value>The company site.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "site", EmitDefaultValue = true)]
        public string Site { get; set; }

        /// <summary>
        /// The company email address.
        /// </summary>
        /// <value>The company email address.</value>
        /*
        <example>Sydney_Roberts4@hotmail.com</example>
        */
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// The company address.
        /// </summary>
        /// <value>The company address.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "address", EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// The company phone number.
        /// </summary>
        /// <value>The company phone number.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "phone", EmitDefaultValue = true)]
        public string Phone { get; set; }

        /// <summary>
        /// Specifies if a company is a licensor or not.
        /// </summary>
        /// <value>Specifies if a company is a licensor or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isLicensor", EmitDefaultValue = true)]
        public bool IsLicensor { get; set; }

        /// <summary>
        /// Specifies if company white label settings are default or not.
        /// </summary>
        /// <value>Specifies if company white label settings are default or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isDefault", EmitDefaultValue = true)]
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
