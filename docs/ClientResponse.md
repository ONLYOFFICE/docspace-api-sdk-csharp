# DocSpace.API.SDK.Model.ClientResponse
The whole stored record of an OAuth2 client, including the secret and every address the client is allowed to use.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The display name shown to the user on the consent screen, between 3 and 256 characters. | [optional] 
**Description** | **string** | The free-text description shown next to the name on the consent screen, at most 255 characters. | [optional] 
**Tenant** | **long** | The identifier of the portal the client belongs to. A client is visible only inside its own tenant, apart from the unauthenticated public info read. | [optional] 
**Scopes** | **List&lt;string&gt;** | The permissions the client may ask for, named as they appear in the tenant scope catalogue - for example files:read, rooms:write or openid. A client cannot request a scope that is not listed here. | [optional] 
**Enabled** | **bool** | Whether the client may currently obtain tokens. A disabled client keeps its registration and the tokens already issued to it, but new authorization requests for it are refused. | [optional] 
**ClientId** | **string** | The generated identifier of the client, sent as client_id in every OAuth2 request. It is assigned when the client is registered and never changes afterwards. | [optional] 
**ClientSecret** | **string** | The client secret, which the client presents at the token endpoint when it authenticates with client_secret_post. It is omitted from the response rather than sent as null when the client has none. | [optional] 
**WebsiteUrl** | **string** | The URL of the client home page, offered to the user before they consent. | [optional] 
**TermsUrl** | **string** | The URL of the client terms of service, linked from the consent screen. | [optional] 
**PolicyUrl** | **string** | The URL of the client privacy policy, linked from the consent screen. | [optional] 
**Logo** | **string** | The client logo as a data URI carrying base64 image data, shown on the consent screen. Only png, jpeg, jpg and svg+xml are accepted, the whole string may not exceed 2000000 characters and the decoded image may not exceed 256000 bytes. | [optional] 
**AuthenticationMethods** | **List&lt;string&gt;** | How the client authenticates itself at the token endpoint: client_secret_post for a confidential client that sends its secret, none for a public client that proves itself with PKCE instead. | [optional] 
**RedirectUris** | **List&lt;string&gt;** | The URIs an authorization code may be delivered to. An authorization request naming any other URI is refused, and the set holds between 1 and 12 addresses. | [optional] 
**AllowedOrigins** | **List&lt;string&gt;** | The web origins allowed to call the portal on behalf of this client, used for the CORS check. The set holds between 1 and 12 addresses. | [optional] 
**LogoutRedirectUris** | **List&lt;string&gt;** | The URIs the user may be sent back to once they have logged out. | [optional] 
**CreatedOn** | **DateTime** | When the client was registered, as an ISO-8601 timestamp with a zone offset. | [optional] 
**CreatedBy** | **string** | The identifier of the user who registered the client. A plain user may read and change only the clients where this is their own identifier. | [optional] 
**ModifiedOn** | **DateTime** | When the client was last changed, as an ISO-8601 timestamp with a zone offset. | [optional] 
**ModifiedBy** | **string** | The identifier of the user who last changed the client. | [optional] 
**IsPublic** | **bool** | Whether the client is offered to third-party tenants rather than only to the tenant that registered it. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

