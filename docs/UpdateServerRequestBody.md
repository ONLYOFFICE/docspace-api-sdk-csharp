# DocSpace.API.SDK.Model.UpdateServerRequestBody
Parameters for updating an existing MCP server. All fields are optional — only provided fields will be modified.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | New display name for the server. Only letters, numbers, underscores, and hyphens are allowed. Maximum 128 characters. | [optional] 
**Description** | **string** | New human-readable description of the server's purpose. Maximum 255 characters. | [optional] 
**Endpoint** | **string** | New base URL of the MCP server endpoint. If changed, the system will re-verify connectivity before saving. | [optional] 
**Headers** | **Dictionary&lt;string, string&gt;** | New HTTP headers to include with every request. If changed alongside the endpoint, connectivity is re-verified. | [optional] 
**UpdateIcon** | **bool** | Set to true to update the server icon. When true, the Icon field value (or null to remove) will be applied. | [optional] 
**Icon** | **string** | New Base64-encoded icon image for the server, or null to remove the existing icon. Only applied when UpdateIcon is true. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

