# DocSpace.API.SDK.Model.UpdateFolderMetadataTemplateRequest
The new state of a template assignment on a folder: whether the template cascades to the content of the folder and how.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cascade** | **bool** | Whether the template cascades from the folder to the folders and files below it: true turns the cascade on,  false turns it off while the template stays on the folder. | [optional] 
**ConflictResolveType** | **MetadataConflictResolveType** | How the cascade treats a value an entry below already holds. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

