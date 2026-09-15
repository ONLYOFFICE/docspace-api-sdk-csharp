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
    /// One background file operation of the caller, as it stood when the answer was built.
    /// </summary>
    [DataContract(Name = "FileOperationDto")]
    public partial class FileOperationDto : IValidatableObject
    {

        /// <summary>
        /// What the operation does with the entries, which also decides what else is reported: only a download fills  &#x60;url&#x60;, and a deletion leaves &#x60;files&#x60; and &#x60;folders&#x60; empty.
        /// </summary>
        [DataMember(Name = "Operation", IsRequired = true, EmitDefaultValue = true)]
        public FileOperationType Operation { get; set; }

        /// <summary>
        /// The state of the background task behind the operation, which tells a task that was cancelled or that crashed  from one that ran to its end.
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public DistributedTaskStatus? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FileOperationDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileOperationDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileOperationDto" /> class.
        /// </summary>
        /// <param name="id">The identifier of the operation, the one to pass to &#x60;PUT api/2.0/files/fileops/terminate/{id}&#x60; to stop it.  Operations belong to the account that started them, so an identifier of somebody else is never listed here. (required).</param>
        /// <param name="operation">What the operation does with the entries, which also decides what else is reported: only a download fills  &#x60;url&#x60;, and a deletion leaves &#x60;files&#x60; and &#x60;folders&#x60; empty. (required).</param>
        /// <param name="progress">How far the operation has come, from 0 to 100. Reaching 100 only means it stopped; whether it did what it was  asked for is told by &#x60;error&#x60;. (required).</param>
        /// <param name="error">The reason the operation could not finish its work, in the language of the request. Empty when nothing went  wrong, which is the only way to tell a successful operation from a failed one. (required).</param>
        /// <param name="processed">How many entries the operation has handled so far, written as a decimal number in a string. It counts items,  not percent, and stays behind &#x60;progress&#x60; on operations that walk into subfolders. (required).</param>
        /// <param name="finished">Whether the operation has stopped running. A finished operation is reported once and then dropped, so the next  read of the operation list no longer contains it. (required).</param>
        /// <param name="url">The address the packed archive can be downloaded from once a bulk download has finished. Empty for every other  kind of operation..</param>
        /// <param name="files">The files the operation produced or moved, in the order it wrote them down. Empty while nothing has been  written yet and for a deletion, which reports no entries at all..</param>
        /// <param name="folders">The folders the operation produced or moved, in the order it wrote them down. Empty while nothing has been  written yet and for a deletion..</param>
        /// <param name="status">The state of the background task behind the operation, which tells a task that was cancelled or that crashed  from one that ran to its end..</param>
        public FileOperationDto(string id = default, FileOperationType operation = default, int progress = default, string error = default, string processed = default, bool finished = default, string url = default, List<FileEntryBaseDto> files = default, List<FileEntryBaseDto> folders = default, DistributedTaskStatus? status = default)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for FileOperationDto and cannot be null");
            }
            this.Id = id;
            this.Operation = operation;
            this.Progress = progress;
            // to ensure "error" is required (not null)
            if (error == null)
            {
                throw new ArgumentNullException("error is a required property for FileOperationDto and cannot be null");
            }
            this.Error = error;
            // to ensure "processed" is required (not null)
            if (processed == null)
            {
                throw new ArgumentNullException("processed is a required property for FileOperationDto and cannot be null");
            }
            this.Processed = processed;
            this.Finished = finished;
            this.Url = url;
            this.Files = files;
            this.Folders = folders;
            this.Status = status;
        }

        /// <summary>
        /// The identifier of the operation, the one to pass to &#x60;PUT api/2.0/files/fileops/terminate/{id}&#x60; to stop it.  Operations belong to the account that started them, so an identifier of somebody else is never listed here.
        /// </summary>
        /// <example>a1f4c9b2-3d8e-4f77-9b16-2c5de8f0a913</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// How far the operation has come, from 0 to 100. Reaching 100 only means it stopped; whether it did what it was  asked for is told by &#x60;error&#x60;.
        /// </summary>
        /// <example>100</example>
        [DataMember(Name = "progress", IsRequired = true, EmitDefaultValue = true)]
        public int Progress { get; set; }

        /// <summary>
        /// The reason the operation could not finish its work, in the language of the request. Empty when nothing went  wrong, which is the only way to tell a successful operation from a failed one.
        /// </summary>
        /// <example>Folder not found.</example>
        [DataMember(Name = "error", IsRequired = true, EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// How many entries the operation has handled so far, written as a decimal number in a string. It counts items,  not percent, and stays behind &#x60;progress&#x60; on operations that walk into subfolders.
        /// </summary>
        /// <example>12</example>
        [DataMember(Name = "processed", IsRequired = true, EmitDefaultValue = true)]
        public string Processed { get; set; }

        /// <summary>
        /// Whether the operation has stopped running. A finished operation is reported once and then dropped, so the next  read of the operation list no longer contains it.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "finished", IsRequired = true, EmitDefaultValue = true)]
        public bool Finished { get; set; }

        /// <summary>
        /// The address the packed archive can be downloaded from once a bulk download has finished. Empty for every other  kind of operation.
        /// </summary>
        /// <example>https://portal.example.com/filehandler.ashx?action=bulk</example>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// The files the operation produced or moved, in the order it wrote them down. Empty while nothing has been  written yet and for a deletion, which reports no entries at all.
        /// </summary>
        /// <example>[{"id":10,"title":"document.docx"}]</example>
        [DataMember(Name = "files", EmitDefaultValue = true)]
        public List<FileEntryBaseDto> Files { get; set; }

        /// <summary>
        /// The folders the operation produced or moved, in the order it wrote them down. Empty while nothing has been  written yet and for a deletion.
        /// </summary>
        /// <example>[{"id":20,"title":"Reports"}]</example>
        [DataMember(Name = "folders", EmitDefaultValue = true)]
        public List<FileEntryBaseDto> Folders { get; set; }

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
            sb.Append("  Status: ").Append(Status).Append("\n");
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
