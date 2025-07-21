// (c) Copyright Ascensio System SIA 2025
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


 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The request parameters for updating the room quota.
    /// </summary>
    [DataContract(Name = "UpdateRoomsQuotaRequestDtoInteger")]
    public partial class UpdateRoomsQuotaRequestDtoInteger : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateRoomsQuotaRequestDtoInteger" /> class.
        /// </summary>
        /// <param name="roomIds">The list of room IDs..</param>
        /// <param name="quota">The room quota..</param>
        public UpdateRoomsQuotaRequestDtoInteger(List<BaseBatchRequestDtoFolderIdsInner> roomIds = default, long quota = default)
        {
            this.RoomIds = roomIds;
            this.Quota = quota;
        }

        /// <summary>
        /// The list of room IDs.
        /// </summary>
        /// <value>The list of room IDs.</value>
        [DataMember(Name = "roomIds", EmitDefaultValue = true)]
        public List<BaseBatchRequestDtoFolderIdsInner> RoomIds { get; set; }

        /// <summary>
        /// The room quota.
        /// </summary>
        /// <value>The room quota.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "quota", EmitDefaultValue = false)]
        public long Quota { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateRoomsQuotaRequestDtoInteger {\n");
            sb.Append("  RoomIds: ").Append(RoomIds).Append("\n");
            sb.Append("  Quota: ").Append(Quota).Append("\n");
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
