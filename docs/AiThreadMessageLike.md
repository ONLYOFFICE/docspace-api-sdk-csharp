# DocSpace.API.SDK.Model.AiThreadMessageLike
A single chat message as it travels on the wire.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Storage-assigned message id (absent on inbound drafts). | [optional] 
**Role** | **string** | Message author role. | 
**Content** | [**AiThreadMessageLikeContent**](AiThreadMessageLikeContent.md) |  | 
**CreatedAt** | **string** | Creation timestamp, ISO-8601 on the wire. | [optional] 
**Status** | [**AiThreadMessageLikeStatus**](AiThreadMessageLikeStatus.md) |  | [optional] 
**Metadata** | **Object** | Per-message metadata. The chat library writes `custom` (with the round's `contextEntityId`) and `steps` (token usage per provider request); `unstable_state`, `unstable_annotations`, `unstable_data` and `submittedFeedback` may appear as well. Read it as an open map. | [optional] 
**Attachments** | **List&lt;Object&gt;** | Attachments linked to the message (`id`, `type`, `name`, `contentType`, `status`, `content`). Read them as open objects. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

