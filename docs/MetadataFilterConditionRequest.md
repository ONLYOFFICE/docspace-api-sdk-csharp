# DocSpace.API.SDK.Model.MetadataFilterConditionRequest
One metadata filter condition as the clients send it: an element of the metadataFilters JSON of the listings and of  the body of the search endpoints. All conditions are combined with AND.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FieldId** | **int** | The ID of the template field the condition is on. A custom field is addressed by ASC.Files.Core.MetadataFilterConditionRequest.Name instead. | [optional] 
**Name** | **string** | The name of a custom field, for the conditions on the custom fields, which have no identifier outside. Either the  field ID or the name is given; the name is matched without regard to case. | [optional] 
**Op** | **string** | The operator, one of ASC.Files.Core.MetadataFilterOperators: eq or contains for a string field, eq, range,  gt, gte, lt or lte for a number field, range, gt, gte, lt or lte for a date field, in for a  choice field. Optional: an omitted operator is read as eq for a string, as range for a date, as in for a  choice, and for a number as eq when a value is given or as range when a bound is. A present one has to belong  to the field type and to the arguments: eq takes a value, range takes bounds. | [optional] 
**Value** | **string** | The value of a single-valued condition: the whole or a part of a string field, the exact value of a number field,  or the bound of a gt, gte, lt or lte condition on a number or a date field. A JSON number is accepted as  well as a string. A number is a whole number of at most 2^53-1 in magnitude, the limit of a stored number value.  A date given without a time (2026-06-30) names the whole day (UTC). | [optional] 
**From** | **string** | The inclusive lower bound of a range. A number is a whole number of at most 2^53-1 in magnitude, the limit of a  stored number value. A date given without a time (2026-06-01) is the start of that day (UTC). | [optional] 
**To** | **string** | The inclusive upper bound of a range. A number is a whole number of at most 2^53-1 in magnitude, the limit of a  stored number value. A date given without a time (2026-06-30) covers the whole day (UTC); a value with a time  is an instant and is taken as is. | [optional] 
**OptionIds** | **List&lt;Guid&gt;** | The options any of which the choice field must hold. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

