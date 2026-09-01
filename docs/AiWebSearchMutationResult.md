# DocSpace.API.SDK.Model.AiWebSearchMutationResult
Outcome of `WebSearchEngine.configure` — either the persisted config or a field-scoped error suitable for the settings form.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Success** | **bool** | True when the configuration was persisted. | 
**Config** | [**AiWebSearchConfig**](AiWebSearchConfig.md) | The persisted web-search configuration. Present on success. | [optional] 
**Error** | [**AiTErrorData**](AiTErrorData.md) | Why the configuration was rejected. Present on failure. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

