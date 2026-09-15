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
    /// An encryption key pair as the portal reports it: the public half of some member&#39;s key, with the encrypted private  half filled in only when the pair belongs to the caller.
    /// </summary>
    [DataContract(Name = "EncryptionKeyDto")]
    public partial class EncryptionKeyDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptionKeyDto" /> class.
        /// </summary>
        /// <param name="id">Names the pair inside its owner&#39;s key set. Pass it back to rotate the pair or to delete it; the all-zero value  belongs to a client that stores its keys without sending an identifier..</param>
        /// <param name="userId">The member the pair belongs to. In the key set of a room or of a file this is how the caller tells its own  entries, the ones carrying a private half, from those of the other members..</param>
        /// <param name="date">When this key material was written. Rotating the pair refreshes it, so it dates the material that is being  reported rather than the first appearance of the identifier..</param>
        /// <param name="publicKey">The public half of the pair, the half a client encrypts file keys with. A pair whose public half is missing  is treated as no access and left out of a room&#39;s or a file&#39;s key set..</param>
        /// <param name="privateKeyEnc">The private half, encrypted with its owner&#39;s password. It is filled in only when the pair belongs to the  calling user; on another member&#39;s entry it comes back empty, because the private half is not handed out..</param>
        /// <param name="cryptoEngineId">The crypto engine this material was issued for, as a braced GUID. The engine is portal-wide, so the same value  comes back for every key of every member..</param>
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
        /// Names the pair inside its owner&#39;s key set. Pass it back to rotate the pair or to delete it; the all-zero value  belongs to a client that stores its keys without sending an identifier.
        /// </summary>
        /// <example>9924256B-447C-4F19-9dbd-8ad8c39e8ff5</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// The member the pair belongs to. In the key set of a room or of a file this is how the caller tells its own  entries, the ones carrying a private half, from those of the other members.
        /// </summary>
        /// <example>9924256B-447C-4F19-9dbd-8ad8c39e8ff5</example>
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// When this key material was written. Rotating the pair refreshes it, so it dates the material that is being  reported rather than the first appearance of the identifier.
        /// </summary>
        /// <example>2025-01-01T00:00:00</example>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public DateTime Date { get; set; }

        /// <summary>
        /// The public half of the pair, the half a client encrypts file keys with. A pair whose public half is missing  is treated as no access and left out of a room&#39;s or a file&#39;s key set.
        /// </summary>
        /// <example>MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8A...</example>
        [DataMember(Name = "publicKey", EmitDefaultValue = true)]
        public string PublicKey { get; set; }

        /// <summary>
        /// The private half, encrypted with its owner&#39;s password. It is filled in only when the pair belongs to the  calling user; on another member&#39;s entry it comes back empty, because the private half is not handed out.
        /// </summary>
        /// <example>U2FsdGVkX1+Lm3s...</example>
        [DataMember(Name = "privateKeyEnc", EmitDefaultValue = true)]
        public string PrivateKeyEnc { get; set; }

        /// <summary>
        /// The crypto engine this material was issued for, as a braced GUID. The engine is portal-wide, so the same value  comes back for every key of every member.
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
