# DocSpace.API.SDK.Model.AiAssignmentMutationResult
Outcome of `AssignmentsEngine.assign` / `AssignmentsEngine.unassign`. Either a success or a field-scoped error suitable for displaying in the profile editor.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Success** | **bool** | True when the assignment was persisted. | 
**Error** | [**AiTErrorData**](AiTErrorData.md) | Why the assignment was rejected. Present on failure. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

