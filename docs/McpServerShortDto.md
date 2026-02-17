# DocSpace.API.SDK.Model.McpServerShortDto
Compact MCP server summary without sensitive details like endpoint URL or authentication headers.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Unique identifier of the MCP server. | [optional] 
**Name** | **string** | Display name of the MCP server. | [optional] 
**ServerType** | **ServerType** |  | [optional] 
**Enabled** | **bool** | Indicates whether the server is currently enabled and available for room assignment. | [optional] 
**Icon** | [**Icon**](Icon.md) |  | [optional] 
**NeedReset** | **bool** | Indicates whether the server requires a configuration reset due to connectivity or credential issues. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

