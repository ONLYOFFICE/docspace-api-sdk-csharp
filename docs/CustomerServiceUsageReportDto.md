# DocSpace.API.SDK.Model.CustomerServiceUsageReportDto
One page of the per-service consumption totals, with the paging figures needed to walk the rest.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Collection** | [**List&lt;CustomerServiceUsageDto&gt;**](CustomerServiceUsageDto.md) | The services on this page, one entry per service rather than per charge. It is empty for a period in  which nothing was consumed as well as for a page past the end of the report. | [optional] 
**Offset** | **int** | How many entries were skipped before this page, echoed from the request. | [optional] 
**Limit** | **int** | How many entries one page may hold, echoed from the request; it is 25 unless another value was asked for. | [optional] 
**TotalQuantity** | **long** | How many services match the filters in total, across every page - services, not charges. | [optional] 
**TotalPage** | **int** | How many pages those entries come to at the current `limit`. | [optional] 
**CurrentPage** | **int** | Which of those pages this one is, as the billing service numbers them. Page through by advancing `offset`  rather than this value, which nothing accepts as an argument. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

