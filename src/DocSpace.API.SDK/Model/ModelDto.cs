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
    /// The AI model information.
    /// </summary>
    [DataContract(Name = "ModelDto")]
    public partial class ModelDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ModelDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelDto" /> class.
        /// </summary>
        /// <param name="providerId">The unique identifier of the AI provider that offers this model..</param>
        /// <param name="providerTitle">The human-readable display name of the AI provider (e.g., OpenAI, Anthropic). (required).</param>
        /// <param name="modelId">The model identifier as recognized by the AI provider (e.g., gpt-4o, claude-sonnet-4-20250514). (required).</param>
        /// <param name="alias">The display name for the model..</param>
        /// <param name="capabilities">capabilities.</param>
        /// <param name="price">price.</param>
        /// <param name="currency">currency.</param>
        public ModelDto(int providerId = default, string providerTitle = default, string modelId = default, string alias = default, AiModelCapabilities capabilities = default, AiChatPrice price = default, CurrencyInfo currency = default)
        {
            // to ensure "providerTitle" is required (not null)
            if (providerTitle == null)
            {
                throw new ArgumentNullException("providerTitle is a required property for ModelDto and cannot be null");
            }
            this.ProviderTitle = providerTitle;
            // to ensure "modelId" is required (not null)
            if (modelId == null)
            {
                throw new ArgumentNullException("modelId is a required property for ModelDto and cannot be null");
            }
            this.ModelId = modelId;
            this.ProviderId = providerId;
            this.Alias = alias;
            this.Capabilities = capabilities;
            this.Price = price;
            this.Currency = currency;
        }

        /// <summary>
        /// The unique identifier of the AI provider that offers this model.
        /// </summary>
        /// <value>The unique identifier of the AI provider that offers this model.</value>
        /*
        <example>1</example>
        */
        [DataMember(Name = "providerId", EmitDefaultValue = false)]
        public int ProviderId { get; set; }

        /// <summary>
        /// The human-readable display name of the AI provider (e.g., OpenAI, Anthropic).
        /// </summary>
        /// <value>The human-readable display name of the AI provider (e.g., OpenAI, Anthropic).</value>
        /*
        <example>OpenAI</example>
        */
        [DataMember(Name = "providerTitle", IsRequired = true, EmitDefaultValue = true)]
        public string ProviderTitle { get; set; }

        /// <summary>
        /// The model identifier as recognized by the AI provider (e.g., gpt-4o, claude-sonnet-4-20250514).
        /// </summary>
        /// <value>The model identifier as recognized by the AI provider (e.g., gpt-4o, claude-sonnet-4-20250514).</value>
        /*
        <example>gpt-4o</example>
        */
        [DataMember(Name = "modelId", IsRequired = true, EmitDefaultValue = true)]
        public string ModelId { get; set; }

        /// <summary>
        /// The display name for the model.
        /// </summary>
        /// <value>The display name for the model.</value>
        /*
        <example>GPT-4o</example>
        */
        [DataMember(Name = "alias", EmitDefaultValue = true)]
        public string Alias { get; set; }

        /// <summary>
        /// Gets or Sets Capabilities
        /// </summary>
        [DataMember(Name = "capabilities", EmitDefaultValue = false)]
        public AiModelCapabilities Capabilities { get; set; }

        /// <summary>
        /// Gets or Sets Price
        /// </summary>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public AiChatPrice Price { get; set; }

        /// <summary>
        /// Gets or Sets Currency
        /// </summary>
        [DataMember(Name = "currency", EmitDefaultValue = false)]
        public CurrencyInfo Currency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelDto {\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  ProviderTitle: ").Append(ProviderTitle).Append("\n");
            sb.Append("  ModelId: ").Append(ModelId).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
