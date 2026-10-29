# DocSpace.API.SDK.Model.ServiceLimitReportDto
A page of the spending limits in force for the portal users.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Collection** | [**List&lt;ServiceLimitDto&gt;**](ServiceLimitDto.md) | The limits of this page, one per user; empty when no limit applies to any user or the page is past the end. | [optional] 
**Offset** | **int** | The number of limits skipped before this page. | [optional] 
**Limit** | **int** | The page size the page was read with. | [optional] 
**TotalPage** | **int** | The number of pages the whole list takes at this page size. | [optional] 
**CurrentPage** | **int** | The number of this page, starting from 1. | [optional] 
**TotalQuantity** | **int** | The number of users with a limit in force across all pages. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

