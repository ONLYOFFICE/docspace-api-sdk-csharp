# DocSpace.API.SDK.Model.SsoSpCertificateActionTypeDto
What the portal's own key pair may be used for, as the `action` of a service provider certificate.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Signing** | **string** | The key pair signs the requests the portal sends and nothing else. | [optional] [readonly] 
**Encrypt** | **string** | The key pair encrypts what the portal sends and decrypts what comes back, but signs nothing. | [optional] [readonly] 
**SigningAndEncrypt** | **string** | The key pair does both, which is what one pair configured on its own has to be set to. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

