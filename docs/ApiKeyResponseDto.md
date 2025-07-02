# DocSpace.Sdk.Model.ApiKeyResponseDto
The response data for the API key operations.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | The unique identifier of the API key. | [optional] 
**Name** | **string** | The API key name. | [optional] 
**Key** | **string** | The full API key value (only returned when creating a new key). | [optional] 
**KeyPostfix** | **string** | The API key postfix (used for identification). | [optional] 
**Permissions** | **List&lt;string&gt;** | The list of permissions granted to the API key. | [optional] 
**LastUsed** | [**ApiDateTime**](ApiDateTime.md) |  | [optional] 
**CreateOn** | [**ApiDateTime**](ApiDateTime.md) |  | [optional] 
**CreateBy** | [**EmployeeDto**](EmployeeDto.md) |  | [optional] 
**ExpiresAt** | [**ApiDateTime**](ApiDateTime.md) |  | [optional] 
**IsActive** | **bool** | Indicates whether the API key is active or not. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

