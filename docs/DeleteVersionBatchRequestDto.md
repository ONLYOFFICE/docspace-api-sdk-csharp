# DocSpace.Model.DeleteVersionBatchRequestDto
The request parameters for deleting file versions.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReturnSingleOperation** | **bool** | Specifies whether to return only the current operation | [optional] 
**DeleteAfter** | **bool** | Specifies whether to delete a file after the editing session is finished or not. | [optional] 
**FileId** | **int** | The file ID to delete. | 
**Versions** | **List&lt;int&gt;** | The collection of file versions to be deleted. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

