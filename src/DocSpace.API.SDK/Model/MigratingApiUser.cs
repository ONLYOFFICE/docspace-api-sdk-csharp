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
    /// The migrating user parameters.
    /// </summary>
    [DataContract(Name = "MigratingApiUser")]
    public partial class MigratingApiUser : ImportableApiEntity, IValidatableObject
    {

        /// <summary>
        /// The user type.
        /// </summary>
        [DataMember(Name = "userType", EmitDefaultValue = false)]
        public EmployeeType? UserType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MigratingApiUser" /> class.
        /// </summary>
        /// <param name="key">The user key..</param>
        /// <param name="email">The user email..</param>
        /// <param name="displayName">The user display name..</param>
        /// <param name="firstName">The user first name..</param>
        /// <param name="lastName">The user last name..</param>
        /// <param name="userType">The user type..</param>
        /// <param name="migratingFiles">The user&#39;s migrating files..</param>
        public MigratingApiUser(string key = default, string email = default, string displayName = default, string firstName = default, string lastName = default, EmployeeType? userType = default, MigratingApiFiles migratingFiles = default)
        {
            this.Key = key;
            this.Email = email;
            this.DisplayName = displayName;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.UserType = userType;
            this.MigratingFiles = migratingFiles;
        }

        /// <summary>
        /// The user key.
        /// </summary>
        /// <example>abcd1234</example>
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// The user email.
        /// </summary>
        /// <example>john.doe@example.com</example>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// The user display name.
        /// </summary>
        /// <example>John Doe</example>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The user first name.
        /// </summary>
        /// <example>John</example>
        [DataMember(Name = "firstName", EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// The user last name.
        /// </summary>
        /// <example>Doe</example>
        [DataMember(Name = "lastName", EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// The user&#39;s migrating files.
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
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
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
