# DocSpace.API.SDK.Model.EncryptionSettingsDto
The state of the portal's storage encryption.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Password** | **string** | Always an empty string: the encryption password is never returned. | [optional] 
**Status** | **EncryptionStatus** | Whether the storage is encrypted, decrypted, or on its way to either. | [optional] 
**NotifyUsers** | **bool** | Whether the users are notified when the operation starts and ends. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

