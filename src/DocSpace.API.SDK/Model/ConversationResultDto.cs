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
    /// The result of file convertion operation.
    /// </summary>
    [DataContract(Name = "ConversationResultDto")]
    public partial class ConversationResultDto : IValidatableObject
    {

        /// <summary>
        /// The conversion operation type.
        /// </summary>
        [DataMember(Name = "Operation", IsRequired = true, EmitDefaultValue = true)]
        public FileOperationType Operation { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationResultDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationResultDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationResultDto" /> class.
        /// </summary>
        /// <param name="id">The conversion operation ID. (required).</param>
        /// <param name="operation">The conversion operation type. (required).</param>
        /// <param name="progress">The conversion operation progress. (required).</param>
        /// <param name="source">The source file for the conversion..</param>
        /// <param name="result">result.</param>
        /// <param name="error">The conversion operation error message..</param>
        /// <param name="processed">Specifies if the conversion operation is processed or not..</param>
        public ConversationResultDto(string id = default, FileOperationType operation = default, int progress = default, string source = default, Object result = default, string error = default, string processed = default)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for ConversationResultDto and cannot be null");
            }
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
        /// <example>12345</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The conversion operation progress.
        /// </summary>
        /// <example>50</example>
        [DataMember(Name = "progress", IsRequired = true, EmitDefaultValue = true)]
        public int Progress { get; set; }

        /// <summary>
        /// The source file for the conversion.
        /// </summary>
        /// <example>document.docx</example>
        [DataMember(Name = "source", EmitDefaultValue = true)]
        public string Source { get; set; }

        /// <summary>
        /// Gets or Sets Result
        /// </summary>
        [DataMember(Name = "result", EmitDefaultValue = true)]
        public Object Result { get; set; }

        /// <summary>
        /// The conversion operation error message.
        /// </summary>
        /// <example>Conversion failed</example>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// Specifies if the conversion operation is processed or not.
        /// </summary>
        /// <example>true</example>
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
