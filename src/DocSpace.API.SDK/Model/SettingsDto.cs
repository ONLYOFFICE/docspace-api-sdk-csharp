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
    /// The general configuration of the current portal, as the client shell needs it before and after sign-in.
    /// </summary>
    [DataContract(Name = "SettingsDto")]
    public partial class SettingsDto : IValidatableObject
    {

        /// <summary>
        /// How the mail domains above are applied: no domain trusted, every domain trusted, or only the listed ones.  Filled in under the same conditions as &#x60;trustedDomains&#x60;.
        /// </summary>
        [DataMember(Name = "trustedDomainsType", EmitDefaultValue = false)]
        public TenantTrustedDomainsType? TrustedDomainsType { get; set; }

        /// <summary>
        /// Which CAPTCHA the login form has to render, decided by the installation&#39;s configuration. Computed for an  anonymous caller only.
        /// </summary>
        [DataMember(Name = "recaptchaType", EmitDefaultValue = false)]
        public RecaptchaType? RecaptchaType { get; set; }

        /// <summary>
        /// The lifecycle state of the portal. Anything other than active means most operations are refused for the  moment, because the portal is being transferred, restored, encrypted or removed.
        /// </summary>
        [DataMember(Name = "tenantStatus", EmitDefaultValue = false)]
        public TenantStatus? TenantStatus { get; set; }

        /// <summary>
        /// The section the client should open after sign-in, which is the caller&#39;s own preference rather than a  portal-wide one. Filled in for a signed-in caller only.
        /// </summary>
        [DataMember(Name = "defaultFolderType", EmitDefaultValue = false)]
        public FolderType? DefaultFolderType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SettingsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsDto" /> class.
        /// </summary>
        /// <param name="timezone">The portal time zone as an IANA identifier, which is the zone every date this API returns in portal time  is expressed in. Filled in for a signed-in caller only..</param>
        /// <param name="trustedDomains">The mail domains a new member may register or be invited from without confirming the address. It is filled  in for a signed-in caller, and for an anonymous one only while &#x60;enabledJoin&#x60; is &#x60;true&#x60;; it is empty  whenever &#x60;trustedDomainsType&#x60; is not &#x60;Custom&#x60;..</param>
        /// <param name="trustedDomainsType">How the mail domains above are applied: no domain trusted, every domain trusted, or only the listed ones.  Filled in under the same conditions as &#x60;trustedDomains&#x60;..</param>
        /// <param name="culture">The default language of the portal as a culture name, which is what unauthenticated pages are rendered in.  A signed-in member may have a language of their own, and that one is not reported here. (required).</param>
        /// <param name="utcOffset">The portal&#39;s offset from UTC as a time span, positive east of UTC. Filled in for a signed-in caller only,  and taken at the moment of the call, so it already reflects daylight saving time..</param>
        /// <param name="utcHoursOffset">The same offset in hours, fractional for a zone that is not on a whole hour. It is there so a client does  not have to parse &#x60;utcOffset&#x60;..</param>
        /// <param name="greetingSettings">The portal title shown on the login page and in letters. It falls back to the product name in the portal  language while the portal has been given no title of its own..</param>
        /// <param name="ownerId">The portal owner, the one account that cannot be removed or demoted. Filled in for a signed-in caller  only, and the empty GUID for an anonymous one..</param>
        /// <param name="nameSchemaId">The naming scheme the portal uses for its own vocabulary - what a member, a group or a room is called in  the interface. &#x60;GET api/2.0/settings/customschemas/{id}&#x60; spells that vocabulary out. Filled in for a  signed-in caller only..</param>
        /// <param name="enabledJoin">Whether someone who is not invited may still register, which is the case when the portal trusts every mail  domain or a list of them. It is computed for an anonymous caller only and left out entirely for a  signed-in one, so a missing value is not a &#x60;false&#x60;..</param>
        /// <param name="enableAdmMess">Whether the login page may offer the form for writing to the portal administrators. It is also &#x60;true&#x60;  while the portal&#39;s payment has lapsed, whatever the setting says, so it can be set on a portal where an  administrator switched the form off..</param>
        /// <param name="thirdpartyEnable">Whether the login page may offer sign-in through an external identity provider. It is computed for an  anonymous caller only; &#x60;GET api/2.0/capabilities&#x60; reports the same thing with the list of providers..</param>
        /// <param name="docSpace">Always &#x60;true&#x60; in this product. It exists so a client that also talks to older ONLYOFFICE portals can tell  them apart, and is not a feature switch..</param>
        /// <param name="standalone">Whether this is a server installation someone administers themselves rather than a portal in the cloud.  Several fields below and a number of operations behave differently in the two, so a client that has to  branch on the deployment reads it here..</param>
        /// <param name="isAmi">Whether the installation runs from an Amazon machine image, which is a server installation that can read  its own instance metadata. It is &#x60;false&#x60; on every cloud portal..</param>
        /// <param name="baseDomain">The domain new portals of this installation are created under, which is what a portal name is checked  against and appended to. It is empty on an installation that serves a single portal on a fixed address. (required).</param>
        /// <param name="wizardToken">The token that authorizes the first-run setup wizard. It is handed out to anonymous callers only, and only  while the wizard has not been completed; once it has, the field stays empty for good..</param>
        /// <param name="passwordHash">The parameters for hashing a password in the client before it is sent - the salt, the iteration count and  the hash size. It is filled in for an anonymous caller and, for a signed-in one, only when  &#x60;withPassword&#x3D;true&#x60; is asked for. Hash with exactly these parameters and send the result as  &#x60;passwordHash&#x60;, since the portal cannot reproduce the hash from a different set..</param>
        /// <param name="firebase">The Firebase project a mobile or web client sends push registrations to. Filled in for a signed-in caller  only, and its own fields are empty strings on an installation that configures no Firebase project..</param>
        /// <param name="version">The product version of the portal, empty when the installation does not publish one. It is the version of  the server, not of this API, whose own version is fixed at 2.0..</param>
        /// <param name="recaptchaType">Which CAPTCHA the login form has to render, decided by the installation&#39;s configuration. Computed for an  anonymous caller only..</param>
        /// <param name="recaptchaPublicKey">The site key for the CAPTCHA named by &#x60;recaptchaType&#x60;, safe to embed in a page. It is empty when the  installation configures no CAPTCHA, in which case the login form asks for none..</param>
        /// <param name="debugInfo">Whether the client may collect and send diagnostic information. Filled in for a signed-in caller only, and  &#x60;false&#x60; unless the installation switched it on..</param>
        /// <param name="socketUrl">The address of the socket service that pushes live updates to a client. It is filled in for a signed-in  caller and for an anonymous one who arrives with an external sharing link, and is empty when the  installation runs no socket service - a client then has to poll..</param>
        /// <param name="tenantStatus">The lifecycle state of the portal. Anything other than active means most operations are refused for the  moment, because the portal is being transferred, restored, encrypted or removed..</param>
        /// <param name="tenantAlias">The portal&#39;s own name within the installation, which together with &#x60;baseDomain&#x60; forms the address it is  reached at. &#x60;PUT api/2.0/portal/portalrename&#x60; changes it..</param>
        /// <param name="displayAbout">Whether the interface may show the About page. A cloud portal always may; a server installation may unless  its plan includes branding and the vendor details hide the page..</param>
        /// <param name="domainValidator">The rules a portal name is checked against - its length limits and the pattern it has to match - so a  client can validate a rename before sending it. Filled in for a signed-in caller only..</param>
        /// <param name="zendeskKey">The key that lets the client open the vendor&#39;s support chat, empty when the installation configures none.  Filled in for a signed-in caller only..</param>
        /// <param name="tagManagerId">The Google Tag Manager container the client should load, empty when the installation configures none.  Filled in for a signed-in caller only..</param>
        /// <param name="cookieSettingsEnabled">Whether the portal limits how long an authentication session stays valid. The limit itself is read with  &#x60;GET api/2.0/settings/cookiesettings&#x60;; while this is &#x60;false&#x60; a session is honoured for a year. (required).</param>
        /// <param name="limitedAccessSpace">Whether the space-management section is restricted to the portal owner. Filled in for a signed-in caller  only..</param>
        /// <param name="limitedAccessDevToolsForUsers">Whether the Developer Tools section is hidden from members who are not administrators. Filled in for a  signed-in caller only..</param>
        /// <param name="displayBanners">Whether the interface may show the vendor&#39;s promotional banners. A cloud portal always reports &#x60;true&#x60;; on  a server installation it follows the banner setting. Filled in for a signed-in caller only..</param>
        /// <param name="aiEnabled">Whether the AI features - chat, agents and vectorisation - may be used on this portal. While it is  &#x60;false&#x60; the AI Agents folder is hidden and the AI operations are refused. Filled in for a signed-in caller  only..</param>
        /// <param name="walletLowBalance">Whether the portal wallet has already dropped below its low-balance threshold, so a client can warn about  AI operations being cut off. It is reported to DocSpace administrators only and left empty for everyone  else, which is not the same as a healthy balance..</param>
        /// <param name="userNameRegex">The pattern a member&#39;s first and last name has to match, so a client can validate a name before sending  it. It is a .NET regular expression and is applied to each name part separately..</param>
        /// <param name="invitationLimit">How many invitations the portal may still send in the current window. Filled in for a signed-in caller  only, and set to the maximum value of a 32-bit integer on an installation that limits nothing..</param>
        /// <param name="plugins">What the installation allows to be done with web plugins. Filled in for a signed-in caller only, with all  three flags &#x60;false&#x60; unless the installation switched plugins on..</param>
        /// <param name="deepLink">What a mobile client needs to hand a document link over to the installed application instead of opening it  in the browser. Its fields are empty strings when the installation configures no application. (required).</param>
        /// <param name="formGallery">Where the ready-made form templates are served from and which extension they carry. Filled in for a  signed-in caller only..</param>
        /// <param name="maxImageUploadSize">The largest image the portal accepts as a logo or an avatar, in bytes. Filled in for a signed-in caller  only, and a larger upload is refused rather than resized..</param>
        /// <param name="logoText">The wordmark to print next to the portal logo. It falls back to the built-in one while the portal has  stored no text of its own, so it is never empty..</param>
        /// <param name="externalResources">The addresses of the vendor&#39;s help, support, forum and video resources, already picked for the portal  language. An entry is missing when the installation configures no address for it or the resource is  switched off, which &#x60;GET api/2.0/settings/rebranding/additional&#x60; reports flag by flag..</param>
        /// <param name="defaultFolderType">The section the client should open after sign-in, which is the caller&#39;s own preference rather than a  portal-wide one. Filled in for a signed-in caller only..</param>
        /// <param name="externalDbEnabled">Whether the installation has an external database wired up for form results, without which the operations  that write form results there are refused. Filled in for a signed-in caller only..</param>
        public SettingsDto(string timezone = default, List<string> trustedDomains = default, TenantTrustedDomainsType? trustedDomainsType = default, string culture = default, string utcOffset = default, double utcHoursOffset = default, string greetingSettings = default, Guid ownerId = default, string nameSchemaId = default, bool? enabledJoin = default, bool? enableAdmMess = default, bool? thirdpartyEnable = default, bool docSpace = default, bool standalone = default, bool isAmi = default, string baseDomain = default, string wizardToken = default, PasswordHasher passwordHash = default, FirebaseDto firebase = default, string version = default, RecaptchaType? recaptchaType = default, string recaptchaPublicKey = default, bool debugInfo = default, string socketUrl = default, TenantStatus? tenantStatus = default, string tenantAlias = default, bool displayAbout = default, TenantDomainValidator domainValidator = default, string zendeskKey = default, string tagManagerId = default, bool cookieSettingsEnabled = default, bool limitedAccessSpace = default, bool limitedAccessDevToolsForUsers = default, bool displayBanners = default, bool aiEnabled = default, bool? walletLowBalance = default, string userNameRegex = default, int? invitationLimit = default, PluginsDto plugins = default, DeepLinkDto deepLink = default, FormGalleryDto formGallery = default, long maxImageUploadSize = default, string logoText = default, CultureSpecificExternalResources externalResources = default, FolderType? defaultFolderType = default, bool externalDbEnabled = default)
        {
            // to ensure "culture" is required (not null)
            if (culture == null)
            {
                throw new ArgumentNullException("culture is a required property for SettingsDto and cannot be null");
            }
            this.Culture = culture;
            // to ensure "baseDomain" is required (not null)
            if (baseDomain == null)
            {
                throw new ArgumentNullException("baseDomain is a required property for SettingsDto and cannot be null");
            }
            this.BaseDomain = baseDomain;
            this.CookieSettingsEnabled = cookieSettingsEnabled;
            // to ensure "deepLink" is required (not null)
            if (deepLink == null)
            {
                throw new ArgumentNullException("deepLink is a required property for SettingsDto and cannot be null");
            }
            this.DeepLink = deepLink;
            this.Timezone = timezone;
            this.TrustedDomains = trustedDomains;
            this.TrustedDomainsType = trustedDomainsType;
            this.UtcOffset = utcOffset;
            this.UtcHoursOffset = utcHoursOffset;
            this.GreetingSettings = greetingSettings;
            this.OwnerId = ownerId;
            this.NameSchemaId = nameSchemaId;
            this.EnabledJoin = enabledJoin;
            this.EnableAdmMess = enableAdmMess;
            this.ThirdpartyEnable = thirdpartyEnable;
            this.DocSpace = docSpace;
            this.Standalone = standalone;
            this.IsAmi = isAmi;
            this.WizardToken = wizardToken;
            this.PasswordHash = passwordHash;
            this.Firebase = firebase;
            this.@Version = version;
            this.RecaptchaType = recaptchaType;
            this.RecaptchaPublicKey = recaptchaPublicKey;
            this.DebugInfo = debugInfo;
            this.SocketUrl = socketUrl;
            this.TenantStatus = tenantStatus;
            this.TenantAlias = tenantAlias;
            this.DisplayAbout = displayAbout;
            this.DomainValidator = domainValidator;
            this.ZendeskKey = zendeskKey;
            this.TagManagerId = tagManagerId;
            this.LimitedAccessSpace = limitedAccessSpace;
            this.LimitedAccessDevToolsForUsers = limitedAccessDevToolsForUsers;
            this.DisplayBanners = displayBanners;
            this.AiEnabled = aiEnabled;
            this.WalletLowBalance = walletLowBalance;
            this.UserNameRegex = userNameRegex;
            this.InvitationLimit = invitationLimit;
            this.Plugins = plugins;
            this.FormGallery = formGallery;
            this.MaxImageUploadSize = maxImageUploadSize;
            this.LogoText = logoText;
            this.ExternalResources = externalResources;
            this.DefaultFolderType = defaultFolderType;
            this.ExternalDbEnabled = externalDbEnabled;
        }

        /// <summary>
        /// The portal time zone as an IANA identifier, which is the zone every date this API returns in portal time  is expressed in. Filled in for a signed-in caller only.
        /// </summary>
        /// <example>UTC</example>
        [DataMember(Name = "timezone", EmitDefaultValue = true)]
        public string Timezone { get; set; }

        /// <summary>
        /// The mail domains a new member may register or be invited from without confirming the address. It is filled  in for a signed-in caller, and for an anonymous one only while &#x60;enabledJoin&#x60; is &#x60;true&#x60;; it is empty  whenever &#x60;trustedDomainsType&#x60; is not &#x60;Custom&#x60;.
        /// </summary>
        /// <example>["mydomain.com","mydomain1.com"]</example>
        [DataMember(Name = "trustedDomains", EmitDefaultValue = true)]
        public List<string> TrustedDomains { get; set; }

        /// <summary>
        /// The default language of the portal as a culture name, which is what unauthenticated pages are rendered in.  A signed-in member may have a language of their own, and that one is not reported here.
        /// </summary>
        /// <example>en-US</example>
        [DataMember(Name = "culture", IsRequired = true, EmitDefaultValue = true)]
        public string Culture { get; set; }

        /// <summary>
        /// The portal&#39;s offset from UTC as a time span, positive east of UTC. Filled in for a signed-in caller only,  and taken at the moment of the call, so it already reflects daylight saving time.
        /// </summary>
        /// <example>-08:30:00</example>
        [DataMember(Name = "utcOffset", EmitDefaultValue = false)]
        public string UtcOffset { get; set; }

        /// <summary>
        /// The same offset in hours, fractional for a zone that is not on a whole hour. It is there so a client does  not have to parse &#x60;utcOffset&#x60;.
        /// </summary>
        /// <example>-8.5</example>
        [DataMember(Name = "utcHoursOffset", EmitDefaultValue = false)]
        public double UtcHoursOffset { get; set; }

        /// <summary>
        /// The portal title shown on the login page and in letters. It falls back to the product name in the portal  language while the portal has been given no title of its own.
        /// </summary>
        /// <example>Web Office Applications</example>
        [DataMember(Name = "greetingSettings", EmitDefaultValue = true)]
        public string GreetingSettings { get; set; }

        /// <summary>
        /// The portal owner, the one account that cannot be removed or demoted. Filled in for a signed-in caller  only, and the empty GUID for an anonymous one.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000000</example>
        [DataMember(Name = "ownerId", EmitDefaultValue = false)]
        public Guid OwnerId { get; set; }

        /// <summary>
        /// The naming scheme the portal uses for its own vocabulary - what a member, a group or a room is called in  the interface. &#x60;GET api/2.0/settings/customschemas/{id}&#x60; spells that vocabulary out. Filled in for a  signed-in caller only.
        /// </summary>
        /// <example>default</example>
        [DataMember(Name = "nameSchemaId", EmitDefaultValue = true)]
        public string NameSchemaId { get; set; }

        /// <summary>
        /// Whether someone who is not invited may still register, which is the case when the portal trusts every mail  domain or a list of them. It is computed for an anonymous caller only and left out entirely for a  signed-in one, so a missing value is not a &#x60;false&#x60;.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "enabledJoin", EmitDefaultValue = true)]
        public bool? EnabledJoin { get; set; }

        /// <summary>
        /// Whether the login page may offer the form for writing to the portal administrators. It is also &#x60;true&#x60;  while the portal&#39;s payment has lapsed, whatever the setting says, so it can be set on a portal where an  administrator switched the form off.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "enableAdmMess", EmitDefaultValue = true)]
        public bool? EnableAdmMess { get; set; }

        /// <summary>
        /// Whether the login page may offer sign-in through an external identity provider. It is computed for an  anonymous caller only; &#x60;GET api/2.0/capabilities&#x60; reports the same thing with the list of providers.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "thirdpartyEnable", EmitDefaultValue = true)]
        public bool? ThirdpartyEnable { get; set; }

        /// <summary>
        /// Always &#x60;true&#x60; in this product. It exists so a client that also talks to older ONLYOFFICE portals can tell  them apart, and is not a feature switch.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "docSpace", EmitDefaultValue = true)]
        public bool DocSpace { get; set; }

        /// <summary>
        /// Whether this is a server installation someone administers themselves rather than a portal in the cloud.  Several fields below and a number of operations behave differently in the two, so a client that has to  branch on the deployment reads it here.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "standalone", EmitDefaultValue = true)]
        public bool Standalone { get; set; }

        /// <summary>
        /// Whether the installation runs from an Amazon machine image, which is a server installation that can read  its own instance metadata. It is &#x60;false&#x60; on every cloud portal.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "isAmi", EmitDefaultValue = true)]
        public bool IsAmi { get; set; }

        /// <summary>
        /// The domain new portals of this installation are created under, which is what a portal name is checked  against and appended to. It is empty on an installation that serves a single portal on a fixed address.
        /// </summary>
        /// <example>example.com</example>
        [DataMember(Name = "baseDomain", IsRequired = true, EmitDefaultValue = true)]
        public string BaseDomain { get; set; }

        /// <summary>
        /// The token that authorizes the first-run setup wizard. It is handed out to anonymous callers only, and only  while the wizard has not been completed; once it has, the field stays empty for good.
        /// </summary>
        /// <example>dGhpc2lzYXRva2Vu...</example>
        [DataMember(Name = "wizardToken", EmitDefaultValue = true)]
        public string WizardToken { get; set; }

        /// <summary>
        /// The parameters for hashing a password in the client before it is sent - the salt, the iteration count and  the hash size. It is filled in for an anonymous caller and, for a signed-in one, only when  &#x60;withPassword&#x3D;true&#x60; is asked for. Hash with exactly these parameters and send the result as  &#x60;passwordHash&#x60;, since the portal cannot reproduce the hash from a different set.
        /// </summary>
        [DataMember(Name = "passwordHash", EmitDefaultValue = false)]
        public PasswordHasher PasswordHash { get; set; }

        /// <summary>
        /// The Firebase project a mobile or web client sends push registrations to. Filled in for a signed-in caller  only, and its own fields are empty strings on an installation that configures no Firebase project.
        /// </summary>
        [DataMember(Name = "firebase", EmitDefaultValue = false)]
        public FirebaseDto Firebase { get; set; }

        /// <summary>
        /// The product version of the portal, empty when the installation does not publish one. It is the version of  the server, not of this API, whose own version is fixed at 2.0.
        /// </summary>
        /// <example>12.5.0</example>
        [DataMember(Name = "version", EmitDefaultValue = true)]
        public string @Version { get; set; }

        /// <summary>
        /// The site key for the CAPTCHA named by &#x60;recaptchaType&#x60;, safe to embed in a page. It is empty when the  installation configures no CAPTCHA, in which case the login form asks for none.
        /// </summary>
        /// <example>abc123def456</example>
        [DataMember(Name = "recaptchaPublicKey", EmitDefaultValue = true)]
        public string RecaptchaPublicKey { get; set; }

        /// <summary>
        /// Whether the client may collect and send diagnostic information. Filled in for a signed-in caller only, and  &#x60;false&#x60; unless the installation switched it on.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "debugInfo", EmitDefaultValue = true)]
        public bool DebugInfo { get; set; }

        /// <summary>
        /// The address of the socket service that pushes live updates to a client. It is filled in for a signed-in  caller and for an anonymous one who arrives with an external sharing link, and is empty when the  installation runs no socket service - a client then has to poll.
        /// </summary>
        /// <example>https://example.com</example>
        [DataMember(Name = "socketUrl", EmitDefaultValue = true)]
        public string SocketUrl { get; set; }

        /// <summary>
        /// The portal&#39;s own name within the installation, which together with &#x60;baseDomain&#x60; forms the address it is  reached at. &#x60;PUT api/2.0/portal/portalrename&#x60; changes it.
        /// </summary>
        /// <example>mycompany</example>
        [DataMember(Name = "tenantAlias", EmitDefaultValue = true)]
        public string TenantAlias { get; set; }

        /// <summary>
        /// Whether the interface may show the About page. A cloud portal always may; a server installation may unless  its plan includes branding and the vendor details hide the page.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "displayAbout", EmitDefaultValue = true)]
        public bool DisplayAbout { get; set; }

        /// <summary>
        /// The rules a portal name is checked against - its length limits and the pattern it has to match - so a  client can validate a rename before sending it. Filled in for a signed-in caller only.
        /// </summary>
        [DataMember(Name = "domainValidator", EmitDefaultValue = false)]
        public TenantDomainValidator DomainValidator { get; set; }

        /// <summary>
        /// The key that lets the client open the vendor&#39;s support chat, empty when the installation configures none.  Filled in for a signed-in caller only.
        /// </summary>
        /// <example>abc123def456</example>
        [DataMember(Name = "zendeskKey", EmitDefaultValue = true)]
        public string ZendeskKey { get; set; }

        /// <summary>
        /// The Google Tag Manager container the client should load, empty when the installation configures none.  Filled in for a signed-in caller only.
        /// </summary>
        /// <example>GTM-XXXXXX</example>
        [DataMember(Name = "tagManagerId", EmitDefaultValue = true)]
        public string TagManagerId { get; set; }

        /// <summary>
        /// Whether the portal limits how long an authentication session stays valid. The limit itself is read with  &#x60;GET api/2.0/settings/cookiesettings&#x60;; while this is &#x60;false&#x60; a session is honoured for a year.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "cookieSettingsEnabled", IsRequired = true, EmitDefaultValue = true)]
        public bool CookieSettingsEnabled { get; set; }

        /// <summary>
        /// Whether the space-management section is restricted to the portal owner. Filled in for a signed-in caller  only.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "limitedAccessSpace", EmitDefaultValue = true)]
        public bool LimitedAccessSpace { get; set; }

        /// <summary>
        /// Whether the Developer Tools section is hidden from members who are not administrators. Filled in for a  signed-in caller only.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "limitedAccessDevToolsForUsers", EmitDefaultValue = true)]
        public bool LimitedAccessDevToolsForUsers { get; set; }

        /// <summary>
        /// Whether the interface may show the vendor&#39;s promotional banners. A cloud portal always reports &#x60;true&#x60;; on  a server installation it follows the banner setting. Filled in for a signed-in caller only.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "displayBanners", EmitDefaultValue = true)]
        public bool DisplayBanners { get; set; }

        /// <summary>
        /// Whether the AI features - chat, agents and vectorisation - may be used on this portal. While it is  &#x60;false&#x60; the AI Agents folder is hidden and the AI operations are refused. Filled in for a signed-in caller  only.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "aiEnabled", EmitDefaultValue = true)]
        public bool AiEnabled { get; set; }

        /// <summary>
        /// Whether the portal wallet has already dropped below its low-balance threshold, so a client can warn about  AI operations being cut off. It is reported to DocSpace administrators only and left empty for everyone  else, which is not the same as a healthy balance.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "walletLowBalance", EmitDefaultValue = true)]
        public bool? WalletLowBalance { get; set; }

        /// <summary>
        /// The pattern a member&#39;s first and last name has to match, so a client can validate a name before sending  it. It is a .NET regular expression and is applied to each name part separately.
        /// </summary>
        /// <example>^[a-zA-Z0-9_]{3,20}$</example>
        [DataMember(Name = "userNameRegex", EmitDefaultValue = true)]
        public string UserNameRegex { get; set; }

        /// <summary>
        /// How many invitations the portal may still send in the current window. Filled in for a signed-in caller  only, and set to the maximum value of a 32-bit integer on an installation that limits nothing.
        /// </summary>
        /// <example>10</example>
        [DataMember(Name = "invitationLimit", EmitDefaultValue = true)]
        public int? InvitationLimit { get; set; }

        /// <summary>
        /// What the installation allows to be done with web plugins. Filled in for a signed-in caller only, with all  three flags &#x60;false&#x60; unless the installation switched plugins on.
        /// </summary>
        [DataMember(Name = "plugins", EmitDefaultValue = false)]
        public PluginsDto Plugins { get; set; }

        /// <summary>
        /// What a mobile client needs to hand a document link over to the installed application instead of opening it  in the browser. Its fields are empty strings when the installation configures no application.
        /// </summary>
        [DataMember(Name = "deepLink", IsRequired = true, EmitDefaultValue = true)]
        public DeepLinkDto DeepLink { get; set; }

        /// <summary>
        /// Where the ready-made form templates are served from and which extension they carry. Filled in for a  signed-in caller only.
        /// </summary>
        [DataMember(Name = "formGallery", EmitDefaultValue = false)]
        public FormGalleryDto FormGallery { get; set; }

        /// <summary>
        /// The largest image the portal accepts as a logo or an avatar, in bytes. Filled in for a signed-in caller  only, and a larger upload is refused rather than resized.
        /// </summary>
        /// <example>10485760</example>
        [DataMember(Name = "maxImageUploadSize", EmitDefaultValue = false)]
        public long MaxImageUploadSize { get; set; }

        /// <summary>
        /// The wordmark to print next to the portal logo. It falls back to the built-in one while the portal has  stored no text of its own, so it is never empty.
        /// </summary>
        /// <example>Company Name</example>
        [DataMember(Name = "logoText", EmitDefaultValue = true)]
        public string LogoText { get; set; }

        /// <summary>
        /// The addresses of the vendor&#39;s help, support, forum and video resources, already picked for the portal  language. An entry is missing when the installation configures no address for it or the resource is  switched off, which &#x60;GET api/2.0/settings/rebranding/additional&#x60; reports flag by flag.
        /// </summary>
        [DataMember(Name = "externalResources", EmitDefaultValue = false)]
        public CultureSpecificExternalResources ExternalResources { get; set; }

        /// <summary>
        /// Whether the installation has an external database wired up for form results, without which the operations  that write form results there are refused. Filled in for a signed-in caller only.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "externalDbEnabled", EmitDefaultValue = true)]
        public bool ExternalDbEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SettingsDto {\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  TrustedDomains: ").Append(TrustedDomains).Append("\n");
            sb.Append("  TrustedDomainsType: ").Append(TrustedDomainsType).Append("\n");
            sb.Append("  Culture: ").Append(Culture).Append("\n");
            sb.Append("  UtcOffset: ").Append(UtcOffset).Append("\n");
            sb.Append("  UtcHoursOffset: ").Append(UtcHoursOffset).Append("\n");
            sb.Append("  GreetingSettings: ").Append(GreetingSettings).Append("\n");
            sb.Append("  OwnerId: ").Append(OwnerId).Append("\n");
            sb.Append("  NameSchemaId: ").Append(NameSchemaId).Append("\n");
            sb.Append("  EnabledJoin: ").Append(EnabledJoin).Append("\n");
            sb.Append("  EnableAdmMess: ").Append(EnableAdmMess).Append("\n");
            sb.Append("  ThirdpartyEnable: ").Append(ThirdpartyEnable).Append("\n");
            sb.Append("  DocSpace: ").Append(DocSpace).Append("\n");
            sb.Append("  Standalone: ").Append(Standalone).Append("\n");
            sb.Append("  IsAmi: ").Append(IsAmi).Append("\n");
            sb.Append("  BaseDomain: ").Append(BaseDomain).Append("\n");
            sb.Append("  WizardToken: ").Append(WizardToken).Append("\n");
            sb.Append("  PasswordHash: ").Append(PasswordHash).Append("\n");
            sb.Append("  Firebase: ").Append(Firebase).Append("\n");
            sb.Append("  @Version: ").Append(@Version).Append("\n");
            sb.Append("  RecaptchaType: ").Append(RecaptchaType).Append("\n");
            sb.Append("  RecaptchaPublicKey: ").Append(RecaptchaPublicKey).Append("\n");
            sb.Append("  DebugInfo: ").Append(DebugInfo).Append("\n");
            sb.Append("  SocketUrl: ").Append(SocketUrl).Append("\n");
            sb.Append("  TenantStatus: ").Append(TenantStatus).Append("\n");
            sb.Append("  TenantAlias: ").Append(TenantAlias).Append("\n");
            sb.Append("  DisplayAbout: ").Append(DisplayAbout).Append("\n");
            sb.Append("  DomainValidator: ").Append(DomainValidator).Append("\n");
            sb.Append("  ZendeskKey: ").Append(ZendeskKey).Append("\n");
            sb.Append("  TagManagerId: ").Append(TagManagerId).Append("\n");
            sb.Append("  CookieSettingsEnabled: ").Append(CookieSettingsEnabled).Append("\n");
            sb.Append("  LimitedAccessSpace: ").Append(LimitedAccessSpace).Append("\n");
            sb.Append("  LimitedAccessDevToolsForUsers: ").Append(LimitedAccessDevToolsForUsers).Append("\n");
            sb.Append("  DisplayBanners: ").Append(DisplayBanners).Append("\n");
            sb.Append("  AiEnabled: ").Append(AiEnabled).Append("\n");
            sb.Append("  WalletLowBalance: ").Append(WalletLowBalance).Append("\n");
            sb.Append("  UserNameRegex: ").Append(UserNameRegex).Append("\n");
            sb.Append("  InvitationLimit: ").Append(InvitationLimit).Append("\n");
            sb.Append("  Plugins: ").Append(Plugins).Append("\n");
            sb.Append("  DeepLink: ").Append(DeepLink).Append("\n");
            sb.Append("  FormGallery: ").Append(FormGallery).Append("\n");
            sb.Append("  MaxImageUploadSize: ").Append(MaxImageUploadSize).Append("\n");
            sb.Append("  LogoText: ").Append(LogoText).Append("\n");
            sb.Append("  ExternalResources: ").Append(ExternalResources).Append("\n");
            sb.Append("  DefaultFolderType: ").Append(DefaultFolderType).Append("\n");
            sb.Append("  ExternalDbEnabled: ").Append(ExternalDbEnabled).Append("\n");
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
