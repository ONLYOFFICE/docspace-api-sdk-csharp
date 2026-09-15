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
    /// The confirmation link a sign-in is authorised with, in place of a password.
    /// </summary>
    [DataContract(Name = "ConfirmData")]
    public partial class ConfirmData : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfirmData" /> class.
        /// </summary>
        /// <param name="email">The address the confirmation link was issued for. It has to be the same address the key was signed with, and  a value that is not an email address fails the request with 400..</param>
        /// <param name="first">Whether the link is being followed for the first time, taken from the &#x60;first&#x60; parameter of the confirmation  URL. It is part of what the key was signed over, so passing a different value invalidates the key rather than  changing behaviour..</param>
        /// <param name="key">The &#x60;key&#x60; parameter of the confirmation URL, copied verbatim. It is bound to the address and to the moment it  was issued, so it stops being accepted once the portal email key lifetime has passed..</param>
        public ConfirmData(string email = default, bool? first = default, string key = default)
        {
            this.Email = email;
            this.First = first;
            this.Key = key;
        }

        /// <summary>
        /// The address the confirmation link was issued for. It has to be the same address the key was signed with, and  a value that is not an email address fails the request with 400.
        /// </summary>
        /// <example>user@example.com</example>
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// Whether the link is being followed for the first time, taken from the &#x60;first&#x60; parameter of the confirmation  URL. It is part of what the key was signed over, so passing a different value invalidates the key rather than  changing behaviour.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "first", EmitDefaultValue = true)]
        public bool? First { get; set; }

        /// <summary>
        /// The &#x60;key&#x60; parameter of the confirmation URL, copied verbatim. It is bound to the address and to the moment it  was issued, so it stops being accepted once the portal email key lifetime has passed.
        /// </summary>
        /// <example>abc123def456</example>
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfirmData {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  First: ").Append(First).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
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
