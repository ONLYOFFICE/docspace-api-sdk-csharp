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
    /// The vendor details of the installation in the shape the licensor listing and the reset of the company details  return, with the licensor flag spelled &#x60;IsLicensor&#x60;.
    /// </summary>
    [DataContract(Name = "LicensorDetailsDto")]
    public partial class LicensorDetailsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LicensorDetailsDto" /> class.
        /// </summary>
        /// <param name="companyName">The vendor name the About page shows and the letters sign off with. Until details are saved it holds  whatever the installation ships as its built-in vendor, and it is empty on an installation that ships none..</param>
        /// <param name="site">The address the vendor name links to, as an absolute URL with its scheme. Empty under the same conditions  as &#x60;companyName&#x60;..</param>
        /// <param name="email">The mailbox the About page offers for reaching the vendor. It is not the portal&#39;s own support address, and  it is empty under the same conditions as &#x60;companyName&#x60;..</param>
        /// <param name="address">The postal address of the vendor as one free-form line, in the shape it was saved in - no structure is  imposed on it..</param>
        /// <param name="phone">The telephone number of the vendor in the shape it was saved in, with no dialling format enforced..</param>
        /// <param name="isLicensor">Whether these details are those of the licensor of the product itself rather than of a reseller. Saving  through &#x60;POST api/2.0/settings/rebranding/company&#x60; always clears it, so only details that came with the  installation can report &#x60;true&#x60;. The name starts with a capital letter, unlike the other fields..</param>
        /// <param name="hideAbout">Whether the About page is hidden from the interface. A plan that does not include branding cannot switch it  on: the value is stored as &#x60;false&#x60; in that case, so it can come back different from what was saved..</param>
        /// <param name="lastModified">When these details were last stored. Details that were never stored report the moment they were read; the  built-in ONLYOFFICE entry and the answer of the reset operation report &#x60;0001-01-01T00:00:00&#x60;..</param>
        public LicensorDetailsDto(string companyName = default, string site = default, string email = default, string address = default, string phone = default, bool isLicensor = default, bool hideAbout = default, DateTime lastModified = default)
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
        /// The vendor name the About page shows and the letters sign off with. Until details are saved it holds  whatever the installation ships as its built-in vendor, and it is empty on an installation that ships none.
        /// </summary>
        /// <example>My Own Corporation</example>
        [DataMember(Name = "companyName", EmitDefaultValue = true)]
        public string CompanyName { get; set; }

        /// <summary>
        /// The address the vendor name links to, as an absolute URL with its scheme. Empty under the same conditions  as &#x60;companyName&#x60;.
        /// </summary>
        /// <example>https://www.example.com</example>
        [DataMember(Name = "site", EmitDefaultValue = true)]
        public string Site { get; set; }

        /// <summary>
        /// The mailbox the About page offers for reaching the vendor. It is not the portal&#39;s own support address, and  it is empty under the same conditions as &#x60;companyName&#x60;.
        /// </summary>
        /// <example>contact@example.com</example>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// The postal address of the vendor as one free-form line, in the shape it was saved in - no structure is  imposed on it.
        /// </summary>
        /// <example>123 Business St, New York, NY 10001</example>
        [DataMember(Name = "address", EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// The telephone number of the vendor in the shape it was saved in, with no dialling format enforced.
        /// </summary>
        /// <example>+1-800-555-0123</example>
        [DataMember(Name = "phone", EmitDefaultValue = true)]
        public string Phone { get; set; }

        /// <summary>
        /// Whether these details are those of the licensor of the product itself rather than of a reseller. Saving  through &#x60;POST api/2.0/settings/rebranding/company&#x60; always clears it, so only details that came with the  installation can report &#x60;true&#x60;. The name starts with a capital letter, unlike the other fields.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "IsLicensor", EmitDefaultValue = true)]
        public bool IsLicensor { get; set; }

        /// <summary>
        /// Whether the About page is hidden from the interface. A plan that does not include branding cannot switch it  on: the value is stored as &#x60;false&#x60; in that case, so it can come back different from what was saved.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "hideAbout", EmitDefaultValue = true)]
        public bool HideAbout { get; set; }

        /// <summary>
        /// When these details were last stored. Details that were never stored report the moment they were read; the  built-in ONLYOFFICE entry and the answer of the reset operation report &#x60;0001-01-01T00:00:00&#x60;.
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
            sb.Append("class LicensorDetailsDto {\n");
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
