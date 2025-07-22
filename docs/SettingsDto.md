# DocSpace.API.SDK.Model.SettingsDto
The settings information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Timezone** | **string** | The time zone. | [optional] 
**TrustedDomains** | **List&lt;string&gt;** | The list of the trusted domains. | [optional] 
**TrustedDomainsType** | **TenantTrustedDomainsType** |  | [optional] 
**Culture** | **string** | The language. | [optional] 
**UtcOffset** | **string** | The UTC offset in the TimeSpan format. | [optional] 
**UtcHoursOffset** | **double** | The UTC offset in hours. | [optional] 
**GreetingSettings** | **string** | The greeting settings. | [optional] 
**OwnerId** | **Guid** | The owner ID. | [optional] 
**NameSchemaId** | **string** | The team template ID. | [optional] 
**EnabledJoin** | **bool?** | Specifies if a user can join the portal or not. | [optional] 
**EnableAdmMess** | **bool?** | Specifies if a user can send a message to the administrator when accessing the DocSpace portal or not. | [optional] 
**ThirdpartyEnable** | **bool?** | Specifies if a user can connect third-party providers to the portal or not. | [optional] 
**DocSpace** | **bool** | Specifies if this portal is a DocSpace portal or not. | [optional] 
**Standalone** | **bool** | Indicates whether the system is running in standalone mode. | [optional] 
**IsAmi** | **bool** | Specifies if this portal is the AMI instance or not. | [optional] 
**BaseDomain** | **string** | The base domain. | [optional] 
**WizardToken** | **string** | The wizard token. | [optional] 
**PasswordHash** | [**PasswordHasher**](PasswordHasher.md) |  | [optional] 
**Firebase** | [**FirebaseDto**](FirebaseDto.md) |  | [optional] 
**@Version** | **string** | The portal version. | [optional] 
**RecaptchaType** | **RecaptchaType** |  | [optional] 
**RecaptchaPublicKey** | **string** | The ReCAPTCHA public key. | [optional] 
**DebugInfo** | **bool** | Specifies if the debug information will be sent or not. | [optional] 
**SocketUrl** | **string** | The socket URL. | [optional] 
**TenantStatus** | **TenantStatus** |  | [optional] 
**TenantAlias** | **string** | The tenant alias. | [optional] 
**DisplayAbout** | **bool** | Specifies whether to display the \&quot;About\&quot; portal section. | [optional] 
**DomainValidator** | [**TenantDomainValidator**](TenantDomainValidator.md) |  | [optional] 
**ZendeskKey** | **string** | The Zendesk key. | [optional] 
**TagManagerId** | **string** | The tag manager ID. | [optional] 
**CookieSettingsEnabled** | **bool** | Specifies whether the cookie settings are enabled. | [optional] 
**LimitedAccessSpace** | **bool** | Specifies whether the access to the space management is limited or not. | [optional] 
**LimitedAccessDevToolsForUsers** | **bool** | Specifies whether the access to the Developer Tools is limited for users or not. | [optional] 
**DisplayBanners** | **bool** | Specifies whether to display the promotional banners. | [optional] 
**UserNameRegex** | **string** | The user name validation regex. | [optional] 
**InvitationLimit** | **int?** | The maximum number of invitations to the portal. | [optional] 
**Plugins** | [**PluginsDto**](PluginsDto.md) |  | [optional] 
**DeepLink** | [**DeepLinkDto**](DeepLinkDto.md) |  | [optional] 
**FormGallery** | [**FormGalleryDto**](FormGalleryDto.md) |  | [optional] 
**MaxImageUploadSize** | **long** | The maximum image upload size. | [optional] 
**LogoText** | **string** | The white label logo text. | [optional] 
**ExternalResources** | [**CultureSpecificExternalResources**](CultureSpecificExternalResources.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

