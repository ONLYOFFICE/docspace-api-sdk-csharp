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
    /// The settings information.
    /// </summary>
    [DataContract(Name = "SettingsDto")]
    public partial class SettingsDto : IValidatableObject
    {

        /// <summary>
        /// The type of the tenant trusted domains.
        /// </summary>
        [DataMember(Name = "trustedDomainsType", EmitDefaultValue = false)]
        public TenantTrustedDomainsType? TrustedDomainsType { get; set; }

        /// <summary>
        /// The type of CAPTCHA validation used.
        /// </summary>
        [DataMember(Name = "recaptchaType", EmitDefaultValue = false)]
        public RecaptchaType? RecaptchaType { get; set; }

        /// <summary>
        /// The tenant status.
        /// </summary>
        [DataMember(Name = "tenantStatus", EmitDefaultValue = false)]
        public TenantStatus? TenantStatus { get; set; }

        /// <summary>
        /// The folder type.
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
        /// <param name="timezone">The time zone..</param>
        /// <param name="trustedDomains">The list of the trusted domains..</param>
        /// <param name="trustedDomainsType">The type of the tenant trusted domains..</param>
        /// <param name="culture">The language. (required).</param>
        /// <param name="utcOffset">The UTC offset in the TimeSpan format..</param>
        /// <param name="utcHoursOffset">The UTC offset in hours..</param>
        /// <param name="greetingSettings">The greeting settings..</param>
        /// <param name="ownerId">The owner ID..</param>
        /// <param name="nameSchemaId">The team template ID..</param>
        /// <param name="enabledJoin">Specifies if a user can join the portal or not..</param>
        /// <param name="enableAdmMess">Specifies if a user can send a message to the administrator when accessing the DocSpace portal or not..</param>
        /// <param name="thirdpartyEnable">Specifies if a user can connect third-party providers to the portal or not..</param>
        /// <param name="docSpace">Specifies if this portal is a DocSpace portal or not..</param>
        /// <param name="standalone">Indicates whether the system is running in standalone mode..</param>
        /// <param name="isAmi">Specifies if this portal is the AMI instance or not..</param>
        /// <param name="baseDomain">The base domain. (required).</param>
        /// <param name="wizardToken">The wizard token..</param>
        /// <param name="passwordHash">The password hash..</param>
        /// <param name="firebase">The Firebase parameters..</param>
        /// <param name="version">The portal version..</param>
        /// <param name="recaptchaType">The type of CAPTCHA validation used..</param>
        /// <param name="recaptchaPublicKey">The ReCAPTCHA public key..</param>
        /// <param name="debugInfo">Specifies if the debug information will be sent or not..</param>
        /// <param name="socketUrl">The socket URL..</param>
        /// <param name="tenantStatus">The tenant status..</param>
        /// <param name="tenantAlias">The tenant alias..</param>
        /// <param name="displayAbout">Specifies whether to display the About portal section..</param>
        /// <param name="domainValidator">The domain validator..</param>
        /// <param name="zendeskKey">The Zendesk key..</param>
        /// <param name="tagManagerId">The tag manager ID..</param>
        /// <param name="cookieSettingsEnabled">Specifies whether the cookie settings are enabled. (required).</param>
        /// <param name="limitedAccessSpace">Specifies whether the access to the space management is limited or not..</param>
        /// <param name="limitedAccessDevToolsForUsers">Specifies whether the access to the Developer Tools is limited for users or not..</param>
        /// <param name="displayBanners">Specifies whether to display the promotional banners..</param>
        /// <param name="aiEnabled">Specifies whether AI functionality (chat, agents, vectorization) is enabled for the current tenant.  When &#x60;false&#x60;, all AI features are disabled and the AI Agents folder is hidden..</param>
        /// <param name="walletLowBalance">Specifies whether the tenant wallet balance is currently below the low-balance threshold. Only returned to portal administrators..</param>
        /// <param name="userNameRegex">The user name validation regex..</param>
        /// <param name="invitationLimit">The maximum number of invitations to the portal..</param>
        /// <param name="plugins">The plugins settings..</param>
        /// <param name="deepLink">The deep link settings. (required).</param>
        /// <param name="formGallery">The form gallery settings..</param>
        /// <param name="maxImageUploadSize">The maximum image upload size..</param>
        /// <param name="logoText">The white label logo text..</param>
        /// <param name="externalResources">The external resources settings..</param>
        /// <param name="defaultFolderType">The folder type..</param>
        /// <param name="externalDbEnabled">Specifies if an external database is connected for storing form results..</param>
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
        /// The time zone.
        /// </summary>
        /// <example>UTC</example>
        [DataMember(Name = "timezone", EmitDefaultValue = true)]
        public string Timezone { get; set; }

        /// <summary>
        /// The list of the trusted domains.
        /// </summary>
        /// <example>["mydomain.com","mydomain1.com"]</example>
        [DataMember(Name = "trustedDomains", EmitDefaultValue = true)]
        public List<string> TrustedDomains { get; set; }

        /// <summary>
        /// The language.
        /// </summary>
        /// <example>en-US</example>
        [DataMember(Name = "culture", IsRequired = true, EmitDefaultValue = true)]
        public string Culture { get; set; }

        /// <summary>
        /// The UTC offset in the TimeSpan format.
        /// </summary>
        /// <example>-08:30:00</example>
        [DataMember(Name = "utcOffset", EmitDefaultValue = false)]
        public string UtcOffset { get; set; }

        /// <summary>
        /// The UTC offset in hours.
        /// </summary>
        /// <example>-8.5</example>
        [DataMember(Name = "utcHoursOffset", EmitDefaultValue = false)]
        public double UtcHoursOffset { get; set; }

        /// <summary>
        /// The greeting settings.
        /// </summary>
        /// <example>Web Office Applications</example>
        [DataMember(Name = "greetingSettings", EmitDefaultValue = true)]
        public string GreetingSettings { get; set; }

        /// <summary>
        /// The owner ID.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000000</example>
        [DataMember(Name = "ownerId", EmitDefaultValue = false)]
        public Guid OwnerId { get; set; }

        /// <summary>
        /// The team template ID.
        /// </summary>
        /// <example>default</example>
        [DataMember(Name = "nameSchemaId", EmitDefaultValue = true)]
        public string NameSchemaId { get; set; }

        /// <summary>
        /// Specifies if a user can join the portal or not.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "enabledJoin", EmitDefaultValue = true)]
        public bool? EnabledJoin { get; set; }

        /// <summary>
        /// Specifies if a user can send a message to the administrator when accessing the DocSpace portal or not.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "enableAdmMess", EmitDefaultValue = true)]
        public bool? EnableAdmMess { get; set; }

        /// <summary>
        /// Specifies if a user can connect third-party providers to the portal or not.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "thirdpartyEnable", EmitDefaultValue = true)]
        public bool? ThirdpartyEnable { get; set; }

        /// <summary>
        /// Specifies if this portal is a DocSpace portal or not.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "docSpace", EmitDefaultValue = true)]
        public bool DocSpace { get; set; }

        /// <summary>
        /// Indicates whether the system is running in standalone mode.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "standalone", EmitDefaultValue = true)]
        public bool Standalone { get; set; }

        /// <summary>
        /// Specifies if this portal is the AMI instance or not.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "isAmi", EmitDefaultValue = true)]
        public bool IsAmi { get; set; }

        /// <summary>
        /// The base domain.
        /// </summary>
        /// <example>example.com</example>
        [DataMember(Name = "baseDomain", IsRequired = true, EmitDefaultValue = true)]
        public string BaseDomain { get; set; }

        /// <summary>
        /// The wizard token.
        /// </summary>
        /// <example>dGhpc2lzYXRva2Vu...</example>
        [DataMember(Name = "wizardToken", EmitDefaultValue = true)]
        public string WizardToken { get; set; }

        /// <summary>
        /// The password hash.
        /// </summary>
        [DataMember(Name = "passwordHash", EmitDefaultValue = false)]
        public PasswordHasher PasswordHash { get; set; }

        /// <summary>
        /// The Firebase parameters.
        /// </summary>
        [DataMember(Name = "firebase", EmitDefaultValue = false)]
        public FirebaseDto Firebase { get; set; }

        /// <summary>
        /// The portal version.
        /// </summary>
        /// <example>12.5.0</example>
        [DataMember(Name = "version", EmitDefaultValue = true)]
        public string @Version { get; set; }

        /// <summary>
        /// The ReCAPTCHA public key.
        /// </summary>
        /// <example>abc123def456</example>
        [DataMember(Name = "recaptchaPublicKey", EmitDefaultValue = true)]
        public string RecaptchaPublicKey { get; set; }

        /// <summary>
        /// Specifies if the debug information will be sent or not.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "debugInfo", EmitDefaultValue = true)]
        public bool DebugInfo { get; set; }

        /// <summary>
        /// The socket URL.
        /// </summary>
        /// <example>https://example.com</example>
        [DataMember(Name = "socketUrl", EmitDefaultValue = true)]
        public string SocketUrl { get; set; }

        /// <summary>
        /// The tenant alias.
        /// </summary>
        /// <example>mycompany</example>
        [DataMember(Name = "tenantAlias", EmitDefaultValue = true)]
        public string TenantAlias { get; set; }

        /// <summary>
        /// Specifies whether to display the About portal section.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "displayAbout", EmitDefaultValue = true)]
        public bool DisplayAbout { get; set; }

        /// <summary>
        /// The domain validator.
        /// </summary>
        [DataMember(Name = "domainValidator", EmitDefaultValue = false)]
        public TenantDomainValidator DomainValidator { get; set; }

        /// <summary>
        /// The Zendesk key.
        /// </summary>
        /// <example>abc123def456</example>
        [DataMember(Name = "zendeskKey", EmitDefaultValue = true)]
        public string ZendeskKey { get; set; }

        /// <summary>
        /// The tag manager ID.
        /// </summary>
        /// <example>GTM-XXXXXX</example>
        [DataMember(Name = "tagManagerId", EmitDefaultValue = true)]
        public string TagManagerId { get; set; }

        /// <summary>
        /// Specifies whether the cookie settings are enabled.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "cookieSettingsEnabled", IsRequired = true, EmitDefaultValue = true)]
        public bool CookieSettingsEnabled { get; set; }

        /// <summary>
        /// Specifies whether the access to the space management is limited or not.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "limitedAccessSpace", EmitDefaultValue = true)]
        public bool LimitedAccessSpace { get; set; }

        /// <summary>
        /// Specifies whether the access to the Developer Tools is limited for users or not.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "limitedAccessDevToolsForUsers", EmitDefaultValue = true)]
        public bool LimitedAccessDevToolsForUsers { get; set; }

        /// <summary>
        /// Specifies whether to display the promotional banners.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "displayBanners", EmitDefaultValue = true)]
        public bool DisplayBanners { get; set; }

        /// <summary>
        /// Specifies whether AI functionality (chat, agents, vectorization) is enabled for the current tenant.  When &#x60;false&#x60;, all AI features are disabled and the AI Agents folder is hidden.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "aiEnabled", EmitDefaultValue = true)]
        public bool AiEnabled { get; set; }

        /// <summary>
        /// Specifies whether the tenant wallet balance is currently below the low-balance threshold. Only returned to portal administrators.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "walletLowBalance", EmitDefaultValue = true)]
        public bool? WalletLowBalance { get; set; }

        /// <summary>
        /// The user name validation regex.
        /// </summary>
        /// <example>^[a-zA-Z0-9_]{3,20}$</example>
        [DataMember(Name = "userNameRegex", EmitDefaultValue = true)]
        public string UserNameRegex { get; set; }

        /// <summary>
        /// The maximum number of invitations to the portal.
        /// </summary>
        /// <example>10</example>
        [DataMember(Name = "invitationLimit", EmitDefaultValue = true)]
        public int? InvitationLimit { get; set; }

        /// <summary>
        /// The plugins settings.
        /// </summary>
        [DataMember(Name = "plugins", EmitDefaultValue = false)]
        public PluginsDto Plugins { get; set; }

        /// <summary>
        /// The deep link settings.
        /// </summary>
        [DataMember(Name = "deepLink", IsRequired = true, EmitDefaultValue = true)]
        public DeepLinkDto DeepLink { get; set; }

        /// <summary>
        /// The form gallery settings.
        /// </summary>
        [DataMember(Name = "formGallery", EmitDefaultValue = false)]
        public FormGalleryDto FormGallery { get; set; }

        /// <summary>
        /// The maximum image upload size.
        /// </summary>
        /// <example>10485760</example>
        [DataMember(Name = "maxImageUploadSize", EmitDefaultValue = false)]
        public long MaxImageUploadSize { get; set; }

        /// <summary>
        /// The white label logo text.
        /// </summary>
        /// <example>Company Name</example>
        [DataMember(Name = "logoText", EmitDefaultValue = true)]
        public string LogoText { get; set; }

        /// <summary>
        /// The external resources settings.
        /// </summary>
        [DataMember(Name = "externalResources", EmitDefaultValue = false)]
        public CultureSpecificExternalResources ExternalResources { get; set; }

        /// <summary>
        /// Specifies if an external database is connected for storing form results.
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
