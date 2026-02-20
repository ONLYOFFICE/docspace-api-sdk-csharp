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
    /// UpdateRoomGroupRequest
    /// </summary>
    [DataContract(Name = "UpdateRoomGroupRequest")]
    public partial class UpdateRoomGroupRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRoomGroupRequest" /> class.
        /// </summary>
        /// <param name="roomsToAdd">The list of room IDs to add to the group..</param>
        /// <param name="roomsToRemove">The list of room IDs to remove from the group..</param>
        /// <param name="groupName">The group name..</param>
        public UpdateRoomGroupRequest(List<DuplicateRequestDtoAllOfFileIds> roomsToAdd = default, List<DuplicateRequestDtoAllOfFileIds> roomsToRemove = default, string groupName = default)
        {
            this.RoomsToAdd = roomsToAdd;
            this.RoomsToRemove = roomsToRemove;
            this.GroupName = groupName;
        }

        /// <summary>
        /// The list of room IDs to add to the group.
        /// </summary>
        /// <value>The list of room IDs to add to the group.</value>
        [DataMember(Name = "roomsToAdd", EmitDefaultValue = true)]
        public List<DuplicateRequestDtoAllOfFileIds> RoomsToAdd { get; set; }

        /// <summary>
        /// The list of room IDs to remove from the group.
        /// </summary>
        /// <value>The list of room IDs to remove from the group.</value>
        [DataMember(Name = "roomsToRemove", EmitDefaultValue = true)]
        public List<DuplicateRequestDtoAllOfFileIds> RoomsToRemove { get; set; }

        /// <summary>
        /// The group name.
        /// </summary>
        /// <value>The group name.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "groupName", EmitDefaultValue = true)]
        public string GroupName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateRoomGroupRequest {\n");
            sb.Append("  RoomsToAdd: ").Append(RoomsToAdd).Append("\n");
            sb.Append("  RoomsToRemove: ").Append(RoomsToRemove).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
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
            // GroupName (string) maxLength
            if (this.GroupName != null && this.GroupName.Length > 128)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GroupName, length must be less than 128.", new [] { "GroupName" });
            }

            // GroupName (string) minLength
            if (this.GroupName != null && this.GroupName.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for GroupName, length must be greater than 0.", new [] { "GroupName" });
            }

            yield break;
        }

    }


}
