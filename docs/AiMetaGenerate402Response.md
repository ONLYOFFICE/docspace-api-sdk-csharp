# DocSpace.API.SDK.Model.AiMetaGenerate402Response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Error** | **string** | Short reason, ready to be shown to the caller. | 
**Code** | **string** | Stable classification of the failure: `rate_limit`, `insufficient_funds`, `auth`, `model_not_found`, `timeout`, `network`, `bad_request`, `server`, `unknown`, or a provider-specific code relayed as it came. | 
**ProviderMessage** | **string** | The provider's own error message, cut to 500 characters. Absent when the failure never reached the provider, or was a timeout. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

