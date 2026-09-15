# DocSpace.API.SDK.Model.LogoRequest
The part of an uploaded picture to use as the logo.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TmpFile** | **string** | The picture to cut the logo out of, named by the path that `POST api/2.0/files/logos` returned for it. The  path may be used once and only by the account that uploaded it. | 
**X** | **int** | The left edge of the rectangle cut out of the uploaded picture, counted in pixels from its left side. The  picture itself was already scaled down to fit 1280 by 1280 pixels when it was uploaded. | [optional] 
**Y** | **int** | The top edge of the rectangle cut out of the uploaded picture, counted in pixels from its top. | [optional] 
**Width** | **int** | How wide a piece of the uploaded picture to cut out, in pixels. It has to be sent together with the height,  and the portal builds the four logo sizes out of the piece. | [optional] 
**Height** | **int** | How tall a piece of the uploaded picture to cut out, in pixels. It has to be sent together with the width. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

