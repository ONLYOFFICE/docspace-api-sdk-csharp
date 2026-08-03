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
    /// NewAiAttachmentsLinkToMessageRequest
    /// </summary>
    [DataContract(Name = "newAiAttachmentsLinkToMessage_request")]
    public partial class NewAiAttachmentsLinkToMessageRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiAttachmentsLinkToMessageRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewAiAttachmentsLinkToMessageRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiAttachmentsLinkToMessageRequest" /> class.
        /// </summary>
        /// <param name="ids">Attachment ids to bind. (required).</param>
        /// <param name="messageId">Owning message id. (required).</param>
        /// <param name="threadId">Owning thread id. (required).</param>
        public NewAiAttachmentsLinkToMessageRequest(List<string> ids = default, string messageId = default, string threadId = default)
        {
            // to ensure "ids" is required (not null)
            if (ids == null)
            {
                throw new ArgumentNullException("ids is a required property for NewAiAttachmentsLinkToMessageRequest and cannot be null");
            }
            this.Ids = ids;
            // to ensure "messageId" is required (not null)
            if (messageId == null)
            {
                throw new ArgumentNullException("messageId is a required property for NewAiAttachmentsLinkToMessageRequest and cannot be null");
            }
            this.MessageId = messageId;
            // to ensure "threadId" is required (not null)
            if (threadId == null)
            {
                throw new ArgumentNullException("threadId is a required property for NewAiAttachmentsLinkToMessageRequest and cannot be null");
            }
            this.ThreadId = threadId;
        }

        /// <summary>
        /// Attachment ids to bind.
        /// </summary>
        /// <value>Attachment ids to bind.</value>
        [DataMember(Name = "ids", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Ids { get; set; }

        /// <summary>
        /// Owning message id.
        /// </summary>
        /// <value>Owning message id.</value>
        [DataMember(Name = "messageId", IsRequired = true, EmitDefaultValue = true)]
        public string MessageId { get; set; }

        /// <summary>
        /// Owning thread id.
        /// </summary>
        /// <value>Owning thread id.</value>
        [DataMember(Name = "threadId", IsRequired = true, EmitDefaultValue = true)]
        public string ThreadId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewAiAttachmentsLinkToMessageRequest {\n");
            sb.Append("  Ids: ").Append(Ids).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  ThreadId: ").Append(ThreadId).Append("\n");
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
