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
    /// The sign-in methods this portal offers, as a login client needs them before anyone has signed in.
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
        /// <param name="ldapEnabled">Whether members may sign in with their directory credentials. It is &#x60;false&#x60; both when LDAP sign-in is  switched off and when the pricing plan or the installation does not include it, and also when the settings  could not be read at all - a &#x60;false&#x60; here means the method is not offered, never that it is unknown. (required).</param>
        /// <param name="ldapDomain">The directory domain members authenticate against, to be shown next to the login field. It is empty  whenever &#x60;ldapEnabled&#x60; is &#x60;false&#x60;, and also while the portal has not completed a directory synchronisation..</param>
        /// <param name="providers">The keys of the external identity providers to offer, ordered for the country the caller&#39;s IP address  resolves to and reduced to those this installation has credentials for. Pass one of them as &#x60;provider&#x60; to  &#x60;POST api/2.0/authentication&#x60;. An empty list means external sign-in is not on offer. (required).</param>
        /// <param name="ssoLabel">The caption for the single sign-on button in the portal language, empty whenever &#x60;ssoUrl&#x60; is. (required).</param>
        /// <param name="oauthEnabled">Whether external identity providers may be used on this portal at all. While it is &#x60;false&#x60;, &#x60;providers&#x60; is  empty because the list is not even assembled. (required).</param>
        /// <param name="ssoUrl">The address to send the browser to for SAML single sign-on. It is empty when single sign-on is not on  offer, which is the one thing to test - there is no separate flag for it. (required).</param>
        /// <param name="identityServerEnabled">Whether the installation exposes its built-in identity server, which is what the portal&#39;s own OAuth  applications authenticate against. It concerns third-party applications signing in to the portal, not  portal members signing in to an external provider - that is &#x60;providers&#x60;. (required).</param>
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
        /// Whether members may sign in with their directory credentials. It is &#x60;false&#x60; both when LDAP sign-in is  switched off and when the pricing plan or the installation does not include it, and also when the settings  could not be read at all - a &#x60;false&#x60; here means the method is not offered, never that it is unknown.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "ldapEnabled", IsRequired = true, EmitDefaultValue = true)]
        public bool LdapEnabled { get; set; }

        /// <summary>
        /// The directory domain members authenticate against, to be shown next to the login field. It is empty  whenever &#x60;ldapEnabled&#x60; is &#x60;false&#x60;, and also while the portal has not completed a directory synchronisation.
        /// </summary>
        /// <example>example.com</example>
        [DataMember(Name = "ldapDomain", EmitDefaultValue = true)]
        public string LdapDomain { get; set; }

        /// <summary>
        /// The keys of the external identity providers to offer, ordered for the country the caller&#39;s IP address  resolves to and reduced to those this installation has credentials for. Pass one of them as &#x60;provider&#x60; to  &#x60;POST api/2.0/authentication&#x60;. An empty list means external sign-in is not on offer.
        /// </summary>
        /// <example>["google","facebook","microsoft"]</example>
        [DataMember(Name = "providers", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Providers { get; set; }

        /// <summary>
        /// The caption for the single sign-on button in the portal language, empty whenever &#x60;ssoUrl&#x60; is.
        /// </summary>
        /// <example>Enterprise SSO</example>
        [DataMember(Name = "ssoLabel", IsRequired = true, EmitDefaultValue = true)]
        public string SsoLabel { get; set; }

        /// <summary>
        /// Whether external identity providers may be used on this portal at all. While it is &#x60;false&#x60;, &#x60;providers&#x60; is  empty because the list is not even assembled.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "oauthEnabled", IsRequired = true, EmitDefaultValue = true)]
        public bool OauthEnabled { get; set; }

        /// <summary>
        /// The address to send the browser to for SAML single sign-on. It is empty when single sign-on is not on  offer, which is the one thing to test - there is no separate flag for it.
        /// </summary>
        /// <example>https://sso.example.com/login</example>
        [DataMember(Name = "ssoUrl", IsRequired = true, EmitDefaultValue = true)]
        public string SsoUrl { get; set; }

        /// <summary>
        /// Whether the installation exposes its built-in identity server, which is what the portal&#39;s own OAuth  applications authenticate against. It concerns third-party applications signing in to the portal, not  portal members signing in to an external provider - that is &#x60;providers&#x60;.
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
