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
    /// The chat settings.
    /// </summary>
    [DataContract(Name = "ChatSettings")]
    public partial class ChatSettings : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSettings" /> class.
        /// </summary>
        /// <param name="providerId">The provider ID..</param>
        /// <param name="modelId">The model ID..</param>
        /// <param name="prompt">The prompt..</param>
        public ChatSettings(int providerId = default, string modelId = default, string prompt = default)
        {
            this.ProviderId = providerId;
            this.ModelId = modelId;
            this.Prompt = prompt;
        }

        /// <summary>
        /// The provider ID.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "providerId", EmitDefaultValue = false)]
        public int ProviderId { get; set; }

        /// <summary>
        /// The model ID.
        /// </summary>
        /// <example>gpt-4</example>
        [DataMember(Name = "modelId", EmitDefaultValue = true)]
        public string ModelId { get; set; }

        /// <summary>
        /// The prompt.
        /// </summary>
        /// <example>Please analyze this document</example>
        [DataMember(Name = "prompt", EmitDefaultValue = true)]
        public string Prompt { get; set; }

        /// <summary>
        /// Specifies whether the provider is internal or not.
        /// </summary>
        /// <example>false</example>
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
            sb.Append("class ChatSettings {\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  ModelId: ").Append(ModelId).Append("\n");
            sb.Append("  Prompt: ").Append(Prompt).Append("\n");
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
