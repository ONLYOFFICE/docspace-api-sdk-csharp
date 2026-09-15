# DocSpace.API.SDK.Model.EditorConfigurationDto
How the editors behave for this opening: the mode, the language, the interface, and who is editing.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CallbackUrl** | **string** | Where the editors post the document back to when they save it. A client must not call it itself; it is the  address the document service uses. | [optional] 
**CoEditing** | [**CoEditingConfig**](CoEditingConfig.md) | How co-editing starts out for this session and whether the user may switch it in the interface. | [optional] 
**CreateUrl** | **string** | Where the editor sends the user when they ask for a new document of the same type. It is empty when creating  one is not offered here. | [optional] 
**Customization** | [**CustomizationConfigDto**](CustomizationConfigDto.md) | How the editor interface is dressed for this portal, this document and this layout. | [optional] 
**Embedded** | [**EmbeddedConfig**](EmbeddedConfig.md) | The addresses the framed viewer needs. It is filled in only for the embedded layout. | [optional] 
**EncryptionKeys** | [**List&lt;EncryptionKeyDto&gt;**](EncryptionKeyDto.md) | The caller's end-to-end encryption keys, added only when the document lies in a private room, so that the  editors can decrypt it in the browser. It is empty everywhere else. | [optional] 
**Lang** | **string** | The culture the editor interface is shown in, taken from the profile of the caller. | 
**Mode** | **string** | `edit` when this session may write the document, `view` when it may only read it. | 
**ModeWrite** | **bool** | Whether this session may write; it is what the mode above says in one word. | [optional] 
**Plugins** | [**PluginsConfig**](PluginsConfig.md) | Which editor plugins are offered. The portal currently offers none, so the list inside comes back empty. | [optional] 
**Recent** | [**List&lt;RecentConfig&gt;**](RecentConfig.md) | The documents offered in the editor's recent list. It is left out altogether when there is nothing to offer. | [optional] 
**Templates** | [**List&lt;TemplatesConfig&gt;**](TemplatesConfig.md) | Always empty: the portal no longer passes creation templates through the editor configuration. | [optional] 
**User** | [**UserConfig**](UserConfig.md) | The account the editors attribute changes to. It is empty for an anonymous session opened through an external  link, and the editors then ask for a name themselves. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

