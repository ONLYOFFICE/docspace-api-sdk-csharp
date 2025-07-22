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
    /// The encryption keys of the editor configuration.
    /// </summary>
    [DataContract(Name = "EncryptionKeysConfig")]
    public partial class EncryptionKeysConfig : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EncryptionKeysConfig" /> class.
        /// </summary>
        /// <param name="privateKeyEnc">The private key..</param>
        /// <param name="publicKey">The public key..</param>
        public EncryptionKeysConfig(string privateKeyEnc = default, string publicKey = default)
        {
            this.PrivateKeyEnc = privateKeyEnc;
            this.PublicKey = publicKey;
        }

        /// <summary>
        /// The crypto engine ID of the encryption key.
        /// </summary>
        /// <value>The crypto engine ID of the encryption key.</value>
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
        /// The private key.
        /// </summary>
        /// <value>The private key.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "privateKeyEnc", EmitDefaultValue = true)]
        public string PrivateKeyEnc { get; set; }

        /// <summary>
        /// The public key.
        /// </summary>
        /// <value>The public key.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "publicKey", EmitDefaultValue = true)]
        public string PublicKey { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EncryptionKeysConfig {\n");
            sb.Append("  CryptoEngineId: ").Append(CryptoEngineId).Append("\n");
            sb.Append("  PrivateKeyEnc: ").Append(PrivateKeyEnc).Append("\n");
            sb.Append("  PublicKey: ").Append(PublicKey).Append("\n");
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
