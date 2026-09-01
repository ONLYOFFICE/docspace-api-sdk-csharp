# DocSpace.API.SDK.Model.EditorConfigurationDto
The editor configuration parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CallbackUrl** | **string** | The callback URL of the editor. | [optional] 
**CoEditing** | [**CoEditingConfig**](CoEditingConfig.md) | The co-editing configuration parameters. | [optional] 
**CreateUrl** | **string** | The creation URL of the editor. | [optional] 
**Customization** | [**CustomizationConfigDto**](CustomizationConfigDto.md) | The customization configuration. | [optional] 
**Embedded** | [**EmbeddedConfig**](EmbeddedConfig.md) | The configuration parameters for the embedded document type. | [optional] 
**EncryptionKeys** | [**List&lt;EncryptionKeyDto&gt;**](EncryptionKeyDto.md) | The encryption keys of the editor configuration. | [optional] 
**Lang** | **string** | The language of the editor configuration. | 
**Mode** | **string** | The mode of the editor configuration. | 
**ModeWrite** | **bool** | Specifies if the mode is write of the editor configuration. | [optional] 
**Plugins** | [**PluginsConfig**](PluginsConfig.md) | The configuration settings to connect the special add-ons. | [optional] 
**Recent** | [**List&lt;RecentConfig&gt;**](RecentConfig.md) | The recent configuration of the editor. | [optional] 
**Templates** | [**List&lt;TemplatesConfig&gt;**](TemplatesConfig.md) | The templates of the editor configuration. | [optional] 
**User** | [**UserConfig**](UserConfig.md) | The configuration parameters of the user currently viewing or editing the document. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

