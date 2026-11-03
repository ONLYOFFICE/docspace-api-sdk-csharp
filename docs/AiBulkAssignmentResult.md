# DocSpace.API.SDK.Model.AiBulkAssignmentResult
The outcome of a bulk assign: either every entry was stored, or none was and the errors are reported per action. Every entry is validated before anything is written, so one bad entry never leaves the assignments half-written.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Success** | **bool** | True when every entry was persisted. | 
**Errors** | [**List&lt;AiBulkAssignmentResultErrorsInner&gt;**](AiBulkAssignmentResultErrorsInner.md) | What was rejected, per action. Present on failure - and then no entry was persisted. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

