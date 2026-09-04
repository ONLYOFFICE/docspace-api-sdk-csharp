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
    /// Data transfer object that represents pricing information for a specific AI service entry.  Contains identification details, provider information, and associated pricing data of generic type T.
    /// </summary>
    [DataContract(Name = "AiEntryPricingDtoDecimal")]
    public partial class AiEntryPricingDtoDecimal : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiEntryPricingDtoDecimal" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiEntryPricingDtoDecimal() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiEntryPricingDtoDecimal" /> class.
        /// </summary>
        /// <param name="id">Gets the unique identifier for the AI pricing entry. (required).</param>
        /// <param name="alias">Gets the display name (alias) for the AI model or service entry. (required).</param>
        /// <param name="provider">Gets the provider name for the AI service or model. (required).</param>
        /// <param name="image">Gets the image URL or identifier associated with the AI model entry. (required).</param>
        /// <param name="price">Gets the pricing information for the AI entry. (required).</param>
        /// <param name="link">Gets the URL link to the AI model or service entry. (required).</param>
        public AiEntryPricingDtoDecimal(string id = default, string alias = default, string provider = default, string image = default, double price = default, string link = default)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for AiEntryPricingDtoDecimal and cannot be null");
            }
            this.Id = id;
            // to ensure "alias" is required (not null)
            if (alias == null)
            {
                throw new ArgumentNullException("alias is a required property for AiEntryPricingDtoDecimal and cannot be null");
            }
            this.Alias = alias;
            // to ensure "provider" is required (not null)
            if (provider == null)
            {
                throw new ArgumentNullException("provider is a required property for AiEntryPricingDtoDecimal and cannot be null");
            }
            this.Provider = provider;
            // to ensure "image" is required (not null)
            if (image == null)
            {
                throw new ArgumentNullException("image is a required property for AiEntryPricingDtoDecimal and cannot be null");
            }
            this.Image = image;
            this.Price = price;
            // to ensure "link" is required (not null)
            if (link == null)
            {
                throw new ArgumentNullException("link is a required property for AiEntryPricingDtoDecimal and cannot be null");
            }
            this.Link = link;
        }

        /// <summary>
        /// Gets the unique identifier for the AI pricing entry.
        /// </summary>
        /// <example>gpt-4o</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets the display name (alias) for the AI model or service entry.
        /// </summary>
        /// <example>GPT-4o</example>
        [DataMember(Name = "alias", IsRequired = true, EmitDefaultValue = true)]
        public string Alias { get; set; }

        /// <summary>
        /// Gets the provider name for the AI service or model.
        /// </summary>
        /// <example>openai</example>
        [DataMember(Name = "provider", IsRequired = true, EmitDefaultValue = true)]
        public string Provider { get; set; }

        /// <summary>
        /// Gets the image URL or identifier associated with the AI model entry.
        /// </summary>
        /// <example>https://cdn.example.com/providers/openai.png</example>
        [DataMember(Name = "image", IsRequired = true, EmitDefaultValue = true)]
        public string Image { get; set; }

        /// <summary>
        /// Gets the pricing information for the AI entry.
        /// </summary>
        /// <example>{"prompt":5.0,"completion":15.0}</example>
        [DataMember(Name = "price", IsRequired = true, EmitDefaultValue = true)]
        public double Price { get; set; }

        /// <summary>
        /// Gets the URL link to the AI model or service entry.
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
            sb.Append("class AiEntryPricingDtoDecimal {\n");
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
