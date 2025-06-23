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
    /// The information about the settings which allow to share the document with other users.
    /// </summary>
    [DataContract(Name = "AceShortWrapper")]
    public partial class AceShortWrapper : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AceShortWrapper" /> class.
        /// </summary>
        /// <param name="user">The name of the user the document will be shared with..</param>
        /// <param name="permissions">The access rights for the user with the name above.  Can be \&quot;Full Access\&quot;, \&quot;Read Only\&quot;, or \&quot;Deny Access\&quot;..</param>
        /// <param name="isLink">Specifies whether to change the user icon to the link icon..</param>
        public AceShortWrapper(string user = default, string permissions = default, bool isLink = default)
        {
            this.User = user;
            this.Permissions = permissions;
            this.IsLink = isLink;
        }

        /// <summary>
        /// The name of the user the document will be shared with.
        /// </summary>
        /// <value>The name of the user the document will be shared with.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "user", EmitDefaultValue = true)]
        public string User { get; set; }

        /// <summary>
        /// The access rights for the user with the name above.  Can be \&quot;Full Access\&quot;, \&quot;Read Only\&quot;, or \&quot;Deny Access\&quot;.
        /// </summary>
        /// <value>The access rights for the user with the name above.  Can be \&quot;Full Access\&quot;, \&quot;Read Only\&quot;, or \&quot;Deny Access\&quot;.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "permissions", EmitDefaultValue = true)]
        public string Permissions { get; set; }

        /// <summary>
        /// Specifies whether to change the user icon to the link icon.
        /// </summary>
        /// <value>Specifies whether to change the user icon to the link icon.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isLink", EmitDefaultValue = true)]
        public bool IsLink { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AceShortWrapper {\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  IsLink: ").Append(IsLink).Append("\n");
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
