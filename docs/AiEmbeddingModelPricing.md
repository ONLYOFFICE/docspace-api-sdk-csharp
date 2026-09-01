# DocSpace.API.SDK.Model.AiEmbeddingModelPricing
The pricing of a single embedding model.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The identifier of the model, as the provider expects it on the wire. | 
**Alias** | **string** | The display name of the model. | [optional] 
**OwnedBy** | **string** | The owner of the model, as reported by the provider. | [optional] 
**Provider** | **string** | The provider that serves the model. | [optional] 
**Link** | **string** | The link to the pricing page of the model. | [optional] 
**Price** | [**AiEmbeddingPrice**](AiEmbeddingPrice.md) | The price of an embedding model, per token. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

