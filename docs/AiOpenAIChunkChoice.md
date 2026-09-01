# DocSpace.API.SDK.Model.AiOpenAIChunkChoice
One choice of a streaming completion, carrying the part this chunk adds.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Index** | **decimal** | The zero-based position of the choice. This service emits a single choice, so always 0. | 
**Delta** | [**AiOpenAIChoiceDelta**](AiOpenAIChoiceDelta.md) | What this chunk adds to the choice. | 
**FinishReason** | **AiOpenAIFinishReason** | Why the completion stopped, or null while it is still streaming. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

