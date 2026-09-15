# DocSpace.API.SDK.Model.RoomTemplateStatusDto
The progress of the job that builds a room template out of an existing room.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TemplateId** | **int** | The template the job is building. It is meaningful once the job has created the template folder, and the  template can be opened with the room operations only after `isCompleted` turns true. | 
**Progress** | **double** | How far the job has got. The value climbs while the contents of the room are being copied and reaches its  maximum at the very end, so it is an indication of life rather than a reliable estimate of the time left. | 
**Error** | **string** | Why the job stopped. It is empty while the job runs and after a successful one; when it is filled the  half-built template has already been removed, so nothing has to be cleaned up by the caller. | [optional] 
**IsCompleted** | **bool** | Whether the job has ended. It is set both after a successful build and after a failure, so `error` is what  tells the two apart, and the record keeps answering with the same values until another job is started. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

