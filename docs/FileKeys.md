# DocSpace.API.SDK.Model.FileKeys
The encrypted file key issued to one user.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserId** | **Guid** | The identifier of the user the file key was issued to. | [optional] 
**PublicKeyId** | **Guid** | The identifier of the key pair the file key is encrypted for. | [optional] 
**PrivateKeyEnc** | **string** | The file key, encrypted with the public key of the pair. | [optional] 
**TenantId** | **int** | The identifier of the portal the file belongs to. | [optional] 
**FileId** | **int** | The identifier of the file the key unlocks. | [optional] 
**CreateOn** | **DateTime** | The date and time when the file key was issued. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

