# DocSpace.API.SDK.Model.ExchangeToken200Response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccessToken** | **string** | The token to send as a Bearer credential when calling the portal on the user behalf. | [optional] 
**TokenType** | **string** | How the access token is to be presented. It is always Bearer. | [optional] 
**ExpiresIn** | **int** | How many seconds the access token stays valid, counted from the moment it was issued. | [optional] 
**RefreshToken** | **string** | The token that buys a new access token once the current one expires. It is present only when the client is registered for the refresh token grant. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

