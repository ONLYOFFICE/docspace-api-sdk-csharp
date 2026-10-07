# DocSpace.API.SDK.Model.SetAuditLifetimeSettingsRequest
How long the portal keeps its two security logs.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LoginHistoryLifeTime** | **int** | How many days login events are kept, from 1 to 180. | [optional] 
**AuditTrailLifeTime** | **int** | How many days audit trail events are kept, from 1 to 180. | [optional] 
**LastModified** | **DateTime** | Accepted for compatibility with earlier clients and not read: the server keeps its own value. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

