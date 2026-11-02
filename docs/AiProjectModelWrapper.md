# DocSpace.API.SDK.Model.AiProjectModelWrapper
The successful API response containing the AiProjectModelDto object.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Response** | [**AiProjectModelDto**](AiProjectModelDto.md) | The AiProjectModelDto object returned by the operation. | [optional] 
**Count** | **int** | How many items this response carries: the length of the page for a list, 1 for a single object | [optional] 
**Total** | **long** | How many items the whole list holds across all pages, for working out how many pages to request. Sent only by the operations that page their results, and left out of every other response | [optional] 
**Links** | [**List&lt;GetPortalPrices200ResponseLinksInner&gt;**](GetPortalPrices200ResponseLinksInner.md) | List of links related to the response | [optional] 
**Status** | **int** | HTTP status code of the response | [optional] 
**StatusCode** | **int** | HTTP status code of the response (duplicate of status) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

