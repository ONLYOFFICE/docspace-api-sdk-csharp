# DocSpace.API.SDK.Model.AiPricesResponse
The AI price list: per-model pricing for every model kind, in a single currency.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Chat** | [**List&lt;AiChatModelPricing&gt;**](AiChatModelPricing.md) | The pricing of every available chat model. | 
**Embedding** | [**List&lt;AiEmbeddingModelPricing&gt;**](AiEmbeddingModelPricing.md) | The pricing of every available embedding model. | 
**Image** | [**List&lt;AiImageModelPricing&gt;**](AiImageModelPricing.md) | The pricing of every available image model. | 
**Search** | [**List&lt;AiWebSearchPricing&gt;**](AiWebSearchPricing.md) | The pricing of every available web search provider. | 
**Currency** | [**CurrencyInfo**](CurrencyInfo.md) | The currency the AI prices are quoted in. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

