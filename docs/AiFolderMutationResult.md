# DocSpace.API.SDK.Model.AiFolderMutationResult
Outcome of `createFolder` / `renameFolder` — either the persisted folder or a field-scoped error.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Success** | **bool** | True when the folder was persisted. | 
**Folder** | [**AiPromptFolder**](AiPromptFolder.md) | The persisted folder. Present on success. | [optional] 
**Error** | [**AiTErrorData**](AiTErrorData.md) | Why the folder was rejected. Present on failure. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

