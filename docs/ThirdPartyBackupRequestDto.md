# DocSpace.API.SDK.Model.ThirdPartyBackupRequestDto
The credentials and the title of the third-party storage account the portal writes its backups to.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Url** | **string** | The address of the storage server to connect to. It is needed by the WebDAV presets whose server is not known  in advance (`WebDav`, `Nextcloud`, `ownCloud`), where it points at the WebDAV endpoint of that server, and by  `SharePoint`; the presets with a fixed address and the OAuth services ignore it. | [optional] 
**Login** | **string** | The account name at the storage service, used by the services that authenticate by login and password. A login  sent without a password is rejected as an invalid request. | [optional] 
**Password** | **string** | The password, or the application password, for `login` at the storage service. Either this or `token` has to  be sent, and the credentials are verified against the service before the account is saved. | [optional] 
**Token** | **string** | The OAuth 2.0 authorization code from the consent screen of `Box`, `DropboxV2`, `GoogleDrive` or `OneDrive` -  not an access token: the portal exchanges the code for its own token and keeps that. The client ID and  redirect URL the consent screen URL is built from come from `GET api/2.0/files/thirdparty/capabilities`. | [optional] 
**CustomerTitle** | **string** | The name the backup account is shown under in the portal. Characters that a folder title cannot hold are  replaced and the value is truncated; on the first connection a title that comes out of that empty is refused. | [optional] 
**ProviderKey** | **string** | The storage service to connect, as the `key` of `GET api/2.0/files/thirdparty/providers`; the value is matched  case-insensitively. `Nextcloud` and `ownCloud` are presets over WebDAV and are stored and reported back as  `WebDav`. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

