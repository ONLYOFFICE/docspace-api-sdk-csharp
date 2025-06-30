# DocSpace.Model.ClientResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The client name. | [optional] 
**Description** | **string** | The client description. | [optional] 
**Tenant** | **long** | The tenant ID associated with the client. | [optional] 
**Scopes** | **List&lt;string&gt;** | The client scopes. | [optional] 
**Enabled** | **bool** | Specifies if the client is currently enabled or not. | [optional] 
**ClientId** | **string** | The client identifier issued to the client during registration. | [optional] 
**ClientSecret** | **string** | The client secret issued to the client during registration. | [optional] 
**WebsiteUrl** | **string** | The URL to the client&#39;s website. | [optional] 
**TermsUrl** | **string** | The URL to the client&#39;s terms of service. | [optional] 
**PolicyUrl** | **string** | The URL to the client&#39;s privacy policy. | [optional] 
**Logo** | **string** | The URL to the client&#39;s logo. | [optional] 
**AuthenticationMethods** | **List&lt;string&gt;** | The authentication methods supported by the client. | [optional] 
**RedirectUris** | **List&lt;string&gt;** | The list of allowed redirect URIs. | [optional] 
**AllowedOrigins** | **List&lt;string&gt;** | The list of allowed CORS origins. | [optional] 
**LogoutRedirectUris** | **List&lt;string&gt;** | The list of allowed logout redirect URIs. | [optional] 
**CreatedOn** | **DateTime** | The date and time when the client was created. | [optional] 
**CreatedBy** | **string** | The user who created the client. | [optional] 
**ModifiedOn** | **DateTime** | The date and time when the client was last modified. | [optional] 
**ModifiedBy** | **string** | The user who last modified the client. | [optional] 
**IsPublic** | **bool** | Indicates whether the client is accessible by third-party tenants. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

