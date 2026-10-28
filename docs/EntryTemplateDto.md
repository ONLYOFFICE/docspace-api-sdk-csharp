# DocSpace.API.SDK.Model.EntryTemplateDto
A metadata template assigned to an entry: the template with every field of it, each field carrying its value on the entry.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The template ID. | [optional] 
**Name** | **string** | The template name. | [optional] 
**Visible** | **bool** | Specifies if the template is visible in the UI pickers. | [optional] 
**Cascade** | **bool** | Whether the template cascades from this entry to the folders and files below it. Only a folder or a room can  cascade; on a file the value is always false. | [optional] 
**ConflictResolveType** | **MetadataConflictResolveType** | How the cascade of this entry treats a value an entry below already holds. Null while the template does not  cascade from this entry. | [optional] 
**Fields** | [**List&lt;EntryFieldDto&gt;**](EntryFieldDto.md) | The template fields with their values on the entry. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

