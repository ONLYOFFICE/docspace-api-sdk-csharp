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
    /// Default templates settings request parameters.
    /// </summary>
    [DataContract(Name = "DefaultTemplateSettingsRequestDto")]
    public partial class DefaultTemplateSettingsRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultTemplateSettingsRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DefaultTemplateSettingsRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultTemplateSettingsRequestDto" /> class.
        /// </summary>
        /// <param name="selectedFile">File id to replace template with (or null to use default template).</param>
        /// <param name="fileExtension">File extension of a template to replace (required).</param>
        public DefaultTemplateSettingsRequestDto(int? selectedFile = default, string fileExtension = default)
        {
            // to ensure "fileExtension" is required (not null)
            if (fileExtension == null)
            {
                throw new ArgumentNullException("fileExtension is a required property for DefaultTemplateSettingsRequestDto and cannot be null");
            }
            this.FileExtension = fileExtension;
            this.SelectedFile = selectedFile;
        }

        /// <summary>
        /// File id to replace template with (or null to use default template)
        /// </summary>
        /// <value>File id to replace template with (or null to use default template)</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "selectedFile", EmitDefaultValue = true)]
        public int? SelectedFile { get; set; }

        /// <summary>
        /// File extension of a template to replace
        /// </summary>
        /// <value>File extension of a template to replace</value>
        /*
        <example>.txt</example>
        */
        [DataMember(Name = "fileExtension", IsRequired = true, EmitDefaultValue = true)]
        public string FileExtension { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DefaultTemplateSettingsRequestDto {\n");
            sb.Append("  SelectedFile: ").Append(SelectedFile).Append("\n");
            sb.Append("  FileExtension: ").Append(FileExtension).Append("\n");
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
            yield break;
        }

    }


}
