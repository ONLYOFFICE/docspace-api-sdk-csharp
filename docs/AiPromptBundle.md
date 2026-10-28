# DocSpace.API.SDK.Model.AiPromptBundle
Versioned, self-contained bundle of every saved prompt and folder. Stable wire format — `version` lets the import path migrate older shapes if the schema ever changes.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**@Version** | **decimal** | The bundle format version, so an import can migrate an older export. | 
**Folders** | [**List&lt;AiPromptFolder&gt;**](AiPromptFolder.md) | Every exported prompt folder. | 
**Prompts** | [**List&lt;AiPrompt&gt;**](AiPrompt.md) | Every exported prompt. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

