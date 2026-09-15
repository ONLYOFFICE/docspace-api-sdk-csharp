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
    /// The file whose versions are deleted, and the versions to delete.
    /// </summary>
    [DataContract(Name = "DeleteVersionBatchRequestDto")]
    public partial class DeleteVersionBatchRequestDto : FileOperationRequestBaseDto, IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteVersionBatchRequestDto" /> class.
        /// </summary>
        [JsonConstructor]
        protected DeleteVersionBatchRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeleteVersionBatchRequestDto" /> class.
        /// </summary>
        /// <param name="deleteAfter">Whether the finished operation is still reported: &#x60;false&#x60; keeps its final record readable through  &#x60;GET api/2.0/files/fileops&#x60; until it has been read once, &#x60;true&#x60; drops the record as soon as the work is done.  It does not postpone the deletion and does not delete anything of its own..</param>
        /// <param name="fileId">The file whose history the versions are taken from; only files stored in the portal itself are addressed here. (required).</param>
        /// <param name="versions">The version numbers to remove, as reported by &#x60;GET api/2.0/files/file/{fileId}/history&#x60;. At least one number  has to be sent: an empty list removes the file itself instead of one of its versions. The number of the  current version is refused outright, while a number that no longer exists is passed over without a complaint. (required).</param>
        public DeleteVersionBatchRequestDto(bool deleteAfter = default, int fileId = default, List<int> versions = default)
        {
            this.FileId = fileId;
            // to ensure "versions" is required (not null)
            if (versions == null)
            {
                throw new ArgumentNullException("versions is a required property for DeleteVersionBatchRequestDto and cannot be null");
            }
            this.Versions = versions;
            this.DeleteAfter = deleteAfter;
        }

        /// <summary>
        /// Whether the finished operation is still reported: &#x60;false&#x60; keeps its final record readable through  &#x60;GET api/2.0/files/fileops&#x60; until it has been read once, &#x60;true&#x60; drops the record as soon as the work is done.  It does not postpone the deletion and does not delete anything of its own.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "deleteAfter", EmitDefaultValue = true)]
        public bool DeleteAfter { get; set; }

        /// <summary>
        /// The file whose history the versions are taken from; only files stored in the portal itself are addressed here.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "fileId", IsRequired = true, EmitDefaultValue = true)]
        public int FileId { get; set; }

        /// <summary>
        /// The version numbers to remove, as reported by &#x60;GET api/2.0/files/file/{fileId}/history&#x60;. At least one number  has to be sent: an empty list removes the file itself instead of one of its versions. The number of the  current version is refused outright, while a number that no longer exists is passed over without a complaint.
        /// </summary>
        /// <example>[1,2,3]</example>
        [DataMember(Name = "versions", IsRequired = true, EmitDefaultValue = true)]
        public List<int> Versions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteVersionBatchRequestDto {\n");
            sb.Append("  DeleteAfter: ").Append(DeleteAfter).Append("\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  Versions: ").Append(Versions).Append("\n");
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
