# DocSpace.API.SDK.Model.ScheduleDto
The backup schedule parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StorageType** | **BackupStorageType** |  | 
**StorageParams** | **Dictionary&lt;string, string&gt;** | The backup storage parameters. | 
**CronParams** | [**CronParams**](CronParams.md) |  | 
**BackupsStored** | **int?** | The maximum number of the stored backup copies. | [optional] 
**LastBackupTime** | **DateTime** | The date and time when the last backup was reated. | 
**Dump** | **bool** | Specifies if a dump will be created or not. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

