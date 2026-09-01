# DocSpace.API.SDK.Model.AiImageModelPricing
The pricing of a single image model.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The identifier of the model, as the provider expects it on the wire. | 
**Alias** | **string** | The display name of the model. | [optional] 
**OwnedBy** | **string** | The owner of the model, as reported by the provider. | [optional] 
**Provider** | **string** | The provider that serves the model. | [optional] 
**Link** | **string** | The link to the pricing page of the model. | [optional] 
**Price** | [**AiImagePrice**](AiImagePrice.md) | The price of an image model: per prompt token and per generated image. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

