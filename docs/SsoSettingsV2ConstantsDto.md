# DocSpace.API.SDK.Model.SsoSettingsV2ConstantsDto
The SSO settings constants: every value the settings accept, by name.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SsoNameIdFormatType** | [**SsoNameIdFormatTypeDto**](SsoNameIdFormatTypeDto.md) | The values the `nameIdFormat` of the identity provider settings accepts. The built-in configuration uses  the SAML 2.0 transient format. | [optional] 
**SsoBindingType** | [**SsoBindingTypeDto**](SsoBindingTypeDto.md) | The values the `ssoBinding` and `sloBinding` of the identity provider settings accept - how the portal  sends its sign-in and sign-out requests. The built-in configuration uses HTTP POST for both. | [optional] 
**SsoSigningAlgorithmType** | [**SsoSigningAlgorithmTypeDto**](SsoSigningAlgorithmTypeDto.md) | The values the `signingAlgorithm` of the service provider certificate and the `verifyAlgorithm` of the  identity provider certificate accept. The built-in configuration uses RSA-SHA1 for both. | [optional] 
**SsoEncryptAlgorithmType** | [**SsoEncryptAlgorithmTypeDto**](SsoEncryptAlgorithmTypeDto.md) | The values the `encryptAlgorithm` and `decryptAlgorithm` of the certificate settings accept. The built-in  configuration uses AES-128 everywhere. | [optional] 
**SsoSpCertificateActionType** | [**SsoSpCertificateActionTypeDto**](SsoSpCertificateActionTypeDto.md) | The values the `action` of a service provider certificate accepts, which is what the portal's own key  pair may be used for. | [optional] 
**SsoIdpCertificateActionType** | [**SsoIdpCertificateActionTypeDto**](SsoIdpCertificateActionTypeDto.md) | The values the `action` of an identity provider certificate accepts, which is what the provider's  certificate may be used for - the mirror image of the service provider actions. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

