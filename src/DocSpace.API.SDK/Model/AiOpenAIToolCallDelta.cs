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
    /// AiOpenAIToolCallDelta
    /// </summary>
    [DataContract(Name = "AiOpenAIToolCallDelta")]
    public partial class AiOpenAIToolCallDelta : IValidatableObject
    {
        /// <summary>
        /// Defines Type
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum Function for value: function
            /// </summary>
            [EnumMember(Value = "function")]
            Function
        }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiOpenAIToolCallDelta" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiOpenAIToolCallDelta() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiOpenAIToolCallDelta" /> class.
        /// </summary>
        /// <param name="index">index (required).</param>
        /// <param name="id">id.</param>
        /// <param name="type">type.</param>
        /// <param name="function">function.</param>
        public AiOpenAIToolCallDelta(decimal index = default, string id = default, TypeEnum? type = default, AiOpenAIToolCallDeltaFunction function = default)
        {
            this.Index = index;
            this.Id = id;
            this.Type = type;
            this.Function = function;
        }

        /// <summary>
        /// Gets or Sets Index
        /// </summary>
        [DataMember(Name = "index", IsRequired = true, EmitDefaultValue = true)]
        public decimal Index { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Function
        /// </summary>
        [DataMember(Name = "function", EmitDefaultValue = false)]
        public AiOpenAIToolCallDeltaFunction Function { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiOpenAIToolCallDelta {\n");
            sb.Append("  Index: ").Append(Index).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Function: ").Append(Function).Append("\n");
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
