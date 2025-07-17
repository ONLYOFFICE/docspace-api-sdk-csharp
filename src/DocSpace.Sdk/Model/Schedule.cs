/**
 *
 * (c) Copyright Ascensio System SIA 2025
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// Schedule
    /// </summary>
    [DataContract(Name = "Schedule")]
    public partial class Schedule : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets StorageType
        /// </summary>
        [DataMember(Name = "storageType", EmitDefaultValue = false)]
        public BackupStorageType? StorageType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Schedule" /> class.
        /// </summary>
        /// <param name="storageType">storageType.</param>
        /// <param name="storageParams">storageParams.</param>
        /// <param name="cronParams">cronParams.</param>
        /// <param name="backupsStored">backupsStored.</param>
        /// <param name="lastBackupTime">lastBackupTime.</param>
        /// <param name="dump">dump.</param>
        public Schedule(BackupStorageType? storageType = default, Dictionary<string, string> storageParams = default, CronParams cronParams = default, int? backupsStored = default, DateTime lastBackupTime = default, bool dump = default)
        {
            this.StorageType = storageType;
            this.StorageParams = storageParams;
            this.CronParams = cronParams;
            this.BackupsStored = backupsStored;
            this.LastBackupTime = lastBackupTime;
            this.Dump = dump;
        }

        /// <summary>
        /// Gets or Sets StorageParams
        /// </summary>
        /*
        <example>[{&quot;key&quot;:&quot;some text&quot;,&quot;value&quot;:&quot;some text&quot;}]</example>
        */
        [DataMember(Name = "storageParams", EmitDefaultValue = true)]
        public Dictionary<string, string> StorageParams { get; set; }

        /// <summary>
        /// Gets or Sets CronParams
        /// </summary>
        [DataMember(Name = "cronParams", EmitDefaultValue = false)]
        public CronParams CronParams { get; set; }

        /// <summary>
        /// Gets or Sets BackupsStored
        /// </summary>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "backupsStored", EmitDefaultValue = true)]
        public int? BackupsStored { get; set; }

        /// <summary>
        /// Gets or Sets LastBackupTime
        /// </summary>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "lastBackupTime", EmitDefaultValue = false)]
        public DateTime LastBackupTime { get; set; }

        /// <summary>
        /// Gets or Sets Dump
        /// </summary>
        /*
        <example>false</example>
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
            sb.Append("class Schedule {\n");
            sb.Append("  StorageType: ").Append(StorageType).Append("\n");
            sb.Append("  StorageParams: ").Append(StorageParams).Append("\n");
            sb.Append("  CronParams: ").Append(CronParams).Append("\n");
            sb.Append("  BackupsStored: ").Append(BackupsStored).Append("\n");
            sb.Append("  LastBackupTime: ").Append(LastBackupTime).Append("\n");
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
