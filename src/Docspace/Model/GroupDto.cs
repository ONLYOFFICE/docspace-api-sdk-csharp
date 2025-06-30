// (c) Copyright Ascensio System SIA 2009-2025
// 
// This program is a free software product.
// You can redistribute it and/or modify it under the terms
// of the GNU Affero General Public License (AGPL) version 3 as published by the Free Software
// Foundation. In accordance with Section 7(a) of the GNU AGPL its Section 15 shall be amended
// to the effect that Ascensio System SIA expressly excludes the warranty of non-infringement of
// any third-party rights.
// 
// This program is distributed WITHOUT ANY WARRANTY, without even the implied warranty
// of MERCHANTABILITY or FITNESS FOR A PARTICULAR  PURPOSE. For details, see
// the GNU AGPL at: http://www.gnu.org/licenses/agpl-3.0.html
// 
// You can contact Ascensio System SIA at Lubanas st. 125a-25, Riga, Latvia, EU, LV-1021.
// 
// The  interactive user interfaces in modified source and object code versions of the Program must
// display Appropriate Legal Notices, as required under Section 5 of the GNU AGPL version 3.
// 
// Pursuant to Section 7(b) of the License you must retain the original Product logo when
// distributing the program. Pursuant to Section 7(e) we decline to grant you any rights under
// trademark law for use of our trademarks.
// 
// All the Product's GUI elements, including illustrations and icon sets, as well as technical writing
// content are licensed under the terms of the Creative Commons Attribution-ShareAlike 4.0
// International. See the License terms at http://creativecommons.org/licenses/by-sa/4.0/legalcode


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
using FileParameter = DocSpace.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.Client.OpenAPIDateConverter;

namespace DocSpace.Model
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
        /// <param name="name">The group name..</param>
        /// <param name="parent">The parent group ID..</param>
        /// <param name="category">The group category ID..</param>
        /// <param name="id">The group ID..</param>
        /// <param name="isLDAP">Specifies if the LDAP settings are enabled for the group or not..</param>
        /// <param name="manager">manager.</param>
        /// <param name="members">The list of group members..</param>
        /// <param name="shared">Specifies whether the group can be shared or not..</param>
        /// <param name="membersCount">The number of group members..</param>
        public GroupDto(string name = default, Guid? parent = default, Guid category = default, Guid id = default, bool isLDAP = default, EmployeeFullDto manager = default, List<EmployeeFullDto> members = default, bool? shared = default, int membersCount = default)
        {
            this.Name = name;
            this.Parent = parent;
            this.Category = category;
            this.Id = id;
            this.IsLDAP = isLDAP;
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
        <example>Winfield Upton</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The parent group ID.
        /// </summary>
        /// <value>The parent group ID.</value>
        /*
        <example>75a5f745-f697-4418-b38d-0fe0d277e258</example>
        */
        [DataMember(Name = "parent", EmitDefaultValue = true)]
        public Guid? Parent { get; set; }

        /// <summary>
        /// The group category ID.
        /// </summary>
        /// <value>The group category ID.</value>
        /*
        <example>75a5f745-f697-4418-b38d-0fe0d277e258</example>
        */
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public Guid Category { get; set; }

        /// <summary>
        /// The group ID.
        /// </summary>
        /// <value>The group ID.</value>
        /*
        <example>aae1e103-bca5-9fa1-ba8c-42058b4abf28</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Specifies if the LDAP settings are enabled for the group or not.
        /// </summary>
        /// <value>Specifies if the LDAP settings are enabled for the group or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isLDAP", EmitDefaultValue = true)]
        public bool IsLDAP { get; set; }

        /// <summary>
        /// Gets or Sets Manager
        /// </summary>
        [DataMember(Name = "manager", EmitDefaultValue = false)]
        public EmployeeFullDto Manager { get; set; }

        /// <summary>
        /// The list of group members.
        /// </summary>
        /// <value>The list of group members.</value>
        [DataMember(Name = "members", EmitDefaultValue = true)]
        public List<EmployeeFullDto> Members { get; set; }

        /// <summary>
        /// Specifies whether the group can be shared or not.
        /// </summary>
        /// <value>Specifies whether the group can be shared or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "shared", EmitDefaultValue = true)]
        public bool? Shared { get; set; }

        /// <summary>
        /// The number of group members.
        /// </summary>
        /// <value>The number of group members.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "membersCount", EmitDefaultValue = false)]
        public int MembersCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Parent: ").Append(Parent).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  IsLDAP: ").Append(IsLDAP).Append("\n");
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
