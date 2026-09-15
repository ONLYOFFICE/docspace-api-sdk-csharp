# DocSpace.API.SDK.Model.Delete
The parameters of a single file deletion.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeleteAfter** | **bool** | When to delete: `true` waits until the editing session on the file has ended, `false` deletes at once, pulling  the file away from whoever is working on it. | [optional] 
**Immediately** | **bool** | Where the file goes: `false` moves it to Trash, from where it can be restored, `true` deletes it for good.  Inside a room, where there is no Trash, deletion is always final. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

