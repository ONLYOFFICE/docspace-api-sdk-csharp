# DocSpace.API.SDK.Model.EncryptionKeyRequestDto
The request parameters for storing the encryption key pair of a user.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | The identifier of the key pair. | [optional] 
**PublicKey** | **string** | The public key of the pair, used to encrypt the file keys. | [optional] 
**PrivateKeyEnc** | **string** | The private key of the pair, encrypted with the user password. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

