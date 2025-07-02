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
using FileParameter = DocSpace.Sdk.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.Sdk.Client.OpenAPIDateConverter;

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
            StringBuilder sb = new StringBuilder();
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
