# DocSpace.API.SDK.Model.RoomsNotificationSettingsDto
The rooms the calling user has silenced.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisabledRooms** | **List&lt;Object&gt;** | The identifiers of the silenced rooms, in the order they were added, and belonging to the caller's own  account alone. They are kept as opaque values, so a numeric identifier of a portal room and a string  identifier of a room on a connected third-party account both appear here, and an identifier stays on the  list after its room is deleted. An empty list means nothing is silenced. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

