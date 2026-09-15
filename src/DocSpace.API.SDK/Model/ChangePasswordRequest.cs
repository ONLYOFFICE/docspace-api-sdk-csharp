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
    /// The request parameters for updating a user password.
    /// </summary>
    [DataContract(Name = "ChangePasswordRequest")]
    public partial class ChangePasswordRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ChangePasswordRequest" /> class.
        /// </summary>
        /// <param name="password">The new password in plain text. It is checked against the portal password policy and rejected with 400 when  it is too weak, then hashed by the portal. Send it only over a secure connection, and prefer &#x60;passwordHash&#x60;  when the client can compute it..</param>
        /// <param name="passwordHash">The new password already hashed by the client, which is what the portal stores. It is a PBKDF2-HMACSHA256  hash of the plain password, computed with the salt, the iteration count and the key size the portal settings  publish, and written as lowercase hexadecimal. When it is sent, &#x60;password&#x60; is ignored and the password policy  is not applied..</param>
        public ChangePasswordRequest(string password = default, string passwordHash = default)
        {
            this.Password = password;
            this.PasswordHash = passwordHash;
        }

        /// <summary>
        /// The new password in plain text. It is checked against the portal password policy and rejected with 400 when  it is too weak, then hashed by the portal. Send it only over a secure connection, and prefer &#x60;passwordHash&#x60;  when the client can compute it.
        /// </summary>
        /// <example>P@ssw0rd</example>
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// The new password already hashed by the client, which is what the portal stores. It is a PBKDF2-HMACSHA256  hash of the plain password, computed with the salt, the iteration count and the key size the portal settings  publish, and written as lowercase hexadecimal. When it is sent, &#x60;password&#x60; is ignored and the password policy  is not applied.
        /// </summary>
        /// <example>c1ba1a0bcbe0f0f42b6c86e1b41a1b4a4a9b4b0e3f2b7d2c1a0e9f8d7c6b5a49</example>
        [DataMember(Name = "passwordHash", EmitDefaultValue = true)]
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
