# DocSpace.API.SDK.Model.ServiceLimitUsageDto
What has been spent against a spending limit in its current period, and what is left.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PeriodStart** | **DateTime** | The start of the current period, in UTC. | [optional] 
**PeriodEnd** | **DateTime?** | The end of the current period, in UTC: the moment the spending starts again from zero. Null for a lifetime  limit, which never resets. | [optional] 
**AmountConsumed** | **double** | The money charged in the current period, in the currency of the limit. | [optional] 
**AmountAvailable** | **double?** | The money still available in the current period: the threshold less what was charged and what is reserved for  operations in progress, never below zero. Null when the limit has no money threshold. | [optional] 
**QuantityConsumed** | **int** | The quantity consumed in the current period, in the unit of the limit. | [optional] 
**QuantityAvailable** | **int?** | The quantity still available in the current period, never below zero; null when the limit has no quantity  threshold. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

