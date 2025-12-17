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
    /// FileEncryptionInfoDto
    /// </summary>
    [DataContract(Name = "FileEncryptionInfoDto")]
    public partial class FileEncryptionInfoDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FileEncryptionInfoDto" /> class.
        /// </summary>
        /// <param name="userKeys">userKeys.</param>
        /// <param name="fileKeys">fileKeys.</param>
        public FileEncryptionInfoDto(List<EncryptionKeyDto> userKeys = default, List<FileKeys> fileKeys = default)
        {
            this.UserKeys = userKeys;
            this.FileKeys = fileKeys;
        }

        /// <summary>
        /// Gets or Sets UserKeys
        /// </summary>
        [DataMember(Name = "userKeys", EmitDefaultValue = true)]
        public List<EncryptionKeyDto> UserKeys { get; set; }

        /// <summary>
        /// Gets or Sets FileKeys
        /// </summary>
        [DataMember(Name = "fileKeys", EmitDefaultValue = true)]
        public List<FileKeys> FileKeys { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileEncryptionInfoDto {\n");
            sb.Append("  UserKeys: ").Append(UserKeys).Append("\n");
            sb.Append("  FileKeys: ").Append(FileKeys).Append("\n");
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
        }    }


}
