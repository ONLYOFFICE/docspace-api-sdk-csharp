# DocSpace.API.SDK.Model.CustomerOperationsReportRequestDto
The request parameters for generating a report on client operations.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ServiceName** | **List&lt;string&gt;** | The service name list. A single string is also accepted for backward compatibility. | [optional] 
**StartDate** | **DateTime?** | The report start date. | [optional] 
**EndDate** | **DateTime?** | The report end date. | [optional] 
**ParticipantName** | **string** | The participant name. | [optional] 
**Credit** | **bool?** | Specifies whether to include credit operations in the report. | [optional] 
**Debit** | **bool?** | Specifies whether to include debit operations in the report. | [optional] 
**Type** | **OperationType** |  | [optional] 
**Status** | **OperationStatus** |  | [optional] 
**OrderBy** | **string** | The field to order by. | [optional] 
**OrderType** | **OperationOrderType** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

