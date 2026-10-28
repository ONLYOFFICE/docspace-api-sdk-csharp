# DocSpace.API.SDK.Model.GetReferenceDataDto
The body of a spreadsheet reference request: the source spreadsheet, and the three ways of naming the document it  refers to, which are tried in the order they are described.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileKey** | **string** | The id of the referenced file as the document service recorded it in the formula. It is tried first, and only  when `instanceId` names this portal. | 
**InstanceId** | **string** | The portal the reference was made on, as the document service recorded it. Only the id of this portal makes  the file key resolvable; any other value falls through to the path and the link. | 
**SourceFileId** | **int** | The spreadsheet the formula sits in. The path is resolved against it - the referenced file is looked for among  the files lying next to it - and it is the file whose read access is checked. | [optional] 
**Path** | **string** | The title of the referenced file exactly as the formula spells it, matched against the files lying next to the  source file. It is tried after the file key, and only when no link is given. | [optional] 
**Link** | **string** | The web address the formula points at, an editor link of this portal or one of its short links. It is tried  last, and an address belonging to another site is not resolved at all but handed back for the client to follow  as it is. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

