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
    /// The request parameters for the user email.
    /// </summary>
    [DataContract(Name = "EmailMemberRequestDto")]
    public partial class EmailMemberRequestDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets RecaptchaType
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
        /// <param name="email">The user email address. (required).</param>
        /// <param name="recaptchaType">recaptchaType.</param>
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
        /// The user email address.
        /// </summary>
        /// <value>The user email address.</value>
        /*
        <example>Sydney_Roberts4@hotmail.com</example>
        */
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

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
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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
