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
    /// The request parameters for the user email.
    /// </summary>
    [DataContract(Name = "EmailMemberRequestDto")]
    public partial class EmailMemberRequestDto : IValidatableObject
    {

        /// <summary>
        /// Which CAPTCHA the &#x60;recaptchaResponse&#x60; comes from: &#x60;Default&#x60; for the web reCAPTCHA, &#x60;AndroidV2&#x60; or &#x60;iOSV2&#x60; for  the mobile ones, and &#x60;hCaptcha&#x60; when the portal is configured with hCaptcha. It matters only for an  unauthenticated request on a portal that has a CAPTCHA.
        /// </summary>
        [DataMember(Name = "recaptchaType", EmitDefaultValue = false)]
        public RecaptchaType? RecaptchaType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailMemberRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmailMemberRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailMemberRequestDto" /> class.
        /// </summary>
        /// <param name="email">The address to send the password recovery link to. It is required and validated even by  &#x60;POST api/2.0/people/guests/share/approve&#x60;, which then ignores its value and takes the account from the  confirmation token instead. (required).</param>
        /// <param name="recaptchaType">Which CAPTCHA the &#x60;recaptchaResponse&#x60; comes from: &#x60;Default&#x60; for the web reCAPTCHA, &#x60;AndroidV2&#x60; or &#x60;iOSV2&#x60; for  the mobile ones, and &#x60;hCaptcha&#x60; when the portal is configured with hCaptcha. It matters only for an  unauthenticated request on a portal that has a CAPTCHA..</param>
        /// <param name="recaptchaResponse">The user&#39;s response to the CAPTCHA challenge..</param>
        public EmailMemberRequestDto(string email = default, RecaptchaType? recaptchaType = default, string recaptchaResponse = default)
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for EmailMemberRequestDto and cannot be null");
            }
            this.Email = email;
            this.RecaptchaType = recaptchaType;
            this.RecaptchaResponse = recaptchaResponse;
        }

        /// <summary>
        /// The address to send the password recovery link to. It is required and validated even by  &#x60;POST api/2.0/people/guests/share/approve&#x60;, which then ignores its value and takes the account from the  confirmation token instead.
        /// </summary>
        /// <example>john.doe@example.com</example>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// The user&#39;s response to the CAPTCHA challenge.
        /// </summary>
        /// <example>03AGdBq27...</example>
        [DataMember(Name = "recaptchaResponse", EmitDefaultValue = true)]
        public string RecaptchaResponse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailMemberRequestDto {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  RecaptchaType: ").Append(RecaptchaType).Append("\n");
            sb.Append("  RecaptchaResponse: ").Append(RecaptchaResponse).Append("\n");
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

            yield break;
        }

    }


}
