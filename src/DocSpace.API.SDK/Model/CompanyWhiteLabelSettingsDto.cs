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
    /// The vendor details the About page and the notification letters print, shared by the whole installation.
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
        /// <param name="companyName">The vendor name the About page shows and the letters sign off with. Until details are saved it holds  whatever the installation ships as its built-in vendor, and it is empty on an installation that ships none. (required).</param>
        /// <param name="site">The address the vendor name links to, as an absolute URL with its scheme. Empty under the same conditions  as &#x60;companyName&#x60;. (required).</param>
        /// <param name="email">The mailbox the About page offers for reaching the vendor. It is not the portal&#39;s own support address, and  it is empty under the same conditions as &#x60;companyName&#x60;. (required).</param>
        /// <param name="address">The postal address of the vendor as one free-form line, in the shape it was saved in - no structure is  imposed on it. (required).</param>
        /// <param name="phone">The telephone number of the vendor in the shape it was saved in, with no dialling format enforced. (required).</param>
        /// <param name="isLicensor">Whether these details are those of the licensor of the product itself rather than of a reseller. Saving  through &#x60;POST api/2.0/settings/rebranding/company&#x60; always clears it, so only details that came with the  installation can report &#x60;true&#x60;. (required).</param>
        /// <param name="hideAbout">Whether the About page is hidden from the interface. A plan that does not include branding cannot switch it  on: the value is stored as &#x60;false&#x60; in that case, so it can come back different from what was saved. (required).</param>
        /// <param name="isDefault">Whether every field above still matches the installation&#39;s built-in vendor details. It turns &#x60;false&#x60; as  soon as one of them is saved differently and &#x60;true&#x60; again after  &#x60;DELETE api/2.0/settings/rebranding/company&#x60;. (required).</param>
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
        /// The vendor name the About page shows and the letters sign off with. Until details are saved it holds  whatever the installation ships as its built-in vendor, and it is empty on an installation that ships none.
        /// </summary>
        /// <example>My Own Corporation</example>
        [DataMember(Name = "companyName", IsRequired = true, EmitDefaultValue = true)]
        public string CompanyName { get; set; }

        /// <summary>
        /// The address the vendor name links to, as an absolute URL with its scheme. Empty under the same conditions  as &#x60;companyName&#x60;.
        /// </summary>
        /// <example>https://www.example.com</example>
        [DataMember(Name = "site", IsRequired = true, EmitDefaultValue = true)]
        public string Site { get; set; }

        /// <summary>
        /// The mailbox the About page offers for reaching the vendor. It is not the portal&#39;s own support address, and  it is empty under the same conditions as &#x60;companyName&#x60;.
        /// </summary>
        /// <example>contact@example.com</example>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// The postal address of the vendor as one free-form line, in the shape it was saved in - no structure is  imposed on it.
        /// </summary>
        /// <example>123 Business St, New York, NY 10001</example>
        [DataMember(Name = "address", IsRequired = true, EmitDefaultValue = true)]
        public string Address { get; set; }

        /// <summary>
        /// The telephone number of the vendor in the shape it was saved in, with no dialling format enforced.
        /// </summary>
        /// <example>+1-800-555-0123</example>
        [DataMember(Name = "phone", IsRequired = true, EmitDefaultValue = true)]
        public string Phone { get; set; }

        /// <summary>
        /// Whether these details are those of the licensor of the product itself rather than of a reseller. Saving  through &#x60;POST api/2.0/settings/rebranding/company&#x60; always clears it, so only details that came with the  installation can report &#x60;true&#x60;.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isLicensor", IsRequired = true, EmitDefaultValue = true)]
        public bool IsLicensor { get; set; }

        /// <summary>
        /// Whether the About page is hidden from the interface. A plan that does not include branding cannot switch it  on: the value is stored as &#x60;false&#x60; in that case, so it can come back different from what was saved.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "hideAbout", IsRequired = true, EmitDefaultValue = true)]
        public bool HideAbout { get; set; }

        /// <summary>
        /// Whether every field above still matches the installation&#39;s built-in vendor details. It turns &#x60;false&#x60; as  soon as one of them is saved differently and &#x60;true&#x60; again after  &#x60;DELETE api/2.0/settings/rebranding/company&#x60;.
        /// </summary>
        /// <example>true</example>
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
