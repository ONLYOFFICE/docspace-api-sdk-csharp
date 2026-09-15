# DocSpace.API.SDK.Model.ProblemDetail
RFC 7807 problem details returned by the registration API for failed requests.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | A URI reference that identifies the problem type. This service sets it to the DocSpace API getting-started page. | [optional] 
**Title** | **string** | A short, human-readable summary of the problem type, typically the HTTP status reason phrase. | [optional] 
**Status** | **int** | The HTTP status code for this occurrence of the problem. | [optional] 
**Detail** | **string** | A human-readable explanation specific to this occurrence of the problem. | [optional] 
**Instance** | **string** | A URI reference that identifies the specific occurrence, set to the request path. | [optional] 
**Properties** | **Dictionary&lt;string, Object&gt;** | Extension members carried on the problem. Usually empty; validation failures also surface as the top-level errors array. | [optional] 
**Errors** | [**List&lt;FieldError&gt;**](FieldError.md) | Field-specific validation errors. Present when the request body or parameters failed validation, or when a named scope is not in the tenant catalogue. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

