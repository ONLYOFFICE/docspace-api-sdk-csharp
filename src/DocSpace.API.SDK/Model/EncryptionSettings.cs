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
    /// The encryption settings.
    /// </summary>
    [DataContract(Name = "EncryptionSettings")]
    public partial class EncryptionSettings : IValidatableObject
    {

        /// <summary>
        /// The encryption status.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public EncryprtionStatus? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptionSettings" /> class.
        /// </summary>
        /// <param name="password">The encryption password..</param>
        /// <param name="status">The encryption status..</param>
        /// <param name="notifyUsers">Specifies if the users will be notified about the encryption operation or not..</param>
        public EncryptionSettings(string password = default, EncryprtionStatus? status = default, bool notifyUsers = default)
        {
            this.Password = password;
            this.Status = status;
            this.NotifyUsers = notifyUsers;
        }

        /// <summary>
        /// The encryption password.
        /// </summary>
        /// <example>password</example>
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// Specifies if the users will be notified about the encryption operation or not.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "notifyUsers", EmitDefaultValue = true)]
        public bool NotifyUsers { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EncryptionSettings {\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  NotifyUsers: ").Append(NotifyUsers).Append("\n");
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
