# DocSpace.Model.BackupScheduleDto
The backup schedule parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StorageType** | **BackupStorageType** |  | [optional] 
**StorageParams** | [**List&lt;ItemKeyValuePairObjectObject&gt;**](.md) | The backup storage parameters. | [optional] 
**BackupsStored** | **int?** | The maximum number of the stored backup copies. | [optional] 
**CronParams** | [**Cron**](.md) |  | [optional] 
**Dump** | **bool** | Specifies if a dump will be created or not. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

