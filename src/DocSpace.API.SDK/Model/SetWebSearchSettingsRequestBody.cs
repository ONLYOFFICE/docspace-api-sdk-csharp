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
    /// Parameters for configuring web search settings.
    /// </summary>
    [DataContract(Name = "SetWebSearchSettingsRequestBody")]
    public partial class SetWebSearchSettingsRequestBody : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public EngineType? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SetWebSearchSettingsRequestBody" /> class.
        /// </summary>
        /// <param name="enabled">Indicates whether web search is enabled for AI chat sessions..</param>
        /// <param name="type">type.</param>
        /// <param name="key">The API key for the selected web search engine. Pass null to keep the existing key unchanged..</param>
        public SetWebSearchSettingsRequestBody(bool enabled = default, EngineType? type = default, string key = default)
        {
            this.Enabled = enabled;
            this.Type = type;
            this.Key = key;
        }

        /// <summary>
        /// Indicates whether web search is enabled for AI chat sessions.
        /// </summary>
        /// <value>Indicates whether web search is enabled for AI chat sessions.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// The API key for the selected web search engine. Pass null to keep the existing key unchanged.
        /// </summary>
        /// <value>The API key for the selected web search engine. Pass null to keep the existing key unchanged.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetWebSearchSettingsRequestBody {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
