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
    /// Delivery/generation status of the message.
    /// </summary>
    [DataContract(Name = "AiThreadMessageLike_status")]
    public partial class AiThreadMessageLikeStatus : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiThreadMessageLikeStatus" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiThreadMessageLikeStatus() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiThreadMessageLikeStatus" /> class.
        /// </summary>
        /// <param name="type">&#x60;running&#x60;, &#x60;requires-action&#x60;, &#x60;complete&#x60; or &#x60;incomplete&#x60;. (required).</param>
        /// <param name="reason">Why the message is in that state: &#x60;tool-calls&#x60; or &#x60;interrupt&#x60; for &#x60;requires-action&#x60;; &#x60;stop&#x60; or &#x60;unknown&#x60; for &#x60;complete&#x60;; &#x60;cancelled&#x60;, &#x60;tool-calls&#x60;, &#x60;length&#x60;, &#x60;content-filter&#x60;, &#x60;other&#x60; or &#x60;error&#x60; for &#x60;incomplete&#x60;. An &#x60;incomplete&#x60; message the chat stored carries &#x60;cancelled&#x60; (the round was stopped) or &#x60;error&#x60;..</param>
        /// <param name="error">What failed, on an &#x60;incomplete&#x60; message whose &#x60;reason&#x60; is &#x60;error&#x60;..</param>
        public AiThreadMessageLikeStatus(string type = default, string reason = default, AiChatErrorPayload error = default)
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new ArgumentNullException("type is a required property for AiThreadMessageLikeStatus and cannot be null");
            }
            this.Type = type;
            this.Reason = reason;
            this.Error = error;
        }

        /// <summary>
        /// &#x60;running&#x60;, &#x60;requires-action&#x60;, &#x60;complete&#x60; or &#x60;incomplete&#x60;.
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Why the message is in that state: &#x60;tool-calls&#x60; or &#x60;interrupt&#x60; for &#x60;requires-action&#x60;; &#x60;stop&#x60; or &#x60;unknown&#x60; for &#x60;complete&#x60;; &#x60;cancelled&#x60;, &#x60;tool-calls&#x60;, &#x60;length&#x60;, &#x60;content-filter&#x60;, &#x60;other&#x60; or &#x60;error&#x60; for &#x60;incomplete&#x60;. An &#x60;incomplete&#x60; message the chat stored carries &#x60;cancelled&#x60; (the round was stopped) or &#x60;error&#x60;.
        /// </summary>
        [DataMember(Name = "reason", EmitDefaultValue = false)]
        public string Reason { get; set; }

        /// <summary>
        /// What failed, on an &#x60;incomplete&#x60; message whose &#x60;reason&#x60; is &#x60;error&#x60;.
        /// </summary>
        [DataMember(Name = "error", EmitDefaultValue = false)]
        public AiChatErrorPayload Error { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiThreadMessageLikeStatus {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Reason: ").Append(Reason).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
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
