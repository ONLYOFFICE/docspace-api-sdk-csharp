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
    /// One page of the contents of a folder or of a section: its entries split into files and folders, the folder itself,  and the counters needed to page through the rest.
    /// </summary>
    [DataContract(Name = "FolderContentDtoInteger")]
    public partial class FolderContentDtoInteger : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FolderContentDtoInteger" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FolderContentDtoInteger() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FolderContentDtoInteger" /> class.
        /// </summary>
        /// <param name="files">The file entries of this page. It is empty when the folder holds no files, when the filters matched none of  them, and in the sections that list rooms only..</param>
        /// <param name="folders">The folder entries of this page. In a section of rooms these entries are the rooms themselves, which is where  their type, tags, logo and quota are read from..</param>
        /// <param name="current">The folder or section the page was read from, with its own title, type and access rights. It describes the  container, not the entries, and is filled in even when the page is empty..</param>
        /// <param name="pathParts">pathParts (required).</param>
        /// <param name="startIndex">The position of the first entry of this page in the whole result, echoing the requested start index. Add the  number of entries received to it to ask for the next page..</param>
        /// <param name="count">How many entries this page carries, files and folders together. A page shorter than the requested size means  the result is exhausted..</param>
        /// <param name="total">How many entries matched before paging was applied, across the whole folder. Page until the start index plus  the entries received reaches it. (required).</param>
        /// <param name="new">How many entries of this folder are marked as new for the caller. It is 0 for every listing when the account  has switched the new-item badges off, so a zero here does not prove that nothing has changed..</param>
        public FolderContentDtoInteger(List<FileEntryBaseDto> files = default, List<FileEntryBaseDto> folders = default, FolderDtoInteger current = default, Object pathParts = default, int startIndex = default, int count = default, int total = default, int @new = default)
        {
            // to ensure "pathParts" is required (not null)
            if (pathParts == null)
            {
                throw new ArgumentNullException("pathParts is a required property for FolderContentDtoInteger and cannot be null");
            }
            this.PathParts = pathParts;
            this.Total = total;
            this.Files = files;
            this.Folders = folders;
            this.Current = current;
            this.StartIndex = startIndex;
            this.Count = count;
            this.New = @new;
        }

        /// <summary>
        /// The file entries of this page. It is empty when the folder holds no files, when the filters matched none of  them, and in the sections that list rooms only.
        /// </summary>
        /// <example>[{"id":10,"title":"document.docx"}]</example>
        [DataMember(Name = "files", EmitDefaultValue = true)]
        public List<FileEntryBaseDto> Files { get; set; }

        /// <summary>
        /// The folder entries of this page. In a section of rooms these entries are the rooms themselves, which is where  their type, tags, logo and quota are read from.
        /// </summary>
        /// <example>[{"id":20,"title":"My Folder"}]</example>
        [DataMember(Name = "folders", EmitDefaultValue = true)]
        public List<FileEntryBaseDto> Folders { get; set; }

        /// <summary>
        /// The folder or section the page was read from, with its own title, type and access rights. It describes the  container, not the entries, and is filled in even when the page is empty.
        /// </summary>
        [DataMember(Name = "current", EmitDefaultValue = false)]
        public FolderDtoInteger Current { get; set; }

        /// <summary>
        /// Gets or Sets PathParts
        /// </summary>
        [DataMember(Name = "pathParts", IsRequired = true, EmitDefaultValue = true)]
        public Object PathParts { get; set; }

        /// <summary>
        /// The position of the first entry of this page in the whole result, echoing the requested start index. Add the  number of entries received to it to ask for the next page.
        /// </summary>
        /// <example>0</example>
        [DataMember(Name = "startIndex", EmitDefaultValue = false)]
        public int StartIndex { get; set; }

        /// <summary>
        /// How many entries this page carries, files and folders together. A page shorter than the requested size means  the result is exhausted.
        /// </summary>
        /// <example>4</example>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public int Count { get; set; }

        /// <summary>
        /// How many entries matched before paging was applied, across the whole folder. Page until the start index plus  the entries received reaches it.
        /// </summary>
        /// <example>4</example>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = true)]
        public int Total { get; set; }

        /// <summary>
        /// How many entries of this folder are marked as new for the caller. It is 0 for every listing when the account  has switched the new-item badges off, so a zero here does not prove that nothing has changed.
        /// </summary>
        /// <example>0</example>
        [DataMember(Name = "new", EmitDefaultValue = false)]
        public int New { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FolderContentDtoInteger {\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
            sb.Append("  Folders: ").Append(Folders).Append("\n");
            sb.Append("  Current: ").Append(Current).Append("\n");
            sb.Append("  PathParts: ").Append(PathParts).Append("\n");
            sb.Append("  StartIndex: ").Append(StartIndex).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  New: ").Append(New).Append("\n");
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
