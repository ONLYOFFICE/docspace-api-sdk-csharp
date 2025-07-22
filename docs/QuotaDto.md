# DocSpace.API.SDK.Model.QuotaDto
The quota information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The quota ID. | [optional] 
**Title** | **string** | The quota title. | [optional] 
**Price** | [**PriceDto**](PriceDto.md) |  | [optional] 
**NonProfit** | **bool** | Specifies if the quota is nonprofit or not. | [optional] 
**Free** | **bool** | Specifies if the quota is free or not. | [optional] 
**Trial** | **bool** | Specifies if the quota is trial or not. | [optional] 
**Features** | [**List&lt;TenantQuotaFeatureDto&gt;**](TenantQuotaFeatureDto.md) | The list of tenant quota features. | [optional] 
**UsersQuota** | [**TenantEntityQuotaSettings**](TenantEntityQuotaSettings.md) |  | [optional] 
**RoomsQuota** | [**TenantEntityQuotaSettings**](TenantEntityQuotaSettings.md) |  | [optional] 
**TenantCustomQuota** | [**TenantQuotaSettings**](TenantQuotaSettings.md) |  | [optional] 
**DueDate** | **DateTime?** | The due date. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

