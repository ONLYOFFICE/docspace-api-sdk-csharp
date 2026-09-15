# DocSpace.API.SDK.Model.TaskProgressResponseDto
The task progress response parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The ID of the queued job. It identifies this run of the job and changes every time the job is started again. | 
**Error** | **string** | The message of the error that stopped the job. It is empty while the job is running and after a job that  succeeded, and it is the only place where the reason for a failure is reported. | [optional] 
**Percentage** | **int** | The share of the job that is already done, from 0 to 100. | 
**IsCompleted** | **bool** | Specifies whether the job has stopped running. This is the field to poll: true means the job will not change  any more, whether it succeeded, failed or was cancelled, and `status` tells which of the three it is. | 
**Status** | **DistributedTaskStatus** | The state of the job: `Created` while it waits in the queue, `Running` while it works, `Completed` once it has  finished on its own, `Canceled` after a terminate operation, and `Failted` when it stopped on an error, in  which case `error` carries the reason. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

