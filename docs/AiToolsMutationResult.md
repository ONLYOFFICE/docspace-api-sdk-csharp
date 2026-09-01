# DocSpace.API.SDK.Model.AiToolsMutationResult
Outcome of an MCP-server CRUD call. Either success or a field-scoped error suitable for the settings form.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Success** | **bool** | True when the MCP server was persisted. | 
**Error** | [**AiTErrorData**](AiTErrorData.md) | Why the MCP server was rejected. Present on failure. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

