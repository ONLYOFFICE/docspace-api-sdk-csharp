# DocSpace.API.SDK.Model.MigrationStatusDto
How far the parse or the import queued for this portal has got, and what it produced once it stopped.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Progress** | **double** | The share of the job that is done, from 0 to 100. It advances unevenly, since the stages differ in  length, so poll `isCompleted` rather than waiting for this to reach 100. | [optional] 
**Error** | **string** | The message that ended the job, in the portal language. It stays empty while nothing has gone wrong, so  once `isCompleted` is `true` this field is what tells success from failure. | [optional] 
**ParseResult** | [**MigrationApiInfo**](MigrationApiInfo.md) | What the migrator has read so far. After a parse pass it holds the users, the groups and the archives it  could not read, which is the body to edit and post to `POST api/2.0/migration/migrate`; during an import it  also carries the accounts that were created and the ones that failed. Its own `operation` field, `parse`  or `migration`, is what tells the two stages apart. | [optional] 
**IsCompleted** | **bool** | Whether the job has stopped, successfully or not. It is the field to poll on; the whole body comes back  empty instead when the portal has no job at all, which is not an error. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

