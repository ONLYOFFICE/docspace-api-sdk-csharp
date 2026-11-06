# DocSpace.API.SDK.Model.AiCreateProfileInput
Input for creating a new profile: the shape of a profile without the fields the service fills in (`id`, `createdAt`).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | User-defined profile display name. | 
**ProviderType** | [**AiProviderType**](AiProviderType.md) | The provider type of the profile. `external` sends every request through a transport the embedding application supplies while parsing the answers with the provider named in `basedOn`. | 
**BasedOn** | **AiBuiltinProviderType** | Selects the response-format parser used by the `external` provider. Ignored for any other `providerType`.  Supported values are `openai`, `anthropic`, `mistral` and `openrouter`. Remaining values (`genai`, `stabilityai`, …) are accepted by the type but not yet implemented; passing one raises an error at request time. | [optional] 
**BaseUrl** | **string** | Base URL of the provider API. | 
**Key** | **string** | API key or token. Optional for local providers. | [optional] 
**Headers** | **Dictionary&lt;string, string&gt;** | Extra HTTP headers sent with every request to this provider. Merged into the SDK client's default headers; an explicit `Authorization` here wins over the one derived from `key`. Honoured by the OpenAI-family providers. | [optional] 
**ModelId** | **string** | Selected model ID within this provider. | 
**Reasoning** | **bool** | Whether extended thinking is enabled for this profile's model. | [optional] 
**ReasoningSupport** | [**AiReasoningSupport**](AiReasoningSupport.md) | What the model can do with extended thinking, as the provider's catalogue reported it when the profile was saved; the effort choices in the chat follow it. When absent, the abilities are taken from the model ID. | [optional] 
**ContextWindow** | **decimal** | Size of the selected model's context window in tokens, as the provider's catalogue reported it at save time (see `Model.contextWindow`). The engine's history compaction measures the thread against it; when absent the id-based table answers, and when that has no row either, `CompactionOptions.defaultContextWindow`. Hosts persist it with the rest of the profile. | [optional] 
**Capabilities** | **decimal** | Bitmask of capabilities supported by the selected model. | [optional] 
**CanUseTool** | **bool** | Result of the live tool-capability probe performed at create time and on changes to `modelId` / `providerType` / `baseUrl`. `undefined` means the probe has never run for this profile (legacy record). | [optional] 
**UseResponsesApi** | **bool** | Result of the live Responses-API probe (parallel to `canUseTool`). `true` means the model speaks `/v1/responses` and the OpenAI provider must route through `client.responses.create` — required for gpt-5+ reasoning models that reject `reasoning_effort` together with `tools` on `/v1/chat/completions`. Probed at create time and whenever `modelId` / `providerType` / `baseUrl` change. `undefined` means the probe never ran (legacy record) — readers treat that as `false`. | [optional] 
**IsCloudProvider** | **bool** | Whether this profile uses a cloud-hosted provider (e.g. ONLYOFFICE DocSpace). | [optional] 
**UseProxy** | **bool** | Whether the chat client sends this profile's provider requests through the portal's proxy instead of directly. Has no effect when no proxy is configured. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

