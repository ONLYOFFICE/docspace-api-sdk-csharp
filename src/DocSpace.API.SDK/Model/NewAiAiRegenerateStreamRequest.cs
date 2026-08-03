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
    /// NewAiAiRegenerateStreamRequest
    /// </summary>
    [DataContract(Name = "newAiAiRegenerateStream_request")]
    public partial class NewAiAiRegenerateStreamRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiAiRegenerateStreamRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewAiAiRegenerateStreamRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiAiRegenerateStreamRequest" /> class.
        /// </summary>
        /// <param name="threadId">Target thread (must already exist). (required).</param>
        /// <param name="actionArgs">actionArgs.</param>
        /// <param name="entityId">entityId.</param>
        /// <param name="profileId">profileId.</param>
        public NewAiAiRegenerateStreamRequest(string threadId = default, NewAiAiActionArgs actionArgs = default, string entityId = default, string profileId = default)
        {
            // to ensure "threadId" is required (not null)
            if (threadId == null)
            {
                throw new ArgumentNullException("threadId is a required property for NewAiAiRegenerateStreamRequest and cannot be null");
            }
            this.ThreadId = threadId;
            this.ActionArgs = actionArgs;
            this.EntityId = entityId;
            this.ProfileId = profileId;
        }

        /// <summary>
        /// Target thread (must already exist).
        /// </summary>
        /// <value>Target thread (must already exist).</value>
        [DataMember(Name = "threadId", IsRequired = true, EmitDefaultValue = true)]
        public string ThreadId { get; set; }

        /// <summary>
        /// Gets or Sets ActionArgs
        /// </summary>
        [DataMember(Name = "actionArgs", EmitDefaultValue = false)]
        public NewAiAiActionArgs ActionArgs { get; set; }

        /// <summary>
        /// Gets or Sets EntityId
        /// </summary>
        [DataMember(Name = "entityId", EmitDefaultValue = false)]
        public string EntityId { get; set; }

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
            sb.Append("class NewAiAiRegenerateStreamRequest {\n");
            sb.Append("  ThreadId: ").Append(ThreadId).Append("\n");
            sb.Append("  ActionArgs: ").Append(ActionArgs).Append("\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
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
