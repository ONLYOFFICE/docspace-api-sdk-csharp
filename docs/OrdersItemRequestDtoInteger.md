# DocSpace.API.SDK.Model.OrdersItemRequestDtoInteger
One entry to move to a given position inside its folder.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntryId** | **int** | The file or folder to move. | 
**EntryType** | **FileEntryType** | Which of the two the identifier names, because a file and a folder may carry the same number. | 
**Order** | **int** | The position the entry is to take, counting from 1. The entry that held it, and everything after it, is  shifted to make room. A dotted path such as 1.2.3 is accepted as well, of which only the last segment is  read. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

