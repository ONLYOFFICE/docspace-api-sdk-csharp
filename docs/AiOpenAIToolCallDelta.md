# DocSpace.API.SDK.Model.AiOpenAIToolCallDelta
The incremental part of one tool call the model requested.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Index** | **decimal** | The zero-based position of the tool call within the message. | 
**Id** | **string** | The tool call identifier, quoted back when its result is submitted. | [optional] 
**Type** | **string** | Always `function` - the only tool kind the API defines. | [optional] 
**Function** | [**AiOpenAIToolCallDeltaFunction**](AiOpenAIToolCallDeltaFunction.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

