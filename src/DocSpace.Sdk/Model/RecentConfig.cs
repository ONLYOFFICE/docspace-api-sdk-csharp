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
    /// The presence or absence of the documents in the \&quot;Open Recent...\&quot; menu option.
    /// </summary>
    [DataContract(Name = "RecentConfig")]
    public partial class RecentConfig : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RecentConfig" /> class.
        /// </summary>
        /// <param name="folder">The folder where the document is stored..</param>
        /// <param name="title">The document title that will be displayed in the Open Recent... menu option..</param>
        /// <param name="url">The absolute URL to the document where it is stored..</param>
        public RecentConfig(string folder = default, string title = default, string url = default)
        {
            this.Folder = folder;
            this.Title = title;
            this.Url = url;
        }

        /// <summary>
        /// The folder where the document is stored.
        /// </summary>
        /// <value>The folder where the document is stored.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "folder", EmitDefaultValue = true)]
        public string Folder { get; set; }

        /// <summary>
        /// The document title that will be displayed in the Open Recent... menu option.
        /// </summary>
        /// <value>The document title that will be displayed in the Open Recent... menu option.</value>
        /*
        <example>legacy_1080p_small_wooden_mouse</example>
        */
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The absolute URL to the document where it is stored.
        /// </summary>
        /// <value>The absolute URL to the document where it is stored.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecentConfig {\n");
            sb.Append("  Folder: ").Append(Folder).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
