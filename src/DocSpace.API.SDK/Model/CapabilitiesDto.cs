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
    /// The capabilities parameters.
    /// </summary>
    [DataContract(Name = "CapabilitiesDto")]
    public partial class CapabilitiesDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CapabilitiesDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CapabilitiesDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CapabilitiesDto" /> class.
        /// </summary>
        /// <param name="ldapEnabled">Specifies if the LDAP settings are enabled or not. (required).</param>
        /// <param name="ldapDomain">The LDAP domain..</param>
        /// <param name="providers">The list of providers. (required).</param>
        /// <param name="ssoLabel">The SP login label. (required).</param>
        /// <param name="oauthEnabled">Specifies if OAuth is enabled or not. (required).</param>
        /// <param name="ssoUrl">The SSO URL. If this parameter is empty, then the SSO settings are disabled. (required).</param>
        /// <param name="identityServerEnabled">Specifies if an identity server is enabled or not. (required).</param>
        public CapabilitiesDto(bool ldapEnabled = default, string ldapDomain = default, List<string> providers = default, string ssoLabel = default, bool oauthEnabled = default, string ssoUrl = default, bool identityServerEnabled = default)
        {
            this.LdapEnabled = ldapEnabled;
            // to ensure "providers" is required (not null)
            if (providers == null)
            {
                throw new ArgumentNullException("providers is a required property for CapabilitiesDto and cannot be null");
            }
            this.Providers = providers;
            // to ensure "ssoLabel" is required (not null)
            if (ssoLabel == null)
            {
                throw new ArgumentNullException("ssoLabel is a required property for CapabilitiesDto and cannot be null");
            }
            this.SsoLabel = ssoLabel;
            this.OauthEnabled = oauthEnabled;
            // to ensure "ssoUrl" is required (not null)
            if (ssoUrl == null)
            {
                throw new ArgumentNullException("ssoUrl is a required property for CapabilitiesDto and cannot be null");
            }
            this.SsoUrl = ssoUrl;
            this.IdentityServerEnabled = identityServerEnabled;
            this.LdapDomain = ldapDomain;
        }

        /// <summary>
        /// Specifies if the LDAP settings are enabled or not.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "ldapEnabled", IsRequired = true, EmitDefaultValue = true)]
        public bool LdapEnabled { get; set; }

        /// <summary>
        /// The LDAP domain.
        /// </summary>
        /// <example>example.com</example>
        [DataMember(Name = "ldapDomain", EmitDefaultValue = true)]
        public string LdapDomain { get; set; }

        /// <summary>
        /// The list of providers.
        /// </summary>
        /// <example>["google","facebook","microsoft"]</example>
        [DataMember(Name = "providers", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Providers { get; set; }

        /// <summary>
        /// The SP login label.
        /// </summary>
        /// <example>Enterprise SSO</example>
        [DataMember(Name = "ssoLabel", IsRequired = true, EmitDefaultValue = true)]
        public string SsoLabel { get; set; }

        /// <summary>
        /// Specifies if OAuth is enabled or not.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "oauthEnabled", IsRequired = true, EmitDefaultValue = true)]
        public bool OauthEnabled { get; set; }

        /// <summary>
        /// The SSO URL. If this parameter is empty, then the SSO settings are disabled.
        /// </summary>
        /// <example>https://sso.example.com/login</example>
        [DataMember(Name = "ssoUrl", IsRequired = true, EmitDefaultValue = true)]
        public string SsoUrl { get; set; }

        /// <summary>
        /// Specifies if an identity server is enabled or not.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "identityServerEnabled", IsRequired = true, EmitDefaultValue = true)]
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
