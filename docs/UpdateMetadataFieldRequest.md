# DocSpace.API.SDK.Model.UpdateMetadataFieldRequest
The parameters of a metadata field update. Every property is optional: a property that is omitted keeps its current value.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The new field name. | [optional] 
**Type** | **MetadataFieldType** | The new field type. The type can be changed only while the field has no values. | [optional] 
**Options** | [**List&lt;MetadataFieldOptionRequest&gt;**](MetadataFieldOptionRequest.md) | The new choice options of the field. The options in use cannot be removed. | [optional] 
**Order** | **int?** | The new display position of the field inside the template: the fields are shown by it ascending. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

