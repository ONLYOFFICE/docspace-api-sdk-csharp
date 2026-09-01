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
    /// One choice of a streaming completion, carrying the part this chunk adds.
    /// </summary>
    [DataContract(Name = "AiOpenAIChunkChoice")]
    public partial class AiOpenAIChunkChoice : IValidatableObject
    {

        /// <summary>
        /// Why the completion stopped, or null while it is still streaming.
        /// </summary>
        [DataMember(Name = "finish_reason", IsRequired = true, EmitDefaultValue = true)]
        public AiOpenAIFinishReason FinishReason { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiOpenAIChunkChoice" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiOpenAIChunkChoice() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiOpenAIChunkChoice" /> class.
        /// </summary>
        /// <param name="index">The zero-based position of the choice. This service emits a single choice, so always 0. (required).</param>
        /// <param name="delta">What this chunk adds to the choice. (required).</param>
        /// <param name="finishReason">Why the completion stopped, or null while it is still streaming. (required).</param>
        public AiOpenAIChunkChoice(decimal index = default, AiOpenAIChoiceDelta delta = default, AiOpenAIFinishReason finishReason = default)
        {
            this.Index = index;
            // to ensure "delta" is required (not null)
            if (delta == null)
            {
                throw new ArgumentNullException("delta is a required property for AiOpenAIChunkChoice and cannot be null");
            }
            this.Delta = delta;
            this.FinishReason = finishReason;
        }

        /// <summary>
        /// The zero-based position of the choice. This service emits a single choice, so always 0.
        /// </summary>
        [DataMember(Name = "index", IsRequired = true, EmitDefaultValue = true)]
        public decimal Index { get; set; }

        /// <summary>
        /// What this chunk adds to the choice.
        /// </summary>
        [DataMember(Name = "delta", IsRequired = true, EmitDefaultValue = true)]
        public AiOpenAIChoiceDelta Delta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiOpenAIChunkChoice {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Delta: ").Append(Delta).Append("\n");
            sb.Append("  FinishReason: ").Append(FinishReason).Append("\n");
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
