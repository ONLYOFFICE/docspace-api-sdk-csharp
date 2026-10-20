# DocSpace.API.SDK.Model.MetadataTemplateDto
The metadata template information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The template ID. | [optional] 
**Name** | **string** | The template name. | [optional] 
**Visible** | **bool** | Specifies if the template is visible in the UI pickers. | [optional] 
**CreateBy** | [**EmployeeDto**](EmployeeDto.md) | The user who created the template. A user who has since left the portal comes back as the lost user placeholder. | [optional] 
**CreateOn** | [**ApiDateTime**](ApiDateTime.md) | The template creation date. | [optional] 
**ModifiedBy** | [**EmployeeDto**](EmployeeDto.md) | The user who changed the template itself last: its name or its visibility. The creator until somebody changes  it; a change of a field is recorded on the field, not here. | [optional] 
**ModifiedOn** | [**ApiDateTime**](ApiDateTime.md) | The date when the template was modified last. | [optional] 
**Fields** | [**List&lt;MetadataFieldDto&gt;**](MetadataFieldDto.md) | The template metadata fields. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

