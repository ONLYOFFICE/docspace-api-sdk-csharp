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
    /// The AI price list: per-model pricing for every model kind, in a single currency.
    /// </summary>
    [DataContract(Name = "AiPricesResponse")]
    public partial class AiPricesResponse : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiPricesResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiPricesResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiPricesResponse" /> class.
        /// </summary>
        /// <param name="chat">The pricing of every available chat model. (required).</param>
        /// <param name="embedding">The pricing of every available embedding model. (required).</param>
        /// <param name="image">The pricing of every available image model. (required).</param>
        /// <param name="search">The pricing of every available web search provider. (required).</param>
        /// <param name="currency">The currency the AI prices are quoted in. (required).</param>
        public AiPricesResponse(List<AiChatModelPricing> chat = default, List<AiEmbeddingModelPricing> embedding = default, List<AiImageModelPricing> image = default, List<AiWebSearchPricing> search = default, CurrencyInfo currency = default)
        {
            // to ensure "chat" is required (not null)
            if (chat == null)
            {
                throw new ArgumentNullException("chat is a required property for AiPricesResponse and cannot be null");
            }
            this.Chat = chat;
            // to ensure "embedding" is required (not null)
            if (embedding == null)
            {
                throw new ArgumentNullException("embedding is a required property for AiPricesResponse and cannot be null");
            }
            this.Embedding = embedding;
            // to ensure "image" is required (not null)
            if (image == null)
            {
                throw new ArgumentNullException("image is a required property for AiPricesResponse and cannot be null");
            }
            this.Image = image;
            // to ensure "search" is required (not null)
            if (search == null)
            {
                throw new ArgumentNullException("search is a required property for AiPricesResponse and cannot be null");
            }
            this.Search = search;
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new ArgumentNullException("currency is a required property for AiPricesResponse and cannot be null");
            }
            this.Currency = currency;
        }

        /// <summary>
        /// The pricing of every available chat model.
        /// </summary>
        [DataMember(Name = "chat", IsRequired = true, EmitDefaultValue = true)]
        public List<AiChatModelPricing> Chat { get; set; }

        /// <summary>
        /// The pricing of every available embedding model.
        /// </summary>
        [DataMember(Name = "embedding", IsRequired = true, EmitDefaultValue = true)]
        public List<AiEmbeddingModelPricing> Embedding { get; set; }

        /// <summary>
        /// The pricing of every available image model.
        /// </summary>
        [DataMember(Name = "image", IsRequired = true, EmitDefaultValue = true)]
        public List<AiImageModelPricing> Image { get; set; }

        /// <summary>
        /// The pricing of every available web search provider.
        /// </summary>
        [DataMember(Name = "search", IsRequired = true, EmitDefaultValue = true)]
        public List<AiWebSearchPricing> Search { get; set; }

        /// <summary>
        /// The currency the AI prices are quoted in.
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
            sb.Append("class AiPricesResponse {\n");
            sb.Append("  Chat: ").Append(Chat).Append("\n");
            sb.Append("  Embedding: ").Append(Embedding).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Search: ").Append(Search).Append("\n");
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
