# DocSpace.API.SDK.Model.AiActionArgs

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tools** | [**List&lt;AiMCPItem&gt;**](AiMCPItem.md) | Extra tools offered to the model for this request. | [optional] 
**IsReasoning** | **bool** | Legacy extended-thinking switch; stands for `medium`. `reasoningLevel` wins when both are set. | [optional] 
**ReasoningLevel** | **AiReasoningLevel** | Depth of extended thinking for the round; providers clamp it to what the model accepts. | [optional] 
**Prompt** | [**AiActionArgsPrompt**](AiActionArgsPrompt.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

