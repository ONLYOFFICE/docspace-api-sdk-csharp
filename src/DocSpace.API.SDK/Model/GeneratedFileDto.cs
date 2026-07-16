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
    /// Information about a file created by an AI editor generation tool.
    /// </summary>
    [DataContract(Name = "GeneratedFileDto")]
    public partial class GeneratedFileDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedFileDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GeneratedFileDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneratedFileDto" /> class.
        /// </summary>
        /// <param name="id">The unique identifier of the created file..</param>
        /// <param name="title">The file title, including extension. (required).</param>
        /// <param name="extension">The file extension. (required).</param>
        public GeneratedFileDto(int id = default, string title = default, string extension = default)
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for GeneratedFileDto and cannot be null");
            }
            this.Title = title;
            // to ensure "extension" is required (not null)
            if (extension == null)
            {
                throw new ArgumentNullException("extension is a required property for GeneratedFileDto and cannot be null");
            }
            this.Extension = extension;
            this.Id = id;
        }

        /// <summary>
        /// The unique identifier of the created file.
        /// </summary>
        /// <value>The unique identifier of the created file.</value>
        /*
        <example>42</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The file title, including extension.
        /// </summary>
        /// <value>The file title, including extension.</value>
        /*
        <example>Report.docx</example>
        */
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The file extension.
        /// </summary>
        /// <value>The file extension.</value>
        /*
        <example>.docx</example>
        */
        [DataMember(Name = "extension", IsRequired = true, EmitDefaultValue = true)]
        public string Extension { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GeneratedFileDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Extension: ").Append(Extension).Append("\n");
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
