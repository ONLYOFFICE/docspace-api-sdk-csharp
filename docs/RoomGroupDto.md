# DocSpace.API.SDK.Model.RoomGroupDto
A personal collection of rooms: the name and icon it was given, the account that owns it, and the rooms it gathers  at the moment it was read.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The identifier of the group, which addresses it in every other group operation and is kept for as long as the  group exists. | [optional] 
**Name** | **string** | The name its owner gave the group, stored trimmed of surrounding spaces. Names are not unique, so two groups  of the same account can be told apart only by their identifier. | [optional] 
**Icon** | [**MultiSizeLogoCover**](MultiSizeLogoCover.md) | The built-in cover chosen for the group, carrying the cover identifier and its rendering in each available  size. Null when the group has no icon, either because it was never given one or because the icon was cleared  by setting it to an empty value. | [optional] 
**UserId** | **Guid** | The account that created the group and the only one able to read, change or delete it; for any other member of  the portal the group does not exist. | [optional] 
**Rooms** | [**List&lt;FileEntryBaseDto&gt;**](FileEntryBaseDto.md) | The rooms the group gathers, those stored in the portal first and those on connected third-party accounts  after them. Null when the group was asked for without its members, and an empty array when the group holds no  room the caller can still see. A room moved to the archive is left out until it is taken out of the archive. | [optional] 
**TotalRooms** | **int** | How many rooms the group shows: the same rooms `rooms` lists, so archived ones are not counted either. It is  filled even when the rooms themselves were not asked for, which makes it the cheap way to tell an empty group  from a populated one. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

