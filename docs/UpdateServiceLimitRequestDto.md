# DocSpace.API.SDK.Model.UpdateServiceLimitRequestDto
The new thresholds and state of an existing service limit.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The ID of the service limit, as returned in `id` by the operation that created it or by the reads of limits. | 
**AmountValue** | **double?** | The most money the AI services may cost per period, in their currency. Zero blocks the AI services completely. | [optional] 
**QuantityValue** | **int?** | The largest quantity the AI services may consume per period, in their common unit. Zero blocks the AI services  completely. | [optional] 
**Enabled** | **bool?** | Whether the limit is in force: false switches it off at once, true switches it back on. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

