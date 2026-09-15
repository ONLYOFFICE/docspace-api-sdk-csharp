# DocSpace.API.SDK.Model.ArchiveRoomRequest
The body of a room archiving request.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeleteAfter** | **bool** | Whether the record of the finished job may be dropped without being read. With it off the record waits for the  first poll, which is what lets the caller learn how the move ended; it has no effect on the room itself. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

