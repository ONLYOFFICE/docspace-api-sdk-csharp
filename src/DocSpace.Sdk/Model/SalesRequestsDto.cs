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


 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The request parameters for handling sales and payment inquiries in the portal.
    /// </summary>
    [DataContract(Name = "SalesRequestsDto")]
    public partial class SalesRequestsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesRequestsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SalesRequestsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SalesRequestsDto" /> class.
        /// </summary>
        /// <param name="userName">The name of the user submitting the sales request..</param>
        /// <param name="email">The contact email address for the sales inquiry. (required).</param>
        /// <param name="message">The details of the sales inquiry or payment request. (required).</param>
        public SalesRequestsDto(string userName = default, string email = default, string message = default)
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for SalesRequestsDto and cannot be null");
            }
            this.Email = email;
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new ArgumentNullException("message is a required property for SalesRequestsDto and cannot be null");
            }
            this.Message = message;
            this.UserName = userName;
        }

        /// <summary>
        /// The name of the user submitting the sales request.
        /// </summary>
        /// <value>The name of the user submitting the sales request.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "userName", EmitDefaultValue = true)]
        public string UserName { get; set; }

        /// <summary>
        /// The contact email address for the sales inquiry.
        /// </summary>
        /// <value>The contact email address for the sales inquiry.</value>
        /*
        <example>Sydney_Roberts4@hotmail.com</example>
        */
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// The details of the sales inquiry or payment request.
        /// </summary>
        /// <value>The details of the sales inquiry or payment request.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SalesRequestsDto {\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            // UserName (string) maxLength
            if (this.UserName != null && this.UserName.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UserName, length must be less than 255.", new [] { "UserName" });
            }

            // Email (string) maxLength
            if (this.Email != null && this.Email.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be less than 64.", new [] { "Email" });
            }

            // Message (string) maxLength
            if (this.Message != null && this.Message.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Message, length must be less than 255.", new [] { "Message" });
            }

            yield break;
        }
    }


}
