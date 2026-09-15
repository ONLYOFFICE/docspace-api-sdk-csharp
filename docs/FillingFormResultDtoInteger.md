# DocSpace.API.SDK.Model.FillingFormResultDtoInteger
The outcome of one completed form-filling session, as the person who has just filled the form sees it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FormNumber** | **int** | The number this copy was given among the copies made of the same form, counting up from 1. It is the number  the results of the form are ordered by and the one the title of the copy carries. | 
**CompletedForm** | [**FileDtoInteger**](FileDtoInteger.md) | The filled copy that the session produced, as an ordinary file: it can be read and downloaded with the file  operations of this API. | [optional] 
**OriginalForm** | [**FileDtoInteger**](FileDtoInteger.md) | The form the copy was made from, so that a client can offer filling it once more. | [optional] 
**Manager** | [**EmployeeFullDto**](EmployeeFullDto.md) | The account that owns the original form, reported with its email address, so that the person who has just  filled the form knows who receives it and whom to ask about it. | [optional] 
**RoomId** | **int** | The room the form was filled in. It comes back as 0 when the session was reached through a link shared for  that single form rather than for its room, in which case there is no room the caller could be sent to. | 
**IsRoomMember** | **bool** | Tells whether the calling account may open that room: true for a member of the room and for a portal  administrator, in which case a client can offer going to the room; false for the anonymous caller who filled  the form through a link and can only be shown the copy itself. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

