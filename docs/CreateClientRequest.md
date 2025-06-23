# Docspace.Model.CreateClientRequest
Client creation request containing client details

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the client | [optional] 
**Description** | **string** | The description of the client | [optional] 
**Logo** | **string** | The logo of the client in base64 format | [optional] 
**Scopes** | **List&lt;string&gt;** | The scopes for the client | [optional] 
**AllowPkce** | **bool** | Indicates whether PKCE is allowed for the client | [optional] 
**IsPublic** | **bool** | Indicates if the client is public | [optional] 
**WebsiteUrl** | **string** | The website URL of the client | [optional] 
**TermsUrl** | **string** | The terms URL of the client | [optional] 
**PolicyUrl** | **string** | The policy URL of the client | [optional] 
**RedirectUris** | **List&lt;string&gt;** | The redirect URIs for the client | 
**AllowedOrigins** | **List&lt;string&gt;** | The allowed origins for the client | 
**LogoutRedirectUri** | **string** | The logout redirect URI for the client | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

