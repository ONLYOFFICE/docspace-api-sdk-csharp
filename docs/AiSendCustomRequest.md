# DocSpace.API.SDK.Model.AiSendCustomRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsStream** | **bool** | Stream the reply (ndjson) when true, else return a single message. | 
**SystemPrompt** | **string** | Caller-supplied system prompt for this one-turn call. | 
**UserMessage** | [**AiThreadMessageLike**](AiThreadMessageLike.md) |  | 
**ActionArgs** | [**AiActionArgs**](AiActionArgs.md) | Per-request options of the round: extra tools, reasoning, a prompt override and the connected context. | [optional] 
**ProfileId** | **string** | Profile to run this call on. When omitted, or when no profile has this id, the `Default` assignment is used. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

