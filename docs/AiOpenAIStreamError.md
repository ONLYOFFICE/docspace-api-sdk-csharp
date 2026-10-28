# DocSpace.API.SDK.Model.AiOpenAIStreamError
OpenAI streaming error envelope. When the upstream request fails mid-stream the OpenAI API emits a single `data:` line carrying an `error` object (no `choices`), then closes the stream — the official SDK turns this into a thrown `APIError`. Mirrors that shape so a host exposing an OpenAI-compatible endpoint stays wire-compatible.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Error** | [**AiOpenAIStreamErrorError**](AiOpenAIStreamErrorError.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

