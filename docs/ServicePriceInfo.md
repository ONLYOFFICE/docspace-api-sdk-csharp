# DocSpace.API.SDK.Model.ServicePriceInfo
Represents a price of the service.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The price unique identifier. | [optional] 
**AccountNumber** | **int** | The account number. | [optional] 
**ServiceId** | **int** | The service ID. | [optional] 
**TimeUnit** | **PriceTimeUnit** | The time unit the price is bound to. | [optional] 
**CostPrice** | **double** | The cost price. | [optional] 
**ExtraCharge** | **double** | The extra charge added to the cost price. | [optional] 
**ServicePrice** | **double** | The resulting service price. | [optional] 
**Quota** | **double?** | The quota the price is set for. | [optional] 
**TimeBound** | [**TimeBound**](TimeBound.md) | The period the price is effective in. | [optional] 
**Status** | **PriceStatus** | The price status. | [optional] 
**Created** | **DateTime** | The date and time when the price was created. | [optional] 
**DiscountCategoryId** | **int?** | The discount category ID. | [optional] 
**DiscountCategory** | [**DiscountCategory**](DiscountCategory.md) | The discount category. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

