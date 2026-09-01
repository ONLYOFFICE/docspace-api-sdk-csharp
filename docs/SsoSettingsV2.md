# DocSpace.API.SDK.Model.SsoSettingsV2
The SSO portal settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LastModified** | **DateTime** | The timestamp indicating when the settings were last modified. | [optional] 
**EnableSso** | **bool?** | Specifies if the SSO settings are enabled or not. | [optional] 
**IdpSettings** | [**SsoIdpSettings**](SsoIdpSettings.md) | The SSO IdP settings. | [optional] 
**IdpCertificates** | [**List&lt;SsoCertificate&gt;**](SsoCertificate.md) | The list of the IdP certificates. | [optional] 
**IdpCertificateAdvanced** | [**SsoIdpCertificateAdvanced**](SsoIdpCertificateAdvanced.md) | The IdP advanced certificate. | [optional] 
**SpLoginLabel** | **string** | The SP login label. | [optional] 
**SpCertificates** | [**List&lt;SsoCertificate&gt;**](SsoCertificate.md) | The list of the SP certificates. | [optional] 
**SpCertificateAdvanced** | [**SsoSpCertificateAdvanced**](SsoSpCertificateAdvanced.md) | The SP advanced certificate. | [optional] 
**FieldMapping** | [**SsoFieldMapping**](SsoFieldMapping.md) | The SSO field mapping. | [optional] 
**HideAuthPage** | **bool** | Specifies if the authentication page will be hidden or not. | [optional] 
**UsersType** | **int** | The user type. | [optional] 
**DisableEmailVerification** | **bool** | Specifies if the email verification is disabled or not. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

