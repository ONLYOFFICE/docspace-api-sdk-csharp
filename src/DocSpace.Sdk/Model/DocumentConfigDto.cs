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


 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The document config parameters.
    /// </summary>
    [DataContract(Name = "DocumentConfigDto")]
    public partial class DocumentConfigDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentConfigDto" /> class.
        /// </summary>
        /// <param name="fileType">The file type of the document..</param>
        /// <param name="info">info.</param>
        /// <param name="isLinkedForMe">Specifies if the documnet is linked for current user..</param>
        /// <param name="key">The document key..</param>
        /// <param name="permissions">permissions.</param>
        /// <param name="sharedLinkParam">The shared link parameter of the document..</param>
        /// <param name="sharedLinkKey">The shared link key of the document..</param>
        /// <param name="referenceData">referenceData.</param>
        /// <param name="title">The document title..</param>
        /// <param name="url">The document url..</param>
        /// <param name="isForm">Indicates whether this is a form..</param>
        /// <param name="options">options.</param>
        public DocumentConfigDto(string fileType = default, InfoConfigDto info = default, bool isLinkedForMe = default, string key = default, PermissionsConfig permissions = default, string sharedLinkParam = default, string sharedLinkKey = default, FileReferenceData referenceData = default, string title = default, string url = default, bool isForm = default, Options options = default)
        {
            this.FileType = fileType;
            this.Info = info;
            this.IsLinkedForMe = isLinkedForMe;
            this.Key = key;
            this.Permissions = permissions;
            this.SharedLinkParam = sharedLinkParam;
            this.SharedLinkKey = sharedLinkKey;
            this.ReferenceData = referenceData;
            this.Title = title;
            this.Url = url;
            this.IsForm = isForm;
            this.Options = options;
        }

        /// <summary>
        /// The file type of the document.
        /// </summary>
        /// <value>The file type of the document.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "fileType", EmitDefaultValue = true)]
        public string FileType { get; set; }

        /// <summary>
        /// Gets or Sets Info
        /// </summary>
        [DataMember(Name = "info", EmitDefaultValue = false)]
        public InfoConfigDto Info { get; set; }

        /// <summary>
        /// Specifies if the documnet is linked for current user.
        /// </summary>
        /// <value>Specifies if the documnet is linked for current user.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isLinkedForMe", EmitDefaultValue = true)]
        public bool IsLinkedForMe { get; set; }

        /// <summary>
        /// The document key.
        /// </summary>
        /// <value>The document key.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name = "permissions", EmitDefaultValue = false)]
        public PermissionsConfig Permissions { get; set; }

        /// <summary>
        /// The shared link parameter of the document.
        /// </summary>
        /// <value>The shared link parameter of the document.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "sharedLinkParam", EmitDefaultValue = true)]
        public string SharedLinkParam { get; set; }

        /// <summary>
        /// The shared link key of the document.
        /// </summary>
        /// <value>The shared link key of the document.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "sharedLinkKey", EmitDefaultValue = true)]
        public string SharedLinkKey { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceData
        /// </summary>
        [DataMember(Name = "referenceData", EmitDefaultValue = false)]
        public FileReferenceData ReferenceData { get; set; }

        /// <summary>
        /// The document title.
        /// </summary>
        /// <value>The document title.</value>
        /*
        <example>legacy_1080p_small_wooden_mouse</example>
        */
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The document url.
        /// </summary>
        /// <value>The document url.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Indicates whether this is a form.
        /// </summary>
        /// <value>Indicates whether this is a form.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isForm", EmitDefaultValue = true)]
        public bool IsForm { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public Options Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DocumentConfigDto {\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  IsLinkedForMe: ").Append(IsLinkedForMe).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  SharedLinkParam: ").Append(SharedLinkParam).Append("\n");
            sb.Append("  SharedLinkKey: ").Append(SharedLinkKey).Append("\n");
            sb.Append("  ReferenceData: ").Append(ReferenceData).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  IsForm: ").Append(IsForm).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
