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
    /// Request parameters for creating a new AI provider.
    /// </summary>
    [DataContract(Name = "CreateProviderRequestDto")]
    public partial class CreateProviderRequestDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public ProviderType? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProviderRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateProviderRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateProviderRequestDto" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="title">The display title for the AI provider. (required).</param>
        /// <param name="url">The API endpoint URL for the AI provider. Required for OpenAiCompatible type; optional for other types that have default URLs..</param>
        /// <param name="key">The authentication API key for the AI provider. (required).</param>
        public CreateProviderRequestDto(ProviderType? type = default, string title = default, string url = default, string key = default)
        {
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for CreateProviderRequestDto and cannot be null");
            }
            this.Title = title;
            // to ensure "key" is required (not null)
            if (key == null)
            {
                throw new ArgumentNullException("key is a required property for CreateProviderRequestDto and cannot be null");
            }
            this.Key = key;
            this.Type = type;
            this.Url = url;
        }

        /// <summary>
        /// The display title for the AI provider.
        /// </summary>
        /// <value>The display title for the AI provider.</value>
        /*
        <example>OpenAI Provider</example>
        */
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The API endpoint URL for the AI provider. Required for OpenAiCompatible type; optional for other types that have default URLs.
        /// </summary>
        /// <value>The API endpoint URL for the AI provider. Required for OpenAiCompatible type; optional for other types that have default URLs.</value>
        /*
        <example>https://api.openai.com/v1</example>
        */
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// The authentication API key for the AI provider.
        /// </summary>
        /// <value>The authentication API key for the AI provider.</value>
        /*
        <example>sk-example-key-123</example>
        */
        [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateProviderRequestDto {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
