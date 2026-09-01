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
    /// The encrypted file key issued to one user.
    /// </summary>
    [DataContract(Name = "FileKeys")]
    public partial class FileKeys : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FileKeys" /> class.
        /// </summary>
        /// <param name="userId">The identifier of the user the file key was issued to..</param>
        /// <param name="publicKeyId">The identifier of the key pair the file key is encrypted for..</param>
        /// <param name="privateKeyEnc">The file key, encrypted with the public key of the pair..</param>
        /// <param name="tenantId">The identifier of the portal the file belongs to..</param>
        /// <param name="fileId">The identifier of the file the key unlocks..</param>
        /// <param name="createOn">The date and time when the file key was issued..</param>
        public FileKeys(Guid userId = default, Guid publicKeyId = default, string privateKeyEnc = default, int tenantId = default, int fileId = default, DateTime createOn = default)
        {
            this.UserId = userId;
            this.PublicKeyId = publicKeyId;
            this.PrivateKeyEnc = privateKeyEnc;
            this.TenantId = tenantId;
            this.FileId = fileId;
            this.CreateOn = createOn;
        }

        /// <summary>
        /// The identifier of the user the file key was issued to.
        /// </summary>
        /// <example>9924256B-447C-4F19-9dbd-8ad8c39e8ff5</example>
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// The identifier of the key pair the file key is encrypted for.
        /// </summary>
        /// <example>9924256B-447C-4F19-9dbd-8ad8c39e8ff5</example>
        [DataMember(Name = "publicKeyId", EmitDefaultValue = false)]
        public Guid PublicKeyId { get; set; }

        /// <summary>
        /// The file key, encrypted with the public key of the pair.
        /// </summary>
        /// <example>U2FsdGVkX1+Lm3s...</example>
        [DataMember(Name = "privateKeyEnc", EmitDefaultValue = true)]
        public string PrivateKeyEnc { get; set; }

        /// <summary>
        /// The identifier of the portal the file belongs to.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public int TenantId { get; set; }

        /// <summary>
        /// The identifier of the file the key unlocks.
        /// </summary>
        /// <example>9846</example>
        [DataMember(Name = "fileId", EmitDefaultValue = false)]
        public int FileId { get; set; }

        /// <summary>
        /// The date and time when the file key was issued.
        /// </summary>
        /// <example>2025-01-01T00:00:00</example>
        [DataMember(Name = "createOn", EmitDefaultValue = false)]
        public DateTime CreateOn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileKeys {\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  PublicKeyId: ").Append(PublicKeyId).Append("\n");
            sb.Append("  PrivateKeyEnc: ").Append(PrivateKeyEnc).Append("\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  CreateOn: ").Append(CreateOn).Append("\n");
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
