# DocSpace.API.SDK.Model.AuthenticationTokenDto
The outcome of a sign-in attempt: either the authentication token, or the second factor still to be passed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Token** | **string** | The token to put in the `Authorization` header of later calls. It is empty whenever a second factor is  still outstanding, which is what `sms` or `tfa` then says; the same token is also set as a portal cookie by  the call that issued it, so a browser client does not have to carry it itself. | [optional] 
**Expires** | **DateTime** | When the token stops being accepted. It stays at its zero value when `session=true` tied the token to the  browser session instead of to a fixed moment. On the two operations that only send an SMS it carries a  different meaning: there is no token, and this is the moment the code that was just sent expires. | [optional] 
**Sms** | **bool** | Whether an SMS code is the second factor in play. Next to an empty `token` it means the code has to be sent  to `POST api/2.0/authentication/{code}` before a token is issued; next to a filled `token` it means the  code just accepted was an SMS one. | [optional] 
**PhoneNoise** | **string** | The stored phone number with its middle digits masked, filled in only while `sms` is set and a number is  already activated for the user. It is there to be shown to the person signing in, not to be sent back. | [optional] 
**Tfa** | **bool** | Whether an authenticator app is the second factor in play, with the same two readings as `sms`. | [optional] 
**TfaKey** | **string** | The secret to enrol in an authenticator app, in the manual-entry form. It is filled in only while `tfa` is  set and the app has not been connected yet, which is the one moment the secret is handed out; once the app  is connected it stays empty. `GET api/2.0/settings/tfaapp/setup` returns the same secret with a QR code. | [optional] 
**ConfirmUrl** | **string** | The confirmation link the client has to open to get past the second factor. It points at phone activation  while no number is activated, at authenticator-app activation while the app is not connected, and at the  plain code prompt once either is in place. It is empty in an answer that already carries a token. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

