# DocSpace.API.SDK.Model.AiAiApproveToolCallRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Result** | **Object** |  | 
**AllowAlways** | **bool** | Persist auto-approve for this tool's name. | [optional] 
**ThreadId** | **string** | Thread the assistant message belongs to. | 
**MessageId** | **string** | Storage id of the assistant message holding the tool call. | 
**Idx** | **decimal** | Index of the tool-call content part inside `message.content`. | 
**Message** | [**AiThreadMessageLike**](AiThreadMessageLike.md) | Snapshot of the assistant message at the time the tool call surfaced. | 
**ActionArgs** | [**AiAiActionArgs**](AiAiActionArgs.md) |  | [optional] 
**EntityId** | **string** |  | [optional] 
**ProfileId** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

