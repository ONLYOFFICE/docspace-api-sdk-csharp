# DocSpace.API.SDK.Model.AiChatPriceDto
What a chat model charges, split by the direction the tokens flow in.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Prompt** | **double** | The cost of one million tokens sent to the model, which includes the conversation history resent with  every turn and not just the newest message. | [optional] 
**Completion** | **double** | The cost of one million tokens the model writes back. It is normally the dearer of the two directions. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

