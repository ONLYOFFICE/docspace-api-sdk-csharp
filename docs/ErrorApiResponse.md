# DocSpace.API.SDK.Model.ErrorApiResponse
The error body returned with every failed request.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **int** | The response status flag. Always 1 on an error, as opposed to 0 on success. | [optional] 
**StatusCode** | **int** | The HTTP status code of the response, repeated in the body. | [optional] 
**Error** | [**ErrorApiResponseError**](ErrorApiResponseError.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

