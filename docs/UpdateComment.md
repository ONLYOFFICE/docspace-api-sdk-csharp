# DocSpace.API.SDK.Model.UpdateComment
The comment to store on one version of a file.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**@Version** | **int** | The version the comment belongs to, as reported by `GET api/2.0/files/file/{fileId}/edit/history`. A version  that does not exist is rejected as an invalid request. | 
**Comment** | **string** | The note that explains what changed in that version, as the version history shows it. An empty text clears the  note, and a longer one is cut rather than refused, so read the stored text from the answer. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

