# DocSpace.API.SDK.Model.FileEncryptionInfoDto
The encryption information of a file: the user key pairs and the per-user file keys.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserKeys** | [**List&lt;EncryptionKeyDto&gt;**](EncryptionKeyDto.md) | The key pairs of the users who have access to the file. | [optional] 
**FileKeys** | [**List&lt;FileKeys&gt;**](FileKeys.md) | The file keys issued to those users. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

