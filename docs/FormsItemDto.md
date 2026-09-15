# DocSpace.API.SDK.Model.FormsItemDto
One field of a form, offered as a filter over the copies gathered in a form-filling room.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The name of the field as it is written in the form; send it back as `formsItemKey` to keep only              the completed copies whose field of that name holds a value.              <example>first_name</example> | [optional] 
**Type** | **string** | The kind of value the field holds, a text box or a checkbox for instance; send it back as              `formsItemType` beside the key.              <example>text</example> | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

