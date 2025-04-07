# Docspace.Model.UserInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | ID | [optional] 
**FirstName** | **string** | First name | [optional] 
**LastName** | **string** | Last name | [optional] 
**UserName** | **string** | Username | [optional] 
**BirthDate** | **DateTime?** | Birthday | [optional] 
**Sex** | **bool?** | Sex (male or female) | [optional] 
**Status** | **EmployeeStatus** |  | [optional] 
**ActivationStatus** | **EmployeeActivationStatus** |  | [optional] 
**TerminatedDate** | **DateTime?** | The date and time when the user account was terminated | [optional] 
**Title** | **string** | Title | [optional] 
**WorkFromDate** | **DateTime?** | Registration date | [optional] 
**Email** | **string** | Email | [optional] 
**Contacts** | **string** | List of contacts in the string format | [optional] 
**ContactsList** | **List&lt;string&gt;** | List of contacts | [optional] 
**Location** | **string** | Location | [optional] 
**Notes** | **string** | Notes | [optional] 
**Removed** | **bool** | Specifies if the user account was removed or not | [optional] 
**LastModified** | **DateTime** | Last modified date | [optional] 
**TenantId** | **int** | Tenant ID | [optional] 
**IsActive** | **bool** | Spceifies if the user is active or not | [optional] [readonly] 
**CultureName** | **string** | Language | [optional] 
**MobilePhone** | **string** | Mobile phone | [optional] 
**MobilePhoneActivationStatus** | **MobilePhoneActivationStatus** |  | [optional] 
**Sid** | **string** | LDAP user identificator | [optional] 
**LdapQouta** | **long** | LDAP user quota attribute | [optional] 
**SsoNameId** | **string** | SSO SAML user identificator | [optional] 
**SsoSessionId** | **string** | SSO SAML user session identificator | [optional] 
**CreateDate** | **DateTime** | Creation date | [optional] 
**CreatedBy** | **Guid?** |  | [optional] 
**Spam** | **bool?** |  | [optional] 
**CheckActivation** | **bool** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

