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
    /// Who is invited to join the portal, and in which language the invitation is written.
    /// </summary>
    [DataContract(Name = "AdminMessageBaseSettingsRequestsDto")]
    public partial class AdminMessageBaseSettingsRequestsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminMessageBaseSettingsRequestsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdminMessageBaseSettingsRequestsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdminMessageBaseSettingsRequestsDto" /> class.
        /// </summary>
        /// <param name="email">The address the join link is sent to. It has to be a well-formed ASCII address rather than an  internationalized one, must not already belong to a member of the portal, and, where the portal trusts named  domains only, has to end with one of them; any of these faults is refused with 400. (required).</param>
        /// <param name="culture">The language the letter is written in, as a culture name such as &#x60;en-US&#x60;. A culture the installation does not  have falls back to the portal language rather than failing the call..</param>
        public AdminMessageBaseSettingsRequestsDto(string email = default, string culture = default)
        {
            // to ensure "email" is required (not null)
            if (email == null)
            {
                throw new ArgumentNullException("email is a required property for AdminMessageBaseSettingsRequestsDto and cannot be null");
            }
            this.Email = email;
            this.Culture = culture;
        }

        /// <summary>
        /// The address the join link is sent to. It has to be a well-formed ASCII address rather than an  internationalized one, must not already belong to a member of the portal, and, where the portal trusts named  domains only, has to end with one of them; any of these faults is refused with 400.
        /// </summary>
        /// <example>admin@example.com</example>
        [DataMember(Name = "email", IsRequired = true, EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// The language the letter is written in, as a culture name such as &#x60;en-US&#x60;. A culture the installation does not  have falls back to the portal language rather than failing the call.
        /// </summary>
        /// <example>en-US</example>
        [DataMember(Name = "culture", EmitDefaultValue = true)]
        public string Culture { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdminMessageBaseSettingsRequestsDto {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Culture: ").Append(Culture).Append("\n");
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
