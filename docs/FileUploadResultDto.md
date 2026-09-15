# DocSpace.API.SDK.Model.FileUploadResultDto
The file upload result.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Success** | **bool** | Whether the upload succeeded. This is the field to check: the operation answers 200 even when it fails, and  reports the reason in `message` instead of in the status code. | [optional] 
**Data** | **Object** |  | [optional] 
**Message** | **string** | The reason the upload failed, ready to be shown to a person. It is empty for a successful upload, and it is  the only place where a failure is described, because the status code stays 200. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

