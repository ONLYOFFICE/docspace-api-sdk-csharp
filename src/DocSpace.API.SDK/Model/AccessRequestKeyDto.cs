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
    /// The file key issued to one account.
    /// </summary>
    [DataContract(Name = "AccessRequestKeyDto")]
    public partial class AccessRequestKeyDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRequestKeyDto" /> class.
        /// </summary>
        /// <param name="userId">The account that is to open the file with this key; it has to have read access to the file..</param>
        /// <param name="publicKeyId">The public key the file key was encrypted with, as reported for that account by  &#x60;GET api/2.0/files/file/{fileId}/publickeys&#x60;..</param>
        /// <param name="privateKeyEnc">The key of the file itself, encrypted by the client with that public key, so that the plain key never reaches  the portal..</param>
        public AccessRequestKeyDto(Guid userId = default, Guid publicKeyId = default, string privateKeyEnc = default)
        {
            this.UserId = userId;
            this.PublicKeyId = publicKeyId;
            this.PrivateKeyEnc = privateKeyEnc;
        }

        /// <summary>
        /// The account that is to open the file with this key; it has to have read access to the file.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000000</example>
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// The public key the file key was encrypted with, as reported for that account by  &#x60;GET api/2.0/files/file/{fileId}/publickeys&#x60;.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000000</example>
        [DataMember(Name = "publicKeyId", EmitDefaultValue = false)]
        public Guid PublicKeyId { get; set; }

        /// <summary>
        /// The key of the file itself, encrypted by the client with that public key, so that the plain key never reaches  the portal.
        /// </summary>
        /// <example>encrypted_key_string</example>
        [DataMember(Name = "privateKeyEnc", EmitDefaultValue = true)]
        public string PrivateKeyEnc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessRequestKeyDto {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  PublicKeyId: ").Append(PublicKeyId).Append("\n");
            sb.Append("  PrivateKeyEnc: ").Append(PrivateKeyEnc).Append("\n");
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
