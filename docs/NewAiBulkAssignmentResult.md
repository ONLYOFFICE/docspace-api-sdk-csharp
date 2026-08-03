# DocSpace.API.SDK.Model.NewAiBulkAssignmentResult
Outcome of  {@link  AssignmentsEngine.bulkAssign } . Either every entry persisted, or no entries persisted and a per-key error report. The engine validates first and writes second so a single bad entry never leaves the assignment table in a half-written state.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Success** | **bool** |  | 
**Errors** | [**List&lt;NewAiBulkAssignmentResultErrorsInner&gt;**](NewAiBulkAssignmentResultErrorsInner.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

