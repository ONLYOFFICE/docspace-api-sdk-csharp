// (c) Copyright Ascensio System SIA 2025
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


 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
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
            var sb = new StringBuilder();
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
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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
