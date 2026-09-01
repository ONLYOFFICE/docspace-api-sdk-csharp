# DocSpace.API.SDK.Model.AiAiSendStreamBody
Shared body of the two streaming send endpoints (`sendWithStream` and its OpenAI-framed twin) — the `Chat` action is implied, so there is no `actionType`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ThreadId** | **string** | Target thread; a new one is created (with an auto title) when omitted. | [optional] 
**UserMessage** | [**AiThreadMessageLike**](AiThreadMessageLike.md) | The user turn to send. | 
**ActionArgs** | [**AiAiActionArgs**](AiAiActionArgs.md) | Per-request engine options: extra tools, reasoning, prompt override. | [optional] 
**EntityId** | **string** | Optional entity (room) scope for profile resolution. | [optional] 
**ProfileId** | **string** | Session-level profile override for this request only. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

