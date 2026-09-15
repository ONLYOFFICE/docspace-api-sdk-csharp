# DocSpace.API.SDK.Model.CookieSettingsDto
How long an authentication session of the portal stays valid, and whether that limit is applied.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LifeTime** | **int** | How long, in minutes, a session issued from now on remains valid. It is `1440` on a portal that has never  stored a limit, and that stored number is reported whether or not `enabled` puts it to use. | 
**Enabled** | **bool** | Whether the stored lifetime is applied at all. While it is `false` the number above is ignored and an  issued session is honoured for a year. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

