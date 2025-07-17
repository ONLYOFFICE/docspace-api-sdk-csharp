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
    /// The folder content information.
    /// </summary>
    [DataContract(Name = "FolderContentDtoInteger")]
    public partial class FolderContentDtoInteger : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FolderContentDtoInteger" /> class.
        /// </summary>
        /// <param name="files">The list of files in the folder..</param>
        /// <param name="folders">The list of folders in the folder..</param>
        /// <param name="current">current.</param>
        /// <param name="pathParts">The folder path..</param>
        /// <param name="startIndex">The folder start index..</param>
        /// <param name="count">The number of folder elements..</param>
        /// <param name="total">The total number of elements in the folder..</param>
        /// <param name="@new">The new element index in the folder..</param>
        public FolderContentDtoInteger(List<FileEntryDto> files = default, List<FileEntryDto> folders = default, FolderDtoInteger current = default, Object pathParts = default, int startIndex = default, int count = default, int total = default, int @new = default)
        {
            this.Files = files;
            this.Folders = folders;
            this.Current = current;
            this.PathParts = pathParts;
            this.StartIndex = startIndex;
            this.Count = count;
            this.Total = total;
            this.New = @new;
        }

        /// <summary>
        /// The list of files in the folder.
        /// </summary>
        /// <value>The list of files in the folder.</value>
        [DataMember(Name = "files", EmitDefaultValue = true)]
        public List<FileEntryDto> Files { get; set; }

        /// <summary>
        /// The list of folders in the folder.
        /// </summary>
        /// <value>The list of folders in the folder.</value>
        [DataMember(Name = "folders", EmitDefaultValue = true)]
        public List<FileEntryDto> Folders { get; set; }

        /// <summary>
        /// Gets or Sets Current
        /// </summary>
        [DataMember(Name = "current", EmitDefaultValue = false)]
        public FolderDtoInteger Current { get; set; }

        /// <summary>
        /// The folder path.
        /// </summary>
        /// <value>The folder path.</value>
        /*
        <example>{key &#x3D; &quot;Key&quot;, path &#x3D; &quot;//path//to//folder&quot;}</example>
        */
        [DataMember(Name = "pathParts", EmitDefaultValue = true)]
        public Object PathParts { get; set; }

        /// <summary>
        /// The folder start index.
        /// </summary>
        /// <value>The folder start index.</value>
        /*
        <example>0</example>
        */
        [DataMember(Name = "startIndex", EmitDefaultValue = false)]
        public int StartIndex { get; set; }

        /// <summary>
        /// The number of folder elements.
        /// </summary>
        /// <value>The number of folder elements.</value>
        /*
        <example>4</example>
        */
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public int Count { get; set; }

        /// <summary>
        /// The total number of elements in the folder.
        /// </summary>
        /// <value>The total number of elements in the folder.</value>
        /*
        <example>4</example>
        */
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public int Total { get; set; }

        /// <summary>
        /// The new element index in the folder.
        /// </summary>
        /// <value>The new element index in the folder.</value>
        /*
        <example>1234</example>
        */
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
