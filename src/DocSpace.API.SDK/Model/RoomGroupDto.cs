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

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// The room security parameters.
    /// </summary>
    [DataContract(Name = "RoomGroupDto")]
    public partial class RoomGroupDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomGroupDto" /> class.
        /// </summary>
        /// <param name="id">The group ID..</param>
        /// <param name="name">Group name.</param>
        /// <param name="icon">icon.</param>
        /// <param name="userId">The user ID..</param>
        /// <param name="rooms">The list of rooms in the group..</param>
        /// <param name="totalRooms">Total number of rooms in the group..</param>
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
        /// The group ID.
        /// </summary>
        /// <value>The group ID.</value>
        /*
        <example>1</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// Group name
        /// </summary>
        /// <value>Group name</value>
        /*
        <example>John Doe</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Icon
        /// </summary>
        [DataMember(Name = "icon", EmitDefaultValue = false)]
        public MultiSizeLogoCover Icon { get; set; }

        /// <summary>
        /// The user ID.
        /// </summary>
        /// <value>The user ID.</value>
        /*
        <example>00000000-0000-0000-0000-000000000000</example>
        */
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// The list of rooms in the group.
        /// </summary>
        /// <value>The list of rooms in the group.</value>
        [DataMember(Name = "rooms", EmitDefaultValue = true)]
        public List<FileEntryBaseDto> Rooms { get; set; }

        /// <summary>
        /// Total number of rooms in the group.
        /// </summary>
        /// <value>Total number of rooms in the group.</value>
        /*
        <example>1234</example>
        */
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
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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
