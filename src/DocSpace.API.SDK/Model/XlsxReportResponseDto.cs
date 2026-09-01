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
    /// The XLSX report task response parameters.
    /// </summary>
    [DataContract(Name = "XlsxReportResponseDto")]
    public partial class XlsxReportResponseDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="XlsxReportResponseDto" /> class.
        /// </summary>
        /// <param name="form">The original form file information..</param>
        /// <param name="task">The Document Builder task information..</param>
        /// <param name="isNewFile">Specifies whether the XLSX report file is newly created or an existing file will be updated..</param>
        public XlsxReportResponseDto(FileDtoInteger form = default, DocumentBuilderTaskDto task = default, bool isNewFile = default)
        {
            this.Form = form;
            this.Task = task;
            this.IsNewFile = isNewFile;
        }

        /// <summary>
        /// The original form file information.
        /// </summary>
        [DataMember(Name = "form", EmitDefaultValue = false)]
        public FileDtoInteger Form { get; set; }

        /// <summary>
        /// The Document Builder task information.
        /// </summary>
        [DataMember(Name = "task", EmitDefaultValue = false)]
        public DocumentBuilderTaskDto Task { get; set; }

        /// <summary>
        /// Specifies whether the XLSX report file is newly created or an existing file will be updated.
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
