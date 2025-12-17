# DocSpace.API.SDK.Model.QuotaDto
The quota information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The quota ID. | 
**Title** | **string** | The quota title. | 
**Price** | [**PriceDto**](PriceDto.md) |  | 
**NonProfit** | **bool** | Specifies if the quota is nonprofit or not. | 
**Free** | **bool** | Specifies if the quota is free or not. | 
**Trial** | **bool** | Specifies if the quota is trial or not. | 
**Features** | [**List&lt;TenantQuotaFeatureDto&gt;**](TenantQuotaFeatureDto.md) | The list of tenant quota features. | 
**UsersQuota** | [**TenantEntityQuotaSettings**](TenantEntityQuotaSettings.md) |  | [optional] 
**RoomsQuota** | [**TenantEntityQuotaSettings**](TenantEntityQuotaSettings.md) |  | [optional] 
**AiAgentsQuota** | [**TenantEntityQuotaSettings**](TenantEntityQuotaSettings.md) |  | [optional] 
**TenantCustomQuota** | [**TenantQuotaSettings**](TenantQuotaSettings.md) |  | [optional] 
**DueDate** | **DateTime?** | The due date. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

