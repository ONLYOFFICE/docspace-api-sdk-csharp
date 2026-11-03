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
    /// Per-request options of an AI round: extra tools, the depth of reasoning, a system prompt override and the rooms and folder connected as context.
    /// </summary>
    [DataContract(Name = "AiActionArgs")]
    public partial class AiActionArgs : IValidatableObject
    {

        /// <summary>
        /// Depth of extended thinking for the round; providers clamp it to what the model accepts.
        /// </summary>
        [DataMember(Name = "reasoningLevel", EmitDefaultValue = false)]
        public AiReasoningLevel? ReasoningLevel { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiActionArgs" /> class.
        /// </summary>
        /// <param name="tools">Extra tools offered to the model for this request..</param>
        /// <param name="isReasoning">Legacy extended-thinking switch; stands for &#x60;medium&#x60;. &#x60;reasoningLevel&#x60; wins when both are set..</param>
        /// <param name="reasoningLevel">Depth of extended thinking for the round; providers clamp it to what the model accepts..</param>
        /// <param name="prompt">prompt.</param>
        /// <param name="toolInstructions">Usage notes of the MCP servers the caller holds the connection to, keyed by server type; folded into the system prompt as advisory text..</param>
        /// <param name="contextRooms">Instructions rooms connected to the chat as context, each with the skills the round may use..</param>
        /// <param name="knowledgeRooms">Knowledge rooms connected to the chat; the knowledge search tool of the round is limited to them. Each &#x60;id&#x60; has to be a DocSpace room id..</param>
        /// <param name="knowledgeRoom">A single knowledge room, as an older client sends it. Read only when &#x60;knowledgeRooms&#x60; is absent; send &#x60;knowledgeRooms&#x60; instead..</param>
        /// <param name="folderContext">The folder connected to the chat as the round&#39;s context. It becomes the location the model is told the user works in, and the entry the round is attributed to..</param>
        /// <param name="entityId">The entry the round is attributed to. A hint, resolved against the caller&#39;s own access..</param>
        public AiActionArgs(List<AiMCPItem> tools = default, bool isReasoning = default, AiReasoningLevel? reasoningLevel = default, AiActionArgsPrompt prompt = default, Dictionary<string, string> toolInstructions = default, List<AiContextRoomRef> contextRooms = default, List<AiKnowledgeRoomRef> knowledgeRooms = default, AiKnowledgeRoomRef knowledgeRoom = default, AiFolderContextRef folderContext = default, string entityId = default)
        {
            this.Tools = tools;
            this.IsReasoning = isReasoning;
            this.ReasoningLevel = reasoningLevel;
            this.Prompt = prompt;
            this.ToolInstructions = toolInstructions;
            this.ContextRooms = contextRooms;
            this.KnowledgeRooms = knowledgeRooms;
            this.KnowledgeRoom = knowledgeRoom;
            this.FolderContext = folderContext;
            this.EntityId = entityId;
        }

        /// <summary>
        /// Extra tools offered to the model for this request.
        /// </summary>
        /// <example>[]</example>
        [DataMember(Name = "tools", EmitDefaultValue = false)]
        public List<AiMCPItem> Tools { get; set; }

        /// <summary>
        /// Legacy extended-thinking switch; stands for &#x60;medium&#x60;. &#x60;reasoningLevel&#x60; wins when both are set.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isReasoning", EmitDefaultValue = true)]
        public bool IsReasoning { get; set; }

        /// <summary>
        /// Gets or Sets Prompt
        /// </summary>
        [DataMember(Name = "prompt", EmitDefaultValue = false)]
        public AiActionArgsPrompt Prompt { get; set; }

        /// <summary>
        /// Usage notes of the MCP servers the caller holds the connection to, keyed by server type; folded into the system prompt as advisory text.
        /// </summary>
        [DataMember(Name = "toolInstructions", EmitDefaultValue = false)]
        public Dictionary<string, string> ToolInstructions { get; set; }

        /// <summary>
        /// Instructions rooms connected to the chat as context, each with the skills the round may use.
        /// </summary>
        [DataMember(Name = "contextRooms", EmitDefaultValue = false)]
        public List<AiContextRoomRef> ContextRooms { get; set; }

        /// <summary>
        /// Knowledge rooms connected to the chat; the knowledge search tool of the round is limited to them. Each &#x60;id&#x60; has to be a DocSpace room id.
        /// </summary>
        [DataMember(Name = "knowledgeRooms", EmitDefaultValue = false)]
        public List<AiKnowledgeRoomRef> KnowledgeRooms { get; set; }

        /// <summary>
        /// A single knowledge room, as an older client sends it. Read only when &#x60;knowledgeRooms&#x60; is absent; send &#x60;knowledgeRooms&#x60; instead.
        /// </summary>
        [DataMember(Name = "knowledgeRoom", EmitDefaultValue = false)]
        [Obsolete]
        public AiKnowledgeRoomRef KnowledgeRoom { get; set; }

        /// <summary>
        /// The folder connected to the chat as the round&#39;s context. It becomes the location the model is told the user works in, and the entry the round is attributed to.
        /// </summary>
        [DataMember(Name = "folderContext", EmitDefaultValue = false)]
        public AiFolderContextRef FolderContext { get; set; }

        /// <summary>
        /// The entry the round is attributed to. A hint, resolved against the caller&#39;s own access.
        /// </summary>
        [DataMember(Name = "entityId", EmitDefaultValue = false)]
        public string EntityId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiActionArgs {\n");
            sb.Append("  Tools: ").Append(Tools).Append("\n");
            sb.Append("  IsReasoning: ").Append(IsReasoning).Append("\n");
            sb.Append("  ReasoningLevel: ").Append(ReasoningLevel).Append("\n");
            sb.Append("  Prompt: ").Append(Prompt).Append("\n");
            sb.Append("  ToolInstructions: ").Append(ToolInstructions).Append("\n");
            sb.Append("  ContextRooms: ").Append(ContextRooms).Append("\n");
            sb.Append("  KnowledgeRooms: ").Append(KnowledgeRooms).Append("\n");
            sb.Append("  KnowledgeRoom: ").Append(KnowledgeRoom).Append("\n");
            sb.Append("  FolderContext: ").Append(FolderContext).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
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
