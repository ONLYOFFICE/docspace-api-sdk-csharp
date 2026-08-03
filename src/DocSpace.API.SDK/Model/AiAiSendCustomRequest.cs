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
    /// AiAiSendCustomRequest
    /// </summary>
    [DataContract(Name = "aiAiSendCustom_request")]
    public partial class AiAiSendCustomRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiAiSendCustomRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiAiSendCustomRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiAiSendCustomRequest" /> class.
        /// </summary>
        /// <param name="isStream">Stream the reply (ndjson) when true, else return a single message. (required).</param>
        /// <param name="systemPrompt">Caller-supplied system prompt for this one-turn call. (required).</param>
        /// <param name="userMessage">userMessage (required).</param>
        /// <param name="actionArgs">actionArgs.</param>
        public AiAiSendCustomRequest(bool isStream = default, string systemPrompt = default, AiThreadMessageLike userMessage = default, AiAiActionArgs actionArgs = default)
        {
            this.IsStream = isStream;
            // to ensure "systemPrompt" is required (not null)
            if (systemPrompt == null)
            {
                throw new ArgumentNullException("systemPrompt is a required property for AiAiSendCustomRequest and cannot be null");
            }
            this.SystemPrompt = systemPrompt;
            // to ensure "userMessage" is required (not null)
            if (userMessage == null)
            {
                throw new ArgumentNullException("userMessage is a required property for AiAiSendCustomRequest and cannot be null");
            }
            this.UserMessage = userMessage;
            this.ActionArgs = actionArgs;
        }

        /// <summary>
        /// Stream the reply (ndjson) when true, else return a single message.
        /// </summary>
        /// <value>Stream the reply (ndjson) when true, else return a single message.</value>
        [DataMember(Name = "isStream", IsRequired = true, EmitDefaultValue = true)]
        public bool IsStream { get; set; }

        /// <summary>
        /// Caller-supplied system prompt for this one-turn call.
        /// </summary>
        /// <value>Caller-supplied system prompt for this one-turn call.</value>
        [DataMember(Name = "systemPrompt", IsRequired = true, EmitDefaultValue = true)]
        public string SystemPrompt { get; set; }

        /// <summary>
        /// Gets or Sets UserMessage
        /// </summary>
        [DataMember(Name = "userMessage", IsRequired = true, EmitDefaultValue = true)]
        public AiThreadMessageLike UserMessage { get; set; }

        /// <summary>
        /// Gets or Sets ActionArgs
        /// </summary>
        [DataMember(Name = "actionArgs", EmitDefaultValue = false)]
        public AiAiActionArgs ActionArgs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiAiSendCustomRequest {\n");
            sb.Append("  IsStream: ").Append(IsStream).Append("\n");
            sb.Append("  SystemPrompt: ").Append(SystemPrompt).Append("\n");
            sb.Append("  UserMessage: ").Append(UserMessage).Append("\n");
            sb.Append("  ActionArgs: ").Append(ActionArgs).Append("\n");
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
