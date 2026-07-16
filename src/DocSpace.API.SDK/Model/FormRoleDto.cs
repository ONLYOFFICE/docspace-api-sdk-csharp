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
    /// The form role parameters.
    /// </summary>
    [DataContract(Name = "FormRoleDto")]
    public partial class FormRoleDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets RoleStatus
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
        /// <param name="roleName">The role name. (required).</param>
        /// <param name="roleColor">The role color..</param>
        /// <param name="user">user.</param>
        /// <param name="sequence">The role sequence. (required).</param>
        /// <param name="submitted">Specifies if the role is submitted. (required).</param>
        /// <param name="stopedBy">stopedBy.</param>
        /// <param name="history">The role history..</param>
        /// <param name="roleStatus">roleStatus.</param>
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
        /// The role name.
        /// </summary>
        /// <value>The role name.</value>
        /*
        <example>Approver</example>
        */
        [DataMember(Name = "roleName", IsRequired = true, EmitDefaultValue = true)]
        public string RoleName { get; set; }

        /// <summary>
        /// The role color.
        /// </summary>
        /// <value>The role color.</value>
        /*
        <example>#FF5733</example>
        */
        [DataMember(Name = "roleColor", EmitDefaultValue = true)]
        public string RoleColor { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public EmployeeFullDto User { get; set; }

        /// <summary>
        /// The role sequence.
        /// </summary>
        /// <value>The role sequence.</value>
        /*
        <example>1</example>
        */
        [DataMember(Name = "sequence", IsRequired = true, EmitDefaultValue = true)]
        public int Sequence { get; set; }

        /// <summary>
        /// Specifies if the role is submitted.
        /// </summary>
        /// <value>Specifies if the role is submitted.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "submitted", IsRequired = true, EmitDefaultValue = true)]
        public bool Submitted { get; set; }

        /// <summary>
        /// Gets or Sets StopedBy
        /// </summary>
        [DataMember(Name = "stopedBy", EmitDefaultValue = false)]
        public EmployeeFullDto StopedBy { get; set; }

        /// <summary>
        /// The role history.
        /// </summary>
        /// <value>The role history.</value>
        /*
        <example>{"0":"2025-01-15T10:30:00Z"}</example>
        */
        [DataMember(Name = "history", EmitDefaultValue = true)]
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
