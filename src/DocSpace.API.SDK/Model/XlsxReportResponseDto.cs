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
    /// The answer to a report generation request: the queued task, the form whose answers are collected, and whether the  report file is being created or refreshed.
    /// </summary>
    [DataContract(Name = "XlsxReportResponseDto")]
    public partial class XlsxReportResponseDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="XlsxReportResponseDto" /> class.
        /// </summary>
        /// <param name="form">The original form the answers are collected from. It is not the produced spreadsheet - that one arrives with  the task, once the task reports completion..</param>
        /// <param name="task">The queued generation. Poll it with &#x60;GET api/2.0/files/file/{fileId}/xlsx&#x60; until it reports completion, and  take the produced file from it then..</param>
        /// <param name="isNewFile">True when this run creates the report file, false when an existing report is rewritten in place, which means  it keeps its id and the links already shared for it..</param>
        public XlsxReportResponseDto(FileDto form = default, DocumentBuilderTaskDto task = default, bool isNewFile = default)
        {
            this.Form = form;
            this.Task = task;
            this.IsNewFile = isNewFile;
        }

        /// <summary>
        /// The original form the answers are collected from. It is not the produced spreadsheet - that one arrives with  the task, once the task reports completion.
        /// </summary>
        [DataMember(Name = "form", EmitDefaultValue = false)]
        public FileDto Form { get; set; }

        /// <summary>
        /// The queued generation. Poll it with &#x60;GET api/2.0/files/file/{fileId}/xlsx&#x60; until it reports completion, and  take the produced file from it then.
        /// </summary>
        [DataMember(Name = "task", EmitDefaultValue = false)]
        public DocumentBuilderTaskDto Task { get; set; }

        /// <summary>
        /// True when this run creates the report file, false when an existing report is rewritten in place, which means  it keeps its id and the links already shared for it.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "isNewFile", EmitDefaultValue = true)]
        public bool IsNewFile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class XlsxReportResponseDto {\n");
            sb.Append("  Form: ").Append(Form).Append("\n");
            sb.Append("  Task: ").Append(Task).Append("\n");
            sb.Append("  IsNewFile: ").Append(IsNewFile).Append("\n");
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
