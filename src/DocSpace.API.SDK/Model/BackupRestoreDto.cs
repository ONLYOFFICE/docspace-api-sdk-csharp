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
    /// The backup restoring parameters.
    /// </summary>
    [DataContract(Name = "BackupRestoreDto")]
    public partial class BackupRestoreDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets StorageType
        /// </summary>
        [DataMember(Name = "storageType", EmitDefaultValue = false)]
        public BackupStorageType? StorageType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupRestoreDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BackupRestoreDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupRestoreDto" /> class.
        /// </summary>
        /// <param name="backupId">The backup ID. (required).</param>
        /// <param name="storageType">storageType.</param>
        /// <param name="storageParams">The backup storage parameters..</param>
        /// <param name="notify">Notifies users about the portal restoring process or not..</param>
        /// <param name="dump">Specifies if a dump will be created or not..</param>
        public BackupRestoreDto(string backupId = default, BackupStorageType? storageType = default, List<ItemKeyValuePairObjectObject> storageParams = default, bool notify = default, bool dump = default)
        {
            // to ensure "backupId" is required (not null)
            if (backupId == null)
            {
                throw new ArgumentNullException("backupId is a required property for BackupRestoreDto and cannot be null");
            }
            this.BackupId = backupId;
            this.StorageType = storageType;
            this.StorageParams = storageParams;
            this.Notify = notify;
            this.Dump = dump;
        }

        /// <summary>
        /// The backup ID.
        /// </summary>
        /// <value>The backup ID.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "backupId", IsRequired = true, EmitDefaultValue = true)]
        public string BackupId { get; set; }

        /// <summary>
        /// The backup storage parameters.
        /// </summary>
        /// <value>The backup storage parameters.</value>
        [DataMember(Name = "storageParams", EmitDefaultValue = true)]
        public List<ItemKeyValuePairObjectObject> StorageParams { get; set; }

        /// <summary>
        /// Notifies users about the portal restoring process or not.
        /// </summary>
        /// <value>Notifies users about the portal restoring process or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "notify", EmitDefaultValue = true)]
        public bool Notify { get; set; }

        /// <summary>
        /// Specifies if a dump will be created or not.
        /// </summary>
        /// <value>Specifies if a dump will be created or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "dump", EmitDefaultValue = true)]
        public bool Dump { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupRestoreDto {\n");
            sb.Append("  BackupId: ").Append(BackupId).Append("\n");
            sb.Append("  StorageType: ").Append(StorageType).Append("\n");
            sb.Append("  StorageParams: ").Append(StorageParams).Append("\n");
            sb.Append("  Notify: ").Append(Notify).Append("\n");
            sb.Append("  Dump: ").Append(Dump).Append("\n");
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
