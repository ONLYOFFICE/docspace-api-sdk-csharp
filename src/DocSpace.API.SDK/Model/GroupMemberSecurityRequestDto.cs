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

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// The group member security information.
    /// </summary>
    [DataContract(Name = "GroupMemberSecurityRequestDto")]
    public partial class GroupMemberSecurityRequestDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets GroupAccess
        /// </summary>
        [DataMember(Name = "groupAccess", IsRequired = true, EmitDefaultValue = true)]
        public FileShare GroupAccess { get; set; }

        /// <summary>
        /// Gets or Sets UserAccess
        /// </summary>
        [DataMember(Name = "userAccess", EmitDefaultValue = false)]
        public FileShare? UserAccess { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupMemberSecurityRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupMemberSecurityRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupMemberSecurityRequestDto" /> class.
        /// </summary>
        /// <param name="user">user (required).</param>
        /// <param name="groupAccess">groupAccess (required).</param>
        /// <param name="userAccess">userAccess.</param>
        /// <param name="overridden">Specifies if the group access rights are overridden or not. (required).</param>
        /// <param name="canEditAccess">Specifies if the group member can edit the group access rights or not. (required).</param>
        /// <param name="owner">Specifies if the group member is a group owner or not. (required).</param>
        public GroupMemberSecurityRequestDto(EmployeeFullDto user = default, FileShare groupAccess = default, FileShare? userAccess = default, bool overridden = default, bool canEditAccess = default, bool owner = default)
        {
            // to ensure "user" is required (not null)
            if (user == null)
            {
                throw new ArgumentNullException("user is a required property for GroupMemberSecurityRequestDto and cannot be null");
            }
            this.User = user;
            this.GroupAccess = groupAccess;
            this.Overridden = overridden;
            this.CanEditAccess = canEditAccess;
            this.Owner = owner;
            this.UserAccess = userAccess;
        }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", IsRequired = true, EmitDefaultValue = true)]
        public EmployeeFullDto User { get; set; }

        /// <summary>
        /// Specifies if the group access rights are overridden or not.
        /// </summary>
        /// <value>Specifies if the group access rights are overridden or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "overridden", IsRequired = true, EmitDefaultValue = true)]
        public bool Overridden { get; set; }

        /// <summary>
        /// Specifies if the group member can edit the group access rights or not.
        /// </summary>
        /// <value>Specifies if the group member can edit the group access rights or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "canEditAccess", IsRequired = true, EmitDefaultValue = true)]
        public bool CanEditAccess { get; set; }

        /// <summary>
        /// Specifies if the group member is a group owner or not.
        /// </summary>
        /// <value>Specifies if the group member is a group owner or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "owner", IsRequired = true, EmitDefaultValue = true)]
        public bool Owner { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupMemberSecurityRequestDto {\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  GroupAccess: ").Append(GroupAccess).Append("\n");
            sb.Append("  UserAccess: ").Append(UserAccess).Append("\n");
            sb.Append("  Overridden: ").Append(Overridden).Append("\n");
            sb.Append("  CanEditAccess: ").Append(CanEditAccess).Append("\n");
            sb.Append("  Owner: ").Append(Owner).Append("\n");
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
