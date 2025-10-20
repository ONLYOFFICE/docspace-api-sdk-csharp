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
    /// BackupHistoryRecord
    /// </summary>
    [DataContract(Name = "BackupHistoryRecord")]
    public partial class BackupHistoryRecord : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets StorageType
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
        /// <param name="id">id (required).</param>
        /// <param name="fileName">fileName (required).</param>
        /// <param name="storageType">storageType (required).</param>
        /// <param name="createdOn">createdOn (required).</param>
        /// <param name="expiresOn">expiresOn (required).</param>
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
        /// Gets or Sets Id
        /// </summary>
        /*
        <example>aae1e103-bca5-9fa1-ba8c-42058b4abf28</example>
        */
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets FileName
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "fileName", IsRequired = true, EmitDefaultValue = true)]
        public string FileName { get; set; }

        /// <summary>
        /// Gets or Sets CreatedOn
        /// </summary>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "createdOn", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresOn
        /// </summary>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
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
