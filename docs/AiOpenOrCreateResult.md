# DocSpace.API.SDK.Model.AiOpenOrCreateResult
Resolved thread state returned by `ThreadsEngine.openOrCreate`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ThreadId** | **string** | The thread that was opened, or the one just created. | 
**Title** | **string** | Empty string for existing threads — the engine doesn't re-fetch. | 
**PriorMessages** | [**List&lt;AiThreadMessageLike&gt;**](AiThreadMessageLike.md) | The messages already in the thread - empty for a thread that was just created. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

