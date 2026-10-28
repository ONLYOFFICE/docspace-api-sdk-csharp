# DocSpace.API.SDK.Model.MetadataValueRequest
The parameters of a metadata field value.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FieldId** | **int** | The field ID. | 
**StringValue** | **string** | The string value. | [optional] 
**NumberValue** | **long?** | The number value. | [optional] 
**DateValue** | **DateTime?** | The date value. A value without a time zone offset is treated as UTC, the same way the metadata filters treat their date bounds. | [optional] 
**OptionIds** | **List&lt;Guid&gt;** | The selected choice option IDs. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

