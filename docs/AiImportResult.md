# DocSpace.API.SDK.Model.AiImportResult
Outcome of `PromptsEngine.importBundle`. Either every entry persisted with counts, or no entries persisted plus a per-entry error report.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Success** | **bool** | True when the whole bundle was imported. | 
**Imported** | [**AiImportResultImported**](AiImportResultImported.md) |  | [optional] 
**Errors** | [**List&lt;AiImportError&gt;**](AiImportError.md) | What was rejected, per entry. Present on failure - and then nothing was imported. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

