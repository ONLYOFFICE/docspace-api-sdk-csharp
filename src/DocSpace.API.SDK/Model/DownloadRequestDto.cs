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
    /// The files and folders to pack into one archive, together with the formats they are converted to.
    /// </summary>
    [DataContract(Name = "DownloadRequestDto")]
    public partial class DownloadRequestDto : FileOperationRequestBaseDto, IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadRequestDto" /> class.
        /// </summary>
        /// <param name="folderIds">The folders to pack, by id; everything inside them that the caller may read goes into the archive. A number  addresses a folder stored in the portal itself, a string addresses a folder on a connected third-party  account, and both kinds may be sent in one list..</param>
        /// <param name="fileIds">The files to pack as they are, by id, without conversion. A number addresses a file stored in the portal  itself, a string addresses a file on a connected third-party account, and both kinds may be sent in one list..</param>
        /// <param name="fileConvertIds">The files to convert before they are packed, each named together with the format it is converted to. A file  listed here does not have to be repeated in &#x60;fileIds&#x60;..</param>
        public DownloadRequestDto(List<DownloadRequestDtoAllOfFolderIds> folderIds = default, List<DownloadRequestDtoAllOfFileIds> fileIds = default, List<DownloadRequestItemDto> fileConvertIds = default)
        {
            this.FolderIds = folderIds;
            this.FileIds = fileIds;
            this.FileConvertIds = fileConvertIds;
        }

        /// <summary>
        /// The folders to pack, by id; everything inside them that the caller may read goes into the archive. A number  addresses a folder stored in the portal itself, a string addresses a folder on a connected third-party  account, and both kinds may be sent in one list.
        /// </summary>
        /// <example>[1,2,3]</example>
        [DataMember(Name = "folderIds", EmitDefaultValue = true)]
        public List<DownloadRequestDtoAllOfFolderIds> FolderIds { get; set; }

        /// <summary>
        /// The files to pack as they are, by id, without conversion. A number addresses a file stored in the portal  itself, a string addresses a file on a connected third-party account, and both kinds may be sent in one list.
        /// </summary>
        /// <example>[1,2,3]</example>
        [DataMember(Name = "fileIds", EmitDefaultValue = true)]
        public List<DownloadRequestDtoAllOfFileIds> FileIds { get; set; }

        /// <summary>
        /// The files to convert before they are packed, each named together with the format it is converted to. A file  listed here does not have to be repeated in &#x60;fileIds&#x60;.
        /// </summary>
        /// <example>[{"key":"1","value":"pdf","password":"password123"}]</example>
        [DataMember(Name = "fileConvertIds", EmitDefaultValue = true)]
        public List<DownloadRequestItemDto> FileConvertIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DownloadRequestDto {\n");
            sb.Append("  FolderIds: ").Append(FolderIds).Append("\n");
            sb.Append("  FileIds: ").Append(FileIds).Append("\n");
            sb.Append("  FileConvertIds: ").Append(FileConvertIds).Append("\n");
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
