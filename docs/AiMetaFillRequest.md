# DocSpace.API.SDK.Model.AiMetaFillRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Kind** | **string** | The entry's table. Only `file` for now: a folder or a room answers 400. | 
**Id** | [**AiMetaGenerateRequestId**](AiMetaGenerateRequestId.md) |  | 
**Prompt** | **string** | What to pay attention to; a hint for the model. | [optional] 
**Overwrite** | **bool** | Also replace the fields that already carry a value. Default false. | [optional] 
**DryRun** | **bool** | Resolve the values but write nothing; the caller writes what the user confirms. Default true: a write needs an explicit false. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

