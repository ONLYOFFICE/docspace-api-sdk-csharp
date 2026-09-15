# DocSpace.API.SDK.Model.CspDto
The Content Security Policy of the portal: the domains an administrator allowed, and the header built from them.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Domains** | **List&lt;string&gt;** | The external hosts an administrator has allowed, each in the form it was saved in - a bare host, a host  with a scheme, or a wildcard such as `*.example.com`. An empty list means nobody has added one, not that  the portal serves no policy. | 
**Header** | **string** | The complete policy value the portal sends to browsers, assembled from `domains` together with the  portal's own sources and the integrations it has switched on. It is therefore wider than `domains` alone,  and is filled in even while that list is empty. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

