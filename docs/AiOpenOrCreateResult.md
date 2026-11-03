# DocSpace.API.SDK.Model.AiOpenOrCreateResult
The thread that was opened or created, with its stored messages.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ThreadId** | **string** | The thread that was opened, or the one just created. | 
**Title** | **string** | The title generated for a thread this call created; an empty string when it opened an existing thread. | 
**PriorMessages** | [**List&lt;AiThreadMessageLike&gt;**](AiThreadMessageLike.md) | The messages already in the thread - empty for a thread that was just created. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

