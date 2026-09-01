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
    /// The encryption key pair of a user.
    /// </summary>
    [DataContract(Name = "EncryptionKeyDto")]
    public partial class EncryptionKeyDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptionKeyDto" /> class.
        /// </summary>
        /// <param name="id">The identifier of the key pair..</param>
        /// <param name="userId">The identifier of the user the key pair belongs to..</param>
        /// <param name="date">The date and time when the key pair was created..</param>
        /// <param name="publicKey">The public key of the pair, used to encrypt the file keys..</param>
        /// <param name="privateKeyEnc">The private key of the pair, encrypted with the user password..</param>
        /// <param name="cryptoEngineId">The identifier of the crypto engine the key pair was issued for..</param>
        public EncryptionKeyDto(Guid id = default, Guid userId = default, DateTime date = default, string publicKey = default, string privateKeyEnc = default, string cryptoEngineId = default)
        {
            this.Id = id;
            this.UserId = userId;
            this.Date = date;
            this.PublicKey = publicKey;
            this.PrivateKeyEnc = privateKeyEnc;
            this.CryptoEngineId = cryptoEngineId;
        }

        /// <summary>
        /// The identifier of the key pair.
        /// </summary>
        /// <example>9924256B-447C-4F19-9dbd-8ad8c39e8ff5</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// The identifier of the user the key pair belongs to.
        /// </summary>
        /// <example>9924256B-447C-4F19-9dbd-8ad8c39e8ff5</example>
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// The date and time when the key pair was created.
        /// </summary>
        /// <example>2025-01-01T00:00:00</example>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public DateTime Date { get; set; }

        /// <summary>
        /// The public key of the pair, used to encrypt the file keys.
        /// </summary>
        /// <example>MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8A...</example>
        [DataMember(Name = "publicKey", EmitDefaultValue = true)]
        public string PublicKey { get; set; }

        /// <summary>
        /// The private key of the pair, encrypted with the user password.
        /// </summary>
        /// <example>U2FsdGVkX1+Lm3s...</example>
        [DataMember(Name = "privateKeyEnc", EmitDefaultValue = true)]
        public string PrivateKeyEnc { get; set; }

        /// <summary>
        /// The identifier of the crypto engine the key pair was issued for.
        /// </summary>
        /// <example>{DC522726-5E0E-43E5-AA02-8EA156BECBC5}</example>
        [DataMember(Name = "cryptoEngineId", EmitDefaultValue = true)]
        public string CryptoEngineId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EncryptionKeyDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
            sb.Append("  PrivateKeyEnc: ").Append(PrivateKeyEnc).Append("\n");
            sb.Append("  CryptoEngineId: ").Append(CryptoEngineId).Append("\n");
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
