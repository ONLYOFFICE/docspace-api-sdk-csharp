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
using FileParameter = Docspace.Client.FileParameter;
using OpenAPIDateConverter = Docspace.Client.OpenAPIDateConverter;

namespace Docspace.Model
{
    /// <summary>
    /// The security information.
    /// </summary>
    [DataContract(Name = "SecurityDto")]
    public partial class SecurityDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SecurityDto" /> class.
        /// </summary>
        /// <param name="webItemId">The module ID..</param>
        /// <param name="users">The list of users with the access to the module..</param>
        /// <param name="groups">The list of groups with the access to the module..</param>
        /// <param name="enabled">Specifies if the security settings are enabled or not..</param>
        /// <param name="isSubItem">Specifies if the module is a subitem or not..</param>
        public SecurityDto(string webItemId = default, List<EmployeeDto> users = default, List<GroupSummaryDto> groups = default, bool enabled = default, bool isSubItem = default)
        {
            this.WebItemId = webItemId;
            this.Users = users;
            this.Groups = groups;
            this.Enabled = enabled;
            this.IsSubItem = isSubItem;
        }

        /// <summary>
        /// The module ID.
        /// </summary>
        /// <value>The module ID.</value>
        /*
        <example>{00000000-0000-0000-0000-000000000000}</example>
        */
        [DataMember(Name = "webItemId", EmitDefaultValue = true)]
        public string WebItemId { get; set; }

        /// <summary>
        /// The list of users with the access to the module.
        /// </summary>
        /// <value>The list of users with the access to the module.</value>
        [DataMember(Name = "users", EmitDefaultValue = true)]
        public List<EmployeeDto> Users { get; set; }

        /// <summary>
        /// The list of groups with the access to the module.
        /// </summary>
        /// <value>The list of groups with the access to the module.</value>
        [DataMember(Name = "groups", EmitDefaultValue = true)]
        public List<GroupSummaryDto> Groups { get; set; }

        /// <summary>
        /// Specifies if the security settings are enabled or not.
        /// </summary>
        /// <value>Specifies if the security settings are enabled or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Specifies if the module is a subitem or not.
        /// </summary>
        /// <value>Specifies if the module is a subitem or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "isSubItem", EmitDefaultValue = true)]
        public bool IsSubItem { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SecurityDto {\n");
            sb.Append("  WebItemId: ").Append(WebItemId).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  Groups: ").Append(Groups).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  IsSubItem: ").Append(IsSubItem).Append("\n");
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
