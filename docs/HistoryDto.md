# DocSpace.API.SDK.Model.HistoryDto
The file history information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The unique identifier for the file history entry. | 
**Action** | [**HistoryAction**](HistoryAction.md) | The action performed on the file. | 
**Initiator** | [**EmployeeDto**](EmployeeDto.md) | The action initiator. | 
**Date** | [**ApiDateTime**](ApiDateTime.md) | The date and time when an action on the file was performed. | 
**Data** | [**HistoryData**](HistoryData.md) | The history data. | 
**Related** | [**List&lt;HistoryDto&gt;**](HistoryDto.md) | The list of related history. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

