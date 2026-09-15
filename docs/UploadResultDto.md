# DocSpace.API.SDK.Model.UploadResultDto
The outcome of storing an image in temporary storage before it is used as a room logo.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Success** | **bool** | True when the image was stored and its path is in the data field. A rejected image is reported with an error  response rather than with a false here, so this field is true in every answer that carries a body. | [optional] 
**Data** | **Object** |  | [optional] 
**Message** | **string** | Left empty by this operation: nothing is reported here, and a refused image comes back as an error response  instead. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

