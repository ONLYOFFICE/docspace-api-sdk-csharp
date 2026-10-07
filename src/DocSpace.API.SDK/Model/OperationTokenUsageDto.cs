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
    /// Tokens an AI operation consumed, as recorded in the operation metadata. A kind the provider did not report is &#x60;0&#x60;.
    /// </summary>
    [DataContract(Name = "OperationTokenUsageDto")]
    public partial class OperationTokenUsageDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="OperationTokenUsageDto" /> class.
        /// </summary>
        /// <param name="totalTokens">All tokens of the request: prompt plus completion..</param>
        /// <param name="promptTokens">Tokens sent to the model, cached ones included..</param>
        /// <param name="completionTokens">Tokens the model generated, reasoning ones included..</param>
        /// <param name="cachedTokens">Part of the prompt tokens read from the provider cache..</param>
        /// <param name="cacheWriteTokens">Part of the prompt tokens written to the provider cache..</param>
        /// <param name="reasoningTokens">Part of the completion tokens the model spent on reasoning..</param>
        /// <param name="imageTokens">Tokens spent on images..</param>
        public OperationTokenUsageDto(long totalTokens = default, long promptTokens = default, long completionTokens = default, long cachedTokens = default, long cacheWriteTokens = default, long reasoningTokens = default, long imageTokens = default)
        {
            this.TotalTokens = totalTokens;
            this.PromptTokens = promptTokens;
            this.CompletionTokens = completionTokens;
            this.CachedTokens = cachedTokens;
            this.CacheWriteTokens = cacheWriteTokens;
            this.ReasoningTokens = reasoningTokens;
            this.ImageTokens = imageTokens;
        }

        /// <summary>
        /// All tokens of the request: prompt plus completion.
        /// </summary>
        /// <example>20747</example>
        [DataMember(Name = "totalTokens", EmitDefaultValue = false)]
        public long TotalTokens { get; set; }

        /// <summary>
        /// Tokens sent to the model, cached ones included.
        /// </summary>
        /// <example>19332</example>
        [DataMember(Name = "promptTokens", EmitDefaultValue = false)]
        public long PromptTokens { get; set; }

        /// <summary>
        /// Tokens the model generated, reasoning ones included.
        /// </summary>
        /// <example>1415</example>
        [DataMember(Name = "completionTokens", EmitDefaultValue = false)]
        public long CompletionTokens { get; set; }

        /// <summary>
        /// Part of the prompt tokens read from the provider cache.
        /// </summary>
        /// <example>19226</example>
        [DataMember(Name = "cachedTokens", EmitDefaultValue = false)]
        public long CachedTokens { get; set; }

        /// <summary>
        /// Part of the prompt tokens written to the provider cache.
        /// </summary>
        /// <example>104</example>
        [DataMember(Name = "cacheWriteTokens", EmitDefaultValue = false)]
        public long CacheWriteTokens { get; set; }

        /// <summary>
        /// Part of the completion tokens the model spent on reasoning.
        /// </summary>
        /// <example>68</example>
        [DataMember(Name = "reasoningTokens", EmitDefaultValue = false)]
        public long ReasoningTokens { get; set; }

        /// <summary>
        /// Tokens spent on images.
        /// </summary>
        /// <example>0</example>
        [DataMember(Name = "imageTokens", EmitDefaultValue = false)]
        public long ImageTokens { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OperationTokenUsageDto {\n");
            sb.Append("  TotalTokens: ").Append(TotalTokens).Append("\n");
            sb.Append("  PromptTokens: ").Append(PromptTokens).Append("\n");
            sb.Append("  CompletionTokens: ").Append(CompletionTokens).Append("\n");
            sb.Append("  CachedTokens: ").Append(CachedTokens).Append("\n");
            sb.Append("  CacheWriteTokens: ").Append(CacheWriteTokens).Append("\n");
            sb.Append("  ReasoningTokens: ").Append(ReasoningTokens).Append("\n");
            sb.Append("  ImageTokens: ").Append(ImageTokens).Append("\n");
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
