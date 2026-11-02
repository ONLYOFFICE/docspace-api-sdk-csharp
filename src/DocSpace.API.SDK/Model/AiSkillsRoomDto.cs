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
    /// An Instructions room with its skills.
    /// </summary>
    [DataContract(Name = "AiSkillsRoomDto")]
    public partial class AiSkillsRoomDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiSkillsRoomDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiSkillsRoomDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiSkillsRoomDto" /> class.
        /// </summary>
        /// <param name="id">ID of the room. (required).</param>
        /// <param name="title">Room title. (required).</param>
        /// <param name="logo">Room logo. (required).</param>
        /// <param name="skills">Skills of the room, sorted by file title. (required).</param>
        public AiSkillsRoomDto(int id = default, string title = default, LogoDto logo = default, List<AiSkillDto> skills = default)
        {
            this.Id = id;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for AiSkillsRoomDto and cannot be null");
            }
            this.Title = title;
            // to ensure "logo" is required (not null)
            if (logo == null)
            {
                throw new ArgumentNullException("logo is a required property for AiSkillsRoomDto and cannot be null");
            }
            this.Logo = logo;
            // to ensure "skills" is required (not null)
            if (skills == null)
            {
                throw new ArgumentNullException("skills is a required property for AiSkillsRoomDto and cannot be null");
            }
            this.Skills = skills;
        }

        /// <summary>
        /// ID of the room.
        /// </summary>
        /// <example>17001</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public int Id { get; set; }

        /// <summary>
        /// Room title.
        /// </summary>
        /// <example>Brand voice</example>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Room logo.
        /// </summary>
        [DataMember(Name = "logo", IsRequired = true, EmitDefaultValue = true)]
        public LogoDto Logo { get; set; }

        /// <summary>
        /// Skills of the room, sorted by file title.
        /// </summary>
        /// <example>[{"id":"9911","name":"brand-voice","description":"Writes marketing texts in the brand voice."}]</example>
        [DataMember(Name = "skills", IsRequired = true, EmitDefaultValue = true)]
        public List<AiSkillDto> Skills { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiSkillsRoomDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
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
