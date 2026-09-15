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
    /// The parameters of a text or HTML file created from content sent in the request.
    /// </summary>
    [DataContract(Name = "CreateTextOrHtmlFile")]
    public partial class CreateTextOrHtmlFile : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextOrHtmlFile" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateTextOrHtmlFile() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTextOrHtmlFile" /> class.
        /// </summary>
        /// <param name="title">The title of the file. The extension the operation stands for is appended unless the title already ends with  it, so Notes becomes Notes.txt or Notes.html. (required).</param>
        /// <param name="content">The content of the file, as plain text or as HTML markup. A request carrying none is rejected as an invalid  request, and for a text file content that looks like markup makes the portal store it as HTML instead..</param>
        /// <param name="createNewIfExist">What to do when the folder already holds a file of this title, the other way round than the name reads: &#x60;true&#x60;  updates that file and adds a version to its history, &#x60;false&#x60; creates another file and makes its title unique,  as in Notes (1).txt..</param>
        public CreateTextOrHtmlFile(string title = default, string content = default, bool createNewIfExist = default)
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for CreateTextOrHtmlFile and cannot be null");
            }
            this.Title = title;
            this.Content = content;
            this.CreateNewIfExist = createNewIfExist;
        }

        /// <summary>
        /// The title of the file. The extension the operation stands for is appended unless the title already ends with  it, so Notes becomes Notes.txt or Notes.html.
        /// </summary>
        /// <example>Document.txt</example>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The content of the file, as plain text or as HTML markup. A request carrying none is rejected as an invalid  request, and for a text file content that looks like markup makes the portal store it as HTML instead.
        /// </summary>
        /// <example>This is the file content</example>
        [DataMember(Name = "content", EmitDefaultValue = true)]
        public string Content { get; set; }

        /// <summary>
        /// What to do when the folder already holds a file of this title, the other way round than the name reads: &#x60;true&#x60;  updates that file and adds a version to its history, &#x60;false&#x60; creates another file and makes its title unique,  as in Notes (1).txt.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "createNewIfExist", EmitDefaultValue = true)]
        public bool CreateNewIfExist { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTextOrHtmlFile {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  CreateNewIfExist: ").Append(CreateNewIfExist).Append("\n");
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
            if (this.Title != null && this.Title.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Title, length must be greater than 1.", new [] { "Title" });
            }

            yield break;
        }

    }


}
