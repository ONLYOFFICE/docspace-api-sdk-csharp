# DocSpace.API.SDK.Model.HistoryDto
The file history information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The unique identifier for the file history entry. | 
**Action** | [**HistoryAction**](HistoryAction.md) | The action performed on the file. | 
**Initiator** | [**EmployeeDto**](EmployeeDto.md) | The user parameters. | 
**Date** | [**ApiDateTime**](ApiDateTime.md) | The API date and time parameters. | 
**Data** | [**HistoryData**](HistoryData.md) | The history data. | 
**Related** | [**List&lt;HistoryDto&gt;**](HistoryDto.md) | The list of related history. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

