# DocSpace.API.SDK.Model.ExternalDbSyncTaskDto
The external DB synchronization task parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The task ID. | 
**Error** | **string** | The error message if the synchronization failed. | [optional] 
**Percentage** | **int** | The progress percentage of the synchronization. | 
**IsCompleted** | **bool** | Specifies whether the synchronization is completed or not. | 
**Status** | **DistributedTaskStatus** |  | 
**Forms** | [**List&lt;ExternalDbSyncFormResultDto&gt;**](ExternalDbSyncFormResultDto.md) | The synchronization results for all original forms in the room. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

