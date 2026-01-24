# DocSpace.API.SDK.Model.InvitationLinkDto
The invitation link parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | The ID of the invitation link. | [optional] 
**EmployeeType** | **EmployeeType** |  | 
**Expiration** | [**ApiDateTime**](ApiDateTime.md) |  | [optional] 
**IsExpired** | **bool** | Indicates whether the invitation link has expired. | [optional] 
**MaxUseCount** | **int?** | The maximum number of times the invitation link can be used. | [optional] 
**CurrentUseCount** | **int** | The current number of times the invitation link has been used. | [optional] 
**Url** | **string** | The URL of the invitation link. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

