# DocSpace.API.SDK.Model.AiAiActionArgs
Wire-serializable subset of the engine's `ActionArgs` — drops the engine-injected `signal`/`fetch`; `profile`/`messages` are owned by the engine and never sent by the caller.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tools** | [**List&lt;AiTMCPItem&gt;**](AiTMCPItem.md) | Extra tools offered to the model for this request. | [optional] 
**IsReasoning** | **bool** | Enable extended thinking / reasoning for this request. | [optional] 
**Prompt** | [**AiAiActionArgsPrompt**](AiAiActionArgsPrompt.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

