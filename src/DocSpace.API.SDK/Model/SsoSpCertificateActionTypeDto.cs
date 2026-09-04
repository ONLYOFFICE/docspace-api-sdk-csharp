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
    /// What an SP certificate can be used for.
    /// </summary>
    [DataContract(Name = "SsoSpCertificateActionTypeDto")]
    public partial class SsoSpCertificateActionTypeDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SsoSpCertificateActionTypeDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SsoSpCertificateActionTypeDto()
        {
        }

        /// <summary>
        /// Signing only.
        /// </summary>
        /// <example>signing</example>
        [DataMember(Name = "signing", EmitDefaultValue = true)]
        public string Signing { get; private set; }

        /// <summary>
        /// Returns false as Signing should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSigning()
        {
            return false;
        }
        /// <summary>
        /// Encryption only.
        /// </summary>
        /// <example>encrypt</example>
        [DataMember(Name = "encrypt", EmitDefaultValue = true)]
        public string Encrypt { get; private set; }

        /// <summary>
        /// Returns false as Encrypt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeEncrypt()
        {
            return false;
        }
        /// <summary>
        /// Both signing and encryption.
        /// </summary>
        /// <example>signing and encrypt</example>
        [DataMember(Name = "signingAndEncrypt", EmitDefaultValue = true)]
        public string SigningAndEncrypt { get; private set; }

        /// <summary>
        /// Returns false as SigningAndEncrypt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSigningAndEncrypt()
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
            sb.Append("class SsoSpCertificateActionTypeDto {\n");
            sb.Append("  Signing: ").Append(Signing).Append("\n");
            sb.Append("  Encrypt: ").Append(Encrypt).Append("\n");
            sb.Append("  SigningAndEncrypt: ").Append(SigningAndEncrypt).Append("\n");
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
