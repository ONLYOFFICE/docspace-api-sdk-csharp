# DocSpace.API.SDK.Model.AuthKeyDto
One key of an authorization provider or a storage, with how the settings form shows it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The authorization key name. | 
**Value** | **string** | The authorization key value. | 
**Title** | **string** | The authorization key title. | [optional] 
**Type** | **string** | The field type: text, password, select, toggle. | [optional] 
**Options** | **List&lt;string&gt;** | The list of options for select type fields. | [optional] 
**DependsOn** | **string** | The name of another key this field depends on for visibility. | [optional] 
**DependsOnValue** | **string** | The value of the `dependsOn` key that makes this field visible. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

