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
    /// FileKeys
    /// </summary>
    [DataContract(Name = "FileKeys")]
    public partial class FileKeys : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FileKeys" /> class.
        /// </summary>
        /// <param name="userId">userId.</param>
        /// <param name="publicKeyId">publicKeyId.</param>
        /// <param name="privateKeyEnc">privateKeyEnc.</param>
        /// <param name="tenantId">tenantId.</param>
        /// <param name="fileId">fileId.</param>
        /// <param name="createOn">createOn.</param>
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
        /// Gets or Sets UserId
        /// </summary>
        /*
        <example>aae1e103-bca5-9fa1-ba8c-42058b4abf28</example>
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
        /// Gets or Sets TenantId
        /// </summary>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "tenantId", EmitDefaultValue = false)]
        public int TenantId { get; set; }

        /// <summary>
        /// Gets or Sets FileId
        /// </summary>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "fileId", EmitDefaultValue = false)]
        public int FileId { get; set; }

        /// <summary>
        /// Gets or Sets CreateOn
        /// </summary>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
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
