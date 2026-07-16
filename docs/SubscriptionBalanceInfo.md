# DocSpace.API.SDK.Model.SubscriptionBalanceInfo
The information about the current subscription and its unused balance.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TotalCost** | **double** | The total cost of the current billing period (the sum across all subscription items). | [optional] 
**Currency** | **string** | The three-character ISO 4217 currency symbol of the subscription. | [optional] 
**PeriodStart** | **DateTime** | The start of the current billing period. | [optional] 
**PeriodEnd** | **DateTime** | The end of the current billing period. | [optional] 
**PeriodUsedUntil** | **DateTime** | The boundary of the used part of the period (the moment of the request). | [optional] 
**DaysElapsed** | **int** | The number of days elapsed since the start of the period (inclusive). | [optional] 
**RemainingBalance** | **double** | The unused balance of the subscription, in the subscription currency. | [optional] 
**RemainingBalanceInWalletCurrency** | **double** | The unused balance of the subscription, converted to the wallet currency. | [optional] 
**WalletCurrency** | **string** | The three-character ISO 4217 currency symbol of the wallet. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

