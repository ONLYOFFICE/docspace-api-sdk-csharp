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
    /// The encryption algorithms the SSO settings accept.
    /// </summary>
    [DataContract(Name = "SsoEncryptAlgorithmTypeDto")]
    public partial class SsoEncryptAlgorithmTypeDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SsoEncryptAlgorithmTypeDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SsoEncryptAlgorithmTypeDto()
        {
        }

        /// <summary>
        /// The AES-128-CBC encryption algorithm.
        /// </summary>
        /// <example>http://www.w3.org/2001/04/xmlenc#aes128-cbc</example>
        [DataMember(Name = "aes128", EmitDefaultValue = true)]
        public string Aes128 { get; private set; }

        /// <summary>
        /// Returns false as Aes128 should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAes128()
        {
            return false;
        }
        /// <summary>
        /// The AES-256-CBC encryption algorithm.
        /// </summary>
        /// <example>http://www.w3.org/2001/04/xmlenc#aes256-cbc</example>
        [DataMember(Name = "aes256", EmitDefaultValue = true)]
        public string Aes256 { get; private set; }

        /// <summary>
        /// Returns false as Aes256 should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAes256()
        {
            return false;
        }
        /// <summary>
        /// The Triple DES CBC encryption algorithm.
        /// </summary>
        /// <example>http://www.w3.org/2001/04/xmlenc#tripledes-cbc</example>
        [DataMember(Name = "triDec", EmitDefaultValue = true)]
        public string TriDec { get; private set; }

        /// <summary>
        /// Returns false as TriDec should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeTriDec()
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
            sb.Append("class SsoEncryptAlgorithmTypeDto {\n");
            sb.Append("  Aes128: ").Append(Aes128).Append("\n");
            sb.Append("  Aes256: ").Append(Aes256).Append("\n");
            sb.Append("  TriDec: ").Append(TriDec).Append("\n");
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
