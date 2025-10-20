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
    /// The file editing history data.
    /// </summary>
    [DataContract(Name = "EditHistoryDataDto")]
    public partial class EditHistoryDataDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EditHistoryDataDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EditHistoryDataDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EditHistoryDataDto" /> class.
        /// </summary>
        /// <param name="changesUrl">The URL address of the file with the document changes data..</param>
        /// <param name="key">The document identifier used to unambiguously identify the document file. (required).</param>
        /// <param name="previous">previous.</param>
        /// <param name="token">The encrypted signature added to the parameter in the form of a token..</param>
        /// <param name="url">The URL address of the current document version. (required).</param>
        /// <param name="version">The document version number. (required).</param>
        /// <param name="fileType">The document extension. (required).</param>
        public EditHistoryDataDto(string changesUrl = default, string key = default, EditHistoryUrl previous = default, string token = default, string url = default, int version = default, string fileType = default)
        {
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new ArgumentNullException("key is a required property for EditHistoryDataDto and cannot be null");
            }
            this.Key = key;
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for EditHistoryDataDto and cannot be null");
            }
            this.Url = url;
            this.@Version = version;
            // to ensure "fileType" is required (not null)
            if (fileType == null)
            {
                throw new ArgumentNullException("fileType is a required property for EditHistoryDataDto and cannot be null");
            }
            this.FileType = fileType;
            this.ChangesUrl = changesUrl;
            this.Previous = previous;
            this.Token = token;
        }

        /// <summary>
        /// The URL address of the file with the document changes data.
        /// </summary>
        /// <value>The URL address of the file with the document changes data.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "changesUrl", EmitDefaultValue = true)]
        public string ChangesUrl { get; set; }

        /// <summary>
        /// The document identifier used to unambiguously identify the document file.
        /// </summary>
        /// <value>The document identifier used to unambiguously identify the document file.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Previous
        /// </summary>
        [DataMember(Name = "previous", EmitDefaultValue = false)]
        public EditHistoryUrl Previous { get; set; }

        /// <summary>
        /// The encrypted signature added to the parameter in the form of a token.
        /// </summary>
        /// <value>The encrypted signature added to the parameter in the form of a token.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "token", EmitDefaultValue = true)]
        public string Token { get; set; }

        /// <summary>
        /// The URL address of the current document version.
        /// </summary>
        /// <value>The URL address of the current document version.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// The document version number.
        /// </summary>
        /// <value>The document version number.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public int @Version { get; set; }

        /// <summary>
        /// The document extension.
        /// </summary>
        /// <value>The document extension.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "fileType", IsRequired = true, EmitDefaultValue = true)]
        public string FileType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EditHistoryDataDto {\n");
            sb.Append("  ChangesUrl: ").Append(ChangesUrl).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Previous: ").Append(Previous).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  @Version: ").Append(@Version).Append("\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
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
