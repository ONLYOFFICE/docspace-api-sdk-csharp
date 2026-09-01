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
**LastUsed** | [**ApiDateTime**](ApiDateTime.md) | The API date and time parameters. | [optional] 
**CreateOn** | [**ApiDateTime**](ApiDateTime.md) | The API date and time parameters. | [optional] 
**CreateBy** | [**EmployeeDto**](EmployeeDto.md) | The user parameters. | [optional] 
**ExpiresAt** | [**ApiDateTime**](ApiDateTime.md) | The API date and time parameters. | [optional] 
**IsActive** | **bool** | Indicates whether the API key is active or not. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

