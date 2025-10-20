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
    /// The request parameters for configuring the administrator message content.
    /// </summary>
    [DataContract(Name = "AdminMessageSettingsRequestsDto")]
    public partial class AdminMessageSettingsRequestsDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets RecaptchaType
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
        /// <param name="message">The content of the administrator message to be sent. (required).</param>
        /// <param name="email">Email (required).</param>
        /// <param name="culture">Culture.</param>
        /// <param name="recaptchaType">recaptchaType.</param>
        /// <param name="recaptchaResponse">The user&#39;s response to the CAPTCHA challenge..</param>
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
        /// The content of the administrator message to be sent.
        /// </summary>
        /// <value>The content of the administrator message to be sent.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        /// <value>Email</value>
        /*
        <example>Sydney_Roberts4@hotmail.com</example>
        */
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Culture
        /// </summary>
        /// <value>Culture</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "culture", EmitDefaultValue = true)]
        public string Culture { get; set; }

        /// <summary>
        /// The user&#39;s response to the CAPTCHA challenge.
        /// </summary>
        /// <value>The user&#39;s response to the CAPTCHA challenge.</value>
        /*
        <example>some text</example>
        */
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
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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
