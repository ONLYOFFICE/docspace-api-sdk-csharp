# DocSpace.API.SDK.Model.AiThreadMessageLikeContent
Message content: either plain text or a list of typed content parts. One part schema lists every field of every part kind of the `@assistant-ui/react` 0.11 `ThreadMessageLike` union (text, reasoning, source, image, file, audio, data, tool-call) plus what the chat library adds itself (`name` on an image part, `metadata` on a tool-call part), so a strict client can read any stored part; each field says which kinds carry it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

