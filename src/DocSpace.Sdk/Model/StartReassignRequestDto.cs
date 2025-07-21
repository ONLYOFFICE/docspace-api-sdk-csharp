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
    /// The request parameters for starting the reassignment process.
    /// </summary>
    [DataContract(Name = "StartReassignRequestDto")]
    public partial class StartReassignRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StartReassignRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StartReassignRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StartReassignRequestDto" /> class.
        /// </summary>
        /// <param name="fromUserId">The user ID whose data will be reassigned to another user. (required).</param>
        /// <param name="toUserId">The user ID to whom all the data will be reassigned. (required).</param>
        /// <param name="deleteProfile">Specifies whether to delete a profile when the data reassignment will be finished or not..</param>
        public StartReassignRequestDto(Guid fromUserId = default, Guid toUserId = default, bool deleteProfile = default)
        {
            this.FromUserId = fromUserId;
            this.ToUserId = toUserId;
            this.DeleteProfile = deleteProfile;
        }

        /// <summary>
        /// The user ID whose data will be reassigned to another user.
        /// </summary>
        /// <value>The user ID whose data will be reassigned to another user.</value>
        /*
        <example>75a5f745-f697-4418-b38d-0fe0d277e258</example>
        */
        [DataMember(Name = "fromUserId", IsRequired = true, EmitDefaultValue = true)]
        public Guid FromUserId { get; set; }

        /// <summary>
        /// The user ID to whom all the data will be reassigned.
        /// </summary>
        /// <value>The user ID to whom all the data will be reassigned.</value>
        /*
        <example>75a5f745-f697-4418-b38d-0fe0d277e258</example>
        */
        [DataMember(Name = "toUserId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ToUserId { get; set; }

        /// <summary>
        /// Specifies whether to delete a profile when the data reassignment will be finished or not.
        /// </summary>
        /// <value>Specifies whether to delete a profile when the data reassignment will be finished or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "deleteProfile", EmitDefaultValue = true)]
        public bool DeleteProfile { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartReassignRequestDto {\n");
            sb.Append("  FromUserId: ").Append(FromUserId).Append("\n");
            sb.Append("  ToUserId: ").Append(ToUserId).Append("\n");
            sb.Append("  DeleteProfile: ").Append(DeleteProfile).Append("\n");
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
