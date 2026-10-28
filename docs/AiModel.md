# DocSpace.API.SDK.Model.AiModel
AI model metadata. Describes a single model available from a provider.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Model identifier as used by the provider API (e.g. `gpt-4o`, `claude-sonnet-4-20250514`). | 
**Name** | **string** | Human-readable model name for display in the UI. | 
**Provider** | [**AiProviderType**](AiProviderType.md) | Provider that offers this model. | 
**Reasoning** | **bool** | Whether this model supports extended thinking / chain-of-thought reasoning. | [optional] 
**ReasoningSupport** | [**AiReasoningSupport**](AiReasoningSupport.md) | What the model can do with extended thinking, when the provider's catalogue says so (OpenRouter and the ONLYOFFICE route report a per-model `reasoning` object). Copied onto the profile at save time; absent, the widget falls back to the provider's id-based table. | [optional] 
**Capabilities** | **decimal** | Bitmask of model capabilities (Chat, Image, Vision, Tools, etc.). Used to filter models per `ActionType`. | [optional] 
**Created** | **decimal** | Release date as a Unix timestamp in **seconds**, when the provider's catalogue reports one (OpenAI-shaped `/models` responses and OpenRouter carry `created`; Anthropic carries an ISO `created_at`). The model picker sorts on it so the newest releases come first; entries without it fall back to alphabetical order. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

