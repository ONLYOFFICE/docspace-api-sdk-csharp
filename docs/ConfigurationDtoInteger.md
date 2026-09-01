# DocSpace.API.SDK.Model.ConfigurationDtoInteger
The configuration parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Document** | [**DocumentConfigDto**](DocumentConfigDto.md) | The document configuration. | 
**DocumentType** | **string** | The document type. | 
**EditorConfig** | [**EditorConfigurationDto**](EditorConfigurationDto.md) | The editor configuration. | 
**EditorType** | **EditorType** | The editor type. | 
**EditorUrl** | **string** | The editor URL. | 
**Token** | **string** | The token of the file configuration. | [optional] 
**Type** | **string** | The platform type. | [optional] 
**File** | [**FileDtoInteger**](FileDtoInteger.md) | The file parameters. | 
**ErrorMessage** | **string** | The error message. | [optional] 
**StartFilling** | **bool?** | Specifies if the file filling has started or not. | [optional] 
**FillingStatus** | **bool?** | The file filling status. | [optional] 
**StartFillingMode** | **StartFillingMode** | The start filling mode. | [optional] 
**FillingSessionId** | **string** | The file filling session ID. | [optional] 
**QuotaExceededScope** | **QuotaScope** | Indicates which quota scope has been exceeded. | [optional] 
**GenerationToolCallState** | [**EditorToolCallStateDto**](EditorToolCallStateDto.md) | The generation tool call state. Used to run the agent flow in the editor. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

