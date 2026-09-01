# DocSpace.API.SDK.Model.AiOpenAIChatCompletionChunk
One `chat.completion.chunk` of an OpenAI-compatible streaming response. Only the fields this service can populate are emitted - an OpenAI client tolerates the rest as absent.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The completion identifier, stable across every chunk of one response. | 
**Object** | **string** | Always `chat.completion.chunk`. | 
**Created** | **decimal** | When the completion started, in Unix seconds. | 
**Model** | **string** | The model that produced the completion - the resolved profile's model. | 
**Choices** | [**List&lt;AiOpenAIChunkChoice&gt;**](AiOpenAIChunkChoice.md) | The choices carried by this chunk. This service emits exactly one. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

