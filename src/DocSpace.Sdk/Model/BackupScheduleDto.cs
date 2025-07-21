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


 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The backup schedule parameters.
    /// </summary>
    [DataContract(Name = "BackupScheduleDto")]
    public partial class BackupScheduleDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets StorageType
        /// </summary>
        [DataMember(Name = "storageType", EmitDefaultValue = false)]
        public BackupStorageType? StorageType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupScheduleDto" /> class.
        /// </summary>
        /// <param name="storageType">storageType.</param>
        /// <param name="storageParams">The backup storage parameters..</param>
        /// <param name="backupsStored">The maximum number of the stored backup copies..</param>
        /// <param name="cronParams">cronParams.</param>
        /// <param name="dump">Specifies if a dump will be created or not..</param>
        public BackupScheduleDto(BackupStorageType? storageType = default, List<ItemKeyValuePairObjectObject> storageParams = default, int? backupsStored = default, Cron cronParams = default, bool dump = default)
        {
            this.StorageType = storageType;
            this.StorageParams = storageParams;
            this.BackupsStored = backupsStored;
            this.CronParams = cronParams;
            this.Dump = dump;
        }

        /// <summary>
        /// The backup storage parameters.
        /// </summary>
        /// <value>The backup storage parameters.</value>
        [DataMember(Name = "storageParams", EmitDefaultValue = true)]
        public List<ItemKeyValuePairObjectObject> StorageParams { get; set; }

        /// <summary>
        /// The maximum number of the stored backup copies.
        /// </summary>
        /// <value>The maximum number of the stored backup copies.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "backupsStored", EmitDefaultValue = true)]
        public int? BackupsStored { get; set; }

        /// <summary>
        /// Gets or Sets CronParams
        /// </summary>
        [DataMember(Name = "cronParams", EmitDefaultValue = false)]
        public Cron CronParams { get; set; }

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
            sb.Append("class BackupScheduleDto {\n");
            sb.Append("  StorageType: ").Append(StorageType).Append("\n");
            sb.Append("  StorageParams: ").Append(StorageParams).Append("\n");
            sb.Append("  BackupsStored: ").Append(BackupsStored).Append("\n");
            sb.Append("  CronParams: ").Append(CronParams).Append("\n");
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
