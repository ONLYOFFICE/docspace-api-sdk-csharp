# DocSpace.API.SDK.Model.AccountInfoDto
The account information parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Provider** | **string** | The name of the identity provider, in lowercase, as every other operation of this group expects it: `google`,  `zoom`, `linkedin`, `facebook`, `twitter`, `microsoft`, `appleid`, `weixin` or `nextcloud`. | 
**Url** | **string** | The URL that starts the login with this provider. Open it as it is - it already carries the provider and the  popup or redirect mode the request asked for. | 
**Linked** | **bool** | Whether this provider is already linked to the calling profile. It is always false for an anonymous caller,  because there is no profile to compare against. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

