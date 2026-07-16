# DocSpace.API.SDK.Model.CreateProviderRequestDto
Request parameters for creating a new AI provider.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **ProviderType** |  | [optional] 
**Title** | **string** | The display title for the AI provider. | 
**Url** | **string** | The API endpoint URL for the AI provider. Required for OpenAiCompatible type; optional for other types that have default URLs. | [optional] 
**Key** | **string** | The authentication API key for the AI provider. | 
**ModelSettings** | [**List&lt;ModelSettingsItemDto&gt;**](ModelSettingsItemDto.md) | Optional list of model settings to configure atomically with the provider creation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

