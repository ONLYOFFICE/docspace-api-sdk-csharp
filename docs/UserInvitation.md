# DocSpace.API.SDK.Model.UserInvitation
Which pending room invitations are to be sent again.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UsersIds** | **List&lt;Guid&gt;** | The accounts to write to, taken from `GET api/2.0/files/rooms/{id}/share`. Anyone who has already joined, is  not in the room, or is invisible to the caller is skipped without an error, and the field is ignored once  every pending invitation is being resent. | [optional] 
**ResendAll** | **bool** | Whether every invitation of the room that is still waiting is sent again. With it on the list of accounts is  ignored, and with it off an empty list means that nothing is sent at all. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

