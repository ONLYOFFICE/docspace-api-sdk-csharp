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
        /// <param name="employeeType">employeeType.</param>
        /// <param name="firstName">The user first name..</param>
        /// <param name="lastName">The user last name..</param>
        /// <param name="email">The user email address..</param>
        /// <param name="passwordHash">The user password hash..</param>
        /// <param name="key">The user link key..</param>
        /// <param name="culture">The user culture code..</param>
        /// <param name="serializedProfile">Third-party profile in the serialized format.</param>
        public SignupAccountRequestDto(EmployeeType? employeeType = default, string firstName = default, string lastName = default, string email = default, string passwordHash = default, string key = default, string culture = default, string serializedProfile = default)
        {
            this.EmployeeType = employeeType;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.PasswordHash = passwordHash;
            this.Key = key;
            this.Culture = culture;
            this.SerializedProfile = serializedProfile;
        }

        /// <summary>
        /// The user first name.
        /// </summary>
        /// <value>The user first name.</value>
        /*
        <example>Winfield</example>
        */
        [DataMember(Name = "firstName", EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// The user last name.
        /// </summary>
        /// <value>The user last name.</value>
        /*
        <example>Wyman</example>
        */
        [DataMember(Name = "lastName", EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// The user email address.
        /// </summary>
        /// <value>The user email address.</value>
        /*
        <example>Sydney_Roberts4@hotmail.com</example>
        */
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// The user password hash.
        /// </summary>
        /// <value>The user password hash.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "passwordHash", EmitDefaultValue = true)]
        public string PasswordHash { get; set; }

        /// <summary>
        /// The user link key.
        /// </summary>
        /// <value>The user link key.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// The user culture code.
        /// </summary>
        /// <value>The user culture code.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "culture", EmitDefaultValue = true)]
        public string Culture { get; set; }

        /// <summary>
        /// Third-party profile in the serialized format
        /// </summary>
        /// <value>Third-party profile in the serialized format</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "serializedProfile", EmitDefaultValue = true)]
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
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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
