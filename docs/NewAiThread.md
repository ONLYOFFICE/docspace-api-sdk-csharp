# DocSpace.API.SDK.Model.NewAiThread
Chat conversation metadata. Represents a single chat session (thread).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ThreadId** | **string** | Unique thread identifier (UUID). | 
**Title** | **string** | Optional thread title. Auto-generated from the first message if not set. | [optional] 
**LastEditDate** | **decimal** | Timestamp (ms since epoch) of the last message in this thread. Used for sorting. | [optional] 
**Provider** | [**NewAiTProvider**](NewAiTProvider.md) |  | [optional] 
**Model** | [**NewAiModel**](NewAiModel.md) |  | [optional] 
**ProfileId** | **string** | ID of the profile used for this thread. Links to  {@link  Profile.id } . | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

