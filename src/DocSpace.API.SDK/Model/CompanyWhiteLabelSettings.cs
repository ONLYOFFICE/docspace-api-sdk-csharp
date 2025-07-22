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
    [DataContract(Name = "CompanyWhiteLabelSettings")]
    public partial class CompanyWhiteLabelSettings : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CompanyWhiteLabelSettings" /> class.
        /// </summary>
        /// <param name="companyName">The company name..</param>
        /// <param name="site">The company site..</param>
        /// <param name="email">The company email address..</param>
        /// <param name="address">The company address..</param>
        /// <param name="phone">The company phone number..</param>
        /// <param name="isLicensor">Specifies if a company is a licensor or not..</param>
        /// <param name="lastModified">lastModified.</param>
        public CompanyWhiteLabelSettings(string companyName = default, string site = default, string email = default, string address = default, string phone = default, bool isLicensor = default, DateTime lastModified = default)
        {
            this.CompanyName = companyName;
            this.Site = site;
            this.Email = email;
            this.Address = address;
            this.Phone = phone;
            this.IsLicensor = isLicensor;
            this.LastModified = lastModified;
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
        [DataMember(Name = "IsLicensor", EmitDefaultValue = true)]
        public bool IsLicensor { get; set; }

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
            sb.Append("class CompanyWhiteLabelSettings {\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Site: ").Append(Site).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  IsLicensor: ").Append(IsLicensor).Append("\n");
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
            // CompanyName (string) maxLength
            if (this.CompanyName != null && this.CompanyName.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CompanyName, length must be less than 255.", new [] { "CompanyName" });
            }

            // CompanyName (string) minLength
            if (this.CompanyName != null && this.CompanyName.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CompanyName, length must be greater than 0.", new [] { "CompanyName" });
            }

            // Site (string) maxLength
            if (this.Site != null && this.Site.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Site, length must be less than 255.", new [] { "Site" });
            }

            // Site (string) minLength
            if (this.Site != null && this.Site.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Site, length must be greater than 0.", new [] { "Site" });
            }

            // Email (string) maxLength
            if (this.Email != null && this.Email.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be less than 255.", new [] { "Email" });
            }

            // Email (string) minLength
            if (this.Email != null && this.Email.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be greater than 0.", new [] { "Email" });
            }

            // Address (string) maxLength
            if (this.Address != null && this.Address.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Address, length must be less than 255.", new [] { "Address" });
            }

            // Address (string) minLength
            if (this.Address != null && this.Address.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Address, length must be greater than 0.", new [] { "Address" });
            }

            // Phone (string) maxLength
            if (this.Phone != null && this.Phone.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Phone, length must be less than 255.", new [] { "Phone" });
            }

            // Phone (string) minLength
            if (this.Phone != null && this.Phone.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Phone, length must be greater than 0.", new [] { "Phone" });
            }

            yield break;
        }
    }


}
