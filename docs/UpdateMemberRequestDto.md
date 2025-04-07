# Docspace.Model.UpdateMemberRequestDto
Request parameters for updating user information

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserId** | **string** | User ID | [optional] 
**Disable** | **bool?** | Specifies whether to disable a user or not | [optional] 
**Email** | **string** | Email | [optional] 
**IsUser** | **bool?** | Specifies if this is a guest or a user | [optional] 
**FirstName** | **string** | First name | [optional] 
**LastName** | **string** | Last name | [optional] 
**Department** | **List&lt;Guid&gt;** | List of user departments | [optional] 
**Title** | **string** | Title | [optional] 
**Location** | **string** | Location | [optional] 
**Sex** | **SexEnum** |  | [optional] 
**Birthday** | [**ApiDateTime**](ApiDateTime.md) |  | [optional] 
**Worksfrom** | [**ApiDateTime**](ApiDateTime.md) |  | [optional] 
**Comment** | **string** | Comment | [optional] 
**Contacts** | [**List&lt;Contact&gt;**](Contact.md) | List of user contacts | [optional] 
**Files** | **string** | Avatar photo URL | [optional] 
**CultureName** | **string** | Language | [optional] 
**Spam** | **bool?** | Spam | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

