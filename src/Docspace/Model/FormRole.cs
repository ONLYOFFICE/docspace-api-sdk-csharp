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
    /// The form role.
    /// </summary>
    [DataContract(Name = "FormRole")]
    public partial class FormRole : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormRole" /> class.
        /// </summary>
        /// <param name="roomId">The room ID..</param>
        /// <param name="roleName">The role name..</param>
        /// <param name="roleColor">The role color..</param>
        /// <param name="userId">The user ID..</param>
        /// <param name="sequence">The role sequence..</param>
        /// <param name="submitted">Specifies if the role was submitted or not..</param>
        /// <param name="openedAt">The date and time when the role was opened..</param>
        /// <param name="submissionDate">The date and time when the role was submitted..</param>
        public FormRole(int roomId = default, string roleName = default, string roleColor = default, Guid userId = default, int sequence = default, bool submitted = default, DateTime openedAt = default, DateTime submissionDate = default)
        {
            this.RoomId = roomId;
            this.RoleName = roleName;
            this.RoleColor = roleColor;
            this.UserId = userId;
            this.Sequence = sequence;
            this.Submitted = submitted;
            this.OpenedAt = openedAt;
            this.SubmissionDate = submissionDate;
        }

        /// <summary>
        /// The room ID.
        /// </summary>
        /// <value>The room ID.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "roomId", EmitDefaultValue = false)]
        public int RoomId { get; set; }

        /// <summary>
        /// The role name.
        /// </summary>
        /// <value>The role name.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "roleName", EmitDefaultValue = true)]
        public string RoleName { get; set; }

        /// <summary>
        /// The role color.
        /// </summary>
        /// <value>The role color.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "roleColor", EmitDefaultValue = true)]
        public string RoleColor { get; set; }

        /// <summary>
        /// The user ID.
        /// </summary>
        /// <value>The user ID.</value>
        /*
        <example>aae1e103-bca5-9fa1-ba8c-42058b4abf28</example>
        */
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// The role sequence.
        /// </summary>
        /// <value>The role sequence.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "sequence", EmitDefaultValue = false)]
        public int Sequence { get; set; }

        /// <summary>
        /// Specifies if the role was submitted or not.
        /// </summary>
        /// <value>Specifies if the role was submitted or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "submitted", EmitDefaultValue = true)]
        public bool Submitted { get; set; }

        /// <summary>
        /// The date and time when the role was opened.
        /// </summary>
        /// <value>The date and time when the role was opened.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "openedAt", EmitDefaultValue = false)]
        public DateTime OpenedAt { get; set; }

        /// <summary>
        /// The date and time when the role was submitted.
        /// </summary>
        /// <value>The date and time when the role was submitted.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "submissionDate", EmitDefaultValue = false)]
        public DateTime SubmissionDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FormRole {\n");
            sb.Append("  RoomId: ").Append(RoomId).Append("\n");
            sb.Append("  RoleName: ").Append(RoleName).Append("\n");
            sb.Append("  RoleColor: ").Append(RoleColor).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Sequence: ").Append(Sequence).Append("\n");
            sb.Append("  Submitted: ").Append(Submitted).Append("\n");
            sb.Append("  OpenedAt: ").Append(OpenedAt).Append("\n");
            sb.Append("  SubmissionDate: ").Append(SubmissionDate).Append("\n");
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
