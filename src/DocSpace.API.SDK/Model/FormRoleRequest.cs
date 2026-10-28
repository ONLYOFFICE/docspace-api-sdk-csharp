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
    /// One role of a form and the account that fills it.
    /// </summary>
    [DataContract(Name = "FormRoleRequest")]
    public partial class FormRoleRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FormRoleRequest" /> class.
        /// </summary>
        /// <param name="roomId">The ID of the room the form is in. It is stored with the role as sent, so pass the room the form lives in..</param>
        /// <param name="roleName">The name of a role the form defines, such as the one the form author gave a group of fields..</param>
        /// <param name="roleColor">The color the editor marks the fields of this role with, as a hex code..</param>
        /// <param name="userId">The account that fills this role. It is notified once filling starts, unless it is the caller..</param>
        /// <param name="sequence">Accepted for compatibility and ignored: the position of the role in the list sets the filling order..</param>
        /// <param name="submitted">Whether this role counts as already submitted. It is stored as sent; send false when filling starts..</param>
        /// <param name="openedAt">Accepted for compatibility and ignored: the portal records when the role is opened..</param>
        /// <param name="submissionDate">Accepted for compatibility and ignored: the portal records when the role is submitted..</param>
        public FormRoleRequest(int roomId = default, string roleName = default, string roleColor = default, Guid userId = default, int sequence = default, bool submitted = default, DateTime openedAt = default, DateTime submissionDate = default)
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
        /// The ID of the room the form is in. It is stored with the role as sent, so pass the room the form lives in.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "roomId", EmitDefaultValue = false)]
        public int RoomId { get; set; }

        /// <summary>
        /// The name of a role the form defines, such as the one the form author gave a group of fields.
        /// </summary>
        /// <example>Manager</example>
        [DataMember(Name = "roleName", EmitDefaultValue = true)]
        public string RoleName { get; set; }

        /// <summary>
        /// The color the editor marks the fields of this role with, as a hex code.
        /// </summary>
        /// <example>#4781D1</example>
        [DataMember(Name = "roleColor", EmitDefaultValue = true)]
        public string RoleColor { get; set; }

        /// <summary>
        /// The account that fills this role. It is notified once filling starts, unless it is the caller.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000000</example>
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Accepted for compatibility and ignored: the position of the role in the list sets the filling order.
        /// </summary>
        /// <example>12</example>
        [DataMember(Name = "sequence", EmitDefaultValue = false)]
        public int Sequence { get; set; }

        /// <summary>
        /// Whether this role counts as already submitted. It is stored as sent; send false when filling starts.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "submitted", EmitDefaultValue = true)]
        public bool Submitted { get; set; }

        /// <summary>
        /// Accepted for compatibility and ignored: the portal records when the role is opened.
        /// </summary>
        /// <example>2026-01-01T10:00:00Z</example>
        [DataMember(Name = "openedAt", EmitDefaultValue = false)]
        public DateTime OpenedAt { get; set; }

        /// <summary>
        /// Accepted for compatibility and ignored: the portal records when the role is submitted.
        /// </summary>
        /// <example>2026-01-01T10:00:00Z</example>
        [DataMember(Name = "submissionDate", EmitDefaultValue = false)]
        public DateTime SubmissionDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormRoleRequest {\n");
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
