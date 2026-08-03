# DocSpace.API.SDK.Model.AiThread
Chat conversation metadata. Represents a single chat session (thread).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ThreadId** | **string** | Unique thread identifier (UUID). | 
**Title** | **string** | Optional thread title. Auto-generated from the first message if not set. | [optional] 
**LastEditDate** | **decimal** | Timestamp (ms since epoch) of the last message in this thread. Used for sorting. | [optional] 
**Provider** | [**AiTProvider**](AiTProvider.md) |  | [optional] 
**Model** | [**AiModel**](AiModel.md) |  | [optional] 
**ProfileId** | **string** | ID of the profile used for this thread. Links to  {@link  Profile.id } . | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

