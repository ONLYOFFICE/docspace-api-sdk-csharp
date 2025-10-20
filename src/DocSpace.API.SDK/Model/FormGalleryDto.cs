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
    /// The form gallery parameters.
    /// </summary>
    [DataContract(Name = "FormGalleryDto")]
    public partial class FormGalleryDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FormGalleryDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FormGalleryDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FormGalleryDto" /> class.
        /// </summary>
        /// <param name="path">The form gallery path. (required).</param>
        /// <param name="domain">The form gallery domain. (required).</param>
        /// <param name="ext">The form gallery extension. (required).</param>
        /// <param name="uploadPath">The form gallery upload path. (required).</param>
        /// <param name="uploadDomain">The form gallery upload domain. (required).</param>
        /// <param name="uploadExt">The form gallery upload extension. (required).</param>
        /// <param name="uploadDashboard">The form gallery upload dashboard. (required).</param>
        public FormGalleryDto(string path = default, string domain = default, string ext = default, string uploadPath = default, string uploadDomain = default, string uploadExt = default, string uploadDashboard = default)
        {
            // to ensure "path" is required (not null)
            if (path == null)
            {
                throw new ArgumentNullException("path is a required property for FormGalleryDto and cannot be null");
            }
            this.Path = path;
            // to ensure "domain" is required (not null)
            if (domain == null)
            {
                throw new ArgumentNullException("domain is a required property for FormGalleryDto and cannot be null");
            }
            this.Domain = domain;
            // to ensure "ext" is required (not null)
            if (ext == null)
            {
                throw new ArgumentNullException("ext is a required property for FormGalleryDto and cannot be null");
            }
            this.Ext = ext;
            // to ensure "uploadPath" is required (not null)
            if (uploadPath == null)
            {
                throw new ArgumentNullException("uploadPath is a required property for FormGalleryDto and cannot be null");
            }
            this.UploadPath = uploadPath;
            // to ensure "uploadDomain" is required (not null)
            if (uploadDomain == null)
            {
                throw new ArgumentNullException("uploadDomain is a required property for FormGalleryDto and cannot be null");
            }
            this.UploadDomain = uploadDomain;
            // to ensure "uploadExt" is required (not null)
            if (uploadExt == null)
            {
                throw new ArgumentNullException("uploadExt is a required property for FormGalleryDto and cannot be null");
            }
            this.UploadExt = uploadExt;
            // to ensure "uploadDashboard" is required (not null)
            if (uploadDashboard == null)
            {
                throw new ArgumentNullException("uploadDashboard is a required property for FormGalleryDto and cannot be null");
            }
            this.UploadDashboard = uploadDashboard;
        }

        /// <summary>
        /// The form gallery path.
        /// </summary>
        /// <value>The form gallery path.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "path", IsRequired = true, EmitDefaultValue = true)]
        public string Path { get; set; }

        /// <summary>
        /// The form gallery domain.
        /// </summary>
        /// <value>The form gallery domain.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "domain", IsRequired = true, EmitDefaultValue = true)]
        public string Domain { get; set; }

        /// <summary>
        /// The form gallery extension.
        /// </summary>
        /// <value>The form gallery extension.</value>
        /*
        <example>.txt</example>
        */
        [DataMember(Name = "ext", IsRequired = true, EmitDefaultValue = true)]
        public string Ext { get; set; }

        /// <summary>
        /// The form gallery upload path.
        /// </summary>
        /// <value>The form gallery upload path.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "uploadPath", IsRequired = true, EmitDefaultValue = true)]
        public string UploadPath { get; set; }

        /// <summary>
        /// The form gallery upload domain.
        /// </summary>
        /// <value>The form gallery upload domain.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "uploadDomain", IsRequired = true, EmitDefaultValue = true)]
        public string UploadDomain { get; set; }

        /// <summary>
        /// The form gallery upload extension.
        /// </summary>
        /// <value>The form gallery upload extension.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "uploadExt", IsRequired = true, EmitDefaultValue = true)]
        public string UploadExt { get; set; }

        /// <summary>
        /// The form gallery upload dashboard.
        /// </summary>
        /// <value>The form gallery upload dashboard.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "uploadDashboard", IsRequired = true, EmitDefaultValue = true)]
        public string UploadDashboard { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormGalleryDto {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Ext: ").Append(Ext).Append("\n");
            sb.Append("  UploadPath: ").Append(UploadPath).Append("\n");
            sb.Append("  UploadDomain: ").Append(UploadDomain).Append("\n");
            sb.Append("  UploadExt: ").Append(UploadExt).Append("\n");
            sb.Append("  UploadDashboard: ").Append(UploadDashboard).Append("\n");
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
