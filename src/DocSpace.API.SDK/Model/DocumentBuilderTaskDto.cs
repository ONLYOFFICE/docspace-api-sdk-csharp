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
    /// The document builder task parameters.
    /// </summary>
    [DataContract(Name = "DocumentBuilderTaskDto")]
    public partial class DocumentBuilderTaskDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public DistributedTaskStatus? Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentBuilderTaskDto" /> class.
        /// </summary>
        /// <param name="id">The document builder ID..</param>
        /// <param name="error">The error message occured while the document building process..</param>
        /// <param name="percentage">The percentage of the progress of the document building process..</param>
        /// <param name="isCompleted">Specifies whether the document building process is completed or not..</param>
        /// <param name="status">status.</param>
        /// <param name="resultFileId">The result file ID..</param>
        /// <param name="resultFileName">The result file name..</param>
        /// <param name="resultFileUrl">The result file URL..</param>
        public DocumentBuilderTaskDto(string id = default, string error = default, int percentage = default, bool isCompleted = default, DistributedTaskStatus? status = default, Object resultFileId = default, string resultFileName = default, string resultFileUrl = default)
        {
            this.Id = id;
            this.Error = error;
            this.Percentage = percentage;
            this.IsCompleted = isCompleted;
            this.Status = status;
            this.ResultFileId = resultFileId;
            this.ResultFileName = resultFileName;
            this.ResultFileUrl = resultFileUrl;
        }

        /// <summary>
        /// The document builder ID.
        /// </summary>
        /// <value>The document builder ID.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The error message occured while the document building process.
        /// </summary>
        /// <value>The error message occured while the document building process.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// The percentage of the progress of the document building process.
        /// </summary>
        /// <value>The percentage of the progress of the document building process.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "percentage", EmitDefaultValue = false)]
        public int Percentage { get; set; }

        /// <summary>
        /// Specifies whether the document building process is completed or not.
        /// </summary>
        /// <value>Specifies whether the document building process is completed or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isCompleted", EmitDefaultValue = true)]
        public bool IsCompleted { get; set; }

        /// <summary>
        /// The result file ID.
        /// </summary>
        /// <value>The result file ID.</value>
        /*
        <example>{&quot;int&quot;:1234,&quot;string&quot;:&quot;some text&quot;,&quot;boolean&quot;:true}</example>
        */
        [DataMember(Name = "resultFileId", EmitDefaultValue = true)]
        public Object ResultFileId { get; set; }

        /// <summary>
        /// The result file name.
        /// </summary>
        /// <value>The result file name.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "resultFileName", EmitDefaultValue = true)]
        public string ResultFileName { get; set; }

        /// <summary>
        /// The result file URL.
        /// </summary>
        /// <value>The result file URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "resultFileUrl", EmitDefaultValue = true)]
        public string ResultFileUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentBuilderTaskDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
            sb.Append("  IsCompleted: ").Append(IsCompleted).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  ResultFileId: ").Append(ResultFileId).Append("\n");
            sb.Append("  ResultFileName: ").Append(ResultFileName).Append("\n");
            sb.Append("  ResultFileUrl: ").Append(ResultFileUrl).Append("\n");
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
