# DocSpace.API.SDK.Model.WalletServiceDto
The wallet service information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The quota ID. | 
**Title** | **string** | The quota title. | [optional] 
**Price** | [**PriceDto**](PriceDto.md) | The price parameters. | 
**NonProfit** | **bool** | Specifies if the quota is nonprofit or not. | 
**Free** | **bool** | Specifies if the quota is free or not. | 
**Trial** | **bool** | Specifies if the quota is trial or not. | 
**Features** | [**List&lt;TenantQuotaFeatureDto&gt;**](TenantQuotaFeatureDto.md) | The list of tenant quota features. | 
**UsersQuota** | [**TenantEntityQuotaSettings**](TenantEntityQuotaSettings.md) | The user quota. | [optional] 
**RoomsQuota** | [**TenantEntityQuotaSettings**](TenantEntityQuotaSettings.md) | The room quota. | [optional] 
**AiAgentsQuota** | [**TenantEntityQuotaSettings**](TenantEntityQuotaSettings.md) | The ai agent quota. | [optional] 
**TenantCustomQuota** | [**TenantQuotaSettings**](TenantQuotaSettings.md) | The tenant custom quota. | [optional] 
**DueDate** | **DateTime** | The due date. | [optional] 
**InnerServices** | [**List&lt;WalletServiceDto&gt;**](WalletServiceDto.md) | The list of inner services. | [optional] 
**ServiceName** | **string** | The service name. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

