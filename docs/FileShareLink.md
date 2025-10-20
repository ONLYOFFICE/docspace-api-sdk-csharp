# DocSpace.API.SDK.Model.FileShareLink
A shareable link for a file with its configuration and status.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | The unique identifier of the shared link. | [optional] 
**Title** | **string** | The title of the shared content. | [optional] 
**ShareLink** | **string** | The URL for accessing the shared content. | [optional] 
**ExpirationDate** | [**ApiDateTime**](ApiDateTime.md) |  | [optional] 
**LinkType** | **LinkType** |  | [optional] 
**Password** | **string** | The password protection for accessing the shared content. | [optional] 
**DenyDownload** | **bool?** | Indicates whether downloading of the shared content is prohibited. | [optional] 
**IsExpired** | **bool?** | Indicates whether the shared link has expired. | [optional] 
**Primary** | **bool** | Indicates whether this is the primary shared link. | [optional] 
**Internal** | **bool?** | Indicates whether the link is for the internal sharing only. | [optional] 
**RequestToken** | **string** | The token for validating access requests. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

