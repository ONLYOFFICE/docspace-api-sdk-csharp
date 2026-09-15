# DocSpace.API.SDK.Model.BatchRequestDto
The files and folders to move or copy, the folder they go to, and the way name clashes are settled.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReturnSingleOperation** | **bool** | Which operations the answer carries: `true` returns the operation this call started and nothing else, `false`  returns every operation of the same kind that the caller has running or unread. When nothing was queued, which  happens for an empty selection, `true` falls back to the full list. | [optional] 
**FolderIds** | [**List&lt;BatchRequestDtoAllOfFolderIds&gt;**](BatchRequestDtoAllOfFolderIds.md) | The folders to move or copy, by id. A number addresses a folder stored in the portal itself, a string  addresses a folder on a connected third-party account, and both kinds may be sent in one list. | [optional] 
**FileIds** | [**List&lt;BatchRequestDtoAllOfFileIds&gt;**](BatchRequestDtoAllOfFileIds.md) | The files to move or copy, by id. A number addresses a file stored in the portal itself, a string addresses a  file on a connected third-party account, and both kinds may be sent in one list. | [optional] 
**DestFolderId** | [**BatchRequestDtoAllOfDestFolderId**](BatchRequestDtoAllOfDestFolderId.md) |  | [optional] 
**ConflictResolveType** | **FileConflictResolveType** | What happens to an item whose name is already taken in the destination folder: `skip` leaves it where it is,  `overwrite` replaces the entry at the destination, and `duplicate` places it beside that entry under a name  with a numeric suffix. `GET api/2.0/files/fileops/move` reports which items would clash. | [optional] 
**DeleteAfter** | **bool** | Whether the finished operation is still reported: `false` keeps its final record readable through  `GET api/2.0/files/fileops` until it has been read once, `true` drops the record as soon as the work is done.  It deletes nothing: a move takes the sources away in any case, and a copy always leaves them. | [optional] 
**Content** | **bool** | What is taken from a listed folder: `false` moves or copies the folder itself, `true` takes only what it  contains, so its files and subfolders land in the destination and the folder is not recreated there. | [optional] 
**ToFillOut** | **bool** | Marks every copied PDF form as a draft prepared for filling, which is how such a copy reports its filling  status in a virtual data room. Files that are not forms are left unaffected. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

