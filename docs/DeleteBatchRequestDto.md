# DocSpace.API.SDK.Model.DeleteBatchRequestDto
The files and folders to delete, and how final the deletion is.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReturnSingleOperation** | **bool** | Which operations the answer carries: `true` returns the operation this call started and nothing else, `false`  returns every operation of the same kind that the caller has running or unread. When nothing was queued, which  happens for an empty selection, `true` falls back to the full list. | [optional] 
**FolderIds** | [**List&lt;DeleteBatchRequestDtoAllOfFolderIds&gt;**](DeleteBatchRequestDtoAllOfFolderIds.md) | The folders to delete, by id, each with everything it contains. A number addresses a folder stored in the  portal itself, a string addresses a folder on a connected third-party account, and both kinds may be sent in  one list. | [optional] 
**FileIds** | [**List&lt;DeleteBatchRequestDtoAllOfFileIds&gt;**](DeleteBatchRequestDtoAllOfFileIds.md) | The files to delete, by id. A number addresses a file stored in the portal itself, a string addresses a file  on a connected third-party account, and both kinds may be sent in one list. | [optional] 
**DeleteAfter** | **bool** | Whether the finished operation is still reported: `false` keeps its final record readable through  `GET api/2.0/files/fileops` until it has been read once, `true` drops the record as soon as the work is done.  It does not postpone the deletion and does not delete anything of its own. | [optional] 
**Immediately** | **bool** | Where the deleted items go: `false` moves them to the Trash of the caller, from which they can be restored,  `true` removes them at once and for good. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

