# DocSpace.API.SDK.Model.InvitationLinkUpdateRequestDto
The invitation link being changed, with the deadline and use limit it is to have afterwards.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | The link to change, by the `id` that creating or reading it returned. The role behind that id cannot be  changed here. | 
**Expiration** | **DateTime?** | The new deadline, read in the portal time zone. The body is applied as a whole, so leaving it out clears the  deadline rather than keeping the current one; a moment in the past is refused. | [optional] 
**MaxUseCount** | **int?** | The new total number of accounts that may join through the link. It may not be lower than the uses already  spent, which the link reports as `currentUseCount`, and leaving it out removes the limit rather than keeping  the current one. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

