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
    /// The backup schedule of a portal.
    /// </summary>
    [DataContract(Name = "ScheduleDto")]
    public partial class ScheduleDto : IValidatableObject
    {

        /// <summary>
        /// The storage the scheduled archives are written to, reported as a number rather than as the name the  schedule was created with.
        /// </summary>
        [DataMember(Name = "storageType", IsRequired = true, EmitDefaultValue = true)]
        public BackupStorageType StorageType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScheduleDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduleDto" /> class.
        /// </summary>
        /// <param name="storageType">The storage the scheduled archives are written to, reported as a number rather than as the name the  schedule was created with. (required).</param>
        /// <param name="storageParams">The settings of the storage, as an object keyed by parameter name - not as the array of key and value  pairs the schedule was created with, so it cannot be sent back unchanged. For every storage type  except &#x60;ThirdPartyConsumer&#x60; the &#x60;folderId&#x60; key is built from the stored base path. (required).</param>
        /// <param name="cronParams">When the backup runs, read back from the stored cron expression. &#x60;day&#x60; is 0 for a daily schedule,  because a daily one has no day. (required).</param>
        /// <param name="backupsStored">The number of scheduled copies kept. It is null, not 0, when the schedule keeps an unlimited number..</param>
        /// <param name="lastBackupTime">The date and time the schedule last ran at. It is &#x60;0001-01-01T00:00:00&#x60; until the schedule has run  for the first time. (required).</param>
        /// <param name="dump">Specifies whether this schedule backs up the whole server instead of one portal. (required).</param>
        public ScheduleDto(BackupStorageType storageType = default, Dictionary<string, string> storageParams = default, CronParams cronParams = default, int? backupsStored = default, DateTime lastBackupTime = default, bool dump = default)
        {
            this.StorageType = storageType;
            // to ensure "storageParams" is required (not null)
            if (storageParams == null)
            {
                throw new ArgumentNullException("storageParams is a required property for ScheduleDto and cannot be null");
            }
            this.StorageParams = storageParams;
            // to ensure "cronParams" is required (not null)
            if (cronParams == null)
            {
                throw new ArgumentNullException("cronParams is a required property for ScheduleDto and cannot be null");
            }
            this.CronParams = cronParams;
            this.LastBackupTime = lastBackupTime;
            this.Dump = dump;
            this.BackupsStored = backupsStored;
        }

        /// <summary>
        /// The settings of the storage, as an object keyed by parameter name - not as the array of key and value  pairs the schedule was created with, so it cannot be sent back unchanged. For every storage type  except &#x60;ThirdPartyConsumer&#x60; the &#x60;folderId&#x60; key is built from the stored base path.
        /// </summary>
        /// <example>{"folderId":"1234"}</example>
        [DataMember(Name = "storageParams", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, string> StorageParams { get; set; }

        /// <summary>
        /// When the backup runs, read back from the stored cron expression. &#x60;day&#x60; is 0 for a daily schedule,  because a daily one has no day.
        /// </summary>
        [DataMember(Name = "cronParams", IsRequired = true, EmitDefaultValue = true)]
        public CronParams CronParams { get; set; }

        /// <summary>
        /// The number of scheduled copies kept. It is null, not 0, when the schedule keeps an unlimited number.
        /// </summary>
        /// <example>5</example>
        [DataMember(Name = "backupsStored", EmitDefaultValue = true)]
        public int? BackupsStored { get; set; }

        /// <summary>
        /// The date and time the schedule last ran at. It is &#x60;0001-01-01T00:00:00&#x60; until the schedule has run  for the first time.
        /// </summary>
        /// <example>2026-01-01T00:00:00Z</example>
        [DataMember(Name = "lastBackupTime", IsRequired = true, EmitDefaultValue = true)]
        public DateTime LastBackupTime { get; set; }

        /// <summary>
        /// Specifies whether this schedule backs up the whole server instead of one portal.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "dump", IsRequired = true, EmitDefaultValue = true)]
        public bool Dump { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ScheduleDto {\n");
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
