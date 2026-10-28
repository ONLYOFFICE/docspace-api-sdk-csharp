# DocSpace.API.SDK.Model.AiBulkAssignmentResult
Outcome of `AssignmentsEngine.bulkAssign`. Either every entry persisted, or no entries persisted and a per-key error report. The engine validates first and writes second so a single bad entry never leaves the assignment table in a half-written state.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Success** | **bool** | True when every entry was persisted. | 
**Errors** | [**List&lt;AiBulkAssignmentResultErrorsInner&gt;**](AiBulkAssignmentResultErrorsInner.md) | What was rejected, per action. Present on failure - and then no entry was persisted. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

