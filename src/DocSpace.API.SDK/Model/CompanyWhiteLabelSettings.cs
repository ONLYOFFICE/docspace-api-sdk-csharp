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
        /// <param name="hideAbout">Specifies if the About page is visible or not.</param>
        /// <param name="lastModified">The timestamp indicating when the settings were last modified..</param>
        public CompanyWhiteLabelSettings(string companyName = default, string site = default, string email = default, string address = default, string phone = default, bool isLicensor = default, bool hideAbout = default, DateTime lastModified = default)
        {
            this.CompanyName = companyName;
            this.Site = site;
            this.Email = email;
            this.Address = address;
            this.Phone = phone;
            this.IsLicensor = isLicensor;
            this.HideAbout = hideAbout;
            this.LastModified = lastModified;
        }

        /// <summary>
        /// The company name.
        /// </summary>
        /// <example>ONLYOFFICE</example>
        [DataMember(Name = "companyName", EmitDefaultValue = true)]
        public string CompanyName { get; set; }

        /// <summary>
        /// The company site.
        /// </summary>
        /// <example>https://www.onlyoffice.com</example>
        [DataMember(Name = "site", EmitDefaultValue = true)]
        public string Site { get; set; }

        /// <summary>
        /// The company email address.
        /// </summary>
        /// <example>support@onlyoffice.com</example>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// The company address.
        /// </summary>
        /// <example>Lubanas st. 125a-25</example>
        [DataMember(Name = "address", EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// The company phone number.
        /// </summary>
        /// <example>+7 843 2271372</example>
        [DataMember(Name = "phone", EmitDefaultValue = true)]
        public string Phone { get; set; }

        /// <summary>
        /// Specifies if a company is a licensor or not.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "IsLicensor", EmitDefaultValue = true)]
        public bool IsLicensor { get; set; }

        /// <summary>
        /// Specifies if the About page is visible or not
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "hideAbout", EmitDefaultValue = true)]
        public bool HideAbout { get; set; }

        /// <summary>
        /// The timestamp indicating when the settings were last modified.
        /// </summary>
        /// <example>1990-01-01T00:00:00Z</example>
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
            sb.Append("  HideAbout: ").Append(HideAbout).Append("\n");
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
