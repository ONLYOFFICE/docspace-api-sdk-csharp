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
    /// The document builder script to run and where to put what it produces.
    /// </summary>
    [DataContract(Name = "RunBuilderScriptRequestDto")]
    public partial class RunBuilderScriptRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RunBuilderScriptRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RunBuilderScriptRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RunBuilderScriptRequestDto" /> class.
        /// </summary>
        /// <param name="script">The document builder script. It names a portal file by its id where the document builder documentation  writes an address - &#x60;builder.OpenFile(1234)&#x60;; an address written out in the script is refused. (required).</param>
        /// <param name="folderId">The id of the folder for the produced files that &#x60;outputs&#x60; does not list, as reported by a folder listing  such as &#x60;GET api/2.0/files/{folderId}&#x60;..</param>
        /// <param name="outputs">Destinations of the produced files, keyed by the name the script saves each one under - the second argument of  &#x60;builder.SaveFile(docx, result.docx)&#x60;..</param>
        /// <param name="argument">argument.</param>
        public RunBuilderScriptRequestDto(string script = default, int? folderId = default, Dictionary<string, RunBuilderScriptOutputRequest> outputs = default, RunBuilderScriptRequestDtoArgument argument = default)
        {
            // to ensure "script" is required (not null)
            if (script == null)
            {
                throw new ArgumentNullException("script is a required property for RunBuilderScriptRequestDto and cannot be null");
            }
            this.Script = script;
            this.FolderId = folderId;
            this.Outputs = outputs;
            this.Argument = argument;
        }

        /// <summary>
        /// The document builder script. It names a portal file by its id where the document builder documentation  writes an address - &#x60;builder.OpenFile(1234)&#x60;; an address written out in the script is refused.
        /// </summary>
        /// <example>builder.OpenFile("1234"); Api.GetDocument().GetElement(0).AddText(Argument.title); builder.SaveFile("docx", "result.docx"); builder.SaveFile("pdf", "result.pdf"); builder.CloseFile();</example>
        [DataMember(Name = "script", IsRequired = true, EmitDefaultValue = true)]
        public string Script { get; set; }

        /// <summary>
        /// The id of the folder for the produced files that &#x60;outputs&#x60; does not list, as reported by a folder listing  such as &#x60;GET api/2.0/files/{folderId}&#x60;.
        /// </summary>
        /// <example>5678</example>
        [DataMember(Name = "folderId", EmitDefaultValue = true)]
        public int? FolderId { get; set; }

        /// <summary>
        /// Destinations of the produced files, keyed by the name the script saves each one under - the second argument of  &#x60;builder.SaveFile(docx, result.docx)&#x60;.
        /// </summary>
        /// <example>{"result.docx":{"fileId":1234},"result.pdf":{"folderId":5678,"title":"Quarterly report.pdf"}}</example>
        [DataMember(Name = "outputs", EmitDefaultValue = false)]
        public Dictionary<string, RunBuilderScriptOutputRequest> Outputs { get; set; }

        /// <summary>
        /// Gets or Sets Argument
        /// </summary>
        [DataMember(Name = "argument", EmitDefaultValue = false)]
        public RunBuilderScriptRequestDtoArgument Argument { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RunBuilderScriptRequestDto {\n");
            sb.Append("  Script: ").Append(Script).Append("\n");
            sb.Append("  FolderId: ").Append(FolderId).Append("\n");
            sb.Append("  Outputs: ").Append(Outputs).Append("\n");
            sb.Append("  Argument: ").Append(Argument).Append("\n");
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
            // Script (string) maxLength
            if (this.Script != null && this.Script.Length > 2097152)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Script, length must be less than 2097152.", new [] { "Script" });
            }

            // Script (string) minLength
            if (this.Script != null && this.Script.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Script, length must be greater than 0.", new [] { "Script" });
            }

            yield break;
        }

    }


}
