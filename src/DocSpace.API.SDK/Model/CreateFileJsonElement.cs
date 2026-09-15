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
    /// The parameters of a file that the portal creates from a template or a blank document.
    /// </summary>
    [DataContract(Name = "CreateFileJsonElement")]
    public partial class CreateFileJsonElement : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFileJsonElement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateFileJsonElement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateFileJsonElement" /> class.
        /// </summary>
        /// <param name="title">The title of the new file. The extension in it decides the format, and one of a known text, spreadsheet or  presentation format is rewritten to the DOCX, XLSX or PPTX of the portal unless &#x60;enableExternalExt&#x60; says  otherwise; a title with no extension gets DOCX added. (required).</param>
        /// <param name="templateId">templateId.</param>
        /// <param name="enableExternalExt">Whether the extension of the title is kept as it is: &#x60;true&#x60; stores the title verbatim, &#x60;false&#x60; rewrites a  known foreign format to the format the portal edits itself..</param>
        /// <param name="formId">A ready form from the form gallery of the portal to copy instead of a template, named by the identifier the  gallery reports for it. It takes precedence over &#x60;templateId&#x60;; 0 means no form..</param>
        public CreateFileJsonElement(string title = default, CreateFileJsonElementTemplateId templateId = default, bool enableExternalExt = default, int formId = default)
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for CreateFileJsonElement and cannot be null");
            }
            this.Title = title;
            this.TemplateId = templateId;
            this.EnableExternalExt = enableExternalExt;
            this.FormId = formId;
        }

        /// <summary>
        /// The title of the new file. The extension in it decides the format, and one of a known text, spreadsheet or  presentation format is rewritten to the DOCX, XLSX or PPTX of the portal unless &#x60;enableExternalExt&#x60; says  otherwise; a title with no extension gets DOCX added.
        /// </summary>
        /// <example>New Document.docx</example>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets TemplateId
        /// </summary>
        [DataMember(Name = "templateId", EmitDefaultValue = false)]
        public CreateFileJsonElementTemplateId TemplateId { get; set; }

        /// <summary>
        /// Whether the extension of the title is kept as it is: &#x60;true&#x60; stores the title verbatim, &#x60;false&#x60; rewrites a  known foreign format to the format the portal edits itself.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "enableExternalExt", EmitDefaultValue = true)]
        public bool EnableExternalExt { get; set; }

        /// <summary>
        /// A ready form from the form gallery of the portal to copy instead of a template, named by the identifier the  gallery reports for it. It takes precedence over &#x60;templateId&#x60;; 0 means no form.
        /// </summary>
        /// <example>0</example>
        [DataMember(Name = "formId", EmitDefaultValue = false)]
        public int FormId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateFileJsonElement {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  EnableExternalExt: ").Append(EnableExternalExt).Append("\n");
            sb.Append("  FormId: ").Append(FormId).Append("\n");
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
            // Title (string) maxLength
            if (this.Title != null && this.Title.Length > 165)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be less than 165.", new [] { "Title" });
            }

            // Title (string) minLength
            if (this.Title != null && this.Title.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be greater than 0.", new [] { "Title" });
            }

            yield break;
        }

    }


}
