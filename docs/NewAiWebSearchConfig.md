# DocSpace.API.SDK.Model.NewAiWebSearchConfig
Web-search provider configuration. Credentials and provider selection for the built-in web-search tool group.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Provider** | **string** | Provider identifier (e.g. `exa`). | 
**Key** | **string** | API key for the provider. Optional for self-hosted or keyless setups. | [optional] 
**BaseUrl** | **string** | Optional override for the provider's base URL. | [optional] 
**IsCloudProvider** | **bool** | Whether this provider is cloud-hosted (vs. self-hosted). | [optional] 
**Headers** | **Dictionary&lt;string, string&gt;** | Extra HTTP headers sent with each request to the ONLYOFFICE / cloud backend (e.g. `X-Tenant`). Merged after the derived `Authorization` header, so a custom header of the same name wins. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

