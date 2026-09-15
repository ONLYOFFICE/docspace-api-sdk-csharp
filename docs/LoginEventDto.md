# DocSpace.API.SDK.Model.LoginEventDto
One entry of the portal login history: a sign-in, a sign-out or a failed attempt, and where it came from.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The ID of the recorded sign-in. When the entry is a successful sign-in that is still open, this is also  the value `GET api/2.0/security/activeconnections` reports as the connection's `id`. | [optional] 
**Date** | [**ApiDateTime**](ApiDateTime.md) | When the attempt was made, in the portal time zone. The `from` and `to` filters are read as UTC instants,  so the two do not line up on a portal that is not on UTC. | [optional] 
**User** | **string** | The display name of the account the attempt was made against, taken from the account as it stands now  rather than as it stood at the time. A localised placeholder stands in when there is no account to read,  which is the usual case for a failed attempt on an address nobody owns. | [optional] 
**UserId** | **Guid** | The ID of that account, which is what the `userId` filter of this operation matches on. It is the empty  GUID when the attempt could not be tied to an account. | [optional] 
**Login** | **string** | The login string as it was typed - normally the email address. It is the only field that survives a failed  attempt against an unknown account, which makes it the one to read when `user` is a placeholder. | [optional] 
**Action** | **string** | The event as a readable sentence in the portal language. On `GET api/2.0/security/audit/login/last` each  substituted value is cut to 50 characters; the filtered operation substitutes them in full. | [optional] 
**ActionId** | **MessageAction** | What happened, as the `action` filter of this operation spells it: a successful sign-in, a failed one, a  sign-out. Use this rather than parsing `action`, which is prose and changes with the portal language. | [optional] 
**Ip** | **string** | The IP address the attempt came from, with the port stripped off. | [optional] 
**Country** | **string** | The English name of the country the IP address is located in, empty when the address cannot be located -  the normal outcome for private and loopback addresses. | [optional] 
**City** | **string** | The city the IP address is located in, empty under the same conditions as `country`. | [optional] 
**Browser** | **string** | The browser and its version as parsed from the user agent of the attempt, empty when the client sent none  that could be parsed. | [optional] 
**Platform** | **string** | The operating system as parsed from the same user agent, empty under the same conditions as `browser`. | [optional] 
**Page** | **string** | Where in the portal the attempt was made from: the referrer of the request, or that request's own path  when it carried no referrer. Long values are cut off at 512 characters. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

