# DocSpace.API.SDK.Model.WhiteLabelItemSizeDto
The pixel box a logo slot is drawn in, in the shape the imaging library reports a geometry.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AspectRatio** | **bool** | Whether the numbers are to be read as an aspect ratio rather than as pixels. Always `false` on the sizes  this API reports. | [optional] 
**FillArea** | **bool** | Whether an image would be scaled to cover the box rather than to fit inside it. Always `false` here. | [optional] 
**Greater** | **bool** | Whether scaling would apply only to an image larger than the box. Always `false` here. | [optional] 
**Height** | **int** | The height of the box in pixels - one of the two fields of this object that carry information. | [optional] 
**IgnoreAspectRatio** | **bool** | Whether scaling would be allowed to distort the image. Always `false` here. | [optional] 
**IsPercentage** | **bool** | Whether `width` and `height` are to be read as percentages. Always `false` here, so both are pixels. | [optional] 
**Less** | **bool** | Whether scaling would apply only to an image smaller than the box. Always `false` here. | [optional] 
**LimitPixels** | **bool** | Whether the box is to be read as a total pixel-area budget instead of as two dimensions. Always `false`  here. | [optional] 
**Width** | **int** | The width of the box in pixels - the other field of this object that carries information. | [optional] 
**X** | **int** | The horizontal offset of the box from the origin. Always `0` here. | [optional] 
**Y** | **int** | The vertical offset of the box from the origin. Always `0` here. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

