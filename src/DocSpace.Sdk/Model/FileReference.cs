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
    /// The file reference parameters.
    /// </summary>
    [DataContract(Name = "FileReference")]
    public partial class FileReference : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FileReference" /> class.
        /// </summary>
        /// <param name="referenceData">referenceData.</param>
        /// <param name="error">The error message text..</param>
        /// <param name="path">The file name or relative path for the formula editor..</param>
        /// <param name="url">The URL address to download the current file..</param>
        /// <param name="fileType">An extension of the document specified with the url parameter..</param>
        /// <param name="key">The unique document identifier used by the service to take the data from the co-editing session..</param>
        /// <param name="link">The file URL..</param>
        /// <param name="token">The encrypted signature added to the parameter in the form of a token..</param>
        public FileReference(FileReferenceData referenceData = default, string error = default, string path = default, string url = default, string fileType = default, string key = default, string link = default, string token = default)
        {
            this.ReferenceData = referenceData;
            this.Error = error;
            this.Path = path;
            this.Url = url;
            this.FileType = fileType;
            this.Key = key;
            this.Link = link;
            this.Token = token;
        }

        /// <summary>
        /// Gets or Sets ReferenceData
        /// </summary>
        [DataMember(Name = "referenceData", EmitDefaultValue = false)]
        public FileReferenceData ReferenceData { get; set; }

        /// <summary>
        /// The error message text.
        /// </summary>
        /// <value>The error message text.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// The file name or relative path for the formula editor.
        /// </summary>
        /// <value>The file name or relative path for the formula editor.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "path", EmitDefaultValue = true)]
        public string Path { get; set; }

        /// <summary>
        /// The URL address to download the current file.
        /// </summary>
        /// <value>The URL address to download the current file.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// An extension of the document specified with the url parameter.
        /// </summary>
        /// <value>An extension of the document specified with the url parameter.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "fileType", EmitDefaultValue = true)]
        public string FileType { get; set; }

        /// <summary>
        /// The unique document identifier used by the service to take the data from the co-editing session.
        /// </summary>
        /// <value>The unique document identifier used by the service to take the data from the co-editing session.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// The file URL.
        /// </summary>
        /// <value>The file URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "link", EmitDefaultValue = true)]
        public string Link { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileReference {\n");
            sb.Append("  ReferenceData: ").Append(ReferenceData).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
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
