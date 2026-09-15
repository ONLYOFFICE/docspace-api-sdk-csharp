# DocSpace.API.SDK.Model.ApiKeyResponseDto
The response data for the API key operations.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | The ID of the key. This is the value to pass to `PUT api/2.0/keys/{keyId}` and  `DELETE api/2.0/keys/{keyId}`. | 
**Name** | **string** | The label given to the key when it was created or last updated. | 
**Key** | **string** | The secret to send in the `Authorization` header as `Bearer sk-...`. It is filled in only by the answer of  `POST api/2.0/keys` and cannot be read again afterwards, so it has to be stored at that moment. | 
**KeyPostfix** | **string** | The last four characters of the secret. It is the only part of the secret that later reads expose, and it is  meant for telling keys apart in a list. | [optional] 
**Permissions** | **List&lt;string&gt;** | The scopes the key may use, as accepted by `GET api/2.0/keys/permissions`. An empty list means the key has no  scope restrictions. | 
**LastUsed** | [**ApiDateTime**](ApiDateTime.md) | The UTC moment the key was last used to authenticate a request. It is empty for a key that has never been  used. | [optional] 
**CreateOn** | [**ApiDateTime**](ApiDateTime.md) | The UTC moment the key was created. | [optional] 
**CreateBy** | [**EmployeeDto**](EmployeeDto.md) | The portal member who created the key, and whose access the key acts with. | [optional] 
**ExpiresAt** | [**ApiDateTime**](ApiDateTime.md) | The UTC moment the key stops working. It is empty for a key created without `expiresInDays`, which never  expires. | [optional] 
**IsActive** | **bool** | Whether the key may authenticate requests. A key deactivated through `PUT api/2.0/keys/{keyId}` stays in the  list with this field set to false. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

