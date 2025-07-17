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
    /// The destination folder checking information.
    /// </summary>
    [DataContract(Name = "CheckDestFolderDto")]
    public partial class CheckDestFolderDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name = "result", EmitDefaultValue = false)]
        public CheckDestFolderResult? Result { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckDestFolderDto" /> class.
        /// </summary>
        /// <param name="result">result.</param>
        /// <param name="files">The list of files of the destination folder..</param>
        public CheckDestFolderDto(CheckDestFolderResult? result = default, List<FileEntryDto> files = default)
        {
            this.Result = result;
            this.Files = files;
        }

        /// <summary>
        /// The list of files of the destination folder.
        /// </summary>
        /// <value>The list of files of the destination folder.</value>
        [DataMember(Name = "files", EmitDefaultValue = true)]
        public List<FileEntryDto> Files { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CheckDestFolderDto {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
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
