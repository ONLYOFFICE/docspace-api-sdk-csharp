# DocSpace.API.SDK.Model.AccessRequestKeyDto
The file key issued to one account.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserId** | **Guid** | The account that is to open the file with this key; it has to have read access to the file. | [optional] 
**PublicKeyId** | **Guid** | The public key the file key was encrypted with, as reported for that account by  `GET api/2.0/files/file/{fileId}/publickeys`. | [optional] 
**PrivateKeyEnc** | **string** | The key of the file itself, encrypted by the client with that public key, so that the plain key never reaches  the portal. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

