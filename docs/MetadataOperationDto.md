# DocSpace.API.SDK.Model.MetadataOperationDto
The cascade metadata assignment operation status.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The operation ID. | [optional] 
**Progress** | **double** | The operation progress percentage. | [optional] 
**IsCompleted** | **bool** | Specifies if the operation is completed. | [optional] 
**Error** | **string** | The operation error message. | [optional] 
**TemplateIds** | **List&lt;int&gt;** | The IDs of the metadata templates the operation propagates to the subtree. Empty when there is no operation to  report, so the answer describes nothing in progress. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

