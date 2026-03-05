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
    /// Default template setting
    /// </summary>
    [DataContract(Name = "DefaultTemplateItemDto")]
    public partial class DefaultTemplateItemDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultTemplateItemDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DefaultTemplateItemDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultTemplateItemDto" /> class.
        /// </summary>
        /// <param name="selectedFile">File id to use as a default template.</param>
        /// <param name="fileExtension">Extension of a default template (required).</param>
        /// <param name="fileTitle">Title of a default template.</param>
        /// <param name="lastModified">Last modified date of a default template.</param>
        /// <param name="viewUrl">View url of a default template.</param>
        public DefaultTemplateItemDto(int? selectedFile = default, string fileExtension = default, string fileTitle = default, DateTime? lastModified = default, string viewUrl = default)
        {
            // to ensure "fileExtension" is required (not null)
            if (fileExtension == null)
            {
                throw new ArgumentNullException("fileExtension is a required property for DefaultTemplateItemDto and cannot be null");
            }
            this.FileExtension = fileExtension;
            this.SelectedFile = selectedFile;
            this.FileTitle = fileTitle;
            this.LastModified = lastModified;
            this.ViewUrl = viewUrl;
        }

        /// <summary>
        /// File id to use as a default template
        /// </summary>
        /// <value>File id to use as a default template</value>
        /*
        <example>123</example>
        */
        [DataMember(Name = "selectedFile", EmitDefaultValue = true)]
        public int? SelectedFile { get; set; }

        /// <summary>
        /// Extension of a default template
        /// </summary>
        /// <value>Extension of a default template</value>
        /*
        <example>.docx</example>
        */
        [DataMember(Name = "fileExtension", IsRequired = true, EmitDefaultValue = true)]
        public string FileExtension { get; set; }

        /// <summary>
        /// Title of a default template
        /// </summary>
        /// <value>Title of a default template</value>
        /*
        <example>Default Template</example>
        */
        [DataMember(Name = "fileTitle", EmitDefaultValue = true)]
        public string FileTitle { get; set; }

        /// <summary>
        /// Last modified date of a default template
        /// </summary>
        /// <value>Last modified date of a default template</value>
        [DataMember(Name = "lastModified", EmitDefaultValue = true)]
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// View url of a default template
        /// </summary>
        /// <value>View url of a default template</value>
        /*
        <example>http://localhost/template/view</example>
        */
        [DataMember(Name = "viewUrl", EmitDefaultValue = true)]
        public string ViewUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DefaultTemplateItemDto {\n");
            sb.Append("  SelectedFile: ").Append(SelectedFile).Append("\n");
            sb.Append("  FileExtension: ").Append(FileExtension).Append("\n");
            sb.Append("  FileTitle: ").Append(FileTitle).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
            sb.Append("  ViewUrl: ").Append(ViewUrl).Append("\n");
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
