# DocSpace.API.SDK.Model.CspRequestsDto
The external sources the portal Content Security Policy is to trust.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Domains** | **List&lt;string&gt;** | The domains the policy trusts, as the complete list that is to hold afterwards rather than a list of  additions: send the domains already trusted together with the new one to add one, leave one out to withdraw  it, and send an empty list to fall back to the portal built-in policy. An entry may be a bare host, a host  with a scheme, or a wildcard host such as `*.example.com`; it has to form a valid absolute address and may  contain ASCII characters only. Every entry becomes an allowed source for scripts, styles, images, fonts,  frames, media and connections at once - the directives cannot be set apart here. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

