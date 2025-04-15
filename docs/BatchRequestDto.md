# Docspace.Model.BatchRequestDto
The request parameters for copying/moving files.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FolderIds** | [**List&lt;BaseBatchRequestDtoFolderIdsInner&gt;**](BaseBatchRequestDtoFolderIdsInner.md) | The list of folder IDs to be copied/moved. | [optional] 
**FileIds** | [**List&lt;BaseBatchRequestDtoFolderIdsInner&gt;**](BaseBatchRequestDtoFolderIdsInner.md) | The list of file IDs to be copied/moved. | [optional] 
**DestFolderId** | [**BatchRequestDtoDestFolderId**](BatchRequestDtoDestFolderId.md) |  | [optional] 
**ConflictResolveType** | **FileConflictResolveType** |  | [optional] 
**DeleteAfter** | **bool** | Specifies whether to delete the source files/folders after they are moved or copied to the destination folder. | [optional] 
**Content** | **bool** | Specifies whether to copy or move the folder content or not. | [optional] 
**ToFillOut** | **bool** | Specifies whether the file is copied for filling out | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

