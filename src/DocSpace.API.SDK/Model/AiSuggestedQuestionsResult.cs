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
    /// The starter questions of an attached form, and whether they are ready.
    /// </summary>
    [DataContract(Name = "AiSuggestedQuestionsResult")]
    public partial class AiSuggestedQuestionsResult : IValidatableObject
    {
        /// <summary>
        /// &#x60;ready&#x60; - the questions are there; &#x60;pending&#x60; - they are being generated and arrive over the socket, ask again later; &#x60;unavailable&#x60; - the attachment is not a form that can have any.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum Ready for value: ready
            /// </summary>
            [EnumMember(Value = "ready")]
            Ready,

            /// <summary>
            /// Enum Pending for value: pending
            /// </summary>
            [EnumMember(Value = "pending")]
            Pending,

            /// <summary>
            /// Enum Unavailable for value: unavailable
            /// </summary>
            [EnumMember(Value = "unavailable")]
            Unavailable
        }

        /// <summary>
        /// &#x60;ready&#x60; - the questions are there; &#x60;pending&#x60; - they are being generated and arrive over the socket, ask again later; &#x60;unavailable&#x60; - the attachment is not a form that can have any.
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public StatusEnum Status { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiSuggestedQuestionsResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiSuggestedQuestionsResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiSuggestedQuestionsResult" /> class.
        /// </summary>
        /// <param name="status">&#x60;ready&#x60; - the questions are there; &#x60;pending&#x60; - they are being generated and arrive over the socket, ask again later; &#x60;unavailable&#x60; - the attachment is not a form that can have any. (required).</param>
        /// <param name="questions">The questions; empty unless &#x60;status&#x60; is &#x60;ready&#x60;. (required).</param>
        public AiSuggestedQuestionsResult(StatusEnum status = default, List<AiSuggestedQuestion> questions = default)
        {
            this.Status = status;
            // to ensure "questions" is required (not null)
            if (questions == null)
            {
                throw new ArgumentNullException("questions is a required property for AiSuggestedQuestionsResult and cannot be null");
            }
            this.Questions = questions;
        }

        /// <summary>
        /// The questions; empty unless &#x60;status&#x60; is &#x60;ready&#x60;.
        /// </summary>
        [DataMember(Name = "questions", IsRequired = true, EmitDefaultValue = true)]
        public List<AiSuggestedQuestion> Questions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiSuggestedQuestionsResult {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Questions: ").Append(Questions).Append("\n");
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
