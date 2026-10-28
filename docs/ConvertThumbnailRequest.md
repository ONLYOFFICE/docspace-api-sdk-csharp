# DocSpace.API.SDK.Model.ConvertThumbnailRequest
How a thumbnail is fitted. A field left out takes the document service default.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Aspect** | **int?** | The mode to fit the image to the height and width specified:  0 - stretch file to fit height and width;  1 - keep the aspect for the image;  2 - convert the metric size of the page into pixels at 96 dpi. | [optional] 
**First** | **bool?** | Whether a thumbnail is made of the first page only; false makes one of every page. | [optional] 
**Height** | **int?** | The thumbnail height in pixels; not used with aspect 2. | [optional] 
**Width** | **int?** | The thumbnail width in pixels; not used with aspect 2. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

