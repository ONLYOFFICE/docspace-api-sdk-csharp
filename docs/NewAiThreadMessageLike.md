# DocSpace.API.SDK.Model.NewAiThreadMessageLike

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Storage-assigned message id (absent on inbound drafts). | [optional] 
**Role** | **string** | Message author role. | 
**Content** | [**NewAiThreadMessageLikeContent**](NewAiThreadMessageLikeContent.md) |  | 
**CreatedAt** | **string** | Creation timestamp, ISO-8601 on the wire. | [optional] 
**Status** | [**NewAiThreadMessageLikeStatus**](NewAiThreadMessageLikeStatus.md) |  | [optional] 
**Metadata** | **Object** | Arbitrary per-message metadata. | [optional] 
**Attachments** | **List&lt;Object&gt;** | Attachments linked to the message. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

