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
    /// The SSO IdP settings.
    /// </summary>
    [DataContract(Name = "SsoIdpSettings")]
    public partial class SsoIdpSettings : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SsoIdpSettings" /> class.
        /// </summary>
        /// <param name="entityId">The entity ID..</param>
        /// <param name="ssoUrl">The SSO URL..</param>
        /// <param name="ssoBinding">The SSO binding..</param>
        /// <param name="sloUrl">The SLO URL..</param>
        /// <param name="sloBinding">The SLO binding..</param>
        /// <param name="nameIdFormat">The name ID format..</param>
        public SsoIdpSettings(string entityId = default, string ssoUrl = default, string ssoBinding = default, string sloUrl = default, string sloBinding = default, string nameIdFormat = default)
        {
            this.EntityId = entityId;
            this.SsoUrl = ssoUrl;
            this.SsoBinding = ssoBinding;
            this.SloUrl = sloUrl;
            this.SloBinding = sloBinding;
            this.NameIdFormat = nameIdFormat;
        }

        /// <summary>
        /// The entity ID.
        /// </summary>
        /// <value>The entity ID.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "entityId", EmitDefaultValue = true)]
        public string EntityId { get; set; }

        /// <summary>
        /// The SSO URL.
        /// </summary>
        /// <value>The SSO URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "ssoUrl", EmitDefaultValue = true)]
        public string SsoUrl { get; set; }

        /// <summary>
        /// The SSO binding.
        /// </summary>
        /// <value>The SSO binding.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "ssoBinding", EmitDefaultValue = true)]
        public string SsoBinding { get; set; }

        /// <summary>
        /// The SLO URL.
        /// </summary>
        /// <value>The SLO URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "sloUrl", EmitDefaultValue = true)]
        public string SloUrl { get; set; }

        /// <summary>
        /// The SLO binding.
        /// </summary>
        /// <value>The SLO binding.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "sloBinding", EmitDefaultValue = true)]
        public string SloBinding { get; set; }

        /// <summary>
        /// The name ID format.
        /// </summary>
        /// <value>The name ID format.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "nameIdFormat", EmitDefaultValue = true)]
        public string NameIdFormat { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SsoIdpSettings {\n");
            sb.Append("  EntityId: ").Append(EntityId).Append("\n");
            sb.Append("  SsoUrl: ").Append(SsoUrl).Append("\n");
            sb.Append("  SsoBinding: ").Append(SsoBinding).Append("\n");
            sb.Append("  SloUrl: ").Append(SloUrl).Append("\n");
            sb.Append("  SloBinding: ").Append(SloBinding).Append("\n");
            sb.Append("  NameIdFormat: ").Append(NameIdFormat).Append("\n");
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
