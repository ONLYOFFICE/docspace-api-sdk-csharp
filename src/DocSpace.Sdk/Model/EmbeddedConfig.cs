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
    /// The configuration parameters for the embedded document type.
    /// </summary>
    [DataContract(Name = "EmbeddedConfig")]
    public partial class EmbeddedConfig : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EmbeddedConfig" /> class.
        /// </summary>
        /// <param name="embedUrl">The absolute URL to the document serving as a source file for the document embedded into the web page..</param>
        /// <param name="shareLinkParam">The shared URL parameter..</param>
        /// <param name="shareUrl">The absolute URL that will allow other users to share this document..</param>
        public EmbeddedConfig(string embedUrl = default, string shareLinkParam = default, string shareUrl = default)
        {
            this.EmbedUrl = embedUrl;
            this.ShareLinkParam = shareLinkParam;
            this.ShareUrl = shareUrl;
        }

        /// <summary>
        /// The absolute URL to the document serving as a source file for the document embedded into the web page.
        /// </summary>
        /// <value>The absolute URL to the document serving as a source file for the document embedded into the web page.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "embedUrl", EmitDefaultValue = true)]
        public string EmbedUrl { get; set; }

        /// <summary>
        /// The absolute URL that will allow the document to be saved onto the user personal computer.
        /// </summary>
        /// <value>The absolute URL that will allow the document to be saved onto the user personal computer.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "saveUrl", EmitDefaultValue = true)]
        public string SaveUrl { get; private set; }

        /// <summary>
        /// Returns false as SaveUrl should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSaveUrl()
        {
            return false;
        }
        /// <summary>
        /// The shared URL parameter.
        /// </summary>
        /// <value>The shared URL parameter.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "shareLinkParam", EmitDefaultValue = true)]
        public string ShareLinkParam { get; set; }

        /// <summary>
        /// The absolute URL that will allow other users to share this document.
        /// </summary>
        /// <value>The absolute URL that will allow other users to share this document.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "shareUrl", EmitDefaultValue = true)]
        public string ShareUrl { get; set; }

        /// <summary>
        /// The place for the embedded viewer toolbar, can be either \&quot;top\&quot; or \&quot;bottom\&quot;.
        /// </summary>
        /// <value>The place for the embedded viewer toolbar, can be either \&quot;top\&quot; or \&quot;bottom\&quot;.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "toolbarDocked", EmitDefaultValue = true)]
        public string ToolbarDocked { get; private set; }

        /// <summary>
        /// Returns false as ToolbarDocked should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeToolbarDocked()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmbeddedConfig {\n");
            sb.Append("  EmbedUrl: ").Append(EmbedUrl).Append("\n");
            sb.Append("  SaveUrl: ").Append(SaveUrl).Append("\n");
            sb.Append("  ShareLinkParam: ").Append(ShareLinkParam).Append("\n");
            sb.Append("  ShareUrl: ").Append(ShareUrl).Append("\n");
            sb.Append("  ToolbarDocked: ").Append(ToolbarDocked).Append("\n");
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
