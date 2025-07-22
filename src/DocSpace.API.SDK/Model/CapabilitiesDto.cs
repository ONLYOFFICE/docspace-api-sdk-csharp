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

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
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
            var sb = new StringBuilder();
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
