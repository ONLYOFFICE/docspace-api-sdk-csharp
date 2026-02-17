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
    /// AccessRequestKeyDto
    /// </summary>
    [DataContract(Name = "AccessRequestKeyDto")]
    public partial class AccessRequestKeyDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AccessRequestKeyDto" /> class.
        /// </summary>
        /// <param name="userId">userId.</param>
        /// <param name="publicKeyId">publicKeyId.</param>
        /// <param name="privateKeyEnc">privateKeyEnc.</param>
        public AccessRequestKeyDto(Guid userId = default, Guid publicKeyId = default, string privateKeyEnc = default)
        {
            this.UserId = userId;
            this.PublicKeyId = publicKeyId;
            this.PrivateKeyEnc = privateKeyEnc;
        }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        /*
        <example>00000000-0000-0000-0000-000000000000</example>
        */
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or Sets PublicKeyId
        /// </summary>
        /*
        <example>75a5f745-f697-4418-b38d-0fe0d277e258</example>
        */
        [DataMember(Name = "publicKeyId", EmitDefaultValue = false)]
        public Guid PublicKeyId { get; set; }

        /// <summary>
        /// Gets or Sets PrivateKeyEnc
        /// </summary>
        /*
        <example>some text</example>
        */
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
