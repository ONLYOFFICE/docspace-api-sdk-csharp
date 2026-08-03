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
    /// The file operation information.
    /// </summary>
    [DataContract(Name = "AiFileOperationDto")]
    public partial class AiFileOperationDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Operation
        /// </summary>
        [DataMember(Name = "Operation", IsRequired = true, EmitDefaultValue = true)]
        public AiFileOperationType Operation { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public AiDistributedTaskStatus? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiFileOperationDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiFileOperationDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiFileOperationDto" /> class.
        /// </summary>
        /// <param name="id">The file operation ID. (required).</param>
        /// <param name="operation">operation (required).</param>
        /// <param name="progress">The file operation progress in percentage. (required).</param>
        /// <param name="error">The file operation error message. (required).</param>
        /// <param name="processed">The file operation processing status. (required).</param>
        /// <param name="finished">Specifies if the file operation is finished or not. (required).</param>
        /// <param name="url">The file operation URL..</param>
        /// <param name="files">The list of files of the file operation..</param>
        /// <param name="folders">The list of folders of the file operation..</param>
        /// <param name="status">status.</param>
        public AiFileOperationDto(string id = default, AiFileOperationType operation = default, int progress = default, string error = default, string processed = default, bool finished = default, string url = default, List<AiFileEntryBaseDto> files = default, List<AiFileEntryBaseDto> folders = default, AiDistributedTaskStatus? status = default)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for AiFileOperationDto and cannot be null");
            }
            this.Id = id;
            this.Operation = operation;
            this.Progress = progress;
            // to ensure "error" is required (not null)
            if (error == null)
            {
                throw new ArgumentNullException("error is a required property for AiFileOperationDto and cannot be null");
            }
            this.Error = error;
            // to ensure "processed" is required (not null)
            if (processed == null)
            {
                throw new ArgumentNullException("processed is a required property for AiFileOperationDto and cannot be null");
            }
            this.Processed = processed;
            this.Finished = finished;
            this.Url = url;
            this.Files = files;
            this.Folders = folders;
            this.Status = status;
        }

        /// <summary>
        /// The file operation ID.
        /// </summary>
        /// <value>The file operation ID.</value>
        /*
        <example>00000000-0000-0000-0000-000000000000</example>
        */
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The file operation progress in percentage.
        /// </summary>
        /// <value>The file operation progress in percentage.</value>
        /*
        <example>100</example>
        */
        [DataMember(Name = "progress", IsRequired = true, EmitDefaultValue = true)]
        public int Progress { get; set; }

        /// <summary>
        /// The file operation error message.
        /// </summary>
        /// <value>The file operation error message.</value>
        /*
        <example>File not found.</example>
        */
        [DataMember(Name = "error", IsRequired = true, EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// The file operation processing status.
        /// </summary>
        /// <value>The file operation processing status.</value>
        /*
        <example>1</example>
        */
        [DataMember(Name = "processed", IsRequired = true, EmitDefaultValue = true)]
        public string Processed { get; set; }

        /// <summary>
        /// Specifies if the file operation is finished or not.
        /// </summary>
        /// <value>Specifies if the file operation is finished or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "finished", IsRequired = true, EmitDefaultValue = true)]
        public bool Finished { get; set; }

        /// <summary>
        /// The file operation URL.
        /// </summary>
        /// <value>The file operation URL.</value>
        /*
        <example>http://localhost/download</example>
        */
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// The list of files of the file operation.
        /// </summary>
        /// <value>The list of files of the file operation.</value>
        /*
        <example>[{"id":10,"title":"document.docx"}]</example>
        */
        [DataMember(Name = "files", EmitDefaultValue = true)]
        public List<AiFileEntryBaseDto> Files { get; set; }

        /// <summary>
        /// The list of folders of the file operation.
        /// </summary>
        /// <value>The list of folders of the file operation.</value>
        /*
        <example>[{"id":20,"title":"My Folder"}]</example>
        */
        [DataMember(Name = "folders", EmitDefaultValue = true)]
        public List<AiFileEntryBaseDto> Folders { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiFileOperationDto {\n");
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
