# DocSpace.API.SDK.Model.DeleteBatchRequestDto
The request parameters for deleting files.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReturnSingleOperation** | **bool** | Specifies whether to return only the current operation | [optional] 
**FolderIds** | [**List&lt;DeleteBatchRequestDtoAllOfFolderIds&gt;**](DeleteBatchRequestDtoAllOfFolderIds.md) | The list of folder IDs to be deleted. | [optional] 
**FileIds** | [**List&lt;DeleteBatchRequestDtoAllOfFileIds&gt;**](DeleteBatchRequestDtoAllOfFileIds.md) | The list of file IDs to be deleted. | [optional] 
**DeleteAfter** | **bool** | Specifies whether to delete a file after the editing session is finished or not | [optional] 
**Immediately** | **bool** | Specifies whether to move a file to the \\Trash\\ folder or delete it immediately. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

