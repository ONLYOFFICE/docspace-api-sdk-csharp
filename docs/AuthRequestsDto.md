# DocSpace.API.SDK.Model.AuthRequestsDto
The credentials a sign-in is attempted with: a portal password, a confirmation key, or a third-party account.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserName** | **string** | The account signing in, given as its email address or its portal user name. It is required for a password  sign-in and ignored when the credentials are a confirmation key or a third-party account. | [optional] 
**Password** | **string** | The password in the clear. Send either this or `passwordHash`, never both; hashing it in the client with the  parameters from `GET api/2.0/settings?withpassword=true` and sending `passwordHash` instead keeps the plain  password off the wire. | [optional] 
**PasswordHash** | **string** | The password already hashed in the client. It has to be produced with the `salt`, iteration count and hash  size that `GET api/2.0/settings?withpassword=true` publishes, or the portal cannot recognise it; a value sent  here takes the place of `password`. | [optional] 
**Provider** | **string** | The third-party identity provider the account is being signed in through, by its internal key such as  `google` or `linkedin`. Sending it switches the call to a third-party sign-in, which needs `accessToken` or  `serializedProfile` and is only allowed on a self-hosted installation or a tariff that includes third-party  sign-in. | [optional] 
**AccessToken** | **string** | The access token the provider named in `provider` issued for the account, passed on unchanged for the portal  to verify with that provider. The portal then matches the address it gets back against its own accounts, so a  valid token for an address unknown here is answered as no such user. | [optional] 
**SerializedProfile** | **string** | The third-party profile already fetched and serialised by the caller, as an alternative to `accessToken` for  a provider whose profile the client holds. It identifies the account by the address it carries. | [optional] 
**CodeOAuth** | **string** | The OAuth authorization code obtained from the provider, for a flow that has not been exchanged for an access  token yet. It is recorded with the sign-in rather than replacing `accessToken`. | [optional] 
**Session** | **bool** | Whether the issued token is tied to the browser session. When it is, the answer carries no `expires` and the  token dies with the session; otherwise it lives for the portal session lifetime. | [optional] 
**ConfirmData** | [**ConfirmData**](ConfirmData.md) | The confirmation link data, as a third way to identify the account beside a password and a third-party  account. Send it when the sign-in comes from a link the portal mailed, in which case `userName` and the  password fields are not read. | [optional] 
**RecaptchaType** | **RecaptchaType** | Which CAPTCHA service the proof in `recaptchaResponse` came from. It has to match the service the  installation is configured with, which `GET api/2.0/settings` publishes together with the site key. | [optional] 
**RecaptchaResponse** | **string** | The token the CAPTCHA widget produced in the browser, passed on unchanged for the portal to verify. It is  only demanded once repeated failures have made the portal ask for a challenge, and it is single-use, so a  retry needs a freshly solved one. | [optional] 
**Culture** | **string** | The language the sign-in messages and any letter that follows are written in, as a culture name such as  `en-US`. A culture the installation does not have falls back to the portal language. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

