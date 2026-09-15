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
    /// One stored backup of a portal.
    /// </summary>
    [DataContract(Name = "BackupHistoryRecord")]
    public partial class BackupHistoryRecord : IValidatableObject
    {

        /// <summary>
        /// The storage the archive was written to, reported as a number rather than as a name.
        /// </summary>
        [DataMember(Name = "storageType", IsRequired = true, EmitDefaultValue = true)]
        public BackupStorageType StorageType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupHistoryRecord" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BackupHistoryRecord() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupHistoryRecord" /> class.
        /// </summary>
        /// <param name="id">The ID of the backup, which is the same value as the &#x60;taskId&#x60; the backup was started with. Pass it to  &#x60;DELETE api/2.0/backup/deletebackup/{id}&#x60; or as the &#x60;backupId&#x60; of  &#x60;POST api/2.0/backup/startrestore&#x60;. (required).</param>
        /// <param name="fileName">The name of the stored archive. It is built from the portal alias and the moment the backup started,  or from &#x60;workspace&#x60; instead of the alias for a backup of the whole server. (required).</param>
        /// <param name="storageType">The storage the archive was written to, reported as a number rather than as a name. (required).</param>
        /// <param name="createdOn">The date and time the backup was stored at, in UTC. (required).</param>
        /// <param name="expiresOn">The date and time a background cleaner removes this backup at. Only a backup written to &#x60;DataStore&#x60;  expires, one day after it was stored; for every other storage type this is &#x60;0001-01-01T00:00:00&#x60;,  which means the backup is kept until it is deleted by hand or pushed out by the stored-copies limit  of a schedule. (required).</param>
        public BackupHistoryRecord(Guid id = default, string fileName = default, BackupStorageType storageType = default, DateTime createdOn = default, DateTime expiresOn = default)
        {
            this.Id = id;
            // to ensure "fileName" is required (not null)
            if (fileName == null)
            {
                throw new ArgumentNullException("fileName is a required property for BackupHistoryRecord and cannot be null");
            }
            this.FileName = fileName;
            this.StorageType = storageType;
            this.CreatedOn = createdOn;
            this.ExpiresOn = expiresOn;
        }

        /// <summary>
        /// The ID of the backup, which is the same value as the &#x60;taskId&#x60; the backup was started with. Pass it to  &#x60;DELETE api/2.0/backup/deletebackup/{id}&#x60; or as the &#x60;backupId&#x60; of  &#x60;POST api/2.0/backup/startrestore&#x60;.
        /// </summary>
        /// <example>11111111-1111-1111-1111-111111111111</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// The name of the stored archive. It is built from the portal alias and the moment the backup started,  or from &#x60;workspace&#x60; instead of the alias for a backup of the whole server.
        /// </summary>
        /// <example>myportal_2026-03-01_02-15-00.tar.gz</example>
        [DataMember(Name = "fileName", IsRequired = true, EmitDefaultValue = true)]
        public string FileName { get; set; }

        /// <summary>
        /// The date and time the backup was stored at, in UTC.
        /// </summary>
        /// <example>2026-03-01T02:15:00Z</example>
        [DataMember(Name = "createdOn", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// The date and time a background cleaner removes this backup at. Only a backup written to &#x60;DataStore&#x60;  expires, one day after it was stored; for every other storage type this is &#x60;0001-01-01T00:00:00&#x60;,  which means the backup is kept until it is deleted by hand or pushed out by the stored-copies limit  of a schedule.
        /// </summary>
        /// <example>0001-01-01T00:00:00Z</example>
        [DataMember(Name = "expiresOn", IsRequired = true, EmitDefaultValue = true)]
        public DateTime ExpiresOn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupHistoryRecord {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  StorageType: ").Append(StorageType).Append("\n");
            sb.Append("  CreatedOn: ").Append(CreatedOn).Append("\n");
            sb.Append("  ExpiresOn: ").Append(ExpiresOn).Append("\n");
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
