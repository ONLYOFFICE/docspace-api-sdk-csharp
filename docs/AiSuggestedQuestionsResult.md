# DocSpace.API.SDK.Model.AiSuggestedQuestionsResult
The starter questions of an attached form, and whether they are ready.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | `ready` - the questions are there; `pending` - they are being generated and arrive over the socket, ask again later; `unavailable` - the attachment is not a form that can have any. | 
**Questions** | [**List&lt;AiSuggestedQuestion&gt;**](AiSuggestedQuestion.md) | The questions; empty unless `status` is `ready`. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

