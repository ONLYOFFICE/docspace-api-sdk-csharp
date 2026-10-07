# DocSpace.API.SDK.Model.OperationTokenUsageDto
Tokens an AI operation consumed, as recorded in the operation metadata. A kind the provider did not report is `0`.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TotalTokens** | **long** | All tokens of the request: prompt plus completion. | [optional] 
**PromptTokens** | **long** | Tokens sent to the model, cached ones included. | [optional] 
**CompletionTokens** | **long** | Tokens the model generated, reasoning ones included. | [optional] 
**CachedTokens** | **long** | Part of the prompt tokens read from the provider cache. | [optional] 
**CacheWriteTokens** | **long** | Part of the prompt tokens written to the provider cache. | [optional] 
**ReasoningTokens** | **long** | Part of the completion tokens the model spent on reasoning. | [optional] 
**ImageTokens** | **long** | Tokens spent on images. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

