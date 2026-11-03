# DocSpace.API.SDK.Model.AiThreadMessageLikeContentAnyOfInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Part kind: `text`, `reasoning`, `source`, `image`, `file`, `audio`, `data` or `tool-call`. | 
**Text** | **string** | The text of a `text` or `reasoning` part. | [optional] 
**ParentId** | **string** | Id of the part this one belongs to, on `text`, `reasoning`, `source` and `tool-call` parts. On a `reasoning` part the chat library keeps the provider's thinking signature here. | [optional] 
**SourceType** | **string** | A `source` part's source kind; always `url`. | [optional] 
**Id** | **string** | A `source` part's id. | [optional] 
**Url** | **string** | A `source` part's URL. | [optional] 
**Title** | **string** | A `source` part's title. | [optional] 
**Image** | **string** | An `image` part's picture, as a URL (usually a `data:` URL). For an image the user attached, a JSON string `{ ref, title, kind: image }` naming the stored attachment instead. | [optional] 
**MimeType** | **string** | A `file` part's media type. For a file the user attached, a JSON string `{ ref, title, kind: file, path, type }` naming the stored attachment instead - the chat library carries the reference here. | [optional] 
**Data** | **string** | A `file` part's content; empty when the part references an attachment. (A `data` part would carry its payload here too, as any JSON value; neither the chat library nor this service writes one.) | [optional] 
**Filename** | **string** | The file name of a `file` or `image` part. | [optional] 
**Name** | **string** | An `image` part's display name, or a `data` part's name. | [optional] 
**Audio** | [**AiThreadMessageLikeContentAnyOfInnerAudio**](AiThreadMessageLikeContentAnyOfInnerAudio.md) |  | [optional] 
**ToolCallId** | **string** | A `tool-call` part's call id. | [optional] 
**ToolName** | **string** | A `tool-call` part's tool name. | [optional] 
**Args** | **Object** | A `tool-call` part's arguments. | [optional] 
**ArgsText** | **string** | A `tool-call` part's arguments as the model streamed them, JSON text. | [optional] 
**Result** | **Object** |  | [optional] 
**IsError** | **bool** | Whether a `tool-call` part's result is an error. | [optional] 
**Artifact** | **Object** |  | [optional] 
**Interrupt** | [**AiThreadMessageLikeContentAnyOfInnerInterrupt**](AiThreadMessageLikeContentAnyOfInnerInterrupt.md) |  | [optional] 
**Messages** | **List&lt;Object&gt;** | Messages of a sub-agent run inside a `tool-call` part. | [optional] 
**Metadata** | **Object** | Provider-specific data of a `tool-call` part - for a Gemini call, `{ thoughtSignature }`, which has to be sent back with the call. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

