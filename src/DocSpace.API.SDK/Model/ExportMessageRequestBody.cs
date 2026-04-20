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
    /// Parameters for exporting an AI chat message to a document.
    /// </summary>
    [DataContract(Name = "ExportMessageRequestBody")]
    public partial class ExportMessageRequestBody : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportMessageRequestBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExportMessageRequestBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportMessageRequestBody" /> class.
        /// </summary>
        /// <param name="folderId">folderId (required).</param>
        /// <param name="title">The file name (without extension) to use for the exported document. (required).</param>
        public ExportMessageRequestBody(ExportChatRequestBodyFolderId folderId = default, string title = default)
        {
            // to ensure "folderId" is required (not null)
            if (folderId == null)
            {
                throw new ArgumentNullException("folderId is a required property for ExportMessageRequestBody and cannot be null");
            }
            this.FolderId = folderId;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for ExportMessageRequestBody and cannot be null");
            }
            this.Title = title;
        }

        /// <summary>
        /// Gets or Sets FolderId
        /// </summary>
        [DataMember(Name = "folderId", IsRequired = true, EmitDefaultValue = true)]
        public ExportChatRequestBodyFolderId FolderId { get; set; }

        /// <summary>
        /// The file name (without extension) to use for the exported document.
        /// </summary>
        /// <value>The file name (without extension) to use for the exported document.</value>
        /*
        <example>Message Export</example>
        */
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportMessageRequestBody {\n");
            sb.Append("  FolderId: ").Append(FolderId).Append("\n");
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
