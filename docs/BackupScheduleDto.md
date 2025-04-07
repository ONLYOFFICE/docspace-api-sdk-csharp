# Docspace.Model.BackupScheduleDto
Backup schedule parameters

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StorageType** | **BackupStorageType** |  | [optional] 
**StorageParams** | [**List&lt;ItemKeyValuePairObjectObject&gt;**](ItemKeyValuePairObjectObject.md) | Storage parameters | [optional] 
**BackupsStored** | **int?** | Maximum number of the stored backup copies | [optional] 
**CronParams** | [**Cron**](Cron.md) |  | [optional] 
**Dump** | **bool** | Specifies if a dump will be created or not | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

