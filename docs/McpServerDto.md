# DocSpace.API.SDK.Model.McpServerDto
Full MCP server configuration, including connection details and authentication headers. Returned for administrator-level operations.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Unique identifier of the MCP server. | [optional] 
**Name** | **string** | Display name of the MCP server. | [optional] 
**Description** | **string** | Human-readable description of the server&#39;s purpose and capabilities. | [optional] 
**Endpoint** | **string** | Base URL of the MCP server endpoint. | [optional] 
**ServerType** | **ServerType** |  | [optional] 
**Headers** | **Dictionary&lt;string, string&gt;** | HTTP headers sent with every request to the server (e.g., authentication tokens). | [optional] 
**Enabled** | **bool** | Indicates whether the server is currently enabled and available for room assignment. | [optional] 
**Icon** | [**Icon**](Icon.md) |  | [optional] 
**NeedReset** | **bool** | Indicates whether the server requires a configuration reset due to connectivity or credential issues. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

