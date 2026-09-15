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
    /// One role of a PDF form, with the state the turn of that role is in.
    /// </summary>
    [DataContract(Name = "FormRoleDto")]
    public partial class FormRoleDto : IValidatableObject
    {

        /// <summary>
        /// Where the role stands in the queue: roles of earlier turns are reported as complete, roles of later turns as a  draft, and the role whose turn it is as either yours to fill or in progress, depending on whether that person  has already opened the form. The role the filling was stopped at is reported as stopped whatever its turn.
        /// </summary>
        [DataMember(Name = "roleStatus", EmitDefaultValue = false)]
        public FormFillingStatus? RoleStatus { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FormRoleDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FormRoleDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FormRoleDto" /> class.
        /// </summary>
        /// <param name="roleName">The name the role was given when the form was laid out, unique within that form. It is the value that names  the role in the calls which change or stop the filling. (required).</param>
        /// <param name="roleColor">The colour a client paints the role with, as a hexadecimal RGB value; empty when the role mapping assigned  none..</param>
        /// <param name="user">The account the role was assigned to, which is the person expected to fill this part of the form..</param>
        /// <param name="sequence">The turn this role takes: the roles come back ordered by this number, roles sharing a number are filled in  parallel, and a role with a higher number waits until every lower one has been submitted. (required).</param>
        /// <param name="submitted">Reports whether this role has already handed in its part. The lowest sequence number that still holds an  unsubmitted role is the turn the form as a whole is waiting on. (required).</param>
        /// <param name="stopedBy">The account that interrupted the filling. It is filled in on the one role the filling was stopped at and stays  empty on every other role, and on all of them while the filling runs normally..</param>
        /// <param name="history">When the role passed through the stages of its turn, keyed by stage: 0 is the moment the form was opened for  it, 1 the moment it was submitted and 2 the moment the filling was stopped at it. The times are given in the  time zone of the portal, and only the stages that have actually happened are present, so an empty object means  the role has not been opened yet..</param>
        /// <param name="roleStatus">Where the role stands in the queue: roles of earlier turns are reported as complete, roles of later turns as a  draft, and the role whose turn it is as either yours to fill or in progress, depending on whether that person  has already opened the form. The role the filling was stopped at is reported as stopped whatever its turn..</param>
        public FormRoleDto(string roleName = default, string roleColor = default, EmployeeFullDto user = default, int sequence = default, bool submitted = default, EmployeeFullDto stopedBy = default, Dictionary<string, DateTime> history = default, FormFillingStatus? roleStatus = default)
        {
            // to ensure "roleName" is required (not null)
            if (roleName == null)
            {
                throw new ArgumentNullException("roleName is a required property for FormRoleDto and cannot be null");
            }
            this.RoleName = roleName;
            this.Sequence = sequence;
            this.Submitted = submitted;
            this.RoleColor = roleColor;
            this.User = user;
            this.StopedBy = stopedBy;
            this.History = history;
            this.RoleStatus = roleStatus;
        }

        /// <summary>
        /// The name the role was given when the form was laid out, unique within that form. It is the value that names  the role in the calls which change or stop the filling.
        /// </summary>
        /// <example>Approver</example>
        [DataMember(Name = "roleName", IsRequired = true, EmitDefaultValue = true)]
        public string RoleName { get; set; }

        /// <summary>
        /// The colour a client paints the role with, as a hexadecimal RGB value; empty when the role mapping assigned  none.
        /// </summary>
        /// <example>#FF5733</example>
        [DataMember(Name = "roleColor", EmitDefaultValue = true)]
        public string RoleColor { get; set; }

        /// <summary>
        /// The account the role was assigned to, which is the person expected to fill this part of the form.
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public EmployeeFullDto User { get; set; }

        /// <summary>
        /// The turn this role takes: the roles come back ordered by this number, roles sharing a number are filled in  parallel, and a role with a higher number waits until every lower one has been submitted.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "sequence", IsRequired = true, EmitDefaultValue = true)]
        public int Sequence { get; set; }

        /// <summary>
        /// Reports whether this role has already handed in its part. The lowest sequence number that still holds an  unsubmitted role is the turn the form as a whole is waiting on.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "submitted", IsRequired = true, EmitDefaultValue = true)]
        public bool Submitted { get; set; }

        /// <summary>
        /// The account that interrupted the filling. It is filled in on the one role the filling was stopped at and stays  empty on every other role, and on all of them while the filling runs normally.
        /// </summary>
        [DataMember(Name = "stopedBy", EmitDefaultValue = false)]
        public EmployeeFullDto StopedBy { get; set; }

        /// <summary>
        /// When the role passed through the stages of its turn, keyed by stage: 0 is the moment the form was opened for  it, 1 the moment it was submitted and 2 the moment the filling was stopped at it. The times are given in the  time zone of the portal, and only the stages that have actually happened are present, so an empty object means  the role has not been opened yet.
        /// </summary>
        /// <example>{"0":"2025-01-15T10:30:00"}</example>
        [DataMember(Name = "history", EmitDefaultValue = false)]
        public Dictionary<string, DateTime> History { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FormRoleDto {\n");
            sb.Append("  RoleName: ").Append(RoleName).Append("\n");
            sb.Append("  RoleColor: ").Append(RoleColor).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Sequence: ").Append(Sequence).Append("\n");
            sb.Append("  Submitted: ").Append(Submitted).Append("\n");
            sb.Append("  StopedBy: ").Append(StopedBy).Append("\n");
            sb.Append("  History: ").Append(History).Append("\n");
            sb.Append("  RoleStatus: ").Append(RoleStatus).Append("\n");
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
