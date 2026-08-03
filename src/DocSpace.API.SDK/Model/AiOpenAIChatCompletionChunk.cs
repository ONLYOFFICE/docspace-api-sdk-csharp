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
    /// AiOpenAIChatCompletionChunk
    /// </summary>
    [DataContract(Name = "AiOpenAIChatCompletionChunk")]
    public partial class AiOpenAIChatCompletionChunk : IValidatableObject
    {
        /// <summary>
        /// Defines Object
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ObjectEnum
        {
            /// <summary>
            /// Enum ChatCompletionChunk for value: chat.completion.chunk
            /// </summary>
            [EnumMember(Value = "chat.completion.chunk")]
            ChatCompletionChunk
        }

        /// <summary>
        /// Gets or Sets Object
        /// </summary>
        [DataMember(Name = "object", IsRequired = true, EmitDefaultValue = true)]
        public ObjectEnum Object { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiOpenAIChatCompletionChunk" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiOpenAIChatCompletionChunk() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiOpenAIChatCompletionChunk" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="object">@object (required).</param>
        /// <param name="created">created (required).</param>
        /// <param name="model">model (required).</param>
        /// <param name="choices">choices (required).</param>
        public AiOpenAIChatCompletionChunk(string id = default, ObjectEnum @object = default, decimal created = default, string model = default, List<AiOpenAIChunkChoice> choices = default)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for AiOpenAIChatCompletionChunk and cannot be null");
            }
            this.Id = id;
            this.Object = @object;
            this.Created = created;
            // to ensure "model" is required (not null)
            if (model == null)
            {
                throw new ArgumentNullException("model is a required property for AiOpenAIChatCompletionChunk and cannot be null");
            }
            this.Model = model;
            // to ensure "choices" is required (not null)
            if (choices == null)
            {
                throw new ArgumentNullException("choices is a required property for AiOpenAIChatCompletionChunk and cannot be null");
            }
            this.Choices = choices;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", IsRequired = true, EmitDefaultValue = true)]
        public decimal Created { get; set; }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name = "model", IsRequired = true, EmitDefaultValue = true)]
        public string Model { get; set; }

        /// <summary>
        /// Gets or Sets Choices
        /// </summary>
        [DataMember(Name = "choices", IsRequired = true, EmitDefaultValue = true)]
        public List<AiOpenAIChunkChoice> Choices { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiOpenAIChatCompletionChunk {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Object: ").Append(Object).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Choices: ").Append(Choices).Append("\n");
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
