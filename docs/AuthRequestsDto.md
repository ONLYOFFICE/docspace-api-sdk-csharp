# DocSpace.Sdk.Model.AuthRequestsDto
The parameters required for the user authentication requests.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserName** | **string** | The username or email used for authentication. | [optional] 
**Password** | **string** | The password in plain text for user authentication. | [optional] 
**PasswordHash** | **string** | The hashed password for secure verification. | [optional] 
**Provider** | **string** | The type of authentication provider (e.g., internal, Google, Azure). | [optional] 
**AccessToken** | **string** | The access token used for authentication with external providers. | [optional] 
**SerializedProfile** | **string** | The serialized user profile data, if applicable. | [optional] 
**Code** | **string** | The code for two-factor authentication. | [optional] 
**CodeOAuth** | **string** | The authorization code used for obtaining OAuth tokens. | [optional] 
**Session** | **bool** | Specifies whether the authentication is session-based. | [optional] 
**ConfirmData** | [**ConfirmData**](ConfirmData.md) |  | [optional] 
**RecaptchaType** | **RecaptchaType** |  | [optional] 
**RecaptchaResponse** | **string** | The user&#39;s response to the CAPTCHA challenge. | [optional] 
**Culture** | **string** | The culture code for localization during authentication. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

