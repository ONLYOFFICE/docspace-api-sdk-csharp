/**
 *
 * (c) Copyright Ascensio System SIA 2025
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The parameters for creating a file.
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
        /// <param name="title">The file title for creation. (required).</param>
        /// <param name="templateId">templateId.</param>
        /// <param name="enableExternalExt">Specifies whether to allow creating a file of an external extension or not..</param>
        /// <param name="formId">The form ID for creation..</param>
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
        /// The file title for creation.
        /// </summary>
        /// <value>The file title for creation.</value>
        /*
        <example>legacy_1080p_small_wooden_mouse</example>
        */
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets TemplateId
        /// </summary>
        [DataMember(Name = "templateId", EmitDefaultValue = false)]
        public CreateFileJsonElementTemplateId TemplateId { get; set; }

        /// <summary>
        /// Specifies whether to allow creating a file of an external extension or not.
        /// </summary>
        /// <value>Specifies whether to allow creating a file of an external extension or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "enableExternalExt", EmitDefaultValue = true)]
        public bool EnableExternalExt { get; set; }

        /// <summary>
        /// The form ID for creation.
        /// </summary>
        /// <value>The form ID for creation.</value>
        /*
        <example>1234</example>
        */
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
