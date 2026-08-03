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
    /// A file attachment draft to persist.
    /// </summary>
    [DataContract(Name = "newAiAttachmentsSaveFile_request_input")]
    public partial class NewAiAttachmentsSaveFileRequestInput : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiAttachmentsSaveFileRequestInput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewAiAttachmentsSaveFileRequestInput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiAttachmentsSaveFileRequestInput" /> class.
        /// </summary>
        /// <param name="path">Storage path/key of the file. (required).</param>
        /// <param name="content">File contents. (required).</param>
        /// <param name="type">File type discriminator. (required).</param>
        /// <param name="title">Optional display title..</param>
        public NewAiAttachmentsSaveFileRequestInput(string path = default, string content = default, decimal type = default, string title = default)
        {
            // to ensure "path" is required (not null)
            if (path == null)
            {
                throw new ArgumentNullException("path is a required property for NewAiAttachmentsSaveFileRequestInput and cannot be null");
            }
            this.Path = path;
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new ArgumentNullException("content is a required property for NewAiAttachmentsSaveFileRequestInput and cannot be null");
            }
            this.Content = content;
            this.Type = type;
            this.Title = title;
        }

        /// <summary>
        /// Storage path/key of the file.
        /// </summary>
        /// <value>Storage path/key of the file.</value>
        [DataMember(Name = "path", IsRequired = true, EmitDefaultValue = true)]
        public string Path { get; set; }

        /// <summary>
        /// File contents.
        /// </summary>
        /// <value>File contents.</value>
        [DataMember(Name = "content", IsRequired = true, EmitDefaultValue = true)]
        public string Content { get; set; }

        /// <summary>
        /// File type discriminator.
        /// </summary>
        /// <value>File type discriminator.</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public decimal Type { get; set; }

        /// <summary>
        /// Optional display title.
        /// </summary>
        /// <value>Optional display title.</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewAiAttachmentsSaveFileRequestInput {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
