# DocSpace.API.SDK.Model.SaveAuthKeysRequestDto
The keys to store for one third-party authorization or storage provider.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The internal key of the provider, such as `google` or `box`. Take it from the `name` of  `GET api/2.0/settings/authservice`. | [optional] 
**Title** | **string** | Accepted for compatibility with earlier clients and not read: the server keeps its own value. | [optional] 
**Description** | **string** | Accepted for compatibility with earlier clients and not read: the server keeps its own value. | [optional] 
**Instruction** | **string** | Accepted for compatibility with earlier clients and not read: the server keeps its own value. | [optional] 
**CanSet** | **bool** | Accepted for compatibility with earlier clients and not read: the server keeps its own value. | [optional] 
**Paid** | **bool** | Accepted for compatibility with earlier clients and not read: the server keeps its own value. | [optional] 
**Props** | [**List&lt;AuthKeyRequest&gt;**](AuthKeyRequest.md) | The keys of the provider with their new values, by the key names `GET api/2.0/settings/authservice` lists in  `props`. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

