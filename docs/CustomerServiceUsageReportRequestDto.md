# DocSpace.API.SDK.Model.CustomerServiceUsageReportRequestDto
The request parameters for generating a customer service usage report.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ServiceName** | **List&lt;string&gt;** | The service name list. A single string is also accepted for backward compatibility. | [optional] 
**StartDate** | **DateTime?** | The report start date. | [optional] 
**EndDate** | **DateTime?** | The report end date. | [optional] 
**ParticipantName** | **string** | The participant name. | [optional] 
**Status** | **OperationStatus** | The operation status to filter by. | [optional] 
**Metadata** | **Dictionary&lt;string, string&gt;** | Metadata key-value pairs to filter by. | [optional] 
**OrderBy** | **string** | The field to order by. | [optional] 
**OrderType** | **OperationOrderType** | Order direction: Ascending or Descending. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

