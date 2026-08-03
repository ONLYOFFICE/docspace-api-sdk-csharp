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
    /// Discriminated event emitted by the streaming methods of  {@link  AIEngine } . The engine never invokes user-supplied middleware or callbacks directly — every observable side-effect is encoded as a  {@link  ChatEvent }  so the same stream can be replayed over SSE, WebSocket, or in-process.  Pause point: &#x60;tool-call-pending&#x60; is the only stop. The UI must execute the tool itself (consulting &#x60;autoAllow&#x60; to decide between the silent path and the approve dialog) and resume via  {@link  AIEngine.approveToolCall }  or  {@link  AIEngine.denyToolCall } .  Other variants are pure data:  - &#x60;message-start&#x60; / &#x60;message-delta&#x60; / &#x60;message-end&#x60; — assistant   reply lifecycle. - &#x60;message-incomplete&#x60; — the provider returned an error or   incomplete status. - &#x60;thread-title&#x60; — auto-generated title ready for a new thread.
    /// </summary>
    [DataContract(Name = "AiChatEvent")]
    public partial class AiChatEvent : IValidatableObject
    {
        /// <summary>
        /// Emitted once per &#x60;sendWithStream&#x60; call, immediately after the user message has been persisted by storage and before the assistant stream starts. Carries the storage-assigned &#x60;id&#x60; and &#x60;createdAt&#x60;. The UI uses it to render the user bubble — no client-side optimistic placeholder is needed, which keeps the runtime tree free of phantom nodes from index-fallback ids.
        /// </summary>
        /// <value>Emitted once per &#x60;sendWithStream&#x60; call, immediately after the user message has been persisted by storage and before the assistant stream starts. Carries the storage-assigned &#x60;id&#x60; and &#x60;createdAt&#x60;. The UI uses it to render the user bubble — no client-side optimistic placeholder is needed, which keeps the runtime tree free of phantom nodes from index-fallback ids.</value>
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
        /// <value>Emitted once per &#x60;sendWithStream&#x60; call, immediately after the user message has been persisted by storage and before the assistant stream starts. Carries the storage-assigned &#x60;id&#x60; and &#x60;createdAt&#x60;. The UI uses it to render the user bubble — no client-side optimistic placeholder is needed, which keeps the runtime tree free of phantom nodes from index-fallback ids.</value>
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
        /// <param name="message">message.</param>
        /// <param name="messageId">messageId.</param>
        /// <param name="idx">idx.</param>
        /// <param name="threadId">threadId.</param>
        /// <param name="autoAllow">The consumer should execute the tool without prompting the user. True when the tool is in the persisted always-allow list, or the tool itself opts in via &#x60;TMCPItem.requireApproval &#x3D;&#x3D;&#x3D; false&#x60; (host tools default to this). For a client-side tool with a server-side engine, this lets the engine return the pending call already flagged auto-allow so the client runs it and streams the result back without a dialog round-trip..</param>
        /// <param name="serverExecuted">Set when the tool is served by a server-side system source: the consumer must NOT execute it locally — only show the approval UI (unless &#x60;autoAllow&#x60;) and resume via &#x60;approveToolCall&#x60; (no &#x60;result&#x60; needed) / &#x60;denyToolCall&#x60;. The engine runs it in-engine..</param>
        /// <param name="title">title.</param>
        /// <param name="profileId">profileId.</param>
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
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public AiThreadMessageLike Message { get; set; }

        /// <summary>
        /// Gets or Sets MessageId
        /// </summary>
        [DataMember(Name = "messageId", EmitDefaultValue = false)]
        public string MessageId { get; set; }

        /// <summary>
        /// Gets or Sets Idx
        /// </summary>
        [DataMember(Name = "idx", EmitDefaultValue = false)]
        public decimal Idx { get; set; }

        /// <summary>
        /// Gets or Sets ThreadId
        /// </summary>
        [DataMember(Name = "threadId", EmitDefaultValue = false)]
        public string ThreadId { get; set; }

        /// <summary>
        /// The consumer should execute the tool without prompting the user. True when the tool is in the persisted always-allow list, or the tool itself opts in via &#x60;TMCPItem.requireApproval &#x3D;&#x3D;&#x3D; false&#x60; (host tools default to this). For a client-side tool with a server-side engine, this lets the engine return the pending call already flagged auto-allow so the client runs it and streams the result back without a dialog round-trip.
        /// </summary>
        /// <value>The consumer should execute the tool without prompting the user. True when the tool is in the persisted always-allow list, or the tool itself opts in via &#x60;TMCPItem.requireApproval &#x3D;&#x3D;&#x3D; false&#x60; (host tools default to this). For a client-side tool with a server-side engine, this lets the engine return the pending call already flagged auto-allow so the client runs it and streams the result back without a dialog round-trip.</value>
        [DataMember(Name = "autoAllow", EmitDefaultValue = true)]
        public bool AutoAllow { get; set; }

        /// <summary>
        /// Set when the tool is served by a server-side system source: the consumer must NOT execute it locally — only show the approval UI (unless &#x60;autoAllow&#x60;) and resume via &#x60;approveToolCall&#x60; (no &#x60;result&#x60; needed) / &#x60;denyToolCall&#x60;. The engine runs it in-engine.
        /// </summary>
        /// <value>Set when the tool is served by a server-side system source: the consumer must NOT execute it locally — only show the approval UI (unless &#x60;autoAllow&#x60;) and resume via &#x60;approveToolCall&#x60; (no &#x60;result&#x60; needed) / &#x60;denyToolCall&#x60;. The engine runs it in-engine.</value>
        [DataMember(Name = "serverExecuted", EmitDefaultValue = true)]
        public bool ServerExecuted { get; set; }

        /// <summary>
        /// Gets or Sets Title
        /// </summary>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

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
