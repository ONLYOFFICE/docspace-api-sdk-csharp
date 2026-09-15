# DocSpace.API.SDK.Model.AiToolsListSystemTools200Response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Groups** | **Dictionary&lt;string, List&lt;AiTMCPItem&gt;&gt;** | Tools by server name, covering both the host-configured system servers and the custom MCP servers registered for this scope. | 
**Errors** | **Dictionary&lt;string, string&gt;** | Why a registered custom server could not be reached, keyed by server name. A server that answered is absent from this map. | 
**System** | **List&lt;string&gt;** | Names of the host-configured system servers among the keys of `groups`; everything else there was registered as a custom server. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

