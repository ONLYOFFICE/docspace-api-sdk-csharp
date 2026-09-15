# DocSpace.API.SDK.Model.PageableModificationResponse
One page of results ordered by modification time, together with the cursor that asks for the next page.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Data** | **Object** |  | [optional] 
**Limit** | **int** | The page size that was applied to this request, between 1 and 50. | [optional] 
**LastModifiedOn** | **DateTime** | The cursor to send back as last_modified_on to ask for the next page. It is null when the page is empty. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

