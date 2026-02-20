// (c) Copyright Ascensio System SIA 2026
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
    /// Parameters for exporting an AI chat session to a document.
    /// </summary>
    [DataContract(Name = "ExportChatRequestBodyInteger")]
    public partial class ExportChatRequestBodyInteger : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportChatRequestBodyInteger" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ExportChatRequestBodyInteger() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ExportChatRequestBodyInteger" /> class.
        /// </summary>
        /// <param name="folderId">The identifier of the destination folder where the exported document will be saved. (required).</param>
        /// <param name="title">The file name (without extension) to use for the exported document. (required).</param>
        public ExportChatRequestBodyInteger(int folderId = default, string title = default)
        {
            this.FolderId = folderId;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for ExportChatRequestBodyInteger and cannot be null");
            }
            this.Title = title;
        }

        /// <summary>
        /// The identifier of the destination folder where the exported document will be saved.
        /// </summary>
        /// <value>The identifier of the destination folder where the exported document will be saved.</value>
        /*
        <example>1</example>
        */
        [DataMember(Name = "folderId", IsRequired = true, EmitDefaultValue = true)]
        public int FolderId { get; set; }

        /// <summary>
        /// The file name (without extension) to use for the exported document.
        /// </summary>
        /// <value>The file name (without extension) to use for the exported document.</value>
        /*
        <example>SampleFile</example>
        */
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExportChatRequestBodyInteger {\n");
            sb.Append("  FolderId: ").Append(FolderId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
