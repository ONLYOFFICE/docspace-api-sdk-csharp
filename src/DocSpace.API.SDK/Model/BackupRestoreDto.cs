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
    /// The request parameters for restoring a portal from a backup.
    /// </summary>
    [DataContract(Name = "BackupRestoreDto")]
    public partial class BackupRestoreDto : IValidatableObject
    {

        /// <summary>
        /// The storage the archive is read from. It defaults to &#x60;Documents&#x60; and is only used when &#x60;backupId&#x60; is  not a GUID, because a known backup carries the storage of its own record.
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
        /// <param name="backupId">The ID of the backup to restore from, as listed by &#x60;GET api/2.0/backup/getbackuphistory&#x60;. Send  anything that is not a GUID to restore from a file given by &#x60;storageParams&#x60; instead; an all-zero GUID  selects neither, because it parses as a GUID and then matches no record. (required).</param>
        /// <param name="storageType">The storage the archive is read from. It defaults to &#x60;Documents&#x60; and is only used when &#x60;backupId&#x60; is  not a GUID, because a known backup carries the storage of its own record..</param>
        /// <param name="storageParams">The location of the archive, as an array of key and value pairs. The key read here is &#x60;filePath&#x60; -  not the &#x60;folderId&#x60; a backup is started with - and it holds a file ID for &#x60;Documents&#x60;, a  provider-specific file ID for &#x60;ThridpartyDocuments&#x60; and a path on the server for &#x60;Local&#x60;. It is only  used when &#x60;backupId&#x60; is not a GUID..</param>
        /// <param name="notify">Chooses who is emailed when the restoring starts and when it finishes: every active user of the  portal when true, and its owner alone when false. Mail goes only to accounts that have been  activated, so this decides the audience rather than whether anybody is notified at all..</param>
        /// <param name="dump">Restores the whole server rather than this one portal. It requires the space access permission..</param>
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
        /// The ID of the backup to restore from, as listed by &#x60;GET api/2.0/backup/getbackuphistory&#x60;. Send  anything that is not a GUID to restore from a file given by &#x60;storageParams&#x60; instead; an all-zero GUID  selects neither, because it parses as a GUID and then matches no record.
        /// </summary>
        /// <example>11111111-1111-1111-1111-111111111111</example>
        [DataMember(Name = "backupId", IsRequired = true, EmitDefaultValue = true)]
        public string BackupId { get; set; }

        /// <summary>
        /// The location of the archive, as an array of key and value pairs. The key read here is &#x60;filePath&#x60; -  not the &#x60;folderId&#x60; a backup is started with - and it holds a file ID for &#x60;Documents&#x60;, a  provider-specific file ID for &#x60;ThridpartyDocuments&#x60; and a path on the server for &#x60;Local&#x60;. It is only  used when &#x60;backupId&#x60; is not a GUID.
        /// </summary>
        /// <example>[{"key":"filePath","value":"1234"}]</example>
        [DataMember(Name = "storageParams", EmitDefaultValue = true)]
        public List<ItemKeyValuePairObjectObject> StorageParams { get; set; }

        /// <summary>
        /// Chooses who is emailed when the restoring starts and when it finishes: every active user of the  portal when true, and its owner alone when false. Mail goes only to accounts that have been  activated, so this decides the audience rather than whether anybody is notified at all.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "notify", EmitDefaultValue = true)]
        public bool Notify { get; set; }

        /// <summary>
        /// Restores the whole server rather than this one portal. It requires the space access permission.
        /// </summary>
        /// <example>false</example>
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
