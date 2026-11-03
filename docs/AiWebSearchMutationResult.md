# DocSpace.API.SDK.Model.AiWebSearchMutationResult
The outcome of storing a web-search configuration: the stored configuration, or an error naming the field that was refused.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Success** | **bool** | True when the configuration was persisted. | 
**Config** | [**AiWebSearchConfig**](AiWebSearchConfig.md) | The persisted web-search configuration. Present on success. | [optional] 
**Error** | [**AiErrorData**](AiErrorData.md) | Why the configuration was rejected. Present on failure. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

