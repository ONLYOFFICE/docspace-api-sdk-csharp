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
    /// The request parameters for creating a third-party account.
    /// </summary>
    [DataContract(Name = "SignupAccountRequestDto")]
    public partial class SignupAccountRequestDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets EmployeeType
        /// </summary>
        [DataMember(Name = "employeeType", EmitDefaultValue = false)]
        public EmployeeType? EmployeeType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SignupAccountRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SignupAccountRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SignupAccountRequestDto" /> class.
        /// </summary>
        /// <param name="employeeType">employeeType.</param>
        /// <param name="firstName">The user first name..</param>
        /// <param name="lastName">The user last name..</param>
        /// <param name="email">The user email address..</param>
        /// <param name="passwordHash">The user password hash..</param>
        /// <param name="key">The user link key. (required).</param>
        /// <param name="culture">The user culture code..</param>
        /// <param name="serializedProfile">The third-party profile in the serialized format (required).</param>
        public SignupAccountRequestDto(EmployeeType? employeeType = default, string firstName = default, string lastName = default, string email = default, string passwordHash = default, string key = default, string culture = default, string serializedProfile = default)
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new ArgumentNullException("key is a required property for SignupAccountRequestDto and cannot be null");
            }
            this.Key = key;
            // to ensure "serializedProfile" is required (not null)
            if (serializedProfile == null)
            {
                throw new ArgumentNullException("serializedProfile is a required property for SignupAccountRequestDto and cannot be null");
            }
            this.SerializedProfile = serializedProfile;
            this.EmployeeType = employeeType;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.PasswordHash = passwordHash;
            this.Culture = culture;
        }

        /// <summary>
        /// The user first name.
        /// </summary>
        /// <value>The user first name.</value>
        /*
        <example>John</example>
        */
        [DataMember(Name = "firstName", EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// The user last name.
        /// </summary>
        /// <value>The user last name.</value>
        /*
        <example>Doe</example>
        */
        [DataMember(Name = "lastName", EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// The user email address.
        /// </summary>
        /// <value>The user email address.</value>
        /*
        <example>john.doe@example.com</example>
        */
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// The user password hash.
        /// </summary>
        /// <value>The user password hash.</value>
        /*
        <example>$2a$10$abcdefghijklmnopqrstuv</example>
        */
        [DataMember(Name = "passwordHash", EmitDefaultValue = true)]
        public string PasswordHash { get; set; }

        /// <summary>
        /// The user link key.
        /// </summary>
        /// <value>The user link key.</value>
        /*
        <example>invite_key_123456</example>
        */
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// The user culture code.
        /// </summary>
        /// <value>The user culture code.</value>
        /*
        <example>en-US</example>
        */
        [DataMember(Name = "culture", EmitDefaultValue = true)]
        public string Culture { get; set; }

        /// <summary>
        /// The third-party profile in the serialized format
        /// </summary>
        /// <value>The third-party profile in the serialized format</value>
        /*
        <example>{&quot;provider&quot;:&quot;Google&quot;,&quot;id&quot;:&quot;123456&quot;}</example>
        */
        [DataMember(Name = "serializedProfile", IsRequired = true, EmitDefaultValue = true)]
        public string SerializedProfile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SignupAccountRequestDto {\n");
            sb.Append("  EmployeeType: ").Append(EmployeeType).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  PasswordHash: ").Append(PasswordHash).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Culture: ").Append(Culture).Append("\n");
            sb.Append("  SerializedProfile: ").Append(SerializedProfile).Append("\n");
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
