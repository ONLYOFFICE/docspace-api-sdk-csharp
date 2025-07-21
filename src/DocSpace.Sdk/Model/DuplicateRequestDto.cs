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
    /// The duplicate request parameters.
    /// </summary>
    [DataContract(Name = "DuplicateRequestDto")]
    public partial class DuplicateRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DuplicateRequestDto" /> class.
        /// </summary>
        /// <param name="returnSingleOperation">Specifies whether to return only the current operation.</param>
        /// <param name="folderIds">The list of folder IDs..</param>
        /// <param name="fileIds">The list of file IDs..</param>
        public DuplicateRequestDto(bool returnSingleOperation = default, List<BaseBatchRequestDtoFolderIdsInner> folderIds = default, List<BaseBatchRequestDtoFolderIdsInner> fileIds = default)
        {
            this.ReturnSingleOperation = returnSingleOperation;
            this.FolderIds = folderIds;
            this.FileIds = fileIds;
        }

        /// <summary>
        /// Specifies whether to return only the current operation
        /// </summary>
        /// <value>Specifies whether to return only the current operation</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "returnSingleOperation", EmitDefaultValue = true)]
        public bool ReturnSingleOperation { get; set; }

        /// <summary>
        /// The list of folder IDs.
        /// </summary>
        /// <value>The list of folder IDs.</value>
        [DataMember(Name = "folderIds", EmitDefaultValue = true)]
        public List<BaseBatchRequestDtoFolderIdsInner> FolderIds { get; set; }

        /// <summary>
        /// The list of file IDs.
        /// </summary>
        /// <value>The list of file IDs.</value>
        [DataMember(Name = "fileIds", EmitDefaultValue = true)]
        public List<BaseBatchRequestDtoFolderIdsInner> FileIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DuplicateRequestDto {\n");
            sb.Append("  ReturnSingleOperation: ").Append(ReturnSingleOperation).Append("\n");
            sb.Append("  FolderIds: ").Append(FolderIds).Append("\n");
            sb.Append("  FileIds: ").Append(FileIds).Append("\n");
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
