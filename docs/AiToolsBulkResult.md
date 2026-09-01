# DocSpace.API.SDK.Model.AiToolsBulkResult
Outcome of `ToolsEngine.replaceAllCustomServers` — either every entry persisted, or no entries persisted plus a per-key error report.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Success** | **bool** | True when every custom MCP server was persisted. | 
**Errors** | [**List&lt;AiToolsBulkResultErrorsInner&gt;**](AiToolsBulkResultErrorsInner.md) | What was rejected, per server. Present on failure - and then no server was persisted. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

