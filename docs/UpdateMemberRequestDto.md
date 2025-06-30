# DocSpace.Model.UpdateMemberRequestDto
The request parameters for updating the user information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserId** | **string** | The user ID. | [optional] 
**Disable** | **bool?** | Specifies whether to disable a user or not. | [optional] 
**Email** | **string** | The user email address. | [optional] 
**IsUser** | **bool?** | Specifies if this is a guest or a user. | [optional] 
**FirstName** | **string** | The user first name. | [optional] 
**LastName** | **string** | The user last name. | [optional] 
**Department** | **List&lt;Guid&gt;** | The list of the user departments. | [optional] 
**Title** | **string** | The user title. | [optional] 
**Location** | **string** | The user location. | [optional] 
**Sex** | **SexEnum** |  | [optional] 
**Birthday** | [**ApiDateTime**](.md) |  | [optional] 
**Worksfrom** | [**ApiDateTime**](.md) |  | [optional] 
**Comment** | **string** | The user comment. | [optional] 
**Contacts** | [**List&lt;Contact&gt;**](.md) | The list of the user contacts. | [optional] 
**Files** | **string** | The user avatar photo URL. | [optional] 
**Spam** | **bool?** | Specifies if tips, updates and offers are allowed to be sent to the user or not. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

