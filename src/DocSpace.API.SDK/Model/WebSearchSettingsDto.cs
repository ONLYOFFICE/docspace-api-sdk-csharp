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
    /// WebSearchSettingsDto
    /// </summary>
    [DataContract(Name = "WebSearchSettingsDto")]
    public partial class WebSearchSettingsDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public EngineType? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebSearchSettingsDto" /> class.
        /// </summary>
        /// <param name="enabled">Indicates whether web search is currently enabled..</param>
        /// <param name="type">type.</param>
        /// <param name="needReset">Indicates whether the web search API key needs to be reconfigured..</param>
        public WebSearchSettingsDto(bool enabled = default, EngineType? type = default, bool needReset = default)
        {
            this.Enabled = enabled;
            this.Type = type;
            this.NeedReset = needReset;
        }

        /// <summary>
        /// Indicates whether web search is currently enabled.
        /// </summary>
        /// <value>Indicates whether web search is currently enabled.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Indicates whether the web search API key needs to be reconfigured.
        /// </summary>
        /// <value>Indicates whether the web search API key needs to be reconfigured.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "needReset", EmitDefaultValue = true)]
        public bool NeedReset { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebSearchSettingsDto {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  NeedReset: ").Append(NeedReset).Append("\n");
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
