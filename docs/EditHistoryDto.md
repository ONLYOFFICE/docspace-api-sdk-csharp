# DocSpace.Sdk.Model.EditHistoryDto
The file editing history parameters.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The document ID. | [optional] 
**Key** | **string** | The document identifier used to unambiguously identify the document file. | [optional] 
**VarVersion** | **int** | The document version number. | [optional] 
**VersionGroup** | **int** | The document version group. | [optional] 
**User** | [**EditHistoryAuthor**](EditHistoryAuthor.md) |  | [optional] 
**Created** | [**ApiDateTime**](ApiDateTime.md) |  | [optional] 
**ChangesHistory** | **string** | The file history changes in the string format. | [optional] 
**Changes** | [**List&lt;EditHistoryChangesWrapper&gt;**](EditHistoryChangesWrapper.md) | The list of file history changes. | [optional] 
**ServerVersion** | **string** | The current server version number. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

