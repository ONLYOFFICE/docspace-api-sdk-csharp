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
    /// NewAiOpenAIChunkChoice
    /// </summary>
    [DataContract(Name = "NewAiOpenAIChunkChoice")]
    public partial class NewAiOpenAIChunkChoice : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets FinishReason
        /// </summary>
        [DataMember(Name = "finish_reason", IsRequired = true, EmitDefaultValue = true)]
        public NewAiOpenAIFinishReason FinishReason { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiOpenAIChunkChoice" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewAiOpenAIChunkChoice() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiOpenAIChunkChoice" /> class.
        /// </summary>
        /// <param name="index">index (required).</param>
        /// <param name="delta">delta (required).</param>
        /// <param name="finishReason">finishReason (required).</param>
        public NewAiOpenAIChunkChoice(decimal index = default, NewAiOpenAIChoiceDelta delta = default, NewAiOpenAIFinishReason finishReason = default)
        {
            this.Index = index;
            // to ensure "delta" is required (not null)
            if (delta == null)
            {
                throw new ArgumentNullException("delta is a required property for NewAiOpenAIChunkChoice and cannot be null");
            }
            this.Delta = delta;
            this.FinishReason = finishReason;
        }

        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name = "index", IsRequired = true, EmitDefaultValue = true)]
        public decimal Index { get; set; }

        /// <summary>
        /// Gets or Sets Delta
        /// </summary>
        [DataMember(Name = "delta", IsRequired = true, EmitDefaultValue = true)]
        public NewAiOpenAIChoiceDelta Delta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewAiOpenAIChunkChoice {\n");
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
