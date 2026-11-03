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
    /// One event of a chat stream, told apart by &#x60;type&#x60;: &#x60;message-start&#x60;, &#x60;message-delta&#x60; and &#x60;message-end&#x60; frame the assistant reply, &#x60;message-incomplete&#x60; reports a provider error or an unfinished answer, &#x60;thread-title&#x60; carries a generated title, and &#x60;tool-call-pending&#x60; pauses the round until the call is approved (&#x60;POST api/2.0/ai/ai/approve-tool-call&#x60;) or denied (&#x60;POST api/2.0/ai/ai/deny-tool-call&#x60;).
    /// </summary>
    [DataContract(Name = "AiChatEvent")]
    public partial class AiChatEvent : IValidatableObject
    {
        /// <summary>
        /// Emitted once per &#x60;sendWithStream&#x60; call, immediately after the user message has been persisted by storage and before the assistant stream starts. Carries the storage-assigned &#x60;id&#x60; and &#x60;createdAt&#x60;. The UI uses it to render the user bubble — no client-side optimistic placeholder is needed, which keeps the runtime tree free of phantom nodes from index-fallback ids.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum UserMessageStored for value: user-message-stored
            /// </summary>
            [EnumMember(Value = "user-message-stored")]
            UserMessageStored,

            /// <summary>
            /// Enum MessageStart for value: message-start
            /// </summary>
            [EnumMember(Value = "message-start")]
            MessageStart,

            /// <summary>
            /// Enum MessageDelta for value: message-delta
            /// </summary>
            [EnumMember(Value = "message-delta")]
            MessageDelta,

            /// <summary>
            /// Enum MessageEnd for value: message-end
            /// </summary>
            [EnumMember(Value = "message-end")]
            MessageEnd,

            /// <summary>
            /// Enum MessageIncomplete for value: message-incomplete
            /// </summary>
            [EnumMember(Value = "message-incomplete")]
            MessageIncomplete,

            /// <summary>
            /// Enum ToolCallPending for value: tool-call-pending
            /// </summary>
            [EnumMember(Value = "tool-call-pending")]
            ToolCallPending,

            /// <summary>
            /// Enum ThreadTitle for value: thread-title
            /// </summary>
            [EnumMember(Value = "thread-title")]
            ThreadTitle
        }

        /// <summary>
        /// Emitted once per &#x60;sendWithStream&#x60; call, immediately after the user message has been persisted by storage and before the assistant stream starts. Carries the storage-assigned &#x60;id&#x60; and &#x60;createdAt&#x60;. The UI uses it to render the user bubble — no client-side optimistic placeholder is needed, which keeps the runtime tree free of phantom nodes from index-fallback ids.
        /// </summary>
        /// <example>message-delta</example>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiChatEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiChatEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiChatEvent" /> class.
        /// </summary>
        /// <param name="type">Emitted once per &#x60;sendWithStream&#x60; call, immediately after the user message has been persisted by storage and before the assistant stream starts. Carries the storage-assigned &#x60;id&#x60; and &#x60;createdAt&#x60;. The UI uses it to render the user bubble — no client-side optimistic placeholder is needed, which keeps the runtime tree free of phantom nodes from index-fallback ids. (required).</param>
        /// <param name="message">The message the event is about, in the state it has reached..</param>
        /// <param name="messageId">The storage identifier of that message..</param>
        /// <param name="idx">The zero-based position of the pending tool call within the message..</param>
        /// <param name="threadId">The thread the event belongs to..</param>
        /// <param name="autoAllow">The tool runs without asking the user, as the user&#39;s tool permission mode decides: under &#x60;ask&#x60; never - the always-allow list, &#x60;requireApproval&#x60; and the annotations are all ignored; under &#x60;auto&#x60; a tool on the always-allow list, one with &#x60;requireApproval: false&#x60;, or one annotated &#x60;readOnlyHint: true&#x60; or &#x60;destructiveHint: false&#x60;; under &#x60;allow&#x60; every tool..</param>
        /// <param name="serverExecuted">The tool is run by the service itself: the client must not run it, only ask for approval (unless &#x60;autoAllow&#x60;) and approve or deny the call - an approval needs no &#x60;result&#x60;..</param>
        /// <param name="title">The generated thread title..</param>
        /// <param name="profileId">The profile that generated the title, when one was used..</param>
        public AiChatEvent(TypeEnum type = default, AiThreadMessageLike message = default, string messageId = default, decimal idx = default, string threadId = default, bool autoAllow = default, bool serverExecuted = default, string title = default, string profileId = default)
        {
            this.Type = type;
            this.Message = message;
            this.MessageId = messageId;
            this.Idx = idx;
            this.ThreadId = threadId;
            this.AutoAllow = autoAllow;
            this.ServerExecuted = serverExecuted;
            this.Title = title;
            this.ProfileId = profileId;
        }

        /// <summary>
        /// The message the event is about, in the state it has reached.
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public AiThreadMessageLike Message { get; set; }

        /// <summary>
        /// The storage identifier of that message.
        /// </summary>
        /// <example>22222222-2222-2222-2222-222222222222</example>
        [DataMember(Name = "messageId", EmitDefaultValue = false)]
        public string MessageId { get; set; }

        /// <summary>
        /// The zero-based position of the pending tool call within the message.
        /// </summary>
        [DataMember(Name = "idx", EmitDefaultValue = false)]
        public decimal Idx { get; set; }

        /// <summary>
        /// The thread the event belongs to.
        /// </summary>
        /// <example>11111111-1111-1111-1111-111111111111</example>
        [DataMember(Name = "threadId", EmitDefaultValue = false)]
        public string ThreadId { get; set; }

        /// <summary>
        /// The tool runs without asking the user, as the user&#39;s tool permission mode decides: under &#x60;ask&#x60; never - the always-allow list, &#x60;requireApproval&#x60; and the annotations are all ignored; under &#x60;auto&#x60; a tool on the always-allow list, one with &#x60;requireApproval: false&#x60;, or one annotated &#x60;readOnlyHint: true&#x60; or &#x60;destructiveHint: false&#x60;; under &#x60;allow&#x60; every tool.
        /// </summary>
        [DataMember(Name = "autoAllow", EmitDefaultValue = true)]
        public bool AutoAllow { get; set; }

        /// <summary>
        /// The tool is run by the service itself: the client must not run it, only ask for approval (unless &#x60;autoAllow&#x60;) and approve or deny the call - an approval needs no &#x60;result&#x60;.
        /// </summary>
        [DataMember(Name = "serverExecuted", EmitDefaultValue = true)]
        public bool ServerExecuted { get; set; }

        /// <summary>
        /// The generated thread title.
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// The profile that generated the title, when one was used.
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
            sb.Append("class AiChatEvent {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  Idx: ").Append(Idx).Append("\n");
            sb.Append("  ThreadId: ").Append(ThreadId).Append("\n");
            sb.Append("  AutoAllow: ").Append(AutoAllow).Append("\n");
            sb.Append("  ServerExecuted: ").Append(ServerExecuted).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
