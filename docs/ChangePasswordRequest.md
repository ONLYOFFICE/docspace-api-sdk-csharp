# DocSpace.API.SDK.Model.ChangePasswordRequest
The request parameters for updating a user password.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Password** | **string** | The new password in plain text. It is checked against the portal password policy and rejected with 400 when  it is too weak, then hashed by the portal. Send it only over a secure connection, and prefer `passwordHash`  when the client can compute it. | [optional] 
**PasswordHash** | **string** | The new password already hashed by the client, which is what the portal stores. It is a PBKDF2-HMACSHA256  hash of the plain password, computed with the salt, the iteration count and the key size the portal settings  publish, and written as lowercase hexadecimal. When it is sent, `password` is ignored and the password policy  is not applied. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

