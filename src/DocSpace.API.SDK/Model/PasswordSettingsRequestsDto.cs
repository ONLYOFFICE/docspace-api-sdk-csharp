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
    /// The four values that make up the portal password policy, replaced together.
    /// </summary>
    [DataContract(Name = "PasswordSettingsRequestsDto")]
    public partial class PasswordSettingsRequestsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordSettingsRequestsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PasswordSettingsRequestsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PasswordSettingsRequestsDto" /> class.
        /// </summary>
        /// <param name="minLength">The shortest password the portal will accept. It has to sit between the floor the installation is configured  with, 8 characters unless it was changed, and the ceiling of 30; a value outside that is refused with 400. (required).</param>
        /// <param name="upperCase">Whether a password must contain at least one uppercase letter. There is no partial update on this body, so  leaving the flag out stores it as &#x60;false&#x60; and drops the requirement..</param>
        /// <param name="digits">Whether a password must contain at least one digit. Leaving the flag out stores it as &#x60;false&#x60; and drops the  requirement..</param>
        /// <param name="specSymbols">Whether a password must contain at least one special symbol. Leaving the flag out stores it as &#x60;false&#x60; and  drops the requirement..</param>
        public PasswordSettingsRequestsDto(int minLength = default, bool upperCase = default, bool digits = default, bool specSymbols = default)
        {
            this.MinLength = minLength;
            this.UpperCase = upperCase;
            this.Digits = digits;
            this.SpecSymbols = specSymbols;
        }

        /// <summary>
        /// The shortest password the portal will accept. It has to sit between the floor the installation is configured  with, 8 characters unless it was changed, and the ceiling of 30; a value outside that is refused with 400.
        /// </summary>
        /// <example>8</example>
        [DataMember(Name = "minLength", IsRequired = true, EmitDefaultValue = true)]
        public int MinLength { get; set; }

        /// <summary>
        /// Whether a password must contain at least one uppercase letter. There is no partial update on this body, so  leaving the flag out stores it as &#x60;false&#x60; and drops the requirement.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "upperCase", EmitDefaultValue = true)]
        public bool UpperCase { get; set; }

        /// <summary>
        /// Whether a password must contain at least one digit. Leaving the flag out stores it as &#x60;false&#x60; and drops the  requirement.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "digits", EmitDefaultValue = true)]
        public bool Digits { get; set; }

        /// <summary>
        /// Whether a password must contain at least one special symbol. Leaving the flag out stores it as &#x60;false&#x60; and  drops the requirement.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "specSymbols", EmitDefaultValue = true)]
        public bool SpecSymbols { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PasswordSettingsRequestsDto {\n");
            sb.Append("  MinLength: ").Append(MinLength).Append("\n");
            sb.Append("  UpperCase: ").Append(UpperCase).Append("\n");
            sb.Append("  Digits: ").Append(Digits).Append("\n");
            sb.Append("  SpecSymbols: ").Append(SpecSymbols).Append("\n");
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
