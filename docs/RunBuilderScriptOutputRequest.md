# DocSpace.API.SDK.Model.RunBuilderScriptOutputRequest
Where one produced file goes.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileId** | **int?** | The id of a portal file to store the result in as a new version, as reported by a folder listing such as  `GET api/2.0/files/{folderId}`. | [optional] 
**FolderId** | **int?** | The id of a folder to save the result in as a new file, as reported by a folder listing such as  `GET api/2.0/files/{folderId}`. | [optional] 
**Title** | **string** | The title of the new file, when it has to differ from the name the script saved the result under. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

