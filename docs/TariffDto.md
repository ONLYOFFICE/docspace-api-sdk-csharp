# DocSpace.API.SDK.Model.TariffDto
The tariff parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OpenSource** | **bool?** | Specifies whether the tariff is Community or not. | [optional] 
**Enterprise** | **bool?** | Specifies whether the tariff is Enterprise or not. | [optional] 
**Developer** | **bool?** | Specifies whether the tariff is Developer or not. | [optional] 
**Id** | **int** | The tariff ID. | [optional] 
**State** | **TariffState** | The tariff state. | [optional] 
**DueDate** | [**ApiDateTime**](ApiDateTime.md) | The tariff due date. | [optional] 
**DelayDueDate** | [**ApiDateTime**](ApiDateTime.md) | The tariff delay due date. | [optional] 
**LicenseDate** | [**ApiDateTime**](ApiDateTime.md) | The tariff license date. | [optional] 
**CustomerId** | **string** | The customer ID. | [optional] 
**Quotas** | [**List&lt;TariffQuotaDto&gt;**](TariffQuotaDto.md) | The list of quotas. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

