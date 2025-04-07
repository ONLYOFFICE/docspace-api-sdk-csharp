# Docspace.Model.EditHistoryDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | File ID | [optional] 
**Key** | **string** | Key | [optional] 
**VarVersion** | **int** | File version | [optional] 
**VersionGroup** | **int** | Version group | [optional] 
**User** | [**EditHistoryAuthor**](EditHistoryAuthor.md) |  | [optional] 
**Created** | [**ApiDateTime**](ApiDateTime.md) |  | [optional] 
**ChangesHistory** | **string** | History changes in the string format | [optional] 
**Changes** | [**List&lt;EditHistoryChangesWrapper&gt;**](EditHistoryChangesWrapper.md) | List of history changes | [optional] 
**ServerVersion** | **string** | Server version | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

