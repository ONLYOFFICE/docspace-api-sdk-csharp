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
    /// A personal collection of rooms: the name and icon it was given, the account that owns it, and the rooms it gathers  at the moment it was read.
    /// </summary>
    [DataContract(Name = "RoomGroupDto")]
    public partial class RoomGroupDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomGroupDto" /> class.
        /// </summary>
        /// <param name="id">The identifier of the group, which addresses it in every other group operation and is kept for as long as the  group exists..</param>
        /// <param name="name">The name its owner gave the group, stored trimmed of surrounding spaces. Names are not unique, so two groups  of the same account can be told apart only by their identifier..</param>
        /// <param name="icon">The built-in cover chosen for the group, carrying the cover identifier and its rendering in each available  size. Null when the group has no icon, either because it was never given one or because the icon was cleared  by setting it to an empty value..</param>
        /// <param name="userId">The account that created the group and the only one able to read, change or delete it; for any other member of  the portal the group does not exist..</param>
        /// <param name="rooms">The rooms the group gathers, those stored in the portal first and those on connected third-party accounts  after them. Null when the group was asked for without its members, and an empty array when the group holds no  room the caller can still see. A room moved to the archive is left out until it is taken out of the archive..</param>
        /// <param name="totalRooms">How many rooms the group shows: the same rooms &#x60;rooms&#x60; lists, so archived ones are not counted either. It is  filled even when the rooms themselves were not asked for, which makes it the cheap way to tell an empty group  from a populated one..</param>
        public RoomGroupDto(int id = default, string name = default, MultiSizeLogoCover icon = default, Guid userId = default, List<FileEntryBaseDto> rooms = default, int totalRooms = default)
        {
            this.Id = id;
            this.Name = name;
            this.Icon = icon;
            this.UserId = userId;
            this.Rooms = rooms;
            this.TotalRooms = totalRooms;
        }

        /// <summary>
        /// The identifier of the group, which addresses it in every other group operation and is kept for as long as the  group exists.
        /// </summary>
        /// <example>42</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The name its owner gave the group, stored trimmed of surrounding spaces. Names are not unique, so two groups  of the same account can be told apart only by their identifier.
        /// </summary>
        /// <example>Client projects</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The built-in cover chosen for the group, carrying the cover identifier and its rendering in each available  size. Null when the group has no icon, either because it was never given one or because the icon was cleared  by setting it to an empty value.
        /// </summary>
        [DataMember(Name = "icon", EmitDefaultValue = false)]
        public MultiSizeLogoCover Icon { get; set; }

        /// <summary>
        /// The account that created the group and the only one able to read, change or delete it; for any other member of  the portal the group does not exist.
        /// </summary>
        /// <example>9a1b2c3d-4e5f-6071-8293-a4b5c6d7e8f9</example>
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// The rooms the group gathers, those stored in the portal first and those on connected third-party accounts  after them. Null when the group was asked for without its members, and an empty array when the group holds no  room the caller can still see. A room moved to the archive is left out until it is taken out of the archive.
        /// </summary>
        /// <example>[{"title":"Client onboarding","fileEntryType":1}]</example>
        [DataMember(Name = "rooms", EmitDefaultValue = true)]
        public List<FileEntryBaseDto> Rooms { get; set; }

        /// <summary>
        /// How many rooms the group shows: the same rooms &#x60;rooms&#x60; lists, so archived ones are not counted either. It is  filled even when the rooms themselves were not asked for, which makes it the cheap way to tell an empty group  from a populated one.
        /// </summary>
        /// <example>2</example>
        [DataMember(Name = "totalRooms", EmitDefaultValue = false)]
        public int TotalRooms { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RoomGroupDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Rooms: ").Append(Rooms).Append("\n");
            sb.Append("  TotalRooms: ").Append(TotalRooms).Append("\n");
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
