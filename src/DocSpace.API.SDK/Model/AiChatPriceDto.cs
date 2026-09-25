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
    /// What a chat model charges, split by the direction the tokens flow in.
    /// </summary>
    [DataContract(Name = "AiChatPriceDto")]
    public partial class AiChatPriceDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiChatPriceDto" /> class.
        /// </summary>
        /// <param name="prompt">The cost of one million tokens sent to the model, which includes the conversation history resent with  every turn and not just the newest message..</param>
        /// <param name="completion">The cost of one million tokens the model writes back. It is normally the dearer of the two directions..</param>
        /// <param name="promptCacheRead">The cost of one million prompt tokens served from the prompt cache. It is absent when the model does not  support prompt caching..</param>
        /// <param name="promptCacheWrite">The cost of one million prompt tokens written to the prompt cache with the default lifetime. It is absent  when the model does not support prompt caching..</param>
        /// <param name="promptCacheWrite1H">The cost of one million prompt tokens written to the prompt cache with a one-hour lifetime. It is absent  when the model offers no such option..</param>
        public AiChatPriceDto(double prompt = default, double completion = default, double? promptCacheRead = default, double? promptCacheWrite = default, double? promptCacheWrite1H = default)
        {
            this.Prompt = prompt;
            this.Completion = completion;
            this.PromptCacheRead = promptCacheRead;
            this.PromptCacheWrite = promptCacheWrite;
            this.PromptCacheWrite1H = promptCacheWrite1H;
        }

        /// <summary>
        /// The cost of one million tokens sent to the model, which includes the conversation history resent with  every turn and not just the newest message.
        /// </summary>
        /// <example>5.0</example>
        [DataMember(Name = "prompt", EmitDefaultValue = false)]
        public double Prompt { get; set; }

        /// <summary>
        /// The cost of one million tokens the model writes back. It is normally the dearer of the two directions.
        /// </summary>
        /// <example>15.0</example>
        [DataMember(Name = "completion", EmitDefaultValue = false)]
        public double Completion { get; set; }

        /// <summary>
        /// The cost of one million prompt tokens served from the prompt cache. It is absent when the model does not  support prompt caching.
        /// </summary>
        /// <example>0.2</example>
        [DataMember(Name = "promptCacheRead", EmitDefaultValue = true)]
        public double? PromptCacheRead { get; set; }

        /// <summary>
        /// The cost of one million prompt tokens written to the prompt cache with the default lifetime. It is absent  when the model does not support prompt caching.
        /// </summary>
        /// <example>2.5</example>
        [DataMember(Name = "promptCacheWrite", EmitDefaultValue = true)]
        public double? PromptCacheWrite { get; set; }

        /// <summary>
        /// The cost of one million prompt tokens written to the prompt cache with a one-hour lifetime. It is absent  when the model offers no such option.
        /// </summary>
        /// <example>4.0</example>
        [DataMember(Name = "promptCacheWrite1H", EmitDefaultValue = true)]
        public double? PromptCacheWrite1H { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiChatPriceDto {\n");
            sb.Append("  Prompt: ").Append(Prompt).Append("\n");
            sb.Append("  Completion: ").Append(Completion).Append("\n");
            sb.Append("  PromptCacheRead: ").Append(PromptCacheRead).Append("\n");
            sb.Append("  PromptCacheWrite: ").Append(PromptCacheWrite).Append("\n");
            sb.Append("  PromptCacheWrite1H: ").Append(PromptCacheWrite1H).Append("\n");
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
