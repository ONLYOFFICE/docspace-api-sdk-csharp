# DocSpace.Sdk.Model.UploadRequestDto
The request parameters for uploading a file.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**File** | [**FileParameter**](FileParameter.md) | The file to be uploaded. | [optional] 
**ContentType** | [**ContentType**](ContentType.md) |  | [optional] 
**ContentDisposition** | [**ContentDisposition**](ContentDisposition.md) |  | [optional] 
**Files** | [**List&lt;FileParameter&gt;**](FileParameter.md) | The list of files when specified as multipart/form-data. | [optional] 
**CreateNewIfExist** | **bool** | Specifies whether to create the new file if it already exists or not. | [optional] 
**StoreOriginalFileFlag** | **bool?** | Specifies whether to upload documents in the original formats as well or not. | [optional] 
**KeepConvertStatus** | **bool** | Specifies whether to keep the file converting status or not. | [optional] 
**Stream** | [**FileParameter**](FileParameter.md) | The request input stream. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

