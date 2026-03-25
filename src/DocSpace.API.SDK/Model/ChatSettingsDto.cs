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
    /// The chat settings parameters.
    /// </summary>
    [DataContract(Name = "ChatSettingsDto")]
    public partial class ChatSettingsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSettingsDto" /> class.
        /// </summary>
        /// <param name="providerId">The AI provider ID..</param>
        /// <param name="modelId">The AI model ID used for chat completions..</param>
        /// <param name="modelAlias">The AI model display alias..</param>
        /// <param name="prompt">The system prompt for the chat..</param>
        /// <param name="multimodal">multimodal.</param>
        /// <param name="thinking">Indicates whether the model supports extended thinking mode..</param>
        public ChatSettingsDto(int providerId = default, string modelId = default, string modelAlias = default, string prompt = default, ChatMultimodalSettingsDto multimodal = default, bool thinking = default)
        {
            this.ProviderId = providerId;
            this.ModelId = modelId;
            this.ModelAlias = modelAlias;
            this.Prompt = prompt;
            this.Multimodal = multimodal;
            this.Thinking = thinking;
        }

        /// <summary>
        /// The AI provider ID.
        /// </summary>
        /// <value>The AI provider ID.</value>
        /*
        <example>1</example>
        */
        [DataMember(Name = "providerId", EmitDefaultValue = false)]
        public int ProviderId { get; set; }

        /// <summary>
        /// The AI model ID used for chat completions.
        /// </summary>
        /// <value>The AI model ID used for chat completions.</value>
        /*
        <example>gpt-5.2</example>
        */
        [DataMember(Name = "modelId", EmitDefaultValue = true)]
        public string ModelId { get; set; }

        /// <summary>
        /// The AI model display alias.
        /// </summary>
        /// <value>The AI model display alias.</value>
        /*
        <example>GPT-5.2</example>
        */
        [DataMember(Name = "modelAlias", EmitDefaultValue = true)]
        public string ModelAlias { get; set; }

        /// <summary>
        /// The system prompt for the chat.
        /// </summary>
        /// <value>The system prompt for the chat.</value>
        /*
        <example>You are a helpful assistant.</example>
        */
        [DataMember(Name = "prompt", EmitDefaultValue = true)]
        public string Prompt { get; set; }

        /// <summary>
        /// Gets or Sets Multimodal
        /// </summary>
        [DataMember(Name = "multimodal", EmitDefaultValue = false)]
        public ChatMultimodalSettingsDto Multimodal { get; set; }

        /// <summary>
        /// Indicates whether the model supports extended thinking mode.
        /// </summary>
        /// <value>Indicates whether the model supports extended thinking mode.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "thinking", EmitDefaultValue = true)]
        public bool Thinking { get; set; }

        /// <summary>
        /// Indicates whether this is an internal AI gateway provider.
        /// </summary>
        /// <value>Indicates whether this is an internal AI gateway provider.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "internal", EmitDefaultValue = true)]
        public bool Internal { get; private set; }

        /// <summary>
        /// Returns false as Internal should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeInternal()
        {
            return false;
        }
        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ChatSettingsDto {\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  ModelId: ").Append(ModelId).Append("\n");
            sb.Append("  ModelAlias: ").Append(ModelAlias).Append("\n");
            sb.Append("  Prompt: ").Append(Prompt).Append("\n");
            sb.Append("  Multimodal: ").Append(Multimodal).Append("\n");
            sb.Append("  Thinking: ").Append(Thinking).Append("\n");
            sb.Append("  Internal: ").Append(Internal).Append("\n");
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
