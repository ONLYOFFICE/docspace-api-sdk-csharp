# DocSpace.API.SDK.Model.SetWalletTopUpSettingsRequest
The part of the automatic top-up settings a payer chooses. The low-balance warning state is kept by the portal  itself and cannot be set here.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Whether the payment method on file is charged automatically when the wallet balance runs low. | [optional] 
**MinBalance** | **int** | The balance below which a top-up is charged, in `currency`. | [optional] 
**UpToBalance** | **int** | The balance a top-up brings the wallet up to, in `currency`. | [optional] 
**Currency** | **string** | The three-letter ISO 4217 code both amounts are expressed in; it has to be the currency of the wallet. | [optional] 
**LowBalanceThreshold** | **int** | Accepted for compatibility with earlier clients and not read: the server keeps its own value. | [optional] 
**LowBalanceNotified** | **bool** | Accepted for compatibility with earlier clients and not read: the server keeps its own value. | [optional] 
**LastModified** | **DateTime** | Accepted for compatibility with earlier clients and not read: the server keeps its own value. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

