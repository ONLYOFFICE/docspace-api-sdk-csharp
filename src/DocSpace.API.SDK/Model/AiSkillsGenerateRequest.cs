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
    /// AiSkillsGenerateRequest
    /// </summary>
    [DataContract(Name = "AiSkillsGenerateRequest")]
    public partial class AiSkillsGenerateRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiSkillsGenerateRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiSkillsGenerateRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiSkillsGenerateRequest" /> class.
        /// </summary>
        /// <param name="destId">destId (required).</param>
        /// <param name="title">The skill&#39;s title, at most 64 characters; its kebab-case form is the skill&#39;s name. (required).</param>
        /// <param name="description">What the skill should do, at most 2000 characters; a specification for the model. (required).</param>
        public AiSkillsGenerateRequest(AiSkillsGenerateRequestDestId destId = default, string title = default, string description = default)
        {
            // to ensure "destId" is required (not null)
            if (destId == null)
            {
                throw new ArgumentNullException("destId is a required property for AiSkillsGenerateRequest and cannot be null");
            }
            this.DestId = destId;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for AiSkillsGenerateRequest and cannot be null");
            }
            this.Title = title;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for AiSkillsGenerateRequest and cannot be null");
            }
            this.Description = description;
        }

        /// <summary>
        /// Gets or Sets DestId
        /// </summary>
        [DataMember(Name = "destId", IsRequired = true, EmitDefaultValue = true)]
        public AiSkillsGenerateRequestDestId DestId { get; set; }

        /// <summary>
        /// The skill&#39;s title, at most 64 characters; its kebab-case form is the skill&#39;s name.
        /// </summary>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// What the skill should do, at most 2000 characters; a specification for the model.
        /// </summary>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiSkillsGenerateRequest {\n");
            sb.Append("  DestId: ").Append(DestId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
