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
    /// The backup history parameters.
    /// </summary>
    [DataContract(Name = "BackupHistoryRecord")]
    public partial class BackupHistoryRecord : IValidatableObject
    {

        /// <summary>
        /// The backup storage type.
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
        /// <param name="id">The backup ID. (required).</param>
        /// <param name="fileName">The backup file name. (required).</param>
        /// <param name="storageType">The backup storage type. (required).</param>
        /// <param name="createdOn">The backup creation date. (required).</param>
        /// <param name="expiresOn">The backup expiration date. (required).</param>
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
        /// The backup ID.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000000</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// The backup file name.
        /// </summary>
        /// <example>tenant-backup</example>
        [DataMember(Name = "fileName", IsRequired = true, EmitDefaultValue = true)]
        public string FileName { get; set; }

        /// <summary>
        /// The backup creation date.
        /// </summary>
        /// <example>2026-03-01T02:15:00Z</example>
        [DataMember(Name = "createdOn", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// The backup expiration date.
        /// </summary>
        /// <example>2026-03-31T02:15:00Z</example>
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
