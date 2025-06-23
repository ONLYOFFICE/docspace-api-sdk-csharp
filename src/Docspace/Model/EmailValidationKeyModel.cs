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
    /// The confirmation email parameters.
    /// </summary>
    [DataContract(Name = "EmailValidationKeyModel")]
    public partial class EmailValidationKeyModel : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets EmplType
        /// </summary>
        [DataMember(Name = "emplType", EmitDefaultValue = false)]
        public EmployeeType? EmplType { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public ConfirmType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailValidationKeyModel" /> class.
        /// </summary>
        /// <param name="key">The email validation key..</param>
        /// <param name="emplType">emplType.</param>
        /// <param name="email">The email address..</param>
        /// <param name="uiD">The user ID..</param>
        /// <param name="type">type.</param>
        /// <param name="first">Specifies whether it is the first time account access or not..</param>
        /// <param name="roomId">The room ID..</param>
        public EmailValidationKeyModel(string key = default, EmployeeType? emplType = default, string email = default, Guid? uiD = default, ConfirmType? type = default, string first = default, string roomId = default)
        {
            this.Key = key;
            this.EmplType = emplType;
            this.Email = email;
            this.UiD = uiD;
            this.Type = type;
            this.First = first;
            this.RoomId = roomId;
        }

        /// <summary>
        /// The email validation key.
        /// </summary>
        /// <value>The email validation key.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// The email address.
        /// </summary>
        /// <value>The email address.</value>
        /*
        <example>Sydney_Roberts4@hotmail.com</example>
        */
        [DataMember(Name = "email", EmitDefaultValue = true)]
        public string Email { get; set; }

        /// <summary>
        /// The user ID.
        /// </summary>
        /// <value>The user ID.</value>
        /*
        <example>75a5f745-f697-4418-b38d-0fe0d277e258</example>
        */
        [DataMember(Name = "uiD", EmitDefaultValue = true)]
        public Guid? UiD { get; set; }

        /// <summary>
        /// Specifies whether it is the first time account access or not.
        /// </summary>
        /// <value>Specifies whether it is the first time account access or not.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "first", EmitDefaultValue = true)]
        public string First { get; set; }

        /// <summary>
        /// The room ID.
        /// </summary>
        /// <value>The room ID.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "roomId", EmitDefaultValue = true)]
        public string RoomId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmailValidationKeyModel {\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  EmplType: ").Append(EmplType).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  UiD: ").Append(UiD).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  First: ").Append(First).Append("\n");
            sb.Append("  RoomId: ").Append(RoomId).Append("\n");
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
