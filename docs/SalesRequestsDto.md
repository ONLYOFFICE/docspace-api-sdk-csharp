# DocSpace.API.SDK.Model.SalesRequestsDto
Who is writing to the ONLYOFFICE sales team, and what about.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserName** | **string** | The name the sales team should address the reply to. It is sent as written and is not matched against any  portal account; an empty value fails the request with 400. | 
**Email** | **string** | The address the answer is sent to. It has to be a well-formed email address and need not be the caller portal  address; an empty or malformed value fails the request with 400. | 
**Message** | **string** | What is being asked of the sales team - a quote, an invoice, or a plan that cannot be bought online. An empty  value fails the request with 400. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

