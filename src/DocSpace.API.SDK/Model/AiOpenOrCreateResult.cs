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
    /// Resolved thread state returned by &#x60;ThreadsEngine.openOrCreate&#x60;.
    /// </summary>
    [DataContract(Name = "AiOpenOrCreateResult")]
    public partial class AiOpenOrCreateResult : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiOpenOrCreateResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiOpenOrCreateResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiOpenOrCreateResult" /> class.
        /// </summary>
        /// <param name="threadId">The thread that was opened, or the one just created. (required).</param>
        /// <param name="title">Empty string for existing threads — the engine doesn&#39;t re-fetch. (required).</param>
        /// <param name="priorMessages">The messages already in the thread - empty for a thread that was just created. (required).</param>
        public AiOpenOrCreateResult(string threadId = default, string title = default, List<AiThreadMessageLike> priorMessages = default)
        {
            // to ensure "threadId" is required (not null)
            if (threadId == null)
            {
                throw new ArgumentNullException("threadId is a required property for AiOpenOrCreateResult and cannot be null");
            }
            this.ThreadId = threadId;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for AiOpenOrCreateResult and cannot be null");
            }
            this.Title = title;
            // to ensure "priorMessages" is required (not null)
            if (priorMessages == null)
            {
                throw new ArgumentNullException("priorMessages is a required property for AiOpenOrCreateResult and cannot be null");
            }
            this.PriorMessages = priorMessages;
        }

        /// <summary>
        /// The thread that was opened, or the one just created.
        /// </summary>
        [DataMember(Name = "threadId", IsRequired = true, EmitDefaultValue = true)]
        public string ThreadId { get; set; }

        /// <summary>
        /// Empty string for existing threads — the engine doesn&#39;t re-fetch.
        /// </summary>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The messages already in the thread - empty for a thread that was just created.
        /// </summary>
        [DataMember(Name = "priorMessages", IsRequired = true, EmitDefaultValue = true)]
        public List<AiThreadMessageLike> PriorMessages { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiOpenOrCreateResult {\n");
            sb.Append("  ThreadId: ").Append(ThreadId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  PriorMessages: ").Append(PriorMessages).Append("\n");
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
