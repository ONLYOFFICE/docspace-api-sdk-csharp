# DocSpace.API.SDK.Model.AiModel
AI model metadata. Describes a single model available from a provider.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | Model identifier as used by the provider API (e.g. `gpt-4o`, `claude-sonnet-4-20250514`). | 
**Name** | **string** | Human-readable model name for display in the UI. | 
**Provider** | [**AiProviderType**](AiProviderType.md) | Provider that offers this model. | 
**Reasoning** | **bool** | Whether this model supports extended thinking / chain-of-thought reasoning. | [optional] 
**Capabilities** | **decimal** | Bitmask of model capabilities (Chat, Image, Vision, Tools, etc.). Used to filter models per `ActionType`. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

