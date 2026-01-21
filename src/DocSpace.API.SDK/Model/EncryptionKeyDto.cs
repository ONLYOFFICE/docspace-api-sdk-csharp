// (c) Copyright Ascensio System SIA 2025
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

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// EncryptionKeyDto
    /// </summary>
    [DataContract(Name = "EncryptionKeyDto")]
    public partial class EncryptionKeyDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptionKeyDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="userId">userId.</param>
        /// <param name="date">date.</param>
        /// <param name="publicKey">publicKey.</param>
        /// <param name="privateKeyEnc">privateKeyEnc.</param>
        public EncryptionKeyDto(Guid id = default, Guid userId = default, DateTime date = default, string publicKey = default, string privateKeyEnc = default)
        {
            this.Id = id;
            this.UserId = userId;
            this.Date = date;
            this.PublicKey = publicKey;
            this.PrivateKeyEnc = privateKeyEnc;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        /*
        <example>aae1e103-bca5-9fa1-ba8c-42058b4abf28</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        /*
        <example>aae1e103-bca5-9fa1-ba8c-42058b4abf28</example>
        */
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or Sets Date
        /// </summary>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or Sets PublicKey
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "publicKey", EmitDefaultValue = true)]
        public string PublicKey { get; set; }

        /// <summary>
        /// Gets or Sets PrivateKeyEnc
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "privateKeyEnc", EmitDefaultValue = true)]
        public string PrivateKeyEnc { get; set; }

        /// <summary>
        /// Gets or Sets CryptoEngineId
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "cryptoEngineId", EmitDefaultValue = true)]
        public string CryptoEngineId { get; private set; }

        /// <summary>
        /// Returns false as CryptoEngineId should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeCryptoEngineId()
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
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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
