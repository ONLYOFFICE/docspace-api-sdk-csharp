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
    /// The request parameters for starting a backup.
    /// </summary>
    [DataContract(Name = "BackupDto")]
    public partial class BackupDto : IValidatableObject
    {

        /// <summary>
        /// The storage the archive is written to. It defaults to &#x60;Documents&#x60;, and it decides which keys  &#x60;storageParams&#x60; has to carry.
        /// </summary>
        [DataMember(Name = "storageType", EmitDefaultValue = false)]
        public BackupStorageType? StorageType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BackupDto" /> class.
        /// </summary>
        /// <param name="storageType">The storage the archive is written to. It defaults to &#x60;Documents&#x60;, and it decides which keys  &#x60;storageParams&#x60; has to carry..</param>
        /// <param name="storageParams">The settings of the chosen storage, as an array of key and value pairs. &#x60;Documents&#x60; needs an integer  &#x60;folderId&#x60;, &#x60;ThridpartyDocuments&#x60; a provider-specific non-integer &#x60;folderId&#x60;, &#x60;Local&#x60; a &#x60;filePath&#x60;,  &#x60;ThirdPartyConsumer&#x60; a &#x60;module&#x60; plus the settings of that consumer, and &#x60;DataStore&#x60; none. The  &#x60;subdir&#x60; key is added by the operation itself and must not be sent..</param>
        /// <param name="dump">Backs up the whole server rather than this one portal. It requires the space access permission and  works on a standalone installation only..</param>
        public BackupDto(BackupStorageType? storageType = default, List<ItemKeyValuePairObjectObject> storageParams = default, bool dump = default)
        {
            this.StorageType = storageType;
            this.StorageParams = storageParams;
            this.Dump = dump;
        }

        /// <summary>
        /// The settings of the chosen storage, as an array of key and value pairs. &#x60;Documents&#x60; needs an integer  &#x60;folderId&#x60;, &#x60;ThridpartyDocuments&#x60; a provider-specific non-integer &#x60;folderId&#x60;, &#x60;Local&#x60; a &#x60;filePath&#x60;,  &#x60;ThirdPartyConsumer&#x60; a &#x60;module&#x60; plus the settings of that consumer, and &#x60;DataStore&#x60; none. The  &#x60;subdir&#x60; key is added by the operation itself and must not be sent.
        /// </summary>
        /// <example>[{"key":"folderId","value":"1234"}]</example>
        [DataMember(Name = "storageParams", EmitDefaultValue = true)]
        public List<ItemKeyValuePairObjectObject> StorageParams { get; set; }

        /// <summary>
        /// Backs up the whole server rather than this one portal. It requires the space access permission and  works on a standalone installation only.
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
            sb.Append("class BackupDto {\n");
            sb.Append("  StorageType: ").Append(StorageType).Append("\n");
            sb.Append("  StorageParams: ").Append(StorageParams).Append("\n");
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
