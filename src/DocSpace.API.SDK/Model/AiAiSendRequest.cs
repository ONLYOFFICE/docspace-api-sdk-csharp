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
    /// AiAiSendRequest
    /// </summary>
    [DataContract(Name = "aiAiSend_request")]
    public partial class AiAiSendRequest : IValidatableObject
    {

        /// <summary>
        /// Which AI action to run — selects the assignment slot and action.
        /// </summary>
        [DataMember(Name = "actionType", IsRequired = true, EmitDefaultValue = true)]
        public AiActionType ActionType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiAiSendRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiAiSendRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiAiSendRequest" /> class.
        /// </summary>
        /// <param name="actionType">Which AI action to run — selects the assignment slot and action. (required).</param>
        /// <param name="userMessage">The user turn to send. (required).</param>
        /// <param name="actionArgs">Per-request engine options: extra tools, reasoning, prompt override..</param>
        /// <param name="entityId">Optional entity (room) scope for profile resolution..</param>
        public AiAiSendRequest(AiActionType actionType = default, AiThreadMessageLike userMessage = default, AiAiActionArgs actionArgs = default, string entityId = default)
        {
            this.ActionType = actionType;
            // to ensure "userMessage" is required (not null)
            if (userMessage == null)
            {
                throw new ArgumentNullException("userMessage is a required property for AiAiSendRequest and cannot be null");
            }
            this.UserMessage = userMessage;
            this.ActionArgs = actionArgs;
            this.EntityId = entityId;
        }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiAiSendRequest {\n");
            sb.Append("  ActionType: ").Append(ActionType).Append("\n");
            sb.Append("  UserMessage: ").Append(UserMessage).Append("\n");
            sb.Append("  ActionArgs: ").Append(ActionArgs).Append("\n");
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
