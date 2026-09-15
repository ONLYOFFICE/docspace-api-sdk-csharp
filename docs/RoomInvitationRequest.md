# DocSpace.API.SDK.Model.RoomInvitationRequest
One batch of membership changes for a room.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Invitations** | [**List&lt;RoomInvitation&gt;**](RoomInvitation.md) | Who is added, changed or removed, one entry per subject. The same subject named twice keeps the level of the  last entry, and an empty list is accepted and changes nothing. | [optional] 
**Notify** | **bool** | Whether the subjects that gained access are told about it by email. With it off the change is silent, which is  the usual choice when membership is synchronised from another system. | [optional] 
**Message** | **string** | The line added to the invitation email. It is used only while the notification is on, and it reaches nobody  whose access was removed. | [optional] 
**Culture** | **string** | The language of the invitation email, as a portal culture name such as en-US. Leaving it out sends each  message in the language of its recipient. | [optional] 
**Force** | **bool** | Whether a member who still holds a role in an unfinished form is removed anyway. With it off such a removal is  refused and reported through the error of the answer, so the form can be reassigned first. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

