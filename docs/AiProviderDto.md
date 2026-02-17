# DocSpace.API.SDK.Model.AiProviderDto
AI provider details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | AI provider identifier. | [optional] 
**Title** | **string** | AI provider display title. | 
**Type** | **ProviderType** |  | [optional] 
**Url** | **string** | API endpoint URL for the AI provider. | [optional] 
**CreatedOn** | [**ApiDateTime**](ApiDateTime.md) |  | 
**ModifiedOn** | [**ApiDateTime**](ApiDateTime.md) |  | 
**NeedReset** | **bool** | Indicates whether the provider&#39;s API key needs to be reset. | [optional] 
**IsDefault** | **bool** | Indicates whether this provider is the default provider for the tenant. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

