# DocSpace.API.SDK.Model.ExternalDatabaseConnectionRequestDto
The connection parameters of an external database to test.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DatabaseType** | **string** | The engine of the external database: `mysql`, or `sqlite` on a Standalone installation. | [optional] 
**DatabaseTypeEnum** | **ExternalDatabaseType** | The engine named by `databaseType`, as the server reads it. A value sent here is ignored. | [optional] 
**DbHost** | **string** | The host name or the IP address of the database server. | [optional] 
**DbPort** | **int** | The port the database server listens on. | [optional] 
**DbName** | **string** | The name of the database to connect to. | [optional] 
**DbUser** | **string** | The user name to connect with. | [optional] 
**DbPassword** | **string** | The password to connect with. | [optional] 
**DbSsl** | **bool** | Whether the connection is secured with SSL. | [optional] 
**SqliteFilePath** | **string** | The path to the database file, used by the SQLite engine only. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

