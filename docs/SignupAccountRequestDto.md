# DocSpace.API.SDK.Model.SignupAccountRequestDto
The request parameters for creating a third-party account.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EmployeeType** | **EmployeeType** | The type the invitation link is looked up as, defaulting to `RoomAdmin`. It does not decide the resulting  type: the link itself does, and this value only has to match the kind of link that was issued. | [optional] 
**Key** | **string** | The key of the invitation link being accepted, taken from the link the invitation email or the room  invitation contains. An expired or already used key is rejected with 403. | 
**Culture** | **string** | The culture to set on the new profile, as a culture code. It is applied only when the portal has that culture  enabled, and otherwise the portal default is kept. | [optional] 
**SerializedProfile** | **string** | The profile a completed provider authorization produced, in the serialized form the login flow hands back.  Pass that value unchanged; the first name, the last name, the email and the avatar of the new profile are  taken from it. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

