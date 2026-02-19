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
    /// The request parameters for updating a user email.
    /// </summary>
    [DataContract(Name = "ChangeEmailRequest")]
    public partial class ChangeEmailRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeEmailRequest" /> class.
        /// </summary>
        /// <param name="email">The user email address..</param>
        /// <param name="encEmail">The user encrypted email address..</param>
        public ChangeEmailRequest(string email = default, string encEmail = default)
        {
            this.Email = email;
            this.EncEmail = encEmail;
        }

        /// <summary>
        /// The user email address.
        /// </summary>
        /// <value>The user email address.</value>
        /*
        <example>example@onlyoffice.com</example>
        */
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// The user encrypted email address.
        /// </summary>
        /// <value>The user encrypted email address.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "encEmail", EmitDefaultValue = false)]
        public string EncEmail { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangeEmailRequest {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EncEmail: ").Append(EncEmail).Append("\n");
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
