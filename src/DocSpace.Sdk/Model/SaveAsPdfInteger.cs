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
    /// The parameters for saving the file as PDF.
    /// </summary>
    [DataContract(Name = "SaveAsPdfInteger")]
    public partial class SaveAsPdfInteger : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveAsPdfInteger" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SaveAsPdfInteger() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveAsPdfInteger" /> class.
        /// </summary>
        /// <param name="folderId">The folder ID to save the file as PDF. (required).</param>
        /// <param name="title">The file title to save as PDF. (required).</param>
        public SaveAsPdfInteger(int folderId = default, string title = default)
        {
            this.FolderId = folderId;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for SaveAsPdfInteger and cannot be null");
            }
            this.Title = title;
        }

        /// <summary>
        /// The folder ID to save the file as PDF.
        /// </summary>
        /// <value>The folder ID to save the file as PDF.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "folderId", IsRequired = true, EmitDefaultValue = true)]
        public int FolderId { get; set; }

        /// <summary>
        /// The file title to save as PDF.
        /// </summary>
        /// <value>The file title to save as PDF.</value>
        /*
        <example>legacy_1080p_small_wooden_mouse</example>
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
            sb.Append("class SaveAsPdfInteger {\n");
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
