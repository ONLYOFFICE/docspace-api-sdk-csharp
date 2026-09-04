# DocSpace.API.SDK.Model.AiPricesDto
Data transfer object that encapsulates comprehensive pricing information for various AI services.  Provides organized collections of pricing details for chat models, embedding services, and web search functionality,  along with the currency in which prices are denominated.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Chat** | [**List&lt;AiEntryPricingDtoAiChatPriceDto&gt;**](AiEntryPricingDtoAiChatPriceDto.md) | Gets the list of pricing entries for AI chat models. | 
**Embedding** | [**List&lt;AiEntryPricingDtoAiEmbeddingPriceDto&gt;**](AiEntryPricingDtoAiEmbeddingPriceDto.md) | Gets the list of pricing entries for AI embedding models. | 
**Image** | [**List&lt;AiEntryPricingDtoAiImagePriceDto&gt;**](AiEntryPricingDtoAiImagePriceDto.md) | Gets the list of pricing entries for AI image models. | 
**WebSearch** | [**List&lt;AiEntryPricingDtoDecimal&gt;**](AiEntryPricingDtoDecimal.md) | Gets the list of pricing entries for AI web search operations. | 
**Currency** | [**CurrencyInfo**](CurrencyInfo.md) | Gets the currency information for the AI pricing data. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

