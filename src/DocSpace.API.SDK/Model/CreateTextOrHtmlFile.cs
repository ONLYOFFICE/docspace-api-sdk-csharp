// (c) Copyright Ascensio System SIA 2025
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

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// The parameters for creating an HTML or text file.
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
        /// <param name="title">The file title for text or HTML file. (required).</param>
        /// <param name="content">The text or HTML file contents..</param>
        /// <param name="createNewIfExist">Specifies whether to create a new text or HTML file if it exists or not..</param>
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
        /// The file title for text or HTML file.
        /// </summary>
        /// <value>The file title for text or HTML file.</value>
        /*
        <example>legacy_1080p_small_wooden_mouse</example>
        */
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The text or HTML file contents.
        /// </summary>
        /// <value>The text or HTML file contents.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "content", EmitDefaultValue = true)]
        public string Content { get; set; }

        /// <summary>
        /// Specifies whether to create a new text or HTML file if it exists or not.
        /// </summary>
        /// <value>Specifies whether to create a new text or HTML file if it exists or not.</value>
        /*
        <example>true</example>
        */
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
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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
