# DocSpace.API.SDK.Model.PortalUserDto
A portal account in the format the portal stores it. Returned where the API has always handed out the  stored record; new endpoints return ASC.Web.Api.Models.EmployeeDto instead.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | The user ID. | [optional] 
**FirstName** | **string** | The user's first name. | [optional] 
**LastName** | **string** | The user's last name. | [optional] 
**UserName** | **string** | The user username. | [optional] 
**BirthDate** | **DateTime?** | The user birthday. | [optional] 
**Sex** | **bool?** | The user sex (male or female). | [optional] 
**Status** | **EmployeeStatus** | The user status. | [optional] 
**ActivationStatus** | **EmployeeActivationStatus** | The user activation status. | [optional] 
**TerminatedDate** | **DateTime?** | The date and time when the user account was terminated. | [optional] 
**Title** | **string** | The user title. | [optional] 
**WorkFromDate** | **DateTime?** | The user registration date. | [optional] 
**Email** | **string** | The user email address. | [optional] 
**Contacts** | **string** | The list of user contacts in the string format. | [optional] 
**ContactsList** | **List&lt;string&gt;** | The list of user contacts. | [optional] 
**Location** | **string** | The user location. | [optional] 
**Notes** | **string** | The user notes. | [optional] 
**Removed** | **bool** | Specifies if the user account was removed or not. | [optional] 
**LastModified** | **DateTime** | The date and time when the user account was last modified. | [optional] 
**TenantId** | **int** | The tenant ID. | [optional] 
**IsActive** | **bool** | Specifies if the user is active or not. | [optional] 
**CultureName** | **string** | The user culture code. | [optional] 
**MobilePhone** | **string** | The user mobile phone. | [optional] 
**MobilePhoneActivationStatus** | **MobilePhoneActivationStatus** | The user mobile phone activation status. | [optional] 
**Sid** | **string** | The LDAP user identifier. | [optional] 
**LdapQouta** | **long** | The LDAP user quota attribute. | [optional] 
**SsoNameId** | **string** | The SSO SAML user identifier. | [optional] 
**SsoSessionId** | **string** | The SSO SAML user session identifier. | [optional] 
**CreateDate** | **DateTime** | The date and time when the user account was created. | [optional] 
**CreatedBy** | **Guid?** | The ID of the user who created the current user account. | [optional] 
**Spam** | **bool?** | Specifies if tips, updates and offers are allowed to be sent to the user or not. | [optional] 
**CheckActivation** | **bool** | Specifies whether the account still has to be activated: the opposite of `isActive`. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

