# DocSpace.Model.SsoSettingsV2
The SSO portal settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LastModified** | **DateTime** |  | [optional] 
**EnableSso** | **bool?** | Specifies if the SSO settings are enabled or not. | [optional] 
**IdpSettings** | [**SsoIdpSettings**](.md) |  | [optional] 
**IdpCertificates** | [**List&lt;SsoCertificate&gt;**](.md) | The list of the IdP certificates. | [optional] 
**IdpCertificateAdvanced** | [**SsoIdpCertificateAdvanced**](.md) |  | [optional] 
**SpLoginLabel** | **string** | The SP login label. | [optional] 
**SpCertificates** | [**List&lt;SsoCertificate&gt;**](.md) | The list of the SP certificates. | [optional] 
**SpCertificateAdvanced** | [**SsoSpCertificateAdvanced**](.md) |  | [optional] 
**FieldMapping** | [**SsoFieldMapping**](.md) |  | [optional] 
**HideAuthPage** | **bool** | Specifies if the authentication page will be hidden or not. | [optional] 
**UsersType** | **int** | The user type. | [optional] 
**DisableEmailVerification** | **bool** | Specifies if the email verification is disabled or not. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

