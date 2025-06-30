# DocSpace.Model.MemberRequestDto
The user request parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Password** | **string** | The user password. | [optional] 
**PasswordHash** | **string** | The user password hash. | [optional] 
**Email** | **string** | The user email address. | [optional] 
**Type** | **EmployeeType** |  | [optional] 
**IsUser** | **bool?** | Specifies if this is a guest or a user. | [optional] 
**FirstName** | **string** | The user first name. | [optional] 
**LastName** | **string** | The user last name. | [optional] 
**Department** | **List&lt;Guid&gt;** | The list of the user departments IDs. | [optional] 
**Title** | **string** | The user title. | [optional] 
**Location** | **string** | The user location. | [optional] 
**Sex** | **SexEnum** |  | [optional] 
**Birthday** | [**ApiDateTime**](.md) |  | [optional] 
**Worksfrom** | [**ApiDateTime**](.md) |  | [optional] 
**Comment** | **string** | The user comment. | [optional] 
**Contacts** | [**List&lt;Contact&gt;**](.md) | The list of the user contacts. | [optional] 
**Files** | **string** | The avatar photo URL. | [optional] 
**FromInviteLink** | **bool** | Specifies if the user is added via the invitation link or not. | [optional] 
**Key** | **string** | The user key. | [optional] 
**CultureName** | **string** | The user culture code. | [optional] 
**Target** | **Guid** | The user target ID. | [optional] 
**Spam** | **bool?** | Specifies if tips, updates and offers are allowed to be sent to the user or not. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

