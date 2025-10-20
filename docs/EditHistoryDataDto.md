# DocSpace.API.SDK.Model.EditHistoryDataDto
The file editing history data.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ChangesUrl** | **string** | The URL address of the file with the document changes data. | [optional] 
**Key** | **string** | The document identifier used to unambiguously identify the document file. | 
**Previous** | [**EditHistoryUrl**](EditHistoryUrl.md) |  | [optional] 
**Token** | **string** | The encrypted signature added to the parameter in the form of a token. | [optional] 
**Url** | **string** | The URL address of the current document version. | 
**@Version** | **int** | The document version number. | 
**FileType** | **string** | The document extension. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

