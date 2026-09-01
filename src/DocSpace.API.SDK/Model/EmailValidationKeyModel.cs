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
    /// The confirmation email parameters.
    /// </summary>
    [DataContract(Name = "EmailValidationKeyModel")]
    public partial class EmailValidationKeyModel : IValidatableObject
    {

        /// <summary>
        /// The user type.
        /// </summary>
        [DataMember(Name = "emplType", EmitDefaultValue = false)]
        public EmployeeType? EmplType { get; set; }

        /// <summary>
        /// The confirmation email type.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public ConfirmType? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailValidationKeyModel" /> class.
        /// </summary>
        /// <param name="key">The email validation key..</param>
        /// <param name="emplType">The user type..</param>
        /// <param name="email">The email address..</param>
        /// <param name="encEmail">The encrypted email address..</param>
        /// <param name="uiD">The user ID..</param>
        /// <param name="type">The confirmation email type..</param>
        /// <param name="first">Specifies whether it is the first time account access or not..</param>
        /// <param name="roomId">The room ID..</param>
        public EmailValidationKeyModel(string key = default, EmployeeType? emplType = default, string email = default, string encEmail = default, Guid? uiD = default, ConfirmType? type = default, string first = default, string roomId = default)
        {
            this.Key = key;
            this.EmplType = emplType;
            this.Email = email;
            this.EncEmail = encEmail;
            this.UiD = uiD;
            this.Type = type;
            this.First = first;
            this.RoomId = roomId;
        }

        /// <summary>
        /// The email validation key.
        /// </summary>
        /// <example>abcdef123456</example>
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// The email address.
        /// </summary>
        /// <example>user@example.com</example>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// The encrypted email address.
        /// </summary>
        /// <example>user%40example.com</example>
        [DataMember(Name = "encEmail", EmitDefaultValue = true)]
        public string EncEmail { get; set; }

        /// <summary>
        /// The user ID.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000000</example>
        [DataMember(Name = "uiD", EmitDefaultValue = true)]
        public Guid? UiD { get; set; }

        /// <summary>
        /// Specifies whether it is the first time account access or not.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "first", EmitDefaultValue = true)]
        public string First { get; set; }

        /// <summary>
        /// The room ID.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "roomId", EmitDefaultValue = true)]
        public string RoomId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailValidationKeyModel {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  EmplType: ").Append(EmplType).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  EncEmail: ").Append(EncEmail).Append("\n");
            sb.Append("  UiD: ").Append(UiD).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  First: ").Append(First).Append("\n");
            sb.Append("  RoomId: ").Append(RoomId).Append("\n");
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
