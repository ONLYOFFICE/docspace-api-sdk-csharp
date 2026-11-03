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
    /// One Instructions room a round runs with as context: the account and room ID from &#x60;GET api/2.0/ai/context/get-context-folders&#x60;, plus the skills of the room the round may use.
    /// </summary>
    [DataContract(Name = "AiContextRoomRef")]
    public partial class AiContextRoomRef : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiContextRoomRef" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiContextRoomRef() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiContextRoomRef" /> class.
        /// </summary>
        /// <param name="cloud">The account the room belongs to; &#x60;docspace&#x60; for a room of this portal. (required).</param>
        /// <param name="id">The room ID. (required).</param>
        /// <param name="skills">The skills of the room the round may use, as &#x60;GET api/2.0/ai/context/get-room-skills&#x60; lists them..</param>
        public AiContextRoomRef(string cloud = default, string id = default, List<AiRoomSkill> skills = default)
        {
            // to ensure "cloud" is required (not null)
            if (cloud == null)
            {
                throw new ArgumentNullException("cloud is a required property for AiContextRoomRef and cannot be null");
            }
            this.Cloud = cloud;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for AiContextRoomRef and cannot be null");
            }
            this.Id = id;
            this.Skills = skills;
        }

        /// <summary>
        /// The account the room belongs to; &#x60;docspace&#x60; for a room of this portal.
        /// </summary>
        /// <example>docspace</example>
        [DataMember(Name = "cloud", IsRequired = true, EmitDefaultValue = true)]
        public string Cloud { get; set; }

        /// <summary>
        /// The room ID.
        /// </summary>
        /// <example>1234</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The skills of the room the round may use, as &#x60;GET api/2.0/ai/context/get-room-skills&#x60; lists them.
        /// </summary>
        /// <example>[]</example>
        [DataMember(Name = "skills", EmitDefaultValue = false)]
        public List<AiRoomSkill> Skills { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiContextRoomRef {\n");
            sb.Append("  Cloud: ").Append(Cloud).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Skills: ").Append(Skills).Append("\n");
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
