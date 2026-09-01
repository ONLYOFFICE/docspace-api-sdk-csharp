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
    /// The domain validator.
    /// </summary>
    [DataContract(Name = "TenantDomainValidator")]
    public partial class TenantDomainValidator : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantDomainValidator" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public TenantDomainValidator()
        {
        }

        /// <summary>
        /// The regex string to validate a domain.
        /// </summary>
        /// <example>^[a-z0-9]([a-z0-9-]){1,61}[a-z0-9]$</example>
        [DataMember(Name = "regex", EmitDefaultValue = true)]
        public string Regex { get; private set; }

        /// <summary>
        /// Returns false as Regex should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRegex()
        {
            return false;
        }
        /// <summary>
        /// The minimum length of the valid domain.
        /// </summary>
        /// <example>6</example>
        [DataMember(Name = "minLength", EmitDefaultValue = false)]
        public int MinLength { get; private set; }

        /// <summary>
        /// Returns false as MinLength should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMinLength()
        {
            return false;
        }
        /// <summary>
        /// The maximum length of the valid domain.
        /// </summary>
        /// <example>63</example>
        [DataMember(Name = "maxLength", EmitDefaultValue = false)]
        public int MaxLength { get; private set; }

        /// <summary>
        /// Returns false as MaxLength should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeMaxLength()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenantDomainValidator {\n");
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
