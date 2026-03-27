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
    /// The request for updating a group.
    /// </summary>
    [DataContract(Name = "UpdateGroupRequest")]
    public partial class UpdateGroupRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateGroupRequest" /> class.
        /// </summary>
        /// <param name="membersToAdd">The list of user IDs to add to the group..</param>
        /// <param name="membersToRemove">The list of user IDs to remove from the group..</param>
        /// <param name="groupManager">The group manager ID..</param>
        /// <param name="groupName">The group name..</param>
        public UpdateGroupRequest(List<Guid> membersToAdd = default, List<Guid> membersToRemove = default, Guid groupManager = default, string groupName = default)
        {
            this.MembersToAdd = membersToAdd;
            this.MembersToRemove = membersToRemove;
            this.GroupManager = groupManager;
            this.GroupName = groupName;
        }

        /// <summary>
        /// The list of user IDs to add to the group.
        /// </summary>
        /// <value>The list of user IDs to add to the group.</value>
        /*
        <example>["00000000-0000-0000-0000-000000000000"]</example>
        */
        [DataMember(Name = "membersToAdd", EmitDefaultValue = true)]
        public List<Guid> MembersToAdd { get; set; }

        /// <summary>
        /// The list of user IDs to remove from the group.
        /// </summary>
        /// <value>The list of user IDs to remove from the group.</value>
        /*
        <example>["11111111-1111-1111-1111-111111111111"]</example>
        */
        [DataMember(Name = "membersToRemove", EmitDefaultValue = true)]
        public List<Guid> MembersToRemove { get; set; }

        /// <summary>
        /// The group manager ID.
        /// </summary>
        /// <value>The group manager ID.</value>
        /*
        <example>00000000-0000-0000-0000-000000000000</example>
        */
        [DataMember(Name = "groupManager", EmitDefaultValue = false)]
        public Guid GroupManager { get; set; }

        /// <summary>
        /// The group name.
        /// </summary>
        /// <value>The group name.</value>
        /*
        <example>Sales Team</example>
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
            sb.Append("class UpdateGroupRequest {\n");
            sb.Append("  MembersToAdd: ").Append(MembersToAdd).Append("\n");
            sb.Append("  MembersToRemove: ").Append(MembersToRemove).Append("\n");
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
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
