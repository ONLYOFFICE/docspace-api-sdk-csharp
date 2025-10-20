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
    /// The file link properties.
    /// </summary>
    [DataContract(Name = "FileLink")]
    public partial class FileLink : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FileLink" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileLink() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileLink" /> class.
        /// </summary>
        /// <param name="filetype">The type of the file for the source viewed or edited document. (required).</param>
        /// <param name="token">The encrypted signature added to the config in the form of a token..</param>
        /// <param name="url">The absolute URL where the source viewed or edited document is stored. (required).</param>
        public FileLink(string filetype = default, string token = default, string url = default)
        {
            // to ensure "filetype" is required (not null)
            if (filetype == null)
            {
                throw new ArgumentNullException("filetype is a required property for FileLink and cannot be null");
            }
            this.Filetype = filetype;
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for FileLink and cannot be null");
            }
            this.Url = url;
            this.Token = token;
        }

        /// <summary>
        /// The type of the file for the source viewed or edited document.
        /// </summary>
        /// <value>The type of the file for the source viewed or edited document.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "filetype", IsRequired = true, EmitDefaultValue = true)]
        public string Filetype { get; set; }

        /// <summary>
        /// The encrypted signature added to the config in the form of a token.
        /// </summary>
        /// <value>The encrypted signature added to the config in the form of a token.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "token", EmitDefaultValue = true)]
        public string Token { get; set; }

        /// <summary>
        /// The absolute URL where the source viewed or edited document is stored.
        /// </summary>
        /// <value>The absolute URL where the source viewed or edited document is stored.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileLink {\n");
            sb.Append("  Filetype: ").Append(Filetype).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
