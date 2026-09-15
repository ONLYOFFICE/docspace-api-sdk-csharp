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
    /// The files and folders to move or copy, the folder they go to, and the way name clashes are settled.
    /// </summary>
    [DataContract(Name = "BatchRequestDto")]
    public partial class BatchRequestDto : FileOperationRequestBaseDto, IValidatableObject
    {

        /// <summary>
        /// What happens to an item whose name is already taken in the destination folder: &#x60;skip&#x60; leaves it where it is,  &#x60;overwrite&#x60; replaces the entry at the destination, and &#x60;duplicate&#x60; places it beside that entry under a name  with a numeric suffix. &#x60;GET api/2.0/files/fileops/move&#x60; reports which items would clash.
        /// </summary>
        [DataMember(Name = "conflictResolveType", EmitDefaultValue = false)]
        public FileConflictResolveType? ConflictResolveType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="BatchRequestDto" /> class.
        /// </summary>
        /// <param name="folderIds">The folders to move or copy, by id. A number addresses a folder stored in the portal itself, a string  addresses a folder on a connected third-party account, and both kinds may be sent in one list..</param>
        /// <param name="fileIds">The files to move or copy, by id. A number addresses a file stored in the portal itself, a string addresses a  file on a connected third-party account, and both kinds may be sent in one list..</param>
        /// <param name="destFolderId">destFolderId.</param>
        /// <param name="conflictResolveType">What happens to an item whose name is already taken in the destination folder: &#x60;skip&#x60; leaves it where it is,  &#x60;overwrite&#x60; replaces the entry at the destination, and &#x60;duplicate&#x60; places it beside that entry under a name  with a numeric suffix. &#x60;GET api/2.0/files/fileops/move&#x60; reports which items would clash..</param>
        /// <param name="deleteAfter">Whether the finished operation is still reported: &#x60;false&#x60; keeps its final record readable through  &#x60;GET api/2.0/files/fileops&#x60; until it has been read once, &#x60;true&#x60; drops the record as soon as the work is done.  It deletes nothing: a move takes the sources away in any case, and a copy always leaves them..</param>
        /// <param name="content">What is taken from a listed folder: &#x60;false&#x60; moves or copies the folder itself, &#x60;true&#x60; takes only what it  contains, so its files and subfolders land in the destination and the folder is not recreated there..</param>
        /// <param name="toFillOut">Marks every copied PDF form as a draft prepared for filling, which is how such a copy reports its filling  status in a virtual data room. Files that are not forms are left unaffected..</param>
        public BatchRequestDto(List<BatchRequestDtoAllOfFolderIds> folderIds = default, List<BatchRequestDtoAllOfFileIds> fileIds = default, BatchRequestDtoAllOfDestFolderId destFolderId = default, FileConflictResolveType? conflictResolveType = default, bool deleteAfter = default, bool content = default, bool toFillOut = default)
        {
            this.FolderIds = folderIds;
            this.FileIds = fileIds;
            this.DestFolderId = destFolderId;
            this.ConflictResolveType = conflictResolveType;
            this.DeleteAfter = deleteAfter;
            this.Content = content;
            this.ToFillOut = toFillOut;
        }

        /// <summary>
        /// The folders to move or copy, by id. A number addresses a folder stored in the portal itself, a string  addresses a folder on a connected third-party account, and both kinds may be sent in one list.
        /// </summary>
        /// <example>[1,2,3]</example>
        [DataMember(Name = "folderIds", EmitDefaultValue = true)]
        public List<BatchRequestDtoAllOfFolderIds> FolderIds { get; set; }

        /// <summary>
        /// The files to move or copy, by id. A number addresses a file stored in the portal itself, a string addresses a  file on a connected third-party account, and both kinds may be sent in one list.
        /// </summary>
        /// <example>[1,2,3]</example>
        [DataMember(Name = "fileIds", EmitDefaultValue = true)]
        public List<BatchRequestDtoAllOfFileIds> FileIds { get; set; }

        /// <summary>
        /// Gets or Sets DestFolderId
        /// </summary>
        [DataMember(Name = "destFolderId", EmitDefaultValue = false)]
        public BatchRequestDtoAllOfDestFolderId DestFolderId { get; set; }

        /// <summary>
        /// Whether the finished operation is still reported: &#x60;false&#x60; keeps its final record readable through  &#x60;GET api/2.0/files/fileops&#x60; until it has been read once, &#x60;true&#x60; drops the record as soon as the work is done.  It deletes nothing: a move takes the sources away in any case, and a copy always leaves them.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "deleteAfter", EmitDefaultValue = true)]
        public bool DeleteAfter { get; set; }

        /// <summary>
        /// What is taken from a listed folder: &#x60;false&#x60; moves or copies the folder itself, &#x60;true&#x60; takes only what it  contains, so its files and subfolders land in the destination and the folder is not recreated there.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "content", EmitDefaultValue = true)]
        public bool Content { get; set; }

        /// <summary>
        /// Marks every copied PDF form as a draft prepared for filling, which is how such a copy reports its filling  status in a virtual data room. Files that are not forms are left unaffected.
        /// </summary>
        /// <example>false</example>
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
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
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
