# DocSpace.API.SDK.Model.FileLinkRequest
The external link request parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LinkId** | **Guid** | The external link ID. | [optional] 
**Access** | **FileShare** |  | [optional] 
**ExpirationDate** | [**ApiDateTime**](ApiDateTime.md) |  | [optional] 
**Title** | **string** | The link name. | [optional] 
**Internal** | **bool** | The link scope, whether it is internal or not. | [optional] 
**Primary** | **bool** | Specifies whether the file link is primary or not. | [optional] 
**DenyDownload** | **bool** | Specifies whether to deny downloading the file or not. | [optional] 
**Password** | **string** | Password for access via link. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

