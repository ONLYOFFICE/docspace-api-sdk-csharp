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
    /// The request parameters for inviting users to the room.
    /// </summary>
    [DataContract(Name = "RoomInvitationRequest")]
    public partial class RoomInvitationRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoomInvitationRequest" /> class.
        /// </summary>
        /// <param name="invitations">The collection of invitation parameters..</param>
        /// <param name="notify">Specifies whether to notify users about the shared room or not..</param>
        /// <param name="message">The message to send when notifying about the shared room..</param>
        /// <param name="culture">The language of the room invitation..</param>
        /// <param name="force">Specifies whether to forcibly delete a user with form roles from the room..</param>
        public RoomInvitationRequest(List<RoomInvitation> invitations = default, bool notify = default, string message = default, string culture = default, bool force = default)
        {
            this.Invitations = invitations;
            this.Notify = notify;
            this.Message = message;
            this.Culture = culture;
            this.Force = force;
        }

        /// <summary>
        /// The collection of invitation parameters.
        /// </summary>
        /// <value>The collection of invitation parameters.</value>
        [DataMember(Name = "invitations", EmitDefaultValue = true)]
        public List<RoomInvitation> Invitations { get; set; }

        /// <summary>
        /// Specifies whether to notify users about the shared room or not.
        /// </summary>
        /// <value>Specifies whether to notify users about the shared room or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "notify", EmitDefaultValue = true)]
        public bool Notify { get; set; }

        /// <summary>
        /// The message to send when notifying about the shared room.
        /// </summary>
        /// <value>The message to send when notifying about the shared room.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// The language of the room invitation.
        /// </summary>
        /// <value>The language of the room invitation.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "culture", EmitDefaultValue = true)]
        public string Culture { get; set; }

        /// <summary>
        /// Specifies whether to forcibly delete a user with form roles from the room.
        /// </summary>
        /// <value>Specifies whether to forcibly delete a user with form roles from the room.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "force", EmitDefaultValue = true)]
        public bool Force { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RoomInvitationRequest {\n");
            sb.Append("  Invitations: ").Append(Invitations).Append("\n");
            sb.Append("  Notify: ").Append(Notify).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Culture: ").Append(Culture).Append("\n");
            sb.Append("  Force: ").Append(Force).Append("\n");
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
