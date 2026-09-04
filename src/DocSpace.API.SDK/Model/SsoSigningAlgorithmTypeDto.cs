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
    /// The signing algorithms the SSO settings accept.
    /// </summary>
    [DataContract(Name = "SsoSigningAlgorithmTypeDto")]
    public partial class SsoSigningAlgorithmTypeDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SsoSigningAlgorithmTypeDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SsoSigningAlgorithmTypeDto()
        {
        }

        /// <summary>
        /// The RSA-SHA1 signing algorithm.
        /// </summary>
        /// <example>http://www.w3.org/2000/09/xmldsig#rsa-sha1</example>
        [DataMember(Name = "rsaSha1", EmitDefaultValue = true)]
        public string RsaSha1 { get; private set; }

        /// <summary>
        /// Returns false as RsaSha1 should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRsaSha1()
        {
            return false;
        }
        /// <summary>
        /// The RSA-SHA256 signing algorithm.
        /// </summary>
        /// <example>http://www.w3.org/2001/04/xmldsig-more#rsa-sha256</example>
        [DataMember(Name = "rsaSha256", EmitDefaultValue = true)]
        public string RsaSha256 { get; private set; }

        /// <summary>
        /// Returns false as RsaSha256 should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRsaSha256()
        {
            return false;
        }
        /// <summary>
        /// The RSA-SHA512 signing algorithm.
        /// </summary>
        /// <example>http://www.w3.org/2001/04/xmldsig-more#rsa-sha512</example>
        [DataMember(Name = "rsaSha512", EmitDefaultValue = true)]
        public string RsaSha512 { get; private set; }

        /// <summary>
        /// Returns false as RsaSha512 should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRsaSha512()
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
            sb.Append("class SsoSigningAlgorithmTypeDto {\n");
            sb.Append("  RsaSha1: ").Append(RsaSha1).Append("\n");
            sb.Append("  RsaSha256: ").Append(RsaSha256).Append("\n");
            sb.Append("  RsaSha512: ").Append(RsaSha512).Append("\n");
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
