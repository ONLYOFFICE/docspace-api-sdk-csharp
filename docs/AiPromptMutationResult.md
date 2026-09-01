# DocSpace.API.SDK.Model.AiPromptMutationResult
Outcome of `create` / `update` / `move` on a prompt — either the persisted prompt or a field-scoped error.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Success** | **bool** | True when the prompt was persisted. | 
**Prompt** | [**AiPrompt**](AiPrompt.md) | The persisted prompt. Present on success. | [optional] 
**Error** | [**AiTErrorData**](AiTErrorData.md) | Why the prompt was rejected. Present on failure. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

