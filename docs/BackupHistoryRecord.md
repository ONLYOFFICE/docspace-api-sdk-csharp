# DocSpace.API.SDK.Model.BackupHistoryRecord
One stored backup of a portal.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | The ID of the backup, which is the same value as the `taskId` the backup was started with. Pass it to  `DELETE api/2.0/backup/deletebackup/{id}` or as the `backupId` of  `POST api/2.0/backup/startrestore`. | 
**FileName** | **string** | The name of the stored archive. It is built from the portal alias and the moment the backup started,  or from `workspace` instead of the alias for a backup of the whole server. | 
**StorageType** | **BackupStorageType** | The storage the archive was written to, reported as a number rather than as a name. | 
**CreatedOn** | **DateTime** | The date and time the backup was stored at, in UTC. | 
**ExpiresOn** | **DateTime** | The date and time a background cleaner removes this backup at. Only a backup written to `DataStore`  expires, one day after it was stored; for every other storage type this is `0001-01-01T00:00:00`,  which means the backup is kept until it is deleted by hand or pushed out by the stored-copies limit  of a schedule. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

