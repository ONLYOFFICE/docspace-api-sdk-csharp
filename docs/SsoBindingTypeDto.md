# DocSpace.API.SDK.Model.SsoBindingTypeDto
The SAML bindings the SSO settings accept.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Saml20HttpPost** | **string** | The SAML 2.0 HTTP POST binding, which carries the request in a self-submitting form. It is what the  built-in configuration uses and the one to pick when requests are signed, since it has no length limit. | [optional] [readonly] 
**Saml20HttpRedirect** | **string** | The SAML 2.0 HTTP redirect binding, which carries the request in the query string and is therefore bound  by the length a URL may have. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

