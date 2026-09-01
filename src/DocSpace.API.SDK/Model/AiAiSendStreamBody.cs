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
    /// Shared body of the two streaming send endpoints (&#x60;sendWithStream&#x60; and its OpenAI-framed twin) — the &#x60;Chat&#x60; action is implied, so there is no &#x60;actionType&#x60;.
    /// </summary>
    [DataContract(Name = "AiAiSendStreamBody")]
    public partial class AiAiSendStreamBody : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiAiSendStreamBody" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiAiSendStreamBody() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiAiSendStreamBody" /> class.
        /// </summary>
        /// <param name="threadId">Target thread; a new one is created (with an auto title) when omitted..</param>
        /// <param name="userMessage">The user turn to send. (required).</param>
        /// <param name="actionArgs">Per-request engine options: extra tools, reasoning, prompt override..</param>
        /// <param name="entityId">Optional entity (room) scope for profile resolution..</param>
        /// <param name="profileId">Session-level profile override for this request only..</param>
        public AiAiSendStreamBody(string threadId = default, AiThreadMessageLike userMessage = default, AiAiActionArgs actionArgs = default, string entityId = default, string profileId = default)
        {
            // to ensure "userMessage" is required (not null)
            if (userMessage == null)
            {
                throw new ArgumentNullException("userMessage is a required property for AiAiSendStreamBody and cannot be null");
            }
            this.UserMessage = userMessage;
            this.ThreadId = threadId;
            this.ActionArgs = actionArgs;
            this.EntityId = entityId;
            this.ProfileId = profileId;
        }

        /// <summary>
        /// Target thread; a new one is created (with an auto title) when omitted.
        /// </summary>
        [DataMember(Name = "threadId", EmitDefaultValue = false)]
        public string ThreadId { get; set; }

        /// <summary>
        /// The user turn to send.
        /// </summary>
        [DataMember(Name = "userMessage", IsRequired = true, EmitDefaultValue = true)]
        public AiThreadMessageLike UserMessage { get; set; }

        /// <summary>
        /// Per-request engine options: extra tools, reasoning, prompt override.
        /// </summary>
        [DataMember(Name = "actionArgs", EmitDefaultValue = false)]
        public AiAiActionArgs ActionArgs { get; set; }

        /// <summary>
        /// Optional entity (room) scope for profile resolution.
        /// </summary>
        [DataMember(Name = "entityId", EmitDefaultValue = false)]
        public string EntityId { get; set; }

        /// <summary>
        /// Session-level profile override for this request only.
        /// </summary>
        [DataMember(Name = "profileId", EmitDefaultValue = false)]
        public string ProfileId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiAiSendStreamBody {\n");
            sb.Append("  ThreadId: ").Append(ThreadId).Append("\n");
            sb.Append("  UserMessage: ").Append(UserMessage).Append("\n");
            sb.Append("  ActionArgs: ").Append(ActionArgs).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
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
