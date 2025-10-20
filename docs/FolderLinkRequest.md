# DocSpace.API.SDK.Model.FolderLinkRequest
The folder link parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LinkId** | **Guid** | The folder link ID. | [optional] 
**Access** | **FileShare** |  | [optional] 
**ExpirationDate** | [**ApiDateTime**](ApiDateTime.md) |  | [optional] 
**Title** | **string** | The link name. | [optional] 
**Password** | **string** | The link password. | [optional] 
**DenyDownload** | **bool** | Specifies if downloading the file from the link is disabled or not. | [optional] 
**Internal** | **bool** | The link scope, whether it is internal or not. | [optional] 
**Primary** | **bool** | Specifies whether the folder link is primary or not. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

