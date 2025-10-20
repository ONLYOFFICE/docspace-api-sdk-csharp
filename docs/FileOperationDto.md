# DocSpace.API.SDK.Model.FileOperationDto
The file operation information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The file operation ID. | 
**Operation** | **FileOperationType** |  | 
**Progress** | **int** | The file operation progress in percentage. | 
**Error** | **string** | The file operation error message. | 
**Processed** | **string** | The file operation processing status. | 
**Finished** | **bool** | Specifies if the file operation is finished or not. | 
**Url** | **string** | The file operation URL. | [optional] 
**Files** | [**List&lt;FileEntryBaseDto&gt;**](FileEntryBaseDto.md) | The list of files of the file operation. | [optional] 
**Folders** | [**List&lt;FileEntryBaseDto&gt;**](FileEntryBaseDto.md) | The list of folders of the file operation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

