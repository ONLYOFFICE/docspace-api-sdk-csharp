# DocSpace.API.SDK.Model.AiOpenAIFinishReason
OpenAI Chat Completions streaming shapes.   {@link  toOpenAIChatCompletionStream }  maps the engine's transport-agnostic  {@link  ChatEvent }  stream onto these chunks so a host can expose an OpenAI-compatible `POST /v1/chat/completions` (`stream: true`) endpoint backed by the same chat pipeline as the in-app widget. Only the subset of fields the engine can populate is emitted; everything else an OpenAI client tolerates as absent.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

