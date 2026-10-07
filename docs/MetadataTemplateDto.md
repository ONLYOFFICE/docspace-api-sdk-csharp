# DocSpace.API.SDK.Model.MetadataTemplateDto
The metadata template information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The template ID. | [optional] 
**Name** | **string** | The template name. | [optional] 
**Visible** | **bool** | Specifies if the template is visible in the UI pickers. | [optional] 
**CreateBy** | **Guid** | The user who created the template. | [optional] 
**CreateOn** | [**ApiDateTime**](ApiDateTime.md) | The template creation date. | [optional] 
**ModifiedBy** | **Guid** | The user who modified the template last. | [optional] 
**ModifiedOn** | [**ApiDateTime**](ApiDateTime.md) | The date when the template was modified last. | [optional] 
**Fields** | [**List&lt;MetadataFieldDto&gt;**](MetadataFieldDto.md) | The template metadata fields. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

