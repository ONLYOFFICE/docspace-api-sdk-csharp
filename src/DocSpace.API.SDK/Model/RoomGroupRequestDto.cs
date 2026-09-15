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
    /// The name, the icon and the rooms of a room group to create.
    /// </summary>
    [DataContract(Name = "RoomGroupRequestDto")]
    public partial class RoomGroupRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomGroupRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RoomGroupRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomGroupRequestDto" /> class.
        /// </summary>
        /// <param name="name">The name to show the group under. Surrounding spaces are trimmed before it is stored, a name that is blank  once trimmed is refused, and the name does not have to differ from the names of the caller&#39;s other groups. (required).</param>
        /// <param name="icon">The icon of the group, given as the identifier of one of the built-in covers listed by  &#x60;GET api/2.0/files/rooms/covers&#x60;. An uploaded image cannot be used, and any value that is not one of those  identifiers is refused. (required).</param>
        /// <param name="rooms">The rooms to gather in the group, each given as a number for a room stored in the portal or as a string for a  room on a connected third-party account. Every identifier has to name a room the caller can read; repeats are  collapsed, and an element of any other shape - a decimal number, a number sent as a string, null - is refused. (required).</param>
        public RoomGroupRequestDto(string name = default, string icon = default, List<DuplicateRequestDtoAllOfFileIds> rooms = default)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for RoomGroupRequestDto and cannot be null");
            }
            this.Name = name;
            // to ensure "icon" is required (not null)
            if (icon == null)
            {
                throw new ArgumentNullException("icon is a required property for RoomGroupRequestDto and cannot be null");
            }
            this.Icon = icon;
            // to ensure "rooms" is required (not null)
            if (rooms == null)
            {
                throw new ArgumentNullException("rooms is a required property for RoomGroupRequestDto and cannot be null");
            }
            this.Rooms = rooms;
        }

        /// <summary>
        /// The name to show the group under. Surrounding spaces are trimmed before it is stored, a name that is blank  once trimmed is refused, and the name does not have to differ from the names of the caller&#39;s other groups.
        /// </summary>
        /// <example>Client projects</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The icon of the group, given as the identifier of one of the built-in covers listed by  &#x60;GET api/2.0/files/rooms/covers&#x60;. An uploaded image cannot be used, and any value that is not one of those  identifiers is refused.
        /// </summary>
        /// <example>star</example>
        [DataMember(Name = "icon", IsRequired = true, EmitDefaultValue = true)]
        public string Icon { get; set; }

        /// <summary>
        /// The rooms to gather in the group, each given as a number for a room stored in the portal or as a string for a  room on a connected third-party account. Every identifier has to name a room the caller can read; repeats are  collapsed, and an element of any other shape - a decimal number, a number sent as a string, null - is refused.
        /// </summary>
        /// <example>[12,15,"folder-123-abc"]</example>
        [DataMember(Name = "rooms", IsRequired = true, EmitDefaultValue = true)]
        public List<DuplicateRequestDtoAllOfFileIds> Rooms { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoomGroupRequestDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Rooms: ").Append(Rooms).Append("\n");
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 128.", new [] { "Name" });
            }

            // Name (string) minLength
            if (this.Name != null && this.Name.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 0.", new [] { "Name" });
            }

            // Icon (string) maxLength
            if (this.Icon != null && this.Icon.Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Icon, length must be less than 50.", new [] { "Icon" });
            }

            // Icon (string) minLength
            if (this.Icon != null && this.Icon.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Icon, length must be greater than 0.", new [] { "Icon" });
            }

            yield break;
        }

    }


}
