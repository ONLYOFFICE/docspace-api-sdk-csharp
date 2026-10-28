# DocSpace.API.SDK.Model.PageableClientResponse
One page of full client records together with the next-page cursor.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Data** | [**List&lt;ClientResponse&gt;**](ClientResponse.md) | The items on this page, at most as many as the requested limit. An empty array means there is nothing further to read. | [optional] 
**Limit** | **int** | The page size that was applied to this request, between 1 and 50. | [optional] 
**LastClientId** | **string** | The cursor to send back as last_client_id to ask for the next page, together with last_created_on. It is null when the page is empty. | [optional] 
**LastCreatedOn** | **DateTime** | The cursor to send back as last_created_on to ask for the next page, together with last_client_id. It is null when the page is empty. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

