# DocSpace.API.SDK.Model.InvitationLinkCreateRequestDto
The role a new invitation link grants, and the limits placed on it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EmployeeType** | **EmployeeType** | The role whoever follows the link joins with. Only `DocSpaceAdmin`, `RoomAdmin` and `User` are accepted, and  the role cannot be changed afterwards - delete the link and create one for the other role instead. | 
**Expiration** | **DateTime?** | When the link stops letting anyone in, read in the portal time zone. It has to lie in the future; leaving it  out creates a link with no deadline at all. | [optional] 
**MaxUseCount** | **int?** | How many accounts may join through the link in total. Leaving it out creates a link with no use limit; the  uses spent so far are reported as `currentUseCount`. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

