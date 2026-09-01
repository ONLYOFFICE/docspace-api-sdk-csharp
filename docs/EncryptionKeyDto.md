# DocSpace.API.SDK.Model.EncryptionKeyDto
The encryption key pair of a user.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | The identifier of the key pair. | [optional] 
**UserId** | **Guid** | The identifier of the user the key pair belongs to. | [optional] 
**Date** | **DateTime** | The date and time when the key pair was created. | [optional] 
**PublicKey** | **string** | The public key of the pair, used to encrypt the file keys. | [optional] 
**PrivateKeyEnc** | **string** | The private key of the pair, encrypted with the user password. | [optional] 
**CryptoEngineId** | **string** | The identifier of the crypto engine the key pair was issued for. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

