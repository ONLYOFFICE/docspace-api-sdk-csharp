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
    /// The request parameters for copying/moving files.
    /// </summary>
    [DataContract(Name = "BatchRequestDto")]
    public partial class BatchRequestDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets ConflictResolveType
        /// </summary>
        [DataMember(Name = "conflictResolveType", EmitDefaultValue = false)]
        public FileConflictResolveType? ConflictResolveType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRequestDto" /> class.
        /// </summary>
        /// <param name="returnSingleOperation">Specifies whether to return only the current operation.</param>
        /// <param name="folderIds">The list of folder IDs to be copied/moved..</param>
        /// <param name="fileIds">The list of file IDs to be copied/moved..</param>
        /// <param name="destFolderId">destFolderId.</param>
        /// <param name="conflictResolveType">conflictResolveType.</param>
        /// <param name="deleteAfter">Specifies whether to delete the source files/folders after they are moved or copied to the destination folder..</param>
        /// <param name="content">Specifies whether to copy or move the folder content or not..</param>
        /// <param name="toFillOut">Specifies whether the file is copied for filling out.</param>
        public BatchRequestDto(bool returnSingleOperation = default, List<BaseBatchRequestDtoFolderIdsInner> folderIds = default, List<BaseBatchRequestDtoFolderIdsInner> fileIds = default, BatchRequestDtoDestFolderId destFolderId = default, FileConflictResolveType? conflictResolveType = default, bool deleteAfter = default, bool content = default, bool toFillOut = default)
        {
            this.ReturnSingleOperation = returnSingleOperation;
            this.FolderIds = folderIds;
            this.FileIds = fileIds;
            this.DestFolderId = destFolderId;
            this.ConflictResolveType = conflictResolveType;
            this.DeleteAfter = deleteAfter;
            this.Content = content;
            this.ToFillOut = toFillOut;
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
        /// The list of folder IDs to be copied/moved.
        /// </summary>
        /// <value>The list of folder IDs to be copied/moved.</value>
        [DataMember(Name = "folderIds", EmitDefaultValue = true)]
        public List<BaseBatchRequestDtoFolderIdsInner> FolderIds { get; set; }

        /// <summary>
        /// The list of file IDs to be copied/moved.
        /// </summary>
        /// <value>The list of file IDs to be copied/moved.</value>
        [DataMember(Name = "fileIds", EmitDefaultValue = true)]
        public List<BaseBatchRequestDtoFolderIdsInner> FileIds { get; set; }

        /// <summary>
        /// Gets or Sets DestFolderId
        /// </summary>
        [DataMember(Name = "destFolderId", EmitDefaultValue = false)]
        public BatchRequestDtoDestFolderId DestFolderId { get; set; }

        /// <summary>
        /// Specifies whether to delete the source files/folders after they are moved or copied to the destination folder.
        /// </summary>
        /// <value>Specifies whether to delete the source files/folders after they are moved or copied to the destination folder.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "deleteAfter", EmitDefaultValue = true)]
        public bool DeleteAfter { get; set; }

        /// <summary>
        /// Specifies whether to copy or move the folder content or not.
        /// </summary>
        /// <value>Specifies whether to copy or move the folder content or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "content", EmitDefaultValue = true)]
        public bool Content { get; set; }

        /// <summary>
        /// Specifies whether the file is copied for filling out
        /// </summary>
        /// <value>Specifies whether the file is copied for filling out</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "toFillOut", EmitDefaultValue = true)]
        public bool ToFillOut { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchRequestDto {\n");
            sb.Append("  ReturnSingleOperation: ").Append(ReturnSingleOperation).Append("\n");
            sb.Append("  FolderIds: ").Append(FolderIds).Append("\n");
            sb.Append("  FileIds: ").Append(FileIds).Append("\n");
            sb.Append("  DestFolderId: ").Append(DestFolderId).Append("\n");
            sb.Append("  ConflictResolveType: ").Append(ConflictResolveType).Append("\n");
            sb.Append("  DeleteAfter: ").Append(DeleteAfter).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  ToFillOut: ").Append(ToFillOut).Append("\n");
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
