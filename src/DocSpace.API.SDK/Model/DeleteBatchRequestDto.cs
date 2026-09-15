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
    /// The files and folders to delete, and how final the deletion is.
    /// </summary>
    [DataContract(Name = "DeleteBatchRequestDto")]
    public partial class DeleteBatchRequestDto : FileOperationRequestBaseDto, IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteBatchRequestDto" /> class.
        /// </summary>
        /// <param name="folderIds">The folders to delete, by id, each with everything it contains. A number addresses a folder stored in the  portal itself, a string addresses a folder on a connected third-party account, and both kinds may be sent in  one list..</param>
        /// <param name="fileIds">The files to delete, by id. A number addresses a file stored in the portal itself, a string addresses a file  on a connected third-party account, and both kinds may be sent in one list..</param>
        /// <param name="deleteAfter">Whether the finished operation is still reported: &#x60;false&#x60; keeps its final record readable through  &#x60;GET api/2.0/files/fileops&#x60; until it has been read once, &#x60;true&#x60; drops the record as soon as the work is done.  It does not postpone the deletion and does not delete anything of its own..</param>
        /// <param name="immediately">Where the deleted items go: &#x60;false&#x60; moves them to the Trash of the caller, from which they can be restored,  &#x60;true&#x60; removes them at once and for good..</param>
        public DeleteBatchRequestDto(List<DeleteBatchRequestDtoAllOfFolderIds> folderIds = default, List<DeleteBatchRequestDtoAllOfFileIds> fileIds = default, bool deleteAfter = default, bool immediately = default)
        {
            this.FolderIds = folderIds;
            this.FileIds = fileIds;
            this.DeleteAfter = deleteAfter;
            this.Immediately = immediately;
        }

        /// <summary>
        /// The folders to delete, by id, each with everything it contains. A number addresses a folder stored in the  portal itself, a string addresses a folder on a connected third-party account, and both kinds may be sent in  one list.
        /// </summary>
        /// <example>[1,2,3]</example>
        [DataMember(Name = "folderIds", EmitDefaultValue = true)]
        public List<DeleteBatchRequestDtoAllOfFolderIds> FolderIds { get; set; }

        /// <summary>
        /// The files to delete, by id. A number addresses a file stored in the portal itself, a string addresses a file  on a connected third-party account, and both kinds may be sent in one list.
        /// </summary>
        /// <example>[1,2,3]</example>
        [DataMember(Name = "fileIds", EmitDefaultValue = true)]
        public List<DeleteBatchRequestDtoAllOfFileIds> FileIds { get; set; }

        /// <summary>
        /// Whether the finished operation is still reported: &#x60;false&#x60; keeps its final record readable through  &#x60;GET api/2.0/files/fileops&#x60; until it has been read once, &#x60;true&#x60; drops the record as soon as the work is done.  It does not postpone the deletion and does not delete anything of its own.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "deleteAfter", EmitDefaultValue = true)]
        public bool DeleteAfter { get; set; }

        /// <summary>
        /// Where the deleted items go: &#x60;false&#x60; moves them to the Trash of the caller, from which they can be restored,  &#x60;true&#x60; removes them at once and for good.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "immediately", EmitDefaultValue = true)]
        public bool Immediately { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteBatchRequestDto {\n");
            sb.Append("  FolderIds: ").Append(FolderIds).Append("\n");
            sb.Append("  FileIds: ").Append(FileIds).Append("\n");
            sb.Append("  DeleteAfter: ").Append(DeleteAfter).Append("\n");
            sb.Append("  Immediately: ").Append(Immediately).Append("\n");
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
