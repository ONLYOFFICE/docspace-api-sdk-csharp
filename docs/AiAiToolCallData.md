# DocSpace.API.SDK.Model.AiAiToolCallData
Identifies a pending tool call to resume — mirrors the library `ToolCallData` (its serializable fields).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ThreadId** | **string** | Thread the assistant message belongs to. | 
**MessageId** | **string** | Storage id of the assistant message holding the tool call. | 
**Idx** | **decimal** | Index of the tool-call content part inside `message.content`. | 
**Message** | [**AiThreadMessageLike**](AiThreadMessageLike.md) | Snapshot of the assistant message at the time the tool call surfaced. | 
**ActionArgs** | [**AiAiActionArgs**](AiAiActionArgs.md) | Per-request engine options: extra tools, reasoning, prompt override. | [optional] 
**EntityId** | **string** | Optional entity (room) scope for profile resolution. | [optional] 
**ProfileId** | **string** | Session-level profile override for this request only. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

