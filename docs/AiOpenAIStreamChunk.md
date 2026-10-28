# DocSpace.API.SDK.Model.AiOpenAIStreamChunk
A chunk or the terminal error envelope emitted on a failed stream.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The completion identifier, stable across every chunk of one response. | 
**Object** | **string** | Always `chat.completion.chunk`. | 
**Created** | **decimal** | When the completion started, in Unix seconds. | 
**Model** | **string** | The model that produced the completion - the resolved profile's model. | 
**Choices** | [**List&lt;AiOpenAIChunkChoice&gt;**](AiOpenAIChunkChoice.md) | The choices carried by this chunk. This service emits exactly one. | 
**Error** | [**AiOpenAIStreamErrorError**](AiOpenAIStreamErrorError.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

