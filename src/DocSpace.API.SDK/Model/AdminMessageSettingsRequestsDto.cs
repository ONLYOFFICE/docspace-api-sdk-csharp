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
    /// The message sent to the portal administrators, with the CAPTCHA proof that a person wrote it.
    /// </summary>
    [DataContract(Name = "AdminMessageSettingsRequestsDto")]
    public partial class AdminMessageSettingsRequestsDto : IValidatableObject
    {

        /// <summary>
        /// Which CAPTCHA service the proof in &#x60;recaptchaResponse&#x60; came from. It has to match the service the  installation is configured with, which &#x60;GET api/2.0/capabilities&#x60; reports; the default value means the  installation is left to decide.
        /// </summary>
        [DataMember(Name = "recaptchaType", EmitDefaultValue = false)]
        public RecaptchaType? RecaptchaType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminMessageSettingsRequestsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdminMessageSettingsRequestsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminMessageSettingsRequestsDto" /> class.
        /// </summary>
        /// <param name="message">What the sender wants to tell the portal administrators. Markup is stripped before the letter is written, so  a body that carries nothing but markup counts as empty and is refused with 400. (required).</param>
        /// <param name="email">The address the sender can be answered at, which the letter is signed with. It has to be a well-formed email  address. (required).</param>
        /// <param name="culture">The language the letter is written in, as a culture name such as &#x60;en-US&#x60;. A culture the installation does not  have falls back to the portal language rather than failing the call..</param>
        /// <param name="recaptchaType">Which CAPTCHA service the proof in &#x60;recaptchaResponse&#x60; came from. It has to match the service the  installation is configured with, which &#x60;GET api/2.0/capabilities&#x60; reports; the default value means the  installation is left to decide..</param>
        /// <param name="recaptchaResponse">The token the CAPTCHA widget produced in the browser, passed on unchanged for the portal to verify with the  CAPTCHA service. It is single-use and short-lived, so it cannot be reused for a second message..</param>
        public AdminMessageSettingsRequestsDto(string message = default, string email = default, string culture = default, RecaptchaType? recaptchaType = default, string recaptchaResponse = default)
        {
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new ArgumentNullException("message is a required property for AdminMessageSettingsRequestsDto and cannot be null");
            }
            this.Message = message;
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for AdminMessageSettingsRequestsDto and cannot be null");
            }
            this.Email = email;
            this.Culture = culture;
            this.RecaptchaType = recaptchaType;
            this.RecaptchaResponse = recaptchaResponse;
        }

        /// <summary>
        /// What the sender wants to tell the portal administrators. Markup is stripped before the letter is written, so  a body that carries nothing but markup counts as empty and is refused with 400.
        /// </summary>
        /// <example>Hello, this is a test message from the administrator.</example>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// The address the sender can be answered at, which the letter is signed with. It has to be a well-formed email  address.
        /// </summary>
        /// <example>user@example.com</example>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// The language the letter is written in, as a culture name such as &#x60;en-US&#x60;. A culture the installation does not  have falls back to the portal language rather than failing the call.
        /// </summary>
        /// <example>en-US</example>
        [DataMember(Name = "culture", EmitDefaultValue = true)]
        public string Culture { get; set; }

        /// <summary>
        /// The token the CAPTCHA widget produced in the browser, passed on unchanged for the portal to verify with the  CAPTCHA service. It is single-use and short-lived, so it cannot be reused for a second message.
        /// </summary>
        /// <example>03AGdBq24PBCbwiDRaS...</example>
        [DataMember(Name = "recaptchaResponse", EmitDefaultValue = true)]
        public string RecaptchaResponse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdminMessageSettingsRequestsDto {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Culture: ").Append(Culture).Append("\n");
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
            // Message (string) maxLength
            if (this.Message != null && this.Message.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Message, length must be less than 255.", new [] { "Message" });
            }

            // Message (string) minLength
            if (this.Message != null && this.Message.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Message, length must be greater than 0.", new [] { "Message" });
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

            yield break;
        }

    }


}
