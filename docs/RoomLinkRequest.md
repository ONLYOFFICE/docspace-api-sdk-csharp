# DocSpace.API.SDK.Model.RoomLinkRequest
The room link parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LinkId** | **Guid** | The room link ID. | [optional] 
**Access** | **FileShare** | The access rights type. | [optional] 
**ExpirationDate** | [**ApiDateTime**](ApiDateTime.md) | The API date and time parameters. | [optional] 
**Internal** | **bool** | The link scope, whether it is internal or not. | [optional] 
**Title** | **string** | The link name. | [optional] 
**LinkType** | **LinkType** | The link type. | [optional] 
**Password** | **string** | The link password. | [optional] 
**DenyDownload** | **bool** | Specifies if downloading the file from the link is disabled or not. | [optional] 
**MaxUseCount** | **int?** | The maximum number of times the invitation link can be used. | [optional] 
**CurrentUseCount** | **int** | The current number of times the invitation link has been used. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

