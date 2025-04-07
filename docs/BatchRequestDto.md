# Docspace.Model.BatchRequestDto
Request parameters for copying/moving files

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FolderIds** | [**List&lt;BaseBatchRequestDtoFolderIdsInner&gt;**](BaseBatchRequestDtoFolderIdsInner.md) | List of folder IDs | [optional] 
**FileIds** | [**List&lt;BaseBatchRequestDtoFolderIdsInner&gt;**](BaseBatchRequestDtoFolderIdsInner.md) | List of file IDs | [optional] 
**DestFolderId** | [**BatchRequestDtoDestFolderId**](BatchRequestDtoDestFolderId.md) |  | [optional] 
**ConflictResolveType** | **FileConflictResolveType** |  | [optional] 
**DeleteAfter** | **bool** | Specifies whether to delete a folder after the editing session is finished or not | [optional] 
**Content** | **bool** | Content | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

