# DocSpace.API.SDK.Model.ChatSettingsDto
The chat settings parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProviderId** | **int** | The AI provider ID. | [optional] 
**ModelId** | **string** | The AI model ID used for chat completions. | [optional] 
**ModelAlias** | **string** | The AI model display alias. | [optional] 
**Prompt** | **string** | The system prompt for the chat. | [optional] 
**Multimodal** | [**ChatMultimodalSettingsDto**](ChatMultimodalSettingsDto.md) |  | [optional] 
**Internal** | **bool** | Indicates whether this is an internal AI gateway provider. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

