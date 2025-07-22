# DocSpace.API.SDK.Model.TfaRequestsDto
The request parameters for configuring the Two-Factor Authentication (TFA) settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **TfaRequestsDtoType** |  | [optional] 
**Id** | **Guid** | The ID of the user for whom the TFA settings are being configured. | [optional] 
**TrustedIps** | **List&lt;string&gt;** | The list of IP addresses that bypass TFA verification. | [optional] 
**MandatoryUsers** | **List&lt;Guid&gt;** | The list of user IDs for whom TFA is mandatory. | [optional] 
**MandatoryGroups** | **List&lt;Guid&gt;** | The list group IDs whose members must use TFA. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

