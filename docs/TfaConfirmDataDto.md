# DocSpace.API.SDK.Model.TfaConfirmDataDto
The confirmation link the caller has to follow to pass the two-factor step, and the cookie it depends on.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** | The link to open. Its `type` shows which step it is: phone activation or phone authorization for the SMS  method, and authenticator activation or re-verification for the application method. The whole body is empty  when the portal requires no second factor of the caller. | [optional] 
**CookieName** | **string** | The name of the confirmation cookie the link is validated against. It is filled in only for the  authenticator-application method; the SMS method returns `url` alone. | [optional] 
**CookieValue** | **string** | The value of that cookie. The call already set it on the response, so it is repeated here only for a client  that does not keep cookies of its own; it is filled in under the same condition as `cookieName`, and a  later call to this operation replaces it. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

