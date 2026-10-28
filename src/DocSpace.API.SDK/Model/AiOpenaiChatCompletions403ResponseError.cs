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
    /// AiOpenaiChatCompletions403ResponseError
    /// </summary>
    [DataContract(Name = "aiOpenaiChatCompletions_403_response_error")]
    public partial class AiOpenaiChatCompletions403ResponseError : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiOpenaiChatCompletions403ResponseError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiOpenaiChatCompletions403ResponseError()
        {
            this.AdditionalProperties = new Dictionary<string, object>();
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiOpenaiChatCompletions403ResponseError" /> class.
        /// </summary>
        /// <param name="message">Human-readable description of the failure. (required).</param>
        /// <param name="type">OpenAI error class, for example &#x60;invalid_request_error&#x60;. (required).</param>
        /// <param name="code">Machine-readable code, when the provider supplies one..</param>
        /// <param name="param">The request parameter at fault, when the failure names one..</param>
        public AiOpenaiChatCompletions403ResponseError(string message = default, string type = default, string code = default, string param = default)
        {
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new ArgumentNullException("message is a required property for AiOpenaiChatCompletions403ResponseError and cannot be null");
            }
            this.Message = message;
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for AiOpenaiChatCompletions403ResponseError and cannot be null");
            }
            this.Type = type;
            this.Code = code;
            this.Param = param;
            this.AdditionalProperties = new Dictionary<string, object>();
        }

        /// <summary>
        /// Human-readable description of the failure.
        /// </summary>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// OpenAI error class, for example &#x60;invalid_request_error&#x60;.
        /// </summary>
        /// <example>invalid_request_error</example>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Machine-readable code, when the provider supplies one.
        /// </summary>
        [DataMember(Name = "code", EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// The request parameter at fault, when the failure names one.
        /// </summary>
        [DataMember(Name = "param", EmitDefaultValue = true)]
        public string Param { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [System.Text.Json.Serialization.JsonExtensionData]
        public IDictionary<string, object> AdditionalProperties { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiOpenaiChatCompletions403ResponseError {\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Param: ").Append(Param).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
