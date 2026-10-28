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
    /// AiThreadsAppendUserMessage200Response
    /// </summary>
    [DataContract(Name = "aiThreadsAppendUserMessage_200_response")]
    public partial class AiThreadsAppendUserMessage200Response : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiThreadsAppendUserMessage200Response" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiThreadsAppendUserMessage200Response() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiThreadsAppendUserMessage200Response" /> class.
        /// </summary>
        /// <param name="messageId">Identifier of the message that was appended to the thread. (required).</param>
        public AiThreadsAppendUserMessage200Response(string messageId = default)
        {
            // to ensure "messageId" is required (not null)
            if (messageId == null)
            {
                throw new ArgumentNullException("messageId is a required property for AiThreadsAppendUserMessage200Response and cannot be null");
            }
            this.MessageId = messageId;
        }

        /// <summary>
        /// Identifier of the message that was appended to the thread.
        /// </summary>
        /// <example>22222222-2222-2222-2222-222222222222</example>
        [DataMember(Name = "messageId", IsRequired = true, EmitDefaultValue = true)]
        public string MessageId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiThreadsAppendUserMessage200Response {\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
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
