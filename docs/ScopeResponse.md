# DocSpace.API.SDK.Model.ScopeResponse
One scope from the tenant scope catalogue, as it may be requested by a client.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The scope exactly as it is written in an authorization request, for example files:read or openid. | [optional] 
**Group** | **string** | The area of the portal the scope belongs to, which is what groups the scopes on the consent screen: files, rooms, contacts, profiles or openid. | [optional] 
**Type** | **string** | What the scope allows inside its group: read for read-only access, write for changes, and openid for the identity scope itself. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

