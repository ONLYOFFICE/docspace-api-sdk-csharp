# DocSpace.API.SDK.Model.MobileRequestsDto
The phone number a user going through phone activation registers for SMS codes.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MobilePhone** | **string** | The number the SMS codes are sent to, in international form with the leading `+` and no spaces. It is stored  as not yet activated and only becomes the confirmed number once a code sent to it is accepted; an already  activated number is not replaced this way and has to be erased first. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

