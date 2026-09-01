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
    /// AiThreadsAppendUserMessageRequest
    /// </summary>
    [DataContract(Name = "aiThreadsAppendUserMessage_request")]
    public partial class AiThreadsAppendUserMessageRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiThreadsAppendUserMessageRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiThreadsAppendUserMessageRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiThreadsAppendUserMessageRequest" /> class.
        /// </summary>
        /// <param name="threadId">threadId (required).</param>
        /// <param name="message">Message to persist (id/createdAt are storage-assigned). (required).</param>
        /// <param name="profileId">profileId.</param>
        public AiThreadsAppendUserMessageRequest(string threadId = default, AiThreadMessageLike message = default, string profileId = default)
        {
            // to ensure "threadId" is required (not null)
            if (threadId == null)
            {
                throw new ArgumentNullException("threadId is a required property for AiThreadsAppendUserMessageRequest and cannot be null");
            }
            this.ThreadId = threadId;
            // to ensure "message" is required (not null)
            if (message == null)
            {
                throw new ArgumentNullException("message is a required property for AiThreadsAppendUserMessageRequest and cannot be null");
            }
            this.Message = message;
            this.ProfileId = profileId;
        }

        /// <summary>
        /// Gets or Sets ThreadId
        /// </summary>
        [DataMember(Name = "threadId", IsRequired = true, EmitDefaultValue = true)]
        public string ThreadId { get; set; }

        /// <summary>
        /// Message to persist (id/createdAt are storage-assigned).
        /// </summary>
        [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = true)]
        public AiThreadMessageLike Message { get; set; }

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
            sb.Append("class AiThreadsAppendUserMessageRequest {\n");
            sb.Append("  ThreadId: ").Append(ThreadId).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
