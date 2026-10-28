# DocSpace.API.SDK.Model.AiMetadataMatchDto
Where a text search met the metadata of a file, a folder or a room: one string value that holds the searched text,  with the field it belongs to.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TemplateId** | **int?** | The ID of the metadata template the matching field belongs to. Null for a custom field, which belongs to no  template the API shows. | [optional] 
**FieldId** | **int?** | The ID of the matching template field. Null for a custom field, which is addressed by its name alone. | [optional] 
**FieldName** | **string** | The name of the matching field: the template field or the custom field as it is shown in the entry metadata. | [optional] 
**Value** | **string** | The stored value that holds the searched text, as it was written, not only the matching part of it. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

