# DocSpace.API.SDK.Model.AiProfileMutationResult
Outcome of `create` / `update` — either a success carrying the persisted profile, or a failure with a field-level error description from the name check or the provider credential check.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Success** | **bool** |  | 
**Profile** | [**AiProfile**](AiProfile.md) |  | [optional] 
**Error** | [**AiTErrorData**](AiTErrorData.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

