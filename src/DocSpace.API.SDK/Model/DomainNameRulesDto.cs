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
    /// The rules a portal name is checked against.
    /// </summary>
    [DataContract(Name = "DomainNameRulesDto")]
    public partial class DomainNameRulesDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainNameRulesDto" /> class.
        /// </summary>
        /// <param name="regex">The pattern the portal name has to match..</param>
        /// <param name="minLength">The shortest portal name accepted..</param>
        /// <param name="maxLength">The longest portal name accepted..</param>
        public DomainNameRulesDto(string regex = default, int minLength = default, int maxLength = default)
        {
            this.Regex = regex;
            this.MinLength = minLength;
            this.MaxLength = maxLength;
        }

        /// <summary>
        /// The pattern the portal name has to match.
        /// </summary>
        /// <example>^[a-z0-9]([a-z0-9-]){1,61}[a-z0-9]$</example>
        [DataMember(Name = "regex", EmitDefaultValue = true)]
        public string Regex { get; set; }

        /// <summary>
        /// The shortest portal name accepted.
        /// </summary>
        /// <example>6</example>
        [DataMember(Name = "minLength", EmitDefaultValue = false)]
        public int MinLength { get; set; }

        /// <summary>
        /// The longest portal name accepted.
        /// </summary>
        /// <example>63</example>
        [DataMember(Name = "maxLength", EmitDefaultValue = false)]
        public int MaxLength { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainNameRulesDto {\n");
            sb.Append("  Regex: ").Append(Regex).Append("\n");
            sb.Append("  MinLength: ").Append(MinLength).Append("\n");
            sb.Append("  MaxLength: ").Append(MaxLength).Append("\n");
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
