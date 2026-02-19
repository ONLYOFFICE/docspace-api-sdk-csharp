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
    /// The request parameters for updating a user password.
    /// </summary>
    [DataContract(Name = "ChangePasswordRequest")]
    public partial class ChangePasswordRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePasswordRequest" /> class.
        /// </summary>
        /// <param name="password">The user password..</param>
        /// <param name="passwordHash">The user password hash..</param>
        public ChangePasswordRequest(string password = default, string passwordHash = default)
        {
            this.Password = password;
            this.PasswordHash = passwordHash;
        }

        /// <summary>
        /// The user password.
        /// </summary>
        /// <value>The user password.</value>
        /*
        <example>P@ssw0rd123</example>
        */
        [DataMember(Name = "password", EmitDefaultValue = false)]
        public string Password { get; set; }

        /// <summary>
        /// The user password hash.
        /// </summary>
        /// <value>The user password hash.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "passwordHash", EmitDefaultValue = false)]
        public string PasswordHash { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChangePasswordRequest {\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  PasswordHash: ").Append(PasswordHash).Append("\n");
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
