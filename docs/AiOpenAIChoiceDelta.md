# DocSpace.API.SDK.Model.AiOpenAIChoiceDelta
The incremental part of one choice - what this chunk adds to the assistant message.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Role** | **string** | Sent on the first chunk only, always `assistant`. | [optional] 
**Content** | **string** | The text this chunk appends. Null when the chunk carries no text. | [optional] 
**ToolCalls** | [**List&lt;AiOpenAIToolCallDelta&gt;**](AiOpenAIToolCallDelta.md) | The tool calls the model requested, emitted in place of text. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

