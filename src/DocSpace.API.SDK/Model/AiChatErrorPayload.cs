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
    /// Why a round failed or stopped early, as the message status and the stream report it: a stable &#x60;code&#x60;, a message safe to show the user, and the cause when there is one.
    /// </summary>
    [DataContract(Name = "AiChatErrorPayload")]
    public partial class AiChatErrorPayload : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiChatErrorPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiChatErrorPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiChatErrorPayload" /> class.
        /// </summary>
        /// <param name="code">Stable machine-readable code. One of a canonical set — &#x60;auth&#x60;, &#x60;model_not_found&#x60;, &#x60;rate_limit&#x60;, &#x60;timeout&#x60;, &#x60;network&#x60;, &#x60;bad_request&#x60;, &#x60;server&#x60;, &#x60;not_found&#x60;, &#x60;insufficient_funds&#x60;, &#x60;aborted&#x60;, &#x60;unknown&#x60; — or a provider-specific string when the SDK supplies one verbatim. (required).</param>
        /// <param name="message">Human-readable, end-user-safe message. (required).</param>
        /// <param name="cause">Optional nested cause, normalized through the same helper..</param>
        public AiChatErrorPayload(string code = default, string message = default, AiChatErrorPayload cause = default)
        {
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for AiChatErrorPayload and cannot be null");
            }
            this.Code = code;
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new ArgumentNullException("message is a required property for AiChatErrorPayload and cannot be null");
            }
            this.Message = message;
            this.Cause = cause;
        }

        /// <summary>
        /// Stable machine-readable code. One of a canonical set — &#x60;auth&#x60;, &#x60;model_not_found&#x60;, &#x60;rate_limit&#x60;, &#x60;timeout&#x60;, &#x60;network&#x60;, &#x60;bad_request&#x60;, &#x60;server&#x60;, &#x60;not_found&#x60;, &#x60;insufficient_funds&#x60;, &#x60;aborted&#x60;, &#x60;unknown&#x60; — or a provider-specific string when the SDK supplies one verbatim.
        /// </summary>
        /// <example>rate_limit</example>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Human-readable, end-user-safe message.
        /// </summary>
        /// <example>The provider is rate limiting requests.</example>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Optional nested cause, normalized through the same helper.
        /// </summary>
        [DataMember(Name = "cause", EmitDefaultValue = false)]
        public AiChatErrorPayload Cause { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiChatErrorPayload {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Cause: ").Append(Cause).Append("\n");
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
