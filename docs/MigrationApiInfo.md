# DocSpace.API.SDK.Model.MigrationApiInfo
The migration API information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MigratorName** | **string** | The migrator name. | [optional] 
**Operation** | **string** | The migration operation. | [optional] 
**FailedArchives** | **List&lt;string&gt;** | The list of failed archives. | [optional] 
**Users** | [**List&lt;MigratingApiUser&gt;**](MigratingApiUser.md) | The list of migrating users. | [optional] 
**WithoutEmailUsers** | [**List&lt;MigratingApiUser&gt;**](MigratingApiUser.md) | The list of migrating users without email. | [optional] 
**ExistUsers** | [**List&lt;MigratingApiUser&gt;**](MigratingApiUser.md) | The list of existing migrating users. | [optional] 
**Groups** | [**List&lt;MigratingApiGroup&gt;**](MigratingApiGroup.md) | The list of migrating groups. | [optional] 
**ImportPersonalFiles** | **bool** | Specifies whether to import personal files or not. | [optional] 
**ImportSharedFiles** | **bool** | Specifies whether to import shared files or not. | [optional] 
**ImportSharedFolders** | **bool** | Specifies whether to import shared folders or not. | [optional] 
**ImportCommonFiles** | **bool** | Specifies whether to import common files or not. | [optional] 
**ImportProjectFiles** | **bool** | Specifies whether to import project files or not. | [optional] 
**ImportGroups** | **bool** | Specifies whether to import groups or not. | [optional] 
**SuccessedUsers** | **int** | The number of successfully migrated users. | [optional] 
**FailedUsers** | **int** | The number of unsuccessfully migrated users. | [optional] 
**Files** | **List&lt;string&gt;** | The list of migrated files. | [optional] 
**Errors** | **List&lt;string&gt;** | The list of migration errors. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

