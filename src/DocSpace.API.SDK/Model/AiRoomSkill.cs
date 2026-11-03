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
    /// A skill of an Instructions room: the frontmatter of one Markdown skill file. &#x60;name&#x60; and &#x60;description&#x60; are what the model is shown; the body is read through &#x60;GET api/2.0/ai/context/get-room-skill&#x60;.
    /// </summary>
    [DataContract(Name = "AiRoomSkill")]
    public partial class AiRoomSkill : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiRoomSkill" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiRoomSkill() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiRoomSkill" /> class.
        /// </summary>
        /// <param name="id">The skill&#39;s ID, as &#x60;GET api/2.0/ai/context/get-room-skill&#x60; takes it. (required).</param>
        /// <param name="name">The skill&#39;s name, from its frontmatter. (required).</param>
        /// <param name="description">What the skill is for, from its frontmatter; empty when it declares none. (required).</param>
        public AiRoomSkill(string id = default, string name = default, string description = default)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for AiRoomSkill and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AiRoomSkill and cannot be null");
            }
            this.Name = name;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for AiRoomSkill and cannot be null");
            }
            this.Description = description;
        }

        /// <summary>
        /// The skill&#39;s ID, as &#x60;GET api/2.0/ai/context/get-room-skill&#x60; takes it.
        /// </summary>
        /// <example>5678</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The skill&#39;s name, from its frontmatter.
        /// </summary>
        /// <example>contract-review</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// What the skill is for, from its frontmatter; empty when it declares none.
        /// </summary>
        /// <example>How to review a supply contract.</example>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiRoomSkill {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
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
