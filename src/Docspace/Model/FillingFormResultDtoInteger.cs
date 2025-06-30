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
    /// The parameters of the form filling result.
    /// </summary>
    [DataContract(Name = "FillingFormResultDtoInteger")]
    public partial class FillingFormResultDtoInteger : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FillingFormResultDtoInteger" /> class.
        /// </summary>
        /// <param name="formNumber">The filling form number..</param>
        /// <param name="completedForm">completedForm.</param>
        /// <param name="originalForm">originalForm.</param>
        /// <param name="manager">manager.</param>
        /// <param name="roomId">The room ID where filling the form..</param>
        /// <param name="isRoomMember">Specifies if the manager who fills the form is a room member or not..</param>
        public FillingFormResultDtoInteger(int formNumber = default, FileDtoInteger completedForm = default, FileDtoInteger originalForm = default, EmployeeFullDto manager = default, int roomId = default, bool isRoomMember = default)
        {
            this.FormNumber = formNumber;
            this.CompletedForm = completedForm;
            this.OriginalForm = originalForm;
            this.Manager = manager;
            this.RoomId = roomId;
            this.IsRoomMember = isRoomMember;
        }

        /// <summary>
        /// The filling form number.
        /// </summary>
        /// <value>The filling form number.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "formNumber", EmitDefaultValue = false)]
        public int FormNumber { get; set; }

        /// <summary>
        /// Gets or Sets CompletedForm
        /// </summary>
        [DataMember(Name = "completedForm", EmitDefaultValue = false)]
        public FileDtoInteger CompletedForm { get; set; }

        /// <summary>
        /// Gets or Sets OriginalForm
        /// </summary>
        [DataMember(Name = "originalForm", EmitDefaultValue = false)]
        public FileDtoInteger OriginalForm { get; set; }

        /// <summary>
        /// Gets or Sets Manager
        /// </summary>
        [DataMember(Name = "manager", EmitDefaultValue = false)]
        public EmployeeFullDto Manager { get; set; }

        /// <summary>
        /// The room ID where filling the form.
        /// </summary>
        /// <value>The room ID where filling the form.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "roomId", EmitDefaultValue = false)]
        public int RoomId { get; set; }

        /// <summary>
        /// Specifies if the manager who fills the form is a room member or not.
        /// </summary>
        /// <value>Specifies if the manager who fills the form is a room member or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isRoomMember", EmitDefaultValue = true)]
        public bool IsRoomMember { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FillingFormResultDtoInteger {\n");
            sb.Append("  FormNumber: ").Append(FormNumber).Append("\n");
            sb.Append("  CompletedForm: ").Append(CompletedForm).Append("\n");
            sb.Append("  OriginalForm: ").Append(OriginalForm).Append("\n");
            sb.Append("  Manager: ").Append(Manager).Append("\n");
            sb.Append("  RoomId: ").Append(RoomId).Append("\n");
            sb.Append("  IsRoomMember: ").Append(IsRoomMember).Append("\n");
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
