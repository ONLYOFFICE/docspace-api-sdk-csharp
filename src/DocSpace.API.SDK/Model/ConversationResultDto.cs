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
    /// The result of file convertion operation.
    /// </summary>
    [DataContract(Name = "ConversationResultDto")]
    public partial class ConversationResultDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Operation
        /// </summary>
        [DataMember(Name = "Operation", EmitDefaultValue = false)]
        public FileOperationType? Operation { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationResultDto" /> class.
        /// </summary>
        /// <param name="id">The conversion operation ID..</param>
        /// <param name="operation">operation.</param>
        /// <param name="progress">The conversion operation progress..</param>
        /// <param name="source">The source file for the conversion..</param>
        /// <param name="result">The resulting file after the conversion..</param>
        /// <param name="error">The conversion operation error message..</param>
        /// <param name="processed">Specifies if the conversion operation is processed or not..</param>
        public ConversationResultDto(string id = default, FileOperationType? operation = default, int progress = default, string source = default, Object result = default, string error = default, string processed = default)
        {
            this.Id = id;
            this.Operation = operation;
            this.Progress = progress;
            this.Source = source;
            this.Result = result;
            this.Error = error;
            this.Processed = processed;
        }

        /// <summary>
        /// The conversion operation ID.
        /// </summary>
        /// <value>The conversion operation ID.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The conversion operation progress.
        /// </summary>
        /// <value>The conversion operation progress.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "progress", EmitDefaultValue = false)]
        public int Progress { get; set; }

        /// <summary>
        /// The source file for the conversion.
        /// </summary>
        /// <value>The source file for the conversion.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "source", EmitDefaultValue = true)]
        public string Source { get; set; }

        /// <summary>
        /// The resulting file after the conversion.
        /// </summary>
        /// <value>The resulting file after the conversion.</value>
        /*
        <example>{&quot;int&quot;:1234,&quot;string&quot;:&quot;some text&quot;,&quot;boolean&quot;:true}</example>
        */
        [DataMember(Name = "result", EmitDefaultValue = true)]
        public Object Result { get; set; }

        /// <summary>
        /// The conversion operation error message.
        /// </summary>
        /// <value>The conversion operation error message.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// Specifies if the conversion operation is processed or not.
        /// </summary>
        /// <value>Specifies if the conversion operation is processed or not.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "processed", EmitDefaultValue = true)]
        public string Processed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConversationResultDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Processed: ").Append(Processed).Append("\n");
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
