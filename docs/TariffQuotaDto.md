# DocSpace.API.SDK.Model.TariffQuotaDto
The tariff quota parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The quota ID. | [optional] 
**Quantity** | **int** | The quota quantity. | [optional] 
**Wallet** | **bool** | The quota applies to the wallet or not. | [optional] 
**Additional** | **bool** | Indicates whether the quota is primary or additional. | [optional] 
**DueDate** | [**ApiDateTime**](ApiDateTime.md) | The quota due date in the portal time zone. Falls back to the tariff due date when the quota has none. | [optional] 
**NextQuantity** | **int?** | The quota next quantity. | [optional] 
**NextQuota** | **int?** | The quota ID to switch to at the next period. | [optional] 
**State** | **QuotaState** | The quota state. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

