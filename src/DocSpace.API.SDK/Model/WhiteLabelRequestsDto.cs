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
    /// The branding a portal is given: the wordmark, the logo images, or both.
    /// </summary>
    [DataContract(Name = "WhiteLabelRequestsDto")]
    public partial class WhiteLabelRequestsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WhiteLabelRequestsDto" /> class.
        /// </summary>
        /// <param name="logoText">The wordmark printed next to or instead of a logo image, on the login page, in the editors and in  notification letters. An empty or blank value, and the built-in &#x60;ONLYOFFICE&#x60; itself, clear the setting rather  than store it. The text is not rendered into the logo images, which carry their own wordmark..</param>
        /// <param name="logo">The logo images to store, each entry naming a logo slot in its &#x60;key&#x60; - the numeric &#x60;type&#x60; published by  &#x60;GET api/2.0/settings/whitelabel/logos&#x60; - and carrying the two theme images in its value. A slot left out of  the list keeps the image it has, so this is a partial update rather than a replacement of the whole branding.  Saving the login-page slot also rebuilds the notification logo from it..</param>
        public WhiteLabelRequestsDto(string logoText = default, List<ItemKeyValuePairStringLogoRequestsDto> logo = default)
        {
            this.LogoText = logoText;
            this.Logo = logo;
        }

        /// <summary>
        /// The wordmark printed next to or instead of a logo image, on the login page, in the editors and in  notification letters. An empty or blank value, and the built-in &#x60;ONLYOFFICE&#x60; itself, clear the setting rather  than store it. The text is not rendered into the logo images, which carry their own wordmark.
        /// </summary>
        /// <example>Company Name</example>
        [DataMember(Name = "logoText", EmitDefaultValue = true)]
        public string LogoText { get; set; }

        /// <summary>
        /// The logo images to store, each entry naming a logo slot in its &#x60;key&#x60; - the numeric &#x60;type&#x60; published by  &#x60;GET api/2.0/settings/whitelabel/logos&#x60; - and carrying the two theme images in its value. A slot left out of  the list keeps the image it has, so this is a partial update rather than a replacement of the whole branding.  Saving the login-page slot also rebuilds the notification logo from it.
        /// </summary>
        /// <example>["item1","item2"]</example>
        [DataMember(Name = "logo", EmitDefaultValue = true)]
        public List<ItemKeyValuePairStringLogoRequestsDto> Logo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WhiteLabelRequestsDto {\n");
            sb.Append("  LogoText: ").Append(LogoText).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
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
            // LogoText (string) maxLength
            if (this.LogoText != null && this.LogoText.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LogoText, length must be less than 40.", new [] { "LogoText" });
            }

            // LogoText (string) minLength
            if (this.LogoText != null && this.LogoText.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LogoText, length must be greater than 0.", new [] { "LogoText" });
            }

            yield break;
        }

    }


}
