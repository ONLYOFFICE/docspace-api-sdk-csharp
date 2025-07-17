/**
 *
 * (c) Copyright Ascensio System SIA 2025
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The group request parameters.
    /// </summary>
    [DataContract(Name = "GroupRequestDto")]
    public partial class GroupRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupRequestDto" /> class.
        /// </summary>
        /// <param name="members">The list of group member IDs..</param>
        /// <param name="groupManager">Group manager ID (required).</param>
        /// <param name="groupName">Group name.</param>
        public GroupRequestDto(List<Guid> members = default, Guid groupManager = default, string groupName = default)
        {
            this.GroupManager = groupManager;
            this.Members = members;
            this.GroupName = groupName;
        }

        /// <summary>
        /// The list of group member IDs.
        /// </summary>
        /// <value>The list of group member IDs.</value>
        /*
        <example>[&quot;75a5f745-f697-4418-b38d-0fe0d277e258&quot;]</example>
        */
        [DataMember(Name = "members", EmitDefaultValue = true)]
        public List<Guid> Members { get; set; }

        /// <summary>
        /// Group manager ID
        /// </summary>
        /// <value>Group manager ID</value>
        /*
        <example>75a5f745-f697-4418-b38d-0fe0d277e258</example>
        */
        [DataMember(Name = "groupManager", IsRequired = true, EmitDefaultValue = true)]
        public Guid GroupManager { get; set; }

        /// <summary>
        /// Group name
        /// </summary>
        /// <value>Group name</value>
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
            sb.Append("class GroupRequestDto {\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  GroupManager: ").Append(GroupManager).Append("\n");
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
