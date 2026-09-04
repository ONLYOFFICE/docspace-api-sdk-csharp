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
    /// Data transfer object that encapsulates comprehensive pricing information for various AI services.  Provides organized collections of pricing details for chat models, embedding services, and web search functionality,  along with the currency in which prices are denominated.
    /// </summary>
    [DataContract(Name = "AiPricesDto")]
    public partial class AiPricesDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiPricesDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiPricesDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiPricesDto" /> class.
        /// </summary>
        /// <param name="chat">Gets the list of pricing entries for AI chat models. (required).</param>
        /// <param name="embedding">Gets the list of pricing entries for AI embedding models. (required).</param>
        /// <param name="image">Gets the list of pricing entries for AI image models. (required).</param>
        /// <param name="webSearch">Gets the list of pricing entries for AI web search operations. (required).</param>
        /// <param name="currency">Gets the currency information for the AI pricing data. (required).</param>
        public AiPricesDto(List<AiEntryPricingDtoAiChatPriceDto> chat = default, List<AiEntryPricingDtoAiEmbeddingPriceDto> embedding = default, List<AiEntryPricingDtoAiImagePriceDto> image = default, List<AiEntryPricingDtoDecimal> webSearch = default, CurrencyInfo currency = default)
        {
            // to ensure "chat" is required (not null)
            if (chat == null)
            {
                throw new ArgumentNullException("chat is a required property for AiPricesDto and cannot be null");
            }
            this.Chat = chat;
            // to ensure "embedding" is required (not null)
            if (embedding == null)
            {
                throw new ArgumentNullException("embedding is a required property for AiPricesDto and cannot be null");
            }
            this.Embedding = embedding;
            // to ensure "image" is required (not null)
            if (image == null)
            {
                throw new ArgumentNullException("image is a required property for AiPricesDto and cannot be null");
            }
            this.Image = image;
            // to ensure "webSearch" is required (not null)
            if (webSearch == null)
            {
                throw new ArgumentNullException("webSearch is a required property for AiPricesDto and cannot be null");
            }
            this.WebSearch = webSearch;
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for AiPricesDto and cannot be null");
            }
            this.Currency = currency;
        }

        /// <summary>
        /// Gets the list of pricing entries for AI chat models.
        /// </summary>
        /// <example>[{"id":"gpt-4o","alias":"GPT-4o","provider":"openai","image":"https://cdn.example.com/providers/openai.png","price":{"prompt":5.0,"completion":15.0}}]</example>
        [DataMember(Name = "chat", IsRequired = true, EmitDefaultValue = true)]
        public List<AiEntryPricingDtoAiChatPriceDto> Chat { get; set; }

        /// <summary>
        /// Gets the list of pricing entries for AI embedding models.
        /// </summary>
        /// <example>[{"id":"text-embedding-3-large","alias":"Text Embedding 3 Large","provider":"openai","image":"https://cdn.example.com/providers/openai.png","price":{"prompt":0.13}}]</example>
        [DataMember(Name = "embedding", IsRequired = true, EmitDefaultValue = true)]
        public List<AiEntryPricingDtoAiEmbeddingPriceDto> Embedding { get; set; }

        /// <summary>
        /// Gets the list of pricing entries for AI image models.
        /// </summary>
        /// <example>[{"id":"gpt-5.4-image-2","alias":"GPT 5.4 Image 2","provider":"OpenRouter","image":"https://cdn.example.com/providers/openai.png","price":{"prompt":8.0,"completion":15.0,"image":30.0}}]</example>
        [DataMember(Name = "image", IsRequired = true, EmitDefaultValue = true)]
        public List<AiEntryPricingDtoAiImagePriceDto> Image { get; set; }

        /// <summary>
        /// Gets the list of pricing entries for AI web search operations.
        /// </summary>
        /// <example>[{"id":"web-search","alias":"Web Search","provider":"tavily","image":"https://cdn.example.com/providers/tavily.png","price":0.01}]</example>
        [DataMember(Name = "webSearch", IsRequired = true, EmitDefaultValue = true)]
        public List<AiEntryPricingDtoDecimal> WebSearch { get; set; }

        /// <summary>
        /// Gets the currency information for the AI pricing data.
        /// </summary>
        [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
        public CurrencyInfo Currency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiPricesDto {\n");
            sb.Append("  Chat: ").Append(Chat).Append("\n");
            sb.Append("  Embedding: ").Append(Embedding).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  WebSearch: ").Append(WebSearch).Append("\n");
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
