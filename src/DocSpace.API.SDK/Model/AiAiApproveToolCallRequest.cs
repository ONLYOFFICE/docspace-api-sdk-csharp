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
    /// AiAiApproveToolCallRequest
    /// </summary>
    [DataContract(Name = "aiAiApproveToolCall_request")]
    public partial class AiAiApproveToolCallRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiAiApproveToolCallRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiAiApproveToolCallRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiAiApproveToolCallRequest" /> class.
        /// </summary>
        /// <param name="result">Final result of the tool call, as the model should see it. (required).</param>
        /// <param name="allowAlways">Persist auto-approve for this tool&#39;s name..</param>
        /// <param name="threadId">Thread the assistant message belongs to. (required).</param>
        /// <param name="messageId">Storage id of the assistant message holding the tool call. (required).</param>
        /// <param name="idx">Index of the tool-call content part inside &#x60;message.content&#x60;. (required).</param>
        /// <param name="message">message (required).</param>
        /// <param name="actionArgs">actionArgs.</param>
        /// <param name="entityId">entityId.</param>
        /// <param name="profileId">profileId.</param>
        public AiAiApproveToolCallRequest(Object result = default, bool allowAlways = default, string threadId = default, string messageId = default, decimal idx = default, AiThreadMessageLike message = default, AiAiActionArgs actionArgs = default, string entityId = default, string profileId = default)
        {
            // to ensure "result" is required (not null)
            if (result == null)
            {
                throw new ArgumentNullException("result is a required property for AiAiApproveToolCallRequest and cannot be null");
            }
            this.Result = result;
            // to ensure "threadId" is required (not null)
            if (threadId == null)
            {
                throw new ArgumentNullException("threadId is a required property for AiAiApproveToolCallRequest and cannot be null");
            }
            this.ThreadId = threadId;
            // to ensure "messageId" is required (not null)
            if (messageId == null)
            {
                throw new ArgumentNullException("messageId is a required property for AiAiApproveToolCallRequest and cannot be null");
            }
            this.MessageId = messageId;
            this.Idx = idx;
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new ArgumentNullException("message is a required property for AiAiApproveToolCallRequest and cannot be null");
            }
            this.Message = message;
            this.AllowAlways = allowAlways;
            this.ActionArgs = actionArgs;
            this.EntityId = entityId;
            this.ProfileId = profileId;
        }

        /// <summary>
        /// Final result of the tool call, as the model should see it.
        /// </summary>
        /// <value>Final result of the tool call, as the model should see it.</value>
        [DataMember(Name = "result", IsRequired = true, EmitDefaultValue = true)]
        public Object Result { get; set; }

        /// <summary>
        /// Persist auto-approve for this tool&#39;s name.
        /// </summary>
        /// <value>Persist auto-approve for this tool&#39;s name.</value>
        [DataMember(Name = "allowAlways", EmitDefaultValue = true)]
        public bool AllowAlways { get; set; }

        /// <summary>
        /// Thread the assistant message belongs to.
        /// </summary>
        /// <value>Thread the assistant message belongs to.</value>
        [DataMember(Name = "threadId", IsRequired = true, EmitDefaultValue = true)]
        public string ThreadId { get; set; }

        /// <summary>
        /// Storage id of the assistant message holding the tool call.
        /// </summary>
        /// <value>Storage id of the assistant message holding the tool call.</value>
        [DataMember(Name = "messageId", IsRequired = true, EmitDefaultValue = true)]
        public string MessageId { get; set; }

        /// <summary>
        /// Index of the tool-call content part inside &#x60;message.content&#x60;.
        /// </summary>
        /// <value>Index of the tool-call content part inside &#x60;message.content&#x60;.</value>
        [DataMember(Name = "idx", IsRequired = true, EmitDefaultValue = true)]
        public decimal Idx { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = true)]
        public AiThreadMessageLike Message { get; set; }

        /// <summary>
        /// Gets or Sets ActionArgs
        /// </summary>
        [DataMember(Name = "actionArgs", EmitDefaultValue = false)]
        public AiAiActionArgs ActionArgs { get; set; }

        /// <summary>
        /// Gets or Sets EntityId
        /// </summary>
        [DataMember(Name = "entityId", EmitDefaultValue = false)]
        public string EntityId { get; set; }

        /// <summary>
        /// Gets or Sets ProfileId
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
            sb.Append("class AiAiApproveToolCallRequest {\n");
            sb.Append("  Result: ").Append(Result).Append("\n");
            sb.Append("  AllowAlways: ").Append(AllowAlways).Append("\n");
            sb.Append("  ThreadId: ").Append(ThreadId).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  Idx: ").Append(Idx).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
