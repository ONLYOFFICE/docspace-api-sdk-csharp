# DocSpace.Model.TfaSettingsDto
The parameters representing the Two-Factor Authentication (TFA) configuration settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The ID of the TFA configuration. | [optional] 
**Title** | **string** | The display name or description of the TFA configuration. | [optional] 
**Enabled** | **bool** | Indicates whether the TFA configuration is currently active. | [optional] 
**Avaliable** | **bool** | Indicates whether the TFA configuration can be used. | [optional] 
**TrustedIps** | **List&lt;string&gt;** | The list of IP addresses that are exempt from TFA requirements. | [optional] 
**MandatoryUsers** | **List&lt;Guid&gt;** | The list of user IDs that are required to use TFA. | [optional] 
**MandatoryGroups** | **List&lt;Guid&gt;** | The list of group IDs whose members are required to use TFA. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

