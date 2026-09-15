# DocSpace.API.SDK.Model.UpdateRoomGroupRequest
The changes to apply to a room group: a new name, rooms to attach and rooms to detach, in any combination.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RoomsToAdd** | [**List&lt;DuplicateRequestDtoAllOfFileIds&gt;**](DuplicateRequestDtoAllOfFileIds.md) | The rooms to attach to the group, each given as a number for a room stored in the portal or as a string for a  room on a connected third-party account. Every identifier has to name a room the caller can read; repeats and  rooms the group already holds are collapsed rather than refused. | [optional] 
**RoomsToRemove** | [**List&lt;DuplicateRequestDtoAllOfFileIds&gt;**](DuplicateRequestDtoAllOfFileIds.md) | The rooms to detach from the group, in the same two forms. Detaching leaves the room and its content  untouched, and a room the group already holds can be detached even when the caller has lost access to it in  the meantime. | [optional] 
**GroupName** | **string** | The new name of the group, trimmed of surrounding spaces before it is stored. Leaving the member out keeps the  current name, and a name that is blank once trimmed is refused. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

