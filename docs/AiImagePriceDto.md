# DocSpace.API.SDK.Model.AiImagePriceDto
What an image model charges: the tokens of the request and the images that come out of it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Prompt** | **double** | The cost of one million tokens sent to the image model, which is the prompt describing the picture. | [optional] 
**Completion** | **double** | The cost of one million tokens the image model writes back alongside the picture. | [optional] 
**Image** | **double** | The cost of one produced image, charged on top of the token amounts above. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

