# DocSpace.API.SDK.Model.McpServerStatusDto
MCP server status within a room, reflecting the current user's connection state for OAuth-based servers.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Unique identifier of the MCP server. | [optional] 
**Name** | **string** | Display name of the MCP server. | 
**ServerType** | **ServerType** |  | [optional] 
**Connected** | **bool** | Indicates whether the current user has an active connection to this server. For direct-connection servers this is always true; for OAuth-based servers it reflects whether the user has completed authorization. | [optional] 
**Icon** | [**Icon**](Icon.md) |  | [optional] 
**NeedReset** | **bool** | Indicates whether the server requires a configuration reset due to connectivity or credential issues. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

