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
    /// The AI model capabilities.
    /// </summary>
    [DataContract(Name = "AiModelCapabilities")]
    public partial class AiModelCapabilities : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiModelCapabilities" /> class.
        /// </summary>
        /// <param name="vision">Indicates whether the model supports image and vision input..</param>
        /// <param name="toolCalling">Indicates whether the model supports tool (function) calling..</param>
        /// <param name="thinking">Indicates whether the model supports extended thinking and reasoning..</param>
        public AiModelCapabilities(bool vision = default, bool toolCalling = default, bool thinking = default)
        {
            this.Vision = vision;
            this.ToolCalling = toolCalling;
            this.Thinking = thinking;
        }

        /// <summary>
        /// Indicates whether the model supports image and vision input.
        /// </summary>
        /// <value>Indicates whether the model supports image and vision input.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "vision", EmitDefaultValue = true)]
        public bool Vision { get; set; }

        /// <summary>
        /// Indicates whether the model supports tool (function) calling.
        /// </summary>
        /// <value>Indicates whether the model supports tool (function) calling.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "toolCalling", EmitDefaultValue = true)]
        public bool ToolCalling { get; set; }

        /// <summary>
        /// Indicates whether the model supports extended thinking and reasoning.
        /// </summary>
        /// <value>Indicates whether the model supports extended thinking and reasoning.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "thinking", EmitDefaultValue = true)]
        public bool Thinking { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiModelCapabilities {\n");
            sb.Append("  Vision: ").Append(Vision).Append("\n");
            sb.Append("  ToolCalling: ").Append(ToolCalling).Append("\n");
            sb.Append("  Thinking: ").Append(Thinking).Append("\n");
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
