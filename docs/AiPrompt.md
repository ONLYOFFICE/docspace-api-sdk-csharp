# DocSpace.API.SDK.Model.AiPrompt
Saved prompt template that users can quickly insert into the chat.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Unique prompt identifier (UUID). | 
**Name** | **string** | Prompt display name shown in the prompt picker. | 
**Text** | **string** | Prompt template text. May contain placeholder tokens. | 
**FolderId** | **string** | Optional parent folder ID. `undefined` means the prompt is at the root level. | [optional] 
**CreatedAt** | **decimal** | Timestamp (ms since epoch) when the prompt was created. | 
**UpdatedAt** | **decimal** | Timestamp (ms since epoch) of the last prompt modification. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

