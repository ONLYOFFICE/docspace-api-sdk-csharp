# DocSpace.API.SDK.Model.AiToolAnnotations
MCP tool annotations (`Tool.annotations` in the protocol). All hints are advisory and optional; the protocol's defaults are `readOnlyHint: false` and `destructiveHint: true`, which is why an unannotated tool is treated as one that may destroy state.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** |  | [optional] 
**ReadOnlyHint** | **bool** |  | [optional] 
**DestructiveHint** | **bool** |  | [optional] 
**IdempotentHint** | **bool** |  | [optional] 
**OpenWorldHint** | **bool** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

