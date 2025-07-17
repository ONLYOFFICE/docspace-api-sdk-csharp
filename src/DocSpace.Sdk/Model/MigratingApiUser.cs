/**
 *
 * (c) Copyright Ascensio System SIA 2025
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// MigratingApiUser
    /// </summary>
    [DataContract(Name = "MigratingApiUser")]
    public partial class MigratingApiUser : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets UserType
        /// </summary>
        [DataMember(Name = "userType", EmitDefaultValue = false)]
        public EmployeeType? UserType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MigratingApiUser" /> class.
        /// </summary>
        /// <param name="shouldImport">shouldImport.</param>
        /// <param name="key">key.</param>
        /// <param name="email">email.</param>
        /// <param name="displayName">displayName.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="userType">userType.</param>
        /// <param name="migratingFiles">migratingFiles.</param>
        public MigratingApiUser(bool shouldImport = default, string key = default, string email = default, string displayName = default, string firstName = default, string lastName = default, EmployeeType? userType = default, MigratingApiFiles migratingFiles = default)
        {
            this.ShouldImport = shouldImport;
            this.Key = key;
            this.Email = email;
            this.DisplayName = displayName;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UserType = userType;
            this.MigratingFiles = migratingFiles;
        }

        /// <summary>
        /// Gets or Sets ShouldImport
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "shouldImport", EmitDefaultValue = true)]
        public bool ShouldImport { get; set; }

        /// <summary>
        /// Gets or Sets Key
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        /*
        <example>Sydney_Roberts4@hotmail.com</example>
        */
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        /*
        <example>Winfield</example>
        */
        [DataMember(Name = "firstName", EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        /*
        <example>Wyman</example>
        */
        [DataMember(Name = "lastName", EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets MigratingFiles
        /// </summary>
        [DataMember(Name = "migratingFiles", EmitDefaultValue = false)]
        public MigratingApiFiles MigratingFiles { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MigratingApiUser {\n");
            sb.Append("  ShouldImport: ").Append(ShouldImport).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  UserType: ").Append(UserType).Append("\n");
            sb.Append("  MigratingFiles: ").Append(MigratingFiles).Append("\n");
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
