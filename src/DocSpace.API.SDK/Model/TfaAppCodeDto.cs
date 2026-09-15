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
    /// One backup code of the caller&#39;s authenticator credential.
    /// </summary>
    [DataContract(Name = "TfaAppCodeDto")]
    public partial class TfaAppCodeDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TfaAppCodeDto" /> class.
        /// </summary>
        /// <param name="isUsed">Whether the code has already been spent. A spent code is kept in the list but is no longer accepted, so  count the entries where this is &#x60;false&#x60; to know how many fallbacks remain..</param>
        /// <param name="code">The code itself, in the form it is typed at sign-in - six characters with the default configuration. It is  stored encrypted and decrypted for this answer, so this is the one place a caller can read it..</param>
        public TfaAppCodeDto(bool isUsed = default, string code = default)
        {
            this.IsUsed = isUsed;
            this.Code = code;
        }

        /// <summary>
        /// Whether the code has already been spent. A spent code is kept in the list but is no longer accepted, so  count the entries where this is &#x60;false&#x60; to know how many fallbacks remain.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "isUsed", EmitDefaultValue = true)]
        public bool IsUsed { get; set; }

        /// <summary>
        /// The code itself, in the form it is typed at sign-in - six characters with the default configuration. It is  stored encrypted and decrypted for this answer, so this is the one place a caller can read it.
        /// </summary>
        /// <example>123456</example>
        [DataMember(Name = "code", EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TfaAppCodeDto {\n");
            sb.Append("  IsUsed: ").Append(IsUsed).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
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
