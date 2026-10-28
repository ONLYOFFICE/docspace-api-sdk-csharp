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
    /// The parameters a client hashes a password with before sending it.
    /// </summary>
    [DataContract(Name = "PasswordHashSettingsDto")]
    public partial class PasswordHashSettingsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordHashSettingsDto" /> class.
        /// </summary>
        /// <param name="size">The length of the hash, in bytes..</param>
        /// <param name="iterations">The number of PBKDF2 iterations..</param>
        /// <param name="salt">The salt the installation hashes passwords with..</param>
        public PasswordHashSettingsDto(int size = default, int iterations = default, string salt = default)
        {
            this.Size = size;
            this.Iterations = iterations;
            this.Salt = salt;
        }

        /// <summary>
        /// The length of the hash, in bytes.
        /// </summary>
        /// <example>32</example>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public int Size { get; set; }

        /// <summary>
        /// The number of PBKDF2 iterations.
        /// </summary>
        /// <example>100000</example>
        [DataMember(Name = "iterations", EmitDefaultValue = false)]
        public int Iterations { get; set; }

        /// <summary>
        /// The salt the installation hashes passwords with.
        /// </summary>
        /// <example>random_salt_value</example>
        [DataMember(Name = "salt", EmitDefaultValue = true)]
        public string Salt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PasswordHashSettingsDto {\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Iterations: ").Append(Iterations).Append("\n");
            sb.Append("  Salt: ").Append(Salt).Append("\n");
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
