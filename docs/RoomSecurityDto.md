# DocSpace.API.SDK.Model.RoomSecurityDto
The outcome of a change of the room membership.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Members** | [**List&lt;FileShareDto&gt;**](FileShareDto.md) | The access entries of the subjects named in the request, read back after the change was applied. A subject the  caller may not see is missing from it, so comparing this list with the request is the way to learn who was  skipped; it is null when nothing was applied at all. | [optional] 
**Warning** | **string** | The reason the first subject that could not be handled was skipped, in the language of the request, while the  rest of the list was still applied. Null when every named subject went through. The text is meant to be shown  to a person, not matched against. | [optional] 
**Error** | **RoomSecurityError** | Reports the one case in which nothing at all was changed: a member being removed still holds a role in a form  of the room, and the request did not ask to remove them anyway. Repeat the call with `force` to remove them  together with the role. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

