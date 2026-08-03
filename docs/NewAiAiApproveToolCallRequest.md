# DocSpace.API.SDK.Model.NewAiAiApproveToolCallRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Result** | **Object** | Final result of the tool call, as the model should see it. | 
**AllowAlways** | **bool** | Persist auto-approve for this tool's name. | [optional] 
**ThreadId** | **string** | Thread the assistant message belongs to. | 
**MessageId** | **string** | Storage id of the assistant message holding the tool call. | 
**Idx** | **decimal** | Index of the tool-call content part inside `message.content`. | 
**Message** | [**NewAiThreadMessageLike**](NewAiThreadMessageLike.md) |  | 
**ActionArgs** | [**NewAiAiActionArgs**](NewAiAiActionArgs.md) |  | [optional] 
**EntityId** | **string** |  | [optional] 
**ProfileId** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

