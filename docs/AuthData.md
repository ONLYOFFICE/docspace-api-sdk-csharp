# DocSpace.API.SDK.Model.AuthData
The credentials of a third-party storage account. The portal takes them when an account is connected and does not  give them back afterwards.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Login** | **string** | The account name at the storage service. | [optional] 
**Password** | **string** | The password of the account at the storage service. | [optional] 
**RawToken** | **string** | The token of the account, kept as the raw JSON document the storage service issued it in. | [optional] 
**Url** | **string** | The address of the storage server the account lives on. | [optional] 
**Provider** | **string** | The storage service the credentials belong to, as the provider key the account was connected with. | [optional] 
**Token** | [**OAuth20Token**](OAuth20Token.md) | The same token as in `rawToken`, parsed into its OAuth 2.0 fields. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

