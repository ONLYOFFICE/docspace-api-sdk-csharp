# DocSpace.API.SDK.Model.EmployeeFullDto
The full list of user parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | The user ID. | [optional] 
**DisplayName** | **string** | The HTML-encoded user's display name formatted according to the default format for the current culture. | [optional] 
**Avatar** | **string** | The user avatar. | [optional] 
**AvatarOriginal** | **string** | The user original size avatar. | [optional] 
**AvatarMax** | **string** | The user maximum size avatar. | [optional] 
**AvatarMedium** | **string** | The user medium size avatar. | [optional] 
**AvatarSmall** | **string** | The user small size avatar. | [optional] 
**ProfileUrl** | **string** | The user profile URL. | [optional] 
**HasAvatar** | **bool** | Specifies if the user has an avatar or not. | [optional] 
**IsAnonim** | **bool** | Specifies if the user is anonymous or not. | [optional] 
**FirstName** | **string** | The user first name. | [optional] 
**LastName** | **string** | The user last name. | [optional] 
**UserName** | **string** | The user username. | [optional] 
**Email** | **string** | The user email. | [optional] 
**Contacts** | [**List&lt;Contact&gt;**](Contact.md) | The list of user contacts. | [optional] 
**Status** | **EmployeeStatus** | The user status. | [optional] 
**ActivationStatus** | **EmployeeActivationStatus** | The user activation status. | [optional] 
**Terminated** | [**ApiDateTime**](ApiDateTime.md) | The date when the user account was terminated. | [optional] 
**Department** | **string** | The user department. | [optional] 
**Groups** | [**List&lt;GroupSummaryDto&gt;**](GroupSummaryDto.md) | The list of user groups. | [optional] 
**Location** | **string** | The user location. | [optional] 
**Notes** | **string** | The user notes. | [optional] 
**IsAdmin** | **bool** | Specifies if the user is an administrator or not. | [optional] 
**IsRoomAdmin** | **bool** | Specifies if the user is a room administrator or not. | [optional] 
**IsLDAP** | **bool** | Specifies if the LDAP settings are enabled for the user or not. | [optional] 
**ListAdminModules** | **List&lt;string&gt;** | The list of the administrator modules. | [optional] 
**IsOwner** | **bool** | Specifies if the user is a portal owner or not. | [optional] 
**IsVisitor** | **bool** | Specifies if the user is a portal visitor or not. | [optional] 
**IsCollaborator** | **bool** | Specifies if the user is a portal collaborator or not. | [optional] 
**CultureName** | **string** | The user culture code. | [optional] 
**MobilePhone** | **string** | The user mobile phone number. | [optional] 
**MobilePhoneActivationStatus** | **MobilePhoneActivationStatus** | The mobile phone activation status. | [optional] 
**IsSSO** | **bool** | Specifies if the SSO settings are enabled for the user or not. | [optional] 
**Theme** | **DarkThemeSettingsType** | The user theme settings. | [optional] 
**QuotaLimit** | **long?** | The user quota limit. | [optional] 
**UsedSpace** | **double?** | The portal used space of the user. | [optional] 
**Shared** | **bool?** | Specifies if the user has access rights. | [optional] 
**IsCustomQuota** | **bool?** | Specifies if the user has a custom quota or not. | [optional] 
**LoginEventId** | **int?** | The current login event ID. | [optional] 
**AuthCookieLifetime** | **double?** | The auth cookie lifetime in seconds. | [optional] 
**CreatedBy** | [**EmployeeDto**](EmployeeDto.md) | The user who created the current user. | [optional] 
**RegistrationDate** | [**ApiDateTime**](ApiDateTime.md) | The user registration date. | [optional] 
**HasPersonalFolder** | **bool?** | Specifies if the user has a personal folder or not. | [optional] 
**TfaAppEnabled** | **bool?** | Indicates whether the user has enabled two-factor authentication (TFA) using an authentication app. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

