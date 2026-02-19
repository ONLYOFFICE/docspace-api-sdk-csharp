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
    /// Parameters for updating an AI provider&#39;s configuration.
    /// </summary>
    [DataContract(Name = "UpdateProviderBody")]
    public partial class UpdateProviderBody : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProviderBody" /> class.
        /// </summary>
        /// <param name="title">The new display title for the AI provider. If null, the title is not changed..</param>
        /// <param name="url">The new API endpoint URL for the AI provider. If null, the URL is not changed..</param>
        /// <param name="key">The new authentication API key for the AI provider. If null, the key is not changed..</param>
        public UpdateProviderBody(string title = default, string url = default, string key = default)
        {
            this.Title = title;
            this.Url = url;
            this.Key = key;
        }

        /// <summary>
        /// The new display title for the AI provider. If null, the title is not changed.
        /// </summary>
        /// <value>The new display title for the AI provider. If null, the title is not changed.</value>
        /*
        <example>SampleFile</example>
        */
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// The new API endpoint URL for the AI provider. If null, the URL is not changed.
        /// </summary>
        /// <value>The new API endpoint URL for the AI provider. If null, the URL is not changed.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "url", EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// The new authentication API key for the AI provider. If null, the key is not changed.
        /// </summary>
        /// <value>The new authentication API key for the AI provider. If null, the key is not changed.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateProviderBody {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
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
