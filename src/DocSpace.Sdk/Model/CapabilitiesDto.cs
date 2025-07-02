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
using FileParameter = DocSpace.Sdk.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.Sdk.Client.OpenAPIDateConverter;

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The capabilities parameters.
    /// </summary>
    [DataContract(Name = "CapabilitiesDto")]
    public partial class CapabilitiesDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CapabilitiesDto" /> class.
        /// </summary>
        /// <param name="ldapEnabled">Specifies if the LDAP settings are enabled or not..</param>
        /// <param name="ldapDomain">The LDAP domain..</param>
        /// <param name="providers">The list of providers..</param>
        /// <param name="ssoLabel">The SP login label..</param>
        /// <param name="oauthEnabled">Specifies if OAuth is enabled or not..</param>
        /// <param name="ssoUrl">The SSO URL. If this parameter is empty, then the SSO settings are disabled..</param>
        /// <param name="identityServerEnabled">Specifies if identity server is enabled or not.</param>
        public CapabilitiesDto(bool ldapEnabled = default, string ldapDomain = default, List<string> providers = default, string ssoLabel = default, bool oauthEnabled = default, string ssoUrl = default, bool identityServerEnabled = default)
        {
            this.LdapEnabled = ldapEnabled;
            this.LdapDomain = ldapDomain;
            this.Providers = providers;
            this.SsoLabel = ssoLabel;
            this.OauthEnabled = oauthEnabled;
            this.SsoUrl = ssoUrl;
            this.IdentityServerEnabled = identityServerEnabled;
        }

        /// <summary>
        /// Specifies if the LDAP settings are enabled or not.
        /// </summary>
        /// <value>Specifies if the LDAP settings are enabled or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "ldapEnabled", EmitDefaultValue = true)]
        public bool LdapEnabled { get; set; }

        /// <summary>
        /// The LDAP domain.
        /// </summary>
        /// <value>The LDAP domain.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "ldapDomain", EmitDefaultValue = true)]
        public string LdapDomain { get; set; }

        /// <summary>
        /// The list of providers.
        /// </summary>
        /// <value>The list of providers.</value>
        /*
        <example>[&quot;some text&quot;]</example>
        */
        [DataMember(Name = "providers", EmitDefaultValue = true)]
        public List<string> Providers { get; set; }

        /// <summary>
        /// The SP login label.
        /// </summary>
        /// <value>The SP login label.</value>
        [DataMember(Name = "ssoLabel", EmitDefaultValue = true)]
        public string SsoLabel { get; set; }

        /// <summary>
        /// Specifies if OAuth is enabled or not.
        /// </summary>
        /// <value>Specifies if OAuth is enabled or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "oauthEnabled", EmitDefaultValue = true)]
        public bool OauthEnabled { get; set; }

        /// <summary>
        /// The SSO URL. If this parameter is empty, then the SSO settings are disabled.
        /// </summary>
        /// <value>The SSO URL. If this parameter is empty, then the SSO settings are disabled.</value>
        [DataMember(Name = "ssoUrl", EmitDefaultValue = true)]
        public string SsoUrl { get; set; }

        /// <summary>
        /// Specifies if identity server is enabled or not
        /// </summary>
        /// <value>Specifies if identity server is enabled or not</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "identityServerEnabled", EmitDefaultValue = true)]
        public bool IdentityServerEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CapabilitiesDto {\n");
            sb.Append("  LdapEnabled: ").Append(LdapEnabled).Append("\n");
            sb.Append("  LdapDomain: ").Append(LdapDomain).Append("\n");
            sb.Append("  Providers: ").Append(Providers).Append("\n");
            sb.Append("  SsoLabel: ").Append(SsoLabel).Append("\n");
            sb.Append("  OauthEnabled: ").Append(OauthEnabled).Append("\n");
            sb.Append("  SsoUrl: ").Append(SsoUrl).Append("\n");
            sb.Append("  IdentityServerEnabled: ").Append(IdentityServerEnabled).Append("\n");
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
