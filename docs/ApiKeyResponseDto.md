# DocSpace.API.SDK.Model.ApiKeyResponseDto
The response data for the API key operations.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | The API key unique identifier. | 
**Name** | **string** | The API key name. | 
**Key** | **string** | The full API key value (only returned when creating a new key). | 
**KeyPostfix** | **string** | The API key postfix (used for identification). | [optional] 
**Permissions** | **List&lt;string&gt;** | The list of permissions granted to the API key. | 
**LastUsed** | [**ApiDateTime**](ApiDateTime.md) | The date and time when the API key was last used. | [optional] 
**CreateOn** | [**ApiDateTime**](ApiDateTime.md) | The date and time when the API key was created. | [optional] 
**CreateBy** | [**EmployeeDto**](EmployeeDto.md) | The identifier of the user who created the API key. | [optional] 
**ExpiresAt** | [**ApiDateTime**](ApiDateTime.md) | The date and time when the API key expires. | [optional] 
**IsActive** | **bool** | Indicates whether the API key is active or not. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

