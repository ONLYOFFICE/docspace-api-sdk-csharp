# Docspace.Model.SettingsDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Timezone** | **string** | Time zone | [optional] 
**TrustedDomains** | **List&lt;string&gt;** | List of trusted domains | [optional] 
**TrustedDomainsType** | **TenantTrustedDomainsType** |  | [optional] 
**Culture** | **string** | Language | [optional] 
**UtcOffset** | **string** | UTC offset | [optional] 
**UtcHoursOffset** | **double** | UTC hours offset | [optional] 
**GreetingSettings** | **string** | Greeting settings | [optional] 
**OwnerId** | **Guid** | Owner ID | [optional] 
**NameSchemaId** | **string** | Team template ID | [optional] 
**EnabledJoin** | **bool?** | Specifies if a user can join to the portal or not | [optional] 
**EnableAdmMess** | **bool?** | Specifies if a user can send a message to the administrator or not | [optional] 
**ThirdpartyEnable** | **bool?** | Specifies if a user can connect third-party providers or not | [optional] 
**DocSpace** | **bool** | Specifies if this is a DocSpace portal or not | [optional] 
**Standalone** | **bool** | Specifies if this is a standalone portal or not | [optional] 
**IsAmi** | **bool** | Specifies if this is a AMI instance or not | [optional] 
**BaseDomain** | **string** | Base domain | [optional] 
**WizardToken** | **string** | Wizard token | [optional] 
**PasswordHash** | [**PasswordHasher**](PasswordHasher.md) |  | [optional] 
**Firebase** | [**FirebaseDto**](FirebaseDto.md) |  | [optional] 
**VarVersion** | **string** | Version | [optional] 
**RecaptchaType** | **RecaptchaType** |  | [optional] 
**RecaptchaPublicKey** | **string** | ReCAPTCHA public key | [optional] 
**DebugInfo** | **bool** | Specifies if the debug information will be sent or not | [optional] 
**SocketUrl** | **string** | Socket URL | [optional] 
**TenantStatus** | **TenantStatus** |  | [optional] 
**TenantAlias** | **string** | Tenant alias | [optional] 
**DisplayAbout** | **bool** | Specifies whether to display the About section | [optional] 
**DomainValidator** | [**TenantDomainValidator**](TenantDomainValidator.md) |  | [optional] 
**ZendeskKey** | **string** | Zendesk key | [optional] 
**TagManagerId** | **string** | Tag manager ID | [optional] 
**CookieSettingsEnabled** | **bool** | Specifies whether the cookie settings are enabled | [optional] 
**LimitedAccessSpace** | **bool** | Limited access space | [optional] 
**UserNameRegex** | **string** | User name validation regex | [optional] 
**InvitationLimit** | **int?** | Invitation limit | [optional] 
**Plugins** | [**PluginsDto**](PluginsDto.md) |  | [optional] 
**DeepLink** | [**DeepLinkDto**](DeepLinkDto.md) |  | [optional] 
**FormGallery** | [**FormGalleryDto**](FormGalleryDto.md) |  | [optional] 
**MaxImageUploadSize** | **long** | Max image upload size | [optional] 
**LogoText** | **string** | White label logo text | [optional] 
**ExternalResources** | [**CultureSpecificExternalResources**](CultureSpecificExternalResources.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

