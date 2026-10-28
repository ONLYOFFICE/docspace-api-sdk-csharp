# DocSpace.API.SDK.Model.EntryFieldDto
A metadata template field with its value on the entry.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **int** | The field ID. | [optional] 
**Name** | **string** | The field name. | [optional] 
**Type** | **MetadataFieldType** | The field type. | [optional] 
**Options** | [**List&lt;MetadataFieldOptionDto&gt;**](MetadataFieldOptionDto.md) | The choice options of the field. | [optional] 
**Order** | **int** | The field display order inside the template. | [optional] 
**Value** | [**MetadataValueDto**](MetadataValueDto.md) | The value of the field on the entry, or `null` when the entry holds no value for it. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

