# DocSpace.API.SDK.Model.AiCreateProfileInput
Input for creating a new profile — the same shape as  {@link  Profile }  without the engine-generated fields (`id`, `createdAt`).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | User-defined profile display name. | 
**ProviderType** | [**AiProviderType**](AiProviderType.md) | Provider type for this profile. Use `external` to delegate all HTTP transport to  {@link  PlatformAdapter.externalFetch  }  while reusing an existing provider's response parser — see  {@link  Profile.basedOn }  for the format selector. | 
**BasedOn** | **AiBuiltinProviderType** | Selects the response-format parser used by the `external` provider. Ignored for any other `providerType`.  Supported values are `openai`, `anthropic`, `mistral` and `openrouter`. Remaining values (`genai`, `stabilityai`, …) are accepted by the type but not yet implemented; passing one raises an error at request time. | [optional] 
**BaseUrl** | **string** | Base URL of the provider API. | 
**Key** | **string** | API key or token. Optional for local providers. | [optional] 
**Headers** | **Dictionary&lt;string, string&gt;** | Extra HTTP headers sent with every request to this provider. Merged into the SDK client's default headers; an explicit `Authorization` here wins over the one derived from  {@link  key  } . Honoured by the OpenAI-family providers. | [optional] 
**ModelId** | **string** | Selected model ID within this provider. | 
**Reasoning** | **bool** | Whether extended thinking is enabled for this profile's model. | [optional] 
**Capabilities** | **decimal** | Bitmask of capabilities supported by the selected model. | [optional] 
**CanUseTool** | **bool** | Result of the live tool-capability probe performed at create time and on changes to `modelId` / `providerType` / `baseUrl`. `undefined` means the probe has never run for this profile (legacy record). | [optional] 
**UseResponsesApi** | **bool** | Result of the live Responses-API probe (parallel to  {@link  canUseTool  } ). `true` means the model speaks `/v1/responses` and the OpenAI provider must route through `client.responses.create` — required for gpt-5+ reasoning models that reject `reasoning_effort` together with `tools` on `/v1/chat/completions`. Probed at create time and whenever `modelId` / `providerType` / `baseUrl` change. `undefined` means the probe never ran (legacy record) — readers treat that as `false`. | [optional] 
**IsCloudProvider** | **bool** | Whether this profile uses a cloud-hosted provider (e.g. ONLYOFFICE DocSpace). | [optional] 
**UseProxy** | **bool** | Route every provider request through the host's `fetchProxy` instead of the global `fetch`. Useful when the host runs the widget in a sandbox without direct network access (CORS, custom auth, etc.). Has no effect when the  {@link  PlatformAdapter.fetchProxy  }  is not configured. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

