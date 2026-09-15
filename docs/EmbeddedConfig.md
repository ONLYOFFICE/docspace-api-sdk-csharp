# DocSpace.API.SDK.Model.EmbeddedConfig
The addresses the framed viewer needs. It is reported for the embedded layout only.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EmbedUrl** | **string** | The page to put into the frame. It is empty when the opening carries no external share key, since a framed  viewer cannot authenticate a portal member. | [optional] 
**SaveUrl** | **string** | Where the download button of the framed viewer leads. | [optional] [readonly] 
**ShareLinkParam** | **string** | The query fragment carrying the external share key, ampersand included, out of which the addresses around it  are built. | [optional] 
**ShareUrl** | **string** | The address behind the share button of the framed viewer, the document opened full-screen for reading. It is  empty when the opening carries no external share key. | [optional] 
**ToolbarDocked** | **string** | Where the framed viewer puts its toolbar. The portal always asks for the top. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

