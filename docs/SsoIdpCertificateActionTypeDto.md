# DocSpace.API.SDK.Model.SsoIdpCertificateActionTypeDto
What the identity provider's certificate may be used for, as the `action` of an identity provider certificate.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Verification** | **string** | The certificate verifies the signatures on what the provider sends, and nothing else - the counterpart of  the service provider's signing action. | [optional] [readonly] 
**Decrypt** | **string** | The certificate is used to decrypt what the provider sends, but verifies no signature. | [optional] [readonly] 
**VerificationAndDecrypt** | **string** | The certificate does both, which is what a single provider certificate has to be set to. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

