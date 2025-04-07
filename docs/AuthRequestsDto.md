# Docspace.Model.AuthRequestsDto
Authentication request parameters

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserName** | **string** | Username / email | [optional] 
**Password** | **string** | Password | [optional] 
**PasswordHash** | **string** | Password hash | [optional] 
**Provider** | **string** | Provider type | [optional] 
**AccessToken** | **string** | Provider access token | [optional] 
**SerializedProfile** | **string** | Serialized user profile | [optional] 
**Code** | **string** | Two-factor authentication code | [optional] 
**CodeOAuth** | **string** | Code for getting a token | [optional] 
**Session** | **bool** | Session based authentication or not | [optional] 
**ConfirmData** | [**ConfirmData**](ConfirmData.md) |  | [optional] 
**RecaptchaType** | **RecaptchaType** |  | [optional] 
**RecaptchaResponse** | **string** | reCAPTCHA response | [optional] 
**Culture** | **string** | Culture | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

