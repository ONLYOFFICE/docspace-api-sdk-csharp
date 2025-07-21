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
    /// The file editing history URL parameters.
    /// </summary>
    [DataContract(Name = "EditHistoryUrl")]
    public partial class EditHistoryUrl : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EditHistoryUrl" /> class.
        /// </summary>
        /// <param name="key">The document identifier of the previous version of the document..</param>
        /// <param name="url">The url address of the previous version of the document..</param>
        /// <param name="fileType">The document extension..</param>
        public EditHistoryUrl(string key = default, string url = default, string fileType = default)
        {
            this.Key = key;
            this.Url = url;
            this.FileType = fileType;
        }

        /// <summary>
        /// The document identifier of the previous version of the document.
        /// </summary>
        /// <value>The document identifier of the previous version of the document.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// The url address of the previous version of the document.
        /// </summary>
        /// <value>The url address of the previous version of the document.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// The document extension.
        /// </summary>
        /// <value>The document extension.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "fileType", EmitDefaultValue = true)]
        public string FileType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EditHistoryUrl {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
