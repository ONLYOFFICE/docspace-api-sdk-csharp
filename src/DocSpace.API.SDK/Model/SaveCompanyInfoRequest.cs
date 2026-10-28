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
    /// The company the installation is branded for, as shown on the About page and in letters.
    /// </summary>
    [DataContract(Name = "SaveCompanyInfoRequest")]
    public partial class SaveCompanyInfoRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveCompanyInfoRequest" /> class.
        /// </summary>
        /// <param name="companyName">The company name..</param>
        /// <param name="site">The company website, as an absolute URL..</param>
        /// <param name="email">The contact email address..</param>
        /// <param name="address">The postal address..</param>
        /// <param name="phone">The contact phone number..</param>
        /// <param name="isLicensor">Accepted for compatibility with earlier clients and not read: saved details are never those of the licensor, so the server always stores &#x60;false&#x60;..</param>
        /// <param name="hideAbout">Whether the About page is hidden..</param>
        /// <param name="lastModified">Accepted for compatibility with earlier clients and not read: the server keeps its own value..</param>
        public SaveCompanyInfoRequest(string companyName = default, string site = default, string email = default, string address = default, string phone = default, bool isLicensor = default, bool hideAbout = default, DateTime lastModified = default)
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
        /// The company website, as an absolute URL.
        /// </summary>
        /// <example>https://www.onlyoffice.com</example>
        [DataMember(Name = "site", EmitDefaultValue = true)]
        public string Site { get; set; }

        /// <summary>
        /// The contact email address.
        /// </summary>
        /// <example>support@onlyoffice.com</example>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// The postal address.
        /// </summary>
        /// <example>Lubanas st. 125a-25</example>
        [DataMember(Name = "address", EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// The contact phone number.
        /// </summary>
        /// <example>+7 843 2271372</example>
        [DataMember(Name = "phone", EmitDefaultValue = true)]
        public string Phone { get; set; }

        /// <summary>
        /// Accepted for compatibility with earlier clients and not read: saved details are never those of the licensor, so the server always stores &#x60;false&#x60;.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "IsLicensor", EmitDefaultValue = true)]
        public bool IsLicensor { get; set; }

        /// <summary>
        /// Whether the About page is hidden.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "hideAbout", EmitDefaultValue = true)]
        public bool HideAbout { get; set; }

        /// <summary>
        /// Accepted for compatibility with earlier clients and not read: the server keeps its own value.
        /// </summary>
        /// <example>2026-01-01T10:00:00</example>
        [DataMember(Name = "lastModified", EmitDefaultValue = false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaveCompanyInfoRequest {\n");
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
