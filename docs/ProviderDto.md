# DocSpace.API.SDK.Model.ProviderDto
One storage service this portal can connect, with the values a connection form needs.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The display name of the service, and the only thing that tells the WebDAV presets apart: `kDrive`, `Yandex`,  `WebDav`, `Nextcloud` and `ownCloud` all report the same key. | [optional] 
**Key** | **string** | The value to send as `providerKey` when an account of this service is connected. | [optional] 
**Connected** | **bool** | Whether the service can be used on this portal: it is enabled in the configuration and, for an OAuth service,  its application is registered. It says nothing about whether an account of it is connected. | [optional] 
**Oauth** | **bool** | Whether an account of this service is connected with an OAuth 2.0 authorization code in `token`; when false,  it is connected with `login` and `password`. | [optional] 
**RedirectUrl** | **string** | The redirect URL this portal is registered with at the service, to build the consent screen URL from. It comes  back as null for the services that do not use OAuth. | [optional] 
**RequiredConnectionUrl** | **bool** | Whether an account of this service cannot be connected without `url`, which is the case for the WebDAV servers  whose address is not known in advance. The presets with a fixed address and the OAuth services do not need it. | [optional] 
**ClientId** | **string** | The OAuth 2.0 client ID this portal is registered with at the service, to build the consent screen URL from.  It comes back as null for the services that do not use OAuth. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

