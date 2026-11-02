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
    /// The sources of an AI project: the Instructions and Knowledge rooms linked to it.
    /// </summary>
    [DataContract(Name = "AiProjectSourcesDto")]
    public partial class AiProjectSourcesDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiProjectSourcesDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiProjectSourcesDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiProjectSourcesDto" /> class.
        /// </summary>
        /// <param name="instructionsRooms">Linked Instructions rooms, sorted by title. (required).</param>
        /// <param name="knowledgeRooms">Linked Knowledge rooms, sorted by title. (required).</param>
        public AiProjectSourcesDto(List<AiProjectSourceDto> instructionsRooms = default, List<AiProjectSourceDto> knowledgeRooms = default)
        {
            // to ensure "instructionsRooms" is required (not null)
            if (instructionsRooms == null)
            {
                throw new ArgumentNullException("instructionsRooms is a required property for AiProjectSourcesDto and cannot be null");
            }
            this.InstructionsRooms = instructionsRooms;
            // to ensure "knowledgeRooms" is required (not null)
            if (knowledgeRooms == null)
            {
                throw new ArgumentNullException("knowledgeRooms is a required property for AiProjectSourcesDto and cannot be null");
            }
            this.KnowledgeRooms = knowledgeRooms;
        }

        /// <summary>
        /// Linked Instructions rooms, sorted by title.
        /// </summary>
        /// <example>[{"id":17001,"title":"Brand voice"}]</example>
        [DataMember(Name = "instructionsRooms", IsRequired = true, EmitDefaultValue = true)]
        public List<AiProjectSourceDto> InstructionsRooms { get; set; }

        /// <summary>
        /// Linked Knowledge rooms, sorted by title.
        /// </summary>
        /// <example>[{"id":17020,"title":"Product catalogue"}]</example>
        [DataMember(Name = "knowledgeRooms", IsRequired = true, EmitDefaultValue = true)]
        public List<AiProjectSourceDto> KnowledgeRooms { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiProjectSourcesDto {\n");
            sb.Append("  InstructionsRooms: ").Append(InstructionsRooms).Append("\n");
            sb.Append("  KnowledgeRooms: ").Append(KnowledgeRooms).Append("\n");
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
