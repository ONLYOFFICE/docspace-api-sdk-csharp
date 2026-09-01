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


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = DocSpace.API.SDK.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.API.SDK.Client.OpenAPIDateConverter;

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// AI model metadata. Describes a single model available from a provider.
    /// </summary>
    [DataContract(Name = "AiModel")]
    public partial class AiModel : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiModel" /> class.
        /// </summary>
        /// <param name="id">Model identifier as used by the provider API (e.g. &#x60;gpt-4o&#x60;, &#x60;claude-sonnet-4-20250514&#x60;). (required).</param>
        /// <param name="name">Human-readable model name for display in the UI. (required).</param>
        /// <param name="provider">Provider that offers this model. (required).</param>
        /// <param name="reasoning">Whether this model supports extended thinking / chain-of-thought reasoning..</param>
        /// <param name="capabilities">Bitmask of model capabilities (Chat, Image, Vision, Tools, etc.). Used to filter models per &#x60;ActionType&#x60;..</param>
        public AiModel(string id = default, string name = default, AiProviderType provider = default, bool reasoning = default, decimal capabilities = default)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for AiModel and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AiModel and cannot be null");
            }
            this.Name = name;
            // to ensure "provider" is required (not null)
            if (provider == null)
            {
                throw new ArgumentNullException("provider is a required property for AiModel and cannot be null");
            }
            this.Provider = provider;
            this.Reasoning = reasoning;
            this.Capabilities = capabilities;
        }

        /// <summary>
        /// Model identifier as used by the provider API (e.g. &#x60;gpt-4o&#x60;, &#x60;claude-sonnet-4-20250514&#x60;).
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Human-readable model name for display in the UI.
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Provider that offers this model.
        /// </summary>
        [DataMember(Name = "provider", IsRequired = true, EmitDefaultValue = true)]
        public AiProviderType Provider { get; set; }

        /// <summary>
        /// Whether this model supports extended thinking / chain-of-thought reasoning.
        /// </summary>
        [DataMember(Name = "reasoning", EmitDefaultValue = true)]
        public bool Reasoning { get; set; }

        /// <summary>
        /// Bitmask of model capabilities (Chat, Image, Vision, Tools, etc.). Used to filter models per &#x60;ActionType&#x60;.
        /// </summary>
        [DataMember(Name = "capabilities", EmitDefaultValue = false)]
        public decimal Capabilities { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiModel {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Reasoning: ").Append(Reasoning).Append("\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
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
