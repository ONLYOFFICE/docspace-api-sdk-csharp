# DocSpace.API.SDK.Model.ModelDto
The AI model information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProviderId** | **int** | The unique identifier of the AI provider that offers this model. | [optional] 
**ProviderTitle** | **string** | The human-readable display name of the AI provider (e.g., OpenAI, Anthropic). | 
**ModelId** | **string** | The model identifier as recognized by the AI provider (e.g., gpt-4o, claude-sonnet-4-20250514). | 
**Alias** | **string** | The display name for the model. | [optional] 
**Capabilities** | [**AiModelCapabilities**](AiModelCapabilities.md) |  | [optional] 
**Price** | [**AiChatPrice**](AiChatPrice.md) |  | [optional] 
**Currency** | [**CurrencyInfo**](CurrencyInfo.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

