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
    /// NewAiExportTextToDocxRequest
    /// </summary>
    [DataContract(Name = "newAiExportTextToDocx_request")]
    public partial class NewAiExportTextToDocxRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiExportTextToDocxRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewAiExportTextToDocxRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiExportTextToDocxRequest" /> class.
        /// </summary>
        /// <param name="title">Document title (also the file name). (required).</param>
        /// <param name="content">Markdown content to convert. (required).</param>
        /// <param name="folderId">folderId (required).</param>
        public NewAiExportTextToDocxRequest(string title = default, string content = default, NewAiExportTextToDocxRequestFolderId folderId = default)
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for NewAiExportTextToDocxRequest and cannot be null");
            }
            this.Title = title;
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new ArgumentNullException("content is a required property for NewAiExportTextToDocxRequest and cannot be null");
            }
            this.Content = content;
            // to ensure "folderId" is required (not null)
            if (folderId == null)
            {
                throw new ArgumentNullException("folderId is a required property for NewAiExportTextToDocxRequest and cannot be null");
            }
            this.FolderId = folderId;
        }

        /// <summary>
        /// Document title (also the file name).
        /// </summary>
        /// <value>Document title (also the file name).</value>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Markdown content to convert.
        /// </summary>
        /// <value>Markdown content to convert.</value>
        [DataMember(Name = "content", IsRequired = true, EmitDefaultValue = true)]
        public string Content { get; set; }

        /// <summary>
        /// Gets or Sets FolderId
        /// </summary>
        [DataMember(Name = "folderId", IsRequired = true, EmitDefaultValue = true)]
        public NewAiExportTextToDocxRequestFolderId FolderId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewAiExportTextToDocxRequest {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  FolderId: ").Append(FolderId).Append("\n");
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
