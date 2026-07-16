# DocSpace.API.SDK.Model.UpdateProviderBody
Parameters for updating an AI provider's configuration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | The new display title for the AI provider. If null, the title is not changed. | [optional] 
**Url** | **string** | The new API endpoint URL for the AI provider. If null, the URL is not changed. | [optional] 
**Key** | **string** | The new authentication API key for the AI provider. If null, the key is not changed. | [optional] 
**ModelSettings** | [**List&lt;ModelSettingsItemDto&gt;**](ModelSettingsItemDto.md) | Optional list of model settings changes to apply atomically with the provider update. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

