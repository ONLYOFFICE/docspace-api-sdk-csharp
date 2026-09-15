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
    /// Who is writing to the ONLYOFFICE sales team, and what about.
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
        /// <param name="userName">The name the sales team should address the reply to. It is sent as written and is not matched against any  portal account; an empty value fails the request with 400. (required).</param>
        /// <param name="email">The address the answer is sent to. It has to be a well-formed email address and need not be the caller portal  address; an empty or malformed value fails the request with 400. (required).</param>
        /// <param name="message">What is being asked of the sales team - a quote, an invoice, or a plan that cannot be bought online. An empty  value fails the request with 400. (required).</param>
        public SalesRequestsDto(string userName = default, string email = default, string message = default)
        {
            // to ensure "userName" is required (not null)
            if (userName == null)
            {
                throw new ArgumentNullException("userName is a required property for SalesRequestsDto and cannot be null");
            }
            this.UserName = userName;
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
        }

        /// <summary>
        /// The name the sales team should address the reply to. It is sent as written and is not matched against any  portal account; an empty value fails the request with 400.
        /// </summary>
        /// <example>John Doe</example>
        [DataMember(Name = "userName", IsRequired = true, EmitDefaultValue = true)]
        public string UserName { get; set; }

        /// <summary>
        /// The address the answer is sent to. It has to be a well-formed email address and need not be the caller portal  address; an empty or malformed value fails the request with 400.
        /// </summary>
        /// <example>user@example.com</example>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// What is being asked of the sales team - a quote, an invoice, or a plan that cannot be bought online. An empty  value fails the request with 400.
        /// </summary>
        /// <example>I would like to inquire about pricing</example>
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
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

            // UserName (string) minLength
            if (this.UserName != null && this.UserName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UserName, length must be greater than 1.", new [] { "UserName" });
            }

            // Email (string) maxLength
            if (this.Email != null && this.Email.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be less than 64.", new [] { "Email" });
            }

            // Email (string) minLength
            if (this.Email != null && this.Email.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Email, length must be greater than 1.", new [] { "Email" });
            }

            // Message (string) maxLength
            if (this.Message != null && this.Message.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Message, length must be less than 255.", new [] { "Message" });
            }

            // Message (string) minLength
            if (this.Message != null && this.Message.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Message, length must be greater than 1.", new [] { "Message" });
            }

            yield break;
        }

    }


}
