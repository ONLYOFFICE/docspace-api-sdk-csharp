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
    /// The file operation information.
    /// </summary>
    [DataContract(Name = "FileOperationDto")]
    public partial class FileOperationDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Operation
        /// </summary>
        [DataMember(Name = "Operation", EmitDefaultValue = false)]
        public FileOperationType? Operation { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FileOperationDto" /> class.
        /// </summary>
        /// <param name="id">The file operation ID..</param>
        /// <param name="operation">operation.</param>
        /// <param name="progress">The file operation progress in percentage..</param>
        /// <param name="error">The file operation error message..</param>
        /// <param name="processed">The file operation processing status..</param>
        /// <param name="finished">Specifies if the file operation is finished or not..</param>
        /// <param name="url">The file operation URL..</param>
        /// <param name="files">The list of files of the file operation..</param>
        /// <param name="folders">The list of folders of the file operation..</param>
        public FileOperationDto(string id = default, FileOperationType? operation = default, int progress = default, string error = default, string processed = default, bool finished = default, string url = default, List<FileEntryDto> files = default, List<FileEntryDto> folders = default)
        {
            this.Id = id;
            this.Operation = operation;
            this.Progress = progress;
            this.Error = error;
            this.Processed = processed;
            this.Finished = finished;
            this.Url = url;
            this.Files = files;
            this.Folders = folders;
        }

        /// <summary>
        /// The file operation ID.
        /// </summary>
        /// <value>The file operation ID.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The file operation progress in percentage.
        /// </summary>
        /// <value>The file operation progress in percentage.</value>
        /*
        <example>100</example>
        */
        [DataMember(Name = "progress", EmitDefaultValue = false)]
        public int Progress { get; set; }

        /// <summary>
        /// The file operation error message.
        /// </summary>
        /// <value>The file operation error message.</value>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// The file operation processing status.
        /// </summary>
        /// <value>The file operation processing status.</value>
        /*
        <example>1</example>
        */
        [DataMember(Name = "processed", EmitDefaultValue = true)]
        public string Processed { get; set; }

        /// <summary>
        /// Specifies if the file operation is finished or not.
        /// </summary>
        /// <value>Specifies if the file operation is finished or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "finished", EmitDefaultValue = true)]
        public bool Finished { get; set; }

        /// <summary>
        /// The file operation URL.
        /// </summary>
        /// <value>The file operation URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// The list of files of the file operation.
        /// </summary>
        /// <value>The list of files of the file operation.</value>
        [DataMember(Name = "files", EmitDefaultValue = true)]
        public List<FileEntryDto> Files { get; set; }

        /// <summary>
        /// The list of folders of the file operation.
        /// </summary>
        /// <value>The list of folders of the file operation.</value>
        [DataMember(Name = "folders", EmitDefaultValue = true)]
        public List<FileEntryDto> Folders { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileOperationDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Processed: ").Append(Processed).Append("\n");
            sb.Append("  Finished: ").Append(Finished).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
            sb.Append("  Folders: ").Append(Folders).Append("\n");
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
