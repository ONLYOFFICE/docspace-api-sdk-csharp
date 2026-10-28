# DocSpace.API.SDK.Model.MetadataValueDto
The value of a metadata field on an entry. Exactly one of the value properties is set, the one matching the field type:  `stringValue` for a string field, `numberValue` for a number field, `dateValue` for a date field,  `optionIds` for a single or multiple choice field.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StringValue** | **string** | The string value. | [optional] 
**NumberValue** | **long?** | The number value. | [optional] 
**DateValue** | [**ApiDateTime**](ApiDateTime.md) | The date value. | [optional] 
**OptionIds** | **List&lt;Guid&gt;** | The selected choice option IDs. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

