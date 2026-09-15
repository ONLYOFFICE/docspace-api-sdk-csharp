# DocSpace.API.SDK.Model.DeleteFolder
How a folder is to be deleted.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeleteAfter** | **bool** | Whether the deletion waits for the editing sessions on the contents to end: with true a folder somebody is  working in is removed once they are done, with false the deletion starts at once. | [optional] 
**Immediately** | **bool** | Whether the folder is discarded for good instead of being moved to the Trash section: with false it can be  restored from Trash, with true it cannot be recovered. Inside a room there is no Trash and the deletion is  final either way. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

