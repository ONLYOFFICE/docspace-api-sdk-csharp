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
    /// One AI model or service on the price list: how to name it, who provides it, and what it costs.
    /// </summary>
    [DataContract(Name = "AiEntryPricingDtoAiImagePriceDto")]
    public partial class AiEntryPricingDtoAiImagePriceDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiEntryPricingDtoAiImagePriceDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiEntryPricingDtoAiImagePriceDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiEntryPricingDtoAiImagePriceDto" /> class.
        /// </summary>
        /// <param name="id">The model identifier to send to the AI operations. It is the value to branch on, while &#x60;alias&#x60; is for display  only. (required).</param>
        /// <param name="alias">The model name as the vendor writes it, meant to be shown to a person rather than matched on. (required).</param>
        /// <param name="provider">Who runs the model. Two entries can share a provider, and one provider&#39;s models can be priced quite  differently, so the price always belongs to the entry and never to the provider. (required).</param>
        /// <param name="image">The absolute URL of the provider&#39;s icon, for rendering next to the entry. (required).</param>
        /// <param name="price">What the entry costs, in the currency the answer names. Amounts per token are normalised per million  tokens, so they are not the price of a single call. (required).</param>
        /// <param name="link">The provider&#39;s own page for the model, for a person to read the model&#39;s terms. It is empty when the  provider publishes none. (required).</param>
        public AiEntryPricingDtoAiImagePriceDto(string id = default, string alias = default, string provider = default, string image = default, AiImagePriceDto price = default, string link = default)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for AiEntryPricingDtoAiImagePriceDto and cannot be null");
            }
            this.Id = id;
            // to ensure "alias" is required (not null)
            if (alias == null)
            {
                throw new ArgumentNullException("alias is a required property for AiEntryPricingDtoAiImagePriceDto and cannot be null");
            }
            this.Alias = alias;
            // to ensure "provider" is required (not null)
            if (provider == null)
            {
                throw new ArgumentNullException("provider is a required property for AiEntryPricingDtoAiImagePriceDto and cannot be null");
            }
            this.Provider = provider;
            // to ensure "image" is required (not null)
            if (image == null)
            {
                throw new ArgumentNullException("image is a required property for AiEntryPricingDtoAiImagePriceDto and cannot be null");
            }
            this.Image = image;
            // to ensure "price" is required (not null)
            if (price == null)
            {
                throw new ArgumentNullException("price is a required property for AiEntryPricingDtoAiImagePriceDto and cannot be null");
            }
            this.Price = price;
            // to ensure "link" is required (not null)
            if (link == null)
            {
                throw new ArgumentNullException("link is a required property for AiEntryPricingDtoAiImagePriceDto and cannot be null");
            }
            this.Link = link;
        }

        /// <summary>
        /// The model identifier to send to the AI operations. It is the value to branch on, while &#x60;alias&#x60; is for display  only.
        /// </summary>
        /// <example>gpt-4o</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The model name as the vendor writes it, meant to be shown to a person rather than matched on.
        /// </summary>
        /// <example>GPT-4o</example>
        [DataMember(Name = "alias", IsRequired = true, EmitDefaultValue = true)]
        public string Alias { get; set; }

        /// <summary>
        /// Who runs the model. Two entries can share a provider, and one provider&#39;s models can be priced quite  differently, so the price always belongs to the entry and never to the provider.
        /// </summary>
        /// <example>openai</example>
        [DataMember(Name = "provider", IsRequired = true, EmitDefaultValue = true)]
        public string Provider { get; set; }

        /// <summary>
        /// The absolute URL of the provider&#39;s icon, for rendering next to the entry.
        /// </summary>
        /// <example>https://cdn.example.com/providers/openai.png</example>
        [DataMember(Name = "image", IsRequired = true, EmitDefaultValue = true)]
        public string Image { get; set; }

        /// <summary>
        /// What the entry costs, in the currency the answer names. Amounts per token are normalised per million  tokens, so they are not the price of a single call.
        /// </summary>
        [DataMember(Name = "price", IsRequired = true, EmitDefaultValue = true)]
        public AiImagePriceDto Price { get; set; }

        /// <summary>
        /// The provider&#39;s own page for the model, for a person to read the model&#39;s terms. It is empty when the  provider publishes none.
        /// </summary>
        /// <example>https://openai.com/pricing</example>
        [DataMember(Name = "link", IsRequired = true, EmitDefaultValue = true)]
        public string Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiEntryPricingDtoAiImagePriceDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
