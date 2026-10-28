# DocSpace.API.SDK.Model.RunBuilderScriptRequestDto
The document builder script to run and where to put what it produces.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Script** | **string** | The document builder script. It names a portal file by its id where the document builder documentation  writes an address - `builder.OpenFile(1234)`; an address written out in the script is refused. | 
**FolderId** | **int?** | The id of the folder for the produced files that `outputs` does not list, as reported by a folder listing  such as `GET api/2.0/files/{folderId}`. | [optional] 
**Outputs** | [**Dictionary&lt;string, RunBuilderScriptOutputRequest&gt;**](RunBuilderScriptOutputRequest.md) | Destinations of the produced files, keyed by the name the script saves each one under - the second argument of  `builder.SaveFile(docx, result.docx)`. | [optional] 
**Argument** | [**RunBuilderScriptRequestDtoArgument**](RunBuilderScriptRequestDtoArgument.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

