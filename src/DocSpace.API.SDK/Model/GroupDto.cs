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
    /// The group parameters.
    /// </summary>
    [DataContract(Name = "GroupDto")]
    public partial class GroupDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupDto" /> class.
        /// </summary>
        /// <param name="name">The group name. (required).</param>
        /// <param name="parent">The parent group ID..</param>
        /// <param name="category">The group category ID. (required).</param>
        /// <param name="id">The group ID. (required).</param>
        /// <param name="isLDAP">Specifies if the LDAP settings are enabled for the group or not. (required).</param>
        /// <param name="isSystem">Indicates whether the group is a system group..</param>
        /// <param name="manager">manager.</param>
        /// <param name="members">The list of group members..</param>
        /// <param name="shared">Specifies whether the group can be shared or not..</param>
        /// <param name="membersCount">The number of group members..</param>
        public GroupDto(string name = default, Guid? parent = default, Guid category = default, Guid id = default, bool isLDAP = default, bool? isSystem = default, EmployeeFullDto manager = default, List<EmployeeFullDto> members = default, bool? shared = default, int membersCount = default)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for GroupDto and cannot be null");
            }
            this.Name = name;
            this.Category = category;
            this.Id = id;
            this.IsLDAP = isLDAP;
            this.Parent = parent;
            this.IsSystem = isSystem;
            this.Manager = manager;
            this.Members = members;
            this.Shared = shared;
            this.MembersCount = membersCount;
        }

        /// <summary>
        /// The group name.
        /// </summary>
        /// <value>The group name.</value>
        /*
        <example>Marketing Team</example>
        */
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The parent group ID.
        /// </summary>
        /// <value>The parent group ID.</value>
        /*
        <example>00000000-0000-0000-0000-000000000000</example>
        */
        [DataMember(Name = "parent", EmitDefaultValue = true)]
        public Guid? Parent { get; set; }

        /// <summary>
        /// The group category ID.
        /// </summary>
        /// <value>The group category ID.</value>
        /*
        <example>00000000-0000-0000-0000-000000000000</example>
        */
        [DataMember(Name = "category", IsRequired = true, EmitDefaultValue = true)]
        public Guid Category { get; set; }

        /// <summary>
        /// The group ID.
        /// </summary>
        /// <value>The group ID.</value>
        /*
        <example>00000000-0000-0000-0000-000000000000</example>
        */
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Specifies if the LDAP settings are enabled for the group or not.
        /// </summary>
        /// <value>Specifies if the LDAP settings are enabled for the group or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "isLDAP", IsRequired = true, EmitDefaultValue = true)]
        public bool IsLDAP { get; set; }

        /// <summary>
        /// Indicates whether the group is a system group.
        /// </summary>
        /// <value>Indicates whether the group is a system group.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "isSystem", EmitDefaultValue = true)]
        public bool? IsSystem { get; set; }

        /// <summary>
        /// Gets or Sets Manager
        /// </summary>
        [DataMember(Name = "manager", EmitDefaultValue = false)]
        public EmployeeFullDto Manager { get; set; }

        /// <summary>
        /// The list of group members.
        /// </summary>
        /// <value>The list of group members.</value>
        /*
        <example>[{&quot;displayName&quot;:&quot;John Doe&quot;}]</example>
        */
        [DataMember(Name = "members", EmitDefaultValue = true)]
        public List<EmployeeFullDto> Members { get; set; }

        /// <summary>
        /// Specifies whether the group can be shared or not.
        /// </summary>
        /// <value>Specifies whether the group can be shared or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "shared", EmitDefaultValue = true)]
        public bool? Shared { get; set; }

        /// <summary>
        /// The number of group members.
        /// </summary>
        /// <value>The number of group members.</value>
        /*
        <example>0</example>
        */
        [DataMember(Name = "membersCount", EmitDefaultValue = false)]
        public int MembersCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GroupDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsLDAP: ").Append(IsLDAP).Append("\n");
            sb.Append("  IsSystem: ").Append(IsSystem).Append("\n");
            sb.Append("  Manager: ").Append(Manager).Append("\n");
            sb.Append("  Members: ").Append(Members).Append("\n");
            sb.Append("  Shared: ").Append(Shared).Append("\n");
            sb.Append("  MembersCount: ").Append(MembersCount).Append("\n");
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
