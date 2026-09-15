# DocSpace.API.SDK.Model.ConfirmData
The confirmation link a sign-in is authorised with, in place of a password.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Email** | **string** | The address the confirmation link was issued for. It has to be the same address the key was signed with, and  a value that is not an email address fails the request with 400. | [optional] 
**First** | **bool?** | Whether the link is being followed for the first time, taken from the `first` parameter of the confirmation  URL. It is part of what the key was signed over, so passing a different value invalidates the key rather than  changing behaviour. | [optional] 
**Key** | **string** | The `key` parameter of the confirmation URL, copied verbatim. It is bound to the address and to the moment it  was issued, so it stops being accepted once the portal email key lifetime has passed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

