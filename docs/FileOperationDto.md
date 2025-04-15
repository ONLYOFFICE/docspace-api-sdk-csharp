# Docspace.Model.FileOperationDto
The file operation information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The file operation ID. | [optional] 
**Operation** | **FileOperationType** |  | [optional] 
**Progress** | **int** | The file operation progress in percentage. | [optional] 
**Error** | **string** | The file operation error message. | [optional] 
**Processed** | **string** | The file operation processing status. | [optional] 
**Finished** | **bool** | Specifies if the file operation is finished or not. | [optional] 
**Url** | **string** | The file operation URL. | [optional] 
**Files** | [**List&lt;FileEntryDto&gt;**](FileEntryDto.md) | The list of files of the file operation. | [optional] 
**Folders** | [**List&lt;FileEntryDto&gt;**](FileEntryDto.md) | The list of folders of the file operation. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

