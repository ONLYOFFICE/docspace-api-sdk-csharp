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
    /// What an IDP certificate can be used for.
    /// </summary>
    [DataContract(Name = "SsoIdpCertificateActionTypeDto")]
    public partial class SsoIdpCertificateActionTypeDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SsoIdpCertificateActionTypeDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public SsoIdpCertificateActionTypeDto()
        {
        }

        /// <summary>
        /// Verification only.
        /// </summary>
        /// <example>verification</example>
        [DataMember(Name = "verification", EmitDefaultValue = true)]
        public string Verification { get; private set; }

        /// <summary>
        /// Returns false as Verification should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVerification()
        {
            return false;
        }
        /// <summary>
        /// Decryption only.
        /// </summary>
        /// <example>decrypt</example>
        [DataMember(Name = "decrypt", EmitDefaultValue = true)]
        public string Decrypt { get; private set; }

        /// <summary>
        /// Returns false as Decrypt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeDecrypt()
        {
            return false;
        }
        /// <summary>
        /// Both verification and decryption.
        /// </summary>
        /// <example>verification and decrypt</example>
        [DataMember(Name = "verificationAndDecrypt", EmitDefaultValue = true)]
        public string VerificationAndDecrypt { get; private set; }

        /// <summary>
        /// Returns false as VerificationAndDecrypt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeVerificationAndDecrypt()
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
            sb.Append("class SsoIdpCertificateActionTypeDto {\n");
            sb.Append("  Verification: ").Append(Verification).Append("\n");
            sb.Append("  Decrypt: ").Append(Decrypt).Append("\n");
            sb.Append("  VerificationAndDecrypt: ").Append(VerificationAndDecrypt).Append("\n");
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
