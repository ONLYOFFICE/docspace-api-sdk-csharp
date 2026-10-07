# DocSpace.API.SDK.Model.AuthKeyRequest
One key of a provider and the value to store for it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The key name, as `GET api/2.0/settings/authservice` lists it in `props`. | 
**Value** | **string** | The value to store. An empty string clears the key. | 
**Title** | **string** | Accepted for compatibility with earlier clients and not read: the server keeps its own value. | [optional] 
**Type** | **string** | Accepted for compatibility with earlier clients and not read: the server keeps its own value. | [optional] 
**Options** | **List&lt;string&gt;** | Accepted for compatibility with earlier clients and not read: the server keeps its own value. | [optional] 
**DependsOn** | **string** | Accepted for compatibility with earlier clients and not read: the server keeps its own value. | [optional] 
**DependsOnValue** | **string** | Accepted for compatibility with earlier clients and not read: the server keeps its own value. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

