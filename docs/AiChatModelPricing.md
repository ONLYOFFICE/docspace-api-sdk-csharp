# DocSpace.API.SDK.Model.AiChatModelPricing
The pricing of a single chat model.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The identifier of the model, as the provider expects it on the wire. | 
**Alias** | **string** | The display name of the model. | [optional] 
**OwnedBy** | **string** | The owner of the model, as reported by the provider. | [optional] 
**Provider** | **string** | The provider that serves the model. | [optional] 
**Link** | **string** | The link to the pricing page of the model. | [optional] 
**Price** | [**AiChatPrice**](AiChatPrice.md) | The price of a chat model, per token. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

