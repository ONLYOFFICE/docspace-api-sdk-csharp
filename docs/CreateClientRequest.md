# DocSpace.Sdk.Model.CreateClientRequest
The request parameters for creating a client.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The client name. | [optional] 
**Description** | **string** | The client description. | [optional] 
**Logo** | **string** | The client logo in base64 format. | [optional] 
**Scopes** | **List&lt;string&gt;** | The client scopes. | [optional] 
**AllowPkce** | **bool** | Indicates whether PKCE is allowed for the client. | [optional] 
**IsPublic** | **bool** | Indicates whether the client is accessible by third-party tenants. | [optional] 
**WebsiteUrl** | **string** | The URL to the client&#39;s website. | [optional] 
**TermsUrl** | **string** | The URL to the client&#39;s terms of service. | [optional] 
**PolicyUrl** | **string** | The URL to the client&#39;s privacy policy. | [optional] 
**RedirectUris** | **List&lt;string&gt;** | The list of allowed redirect URIs. | 
**AllowedOrigins** | **List&lt;string&gt;** | The list of allowed CORS origins. | 
**LogoutRedirectUri** | **string** | The list of allowed logout redirect URIs. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

