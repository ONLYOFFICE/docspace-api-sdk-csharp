# DocSpace.API.SDK.Model.CreateClientRequest
Client creation request containing client details

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The display name shown to the user on the consent screen. It has to be between 3 and 256 characters long. | 
**Description** | **string** | The free-text description shown next to the name on the consent screen, at most 255 characters. | [optional] 
**Logo** | **string** | The client logo as a data URI carrying base64 image data, shown on the consent screen. Only png, jpeg, jpg and svg+xml are accepted, the whole string may not exceed 2000000 characters and the decoded image may not exceed 256000 bytes. | 
**Scopes** | **List&lt;string&gt;** | The permissions the client may ask for, named as they appear in the tenant scope catalogue - for example files:read, rooms:write or openid. A client cannot request a scope that is not listed here. | 
**AllowPkce** | **bool** | Whether the client may use PKCE. Turning it on lets the client authenticate with the none method and prove itself with a code verifier instead of sending a secret, which is what a client that cannot keep a secret needs. | [optional] 
**WebsiteUrl** | **string** | The URL of the client home page, offered to the user before they consent. The value has to be an http or https URL. | 
**TermsUrl** | **string** | The URL of the client terms of service, linked from the consent screen. The value has to be an http or https URL. | 
**PolicyUrl** | **string** | The URL of the client privacy policy, linked from the consent screen. The value has to be an http or https URL. | 
**RedirectUris** | **List&lt;string&gt;** | The URIs an authorization code may be delivered to. An authorization request naming any other URI is refused, and the set holds between 1 and 12 addresses. | 
**AllowedOrigins** | **List&lt;string&gt;** | The web origins allowed to call the portal on behalf of this client, used for the CORS check. The set holds between 1 and 12 addresses. | 
**LogoutRedirectUri** | **string** | The single URI the user may be sent back to once they have logged out. The value has to be an http or https URL. | 
**IsPublic** | **bool** | Whether the client is offered to third-party tenants rather than only to the tenant that registers it. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

