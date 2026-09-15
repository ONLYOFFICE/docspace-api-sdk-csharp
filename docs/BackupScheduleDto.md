# DocSpace.API.SDK.Model.BackupScheduleDto
The request parameters for setting the backup schedule.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StorageType** | **BackupStorageType** | The storage the scheduled archives are written to. It defaults to `Documents`, and it decides which  keys `storageParams` has to carry. | [optional] 
**StorageParams** | [**List&lt;ItemKeyValuePairObjectObject&gt;**](ItemKeyValuePairObjectObject.md) | The settings of the chosen storage, as an array of key and value pairs. `Documents` and  `ThridpartyDocuments` need `folderId`, `Local` needs `filePath`, `ThirdPartyConsumer` needs `module`  plus the settings of that consumer, and `DataStore` needs none. | [optional] 
**BackupsStored** | **int?** | The number of scheduled copies to keep, from 1 to 30. It defaults to 1, and only the copies this  schedule creates are counted and removed - archives started by hand are left alone. | [optional] 
**CronParams** | [**Cron**](Cron.md) | When the backup runs. It is required: a request without it fails rather than falling back to a  default. | [optional] 
**Dump** | **bool** | Schedules a backup of the whole server rather than of this one portal. It requires the space access  permission and works on a standalone installation only. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

