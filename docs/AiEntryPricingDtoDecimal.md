# DocSpace.API.SDK.Model.AiEntryPricingDtoDecimal
One AI model or service on the price list: how to name it, who provides it, and what it costs.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The model identifier to send to the AI operations. It is the value to branch on, while `alias` is for display  only. | 
**Alias** | **string** | The model name as the vendor writes it, meant to be shown to a person rather than matched on. | 
**Provider** | **string** | Who runs the model. Two entries can share a provider, and one provider's models can be priced quite  differently, so the price always belongs to the entry and never to the provider. | 
**Image** | **string** | The absolute URL of the provider's icon, for rendering next to the entry. | 
**Price** | **double** | What the entry costs, in the currency the answer names. Amounts per token are normalised per million  tokens, so they are not the price of a single call. | 
**Link** | **string** | The provider's own page for the model, for a person to read the model's terms. It is empty when the  provider publishes none. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

