# DocSpace.API.SDK.Model.FileOperationRequestBaseDto
The parameter shared by every request that starts a background file operation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReturnSingleOperation** | **bool** | Which operations the answer carries: `true` returns the operation this call started and nothing else, `false`  returns every operation of the same kind that the caller has running or unread. When nothing was queued, which  happens for an empty selection, `true` falls back to the full list. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

