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
    /// One member of a portal group together with the access that member has on the file or folder the group was granted  rights to. Every line of the answer describes the same file or folder and differs only in the member and in the  level that applies to them.
    /// </summary>
    [DataContract(Name = "GroupMemberSecurityRequestDto")]
    public partial class GroupMemberSecurityRequestDto : IValidatableObject
    {

        /// <summary>
        /// The level granted to the group as a whole on this file or folder. It belongs to the group record rather than  to the member, so the same value repeats on every line of the answer; a group whose record was set back to  none is answered with an empty list instead.
        /// </summary>
        [DataMember(Name = "groupAccess", IsRequired = true, EmitDefaultValue = true)]
        public FileShare GroupAccess { get; set; }

        /// <summary>
        /// The level granted to this member alone on the same file or folder, or &#x60;null&#x60; when the member has no record of  their own and the group level is what applies. The member who created the file or folder is always reported  here as a room manager, whatever their own record says.
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
        /// <param name="user">The member the line is about, as the portal reports the account: the display name, the avatar and the portal  role to show next to the access level. (required).</param>
        /// <param name="groupAccess">The level granted to the group as a whole on this file or folder. It belongs to the group record rather than  to the member, so the same value repeats on every line of the answer; a group whose record was set back to  none is answered with an empty list instead. (required).</param>
        /// <param name="userAccess">The level granted to this member alone on the same file or folder, or &#x60;null&#x60; when the member has no record of  their own and the group level is what applies. The member who created the file or folder is always reported  here as a room manager, whatever their own record says..</param>
        /// <param name="overridden">Whether &#x60;userAccess&#x60; is the level that decides what the member may do. When it is false the member inherits  &#x60;groupAccess&#x60;, and the creator of the file or folder is always reported as overridden because of the room  manager level forced onto them. (required).</param>
        /// <param name="canEditAccess">Whether the caller may still change the level of this member. It comes back false on the line of the member  who created the file or folder, on the line of the caller themselves, and on every line at once when the  caller may read the file or folder but not manage access to it. (required).</param>
        /// <param name="owner">Whether this member created the file or folder - the owner of the entry, not the owner of the group. Their  level is reported as a room manager one and cannot be taken away through this group. (required).</param>
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
        /// The member the line is about, as the portal reports the account: the display name, the avatar and the portal  role to show next to the access level.
        /// </summary>
        [DataMember(Name = "user", IsRequired = true, EmitDefaultValue = true)]
        public EmployeeFullDto User { get; set; }

        /// <summary>
        /// Whether &#x60;userAccess&#x60; is the level that decides what the member may do. When it is false the member inherits  &#x60;groupAccess&#x60;, and the creator of the file or folder is always reported as overridden because of the room  manager level forced onto them.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "overridden", IsRequired = true, EmitDefaultValue = true)]
        public bool Overridden { get; set; }

        /// <summary>
        /// Whether the caller may still change the level of this member. It comes back false on the line of the member  who created the file or folder, on the line of the caller themselves, and on every line at once when the  caller may read the file or folder but not manage access to it.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "canEditAccess", IsRequired = true, EmitDefaultValue = true)]
        public bool CanEditAccess { get; set; }

        /// <summary>
        /// Whether this member created the file or folder - the owner of the entry, not the owner of the group. Their  level is reported as a room manager one and cannot be taken away through this group.
        /// </summary>
        /// <example>false</example>
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
