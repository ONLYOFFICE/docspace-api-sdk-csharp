# DocSpace.API.SDK.Model.TfaAppCodeDto
One backup code of the caller's authenticator credential.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IsUsed** | **bool** | Whether the code has already been spent. A spent code is kept in the list but is no longer accepted, so  count the entries where this is `false` to know how many fallbacks remain. | [optional] 
**Code** | **string** | The code itself, in the form it is typed at sign-in - six characters with the default configuration. It is  stored encrypted and decrypted for this answer, so this is the one place a caller can read it. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

