# DocSpace.API.SDK.Model.TenantWalletSettings
The tenant wallet settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Specifies whether automatic top-up for the tenant wallet is enabled. | [optional] 
**MinBalance** | **int** | The minimum wallet balance at which automatic top-up will be triggered. Must be between 5 and 1000. | [optional] 
**UpToBalance** | **int** | The maximum wallet balance at which automatic top-up will be triggered. Must be between 6 and 5000. | [optional] 
**Currency** | **string** | The three-character ISO 4217 currency symbol. | [optional] 
**LowBalanceThreshold** | **int** | The wallet balance below which a low-balance notification is sent. Set internally, not user-configurable. | [optional] 
**LowBalanceNotified** | **bool** | Specifies whether a low-balance notification has already been sent for the current dip below ASC.Core.Tenants.TenantWalletSettings.LowBalanceThreshold. | [optional] 
**LastModified** | **DateTime** | The date and time when the tenant wallet settings were last modified. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

