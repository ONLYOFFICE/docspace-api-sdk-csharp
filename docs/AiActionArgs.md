# DocSpace.API.SDK.Model.AiActionArgs
Per-request options of an AI round: extra tools, the depth of reasoning, a system prompt override and the rooms and folder connected as context.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Tools** | [**List&lt;AiMCPItem&gt;**](AiMCPItem.md) | Extra tools offered to the model for this request. | [optional] 
**IsReasoning** | **bool** | Legacy extended-thinking switch; stands for `medium`. `reasoningLevel` wins when both are set. | [optional] 
**ReasoningLevel** | **AiReasoningLevel** | Depth of extended thinking for the round; providers clamp it to what the model accepts. | [optional] 
**Prompt** | [**AiActionArgsPrompt**](AiActionArgsPrompt.md) |  | [optional] 
**ToolInstructions** | **Dictionary&lt;string, string&gt;** | Usage notes of the MCP servers the caller holds the connection to, keyed by server type; folded into the system prompt as advisory text. | [optional] 
**ContextRooms** | [**List&lt;AiContextRoomRef&gt;**](AiContextRoomRef.md) | Instructions rooms connected to the chat as context, each with the skills the round may use. | [optional] 
**KnowledgeRooms** | [**List&lt;AiKnowledgeRoomRef&gt;**](AiKnowledgeRoomRef.md) | Knowledge rooms connected to the chat; the knowledge search tool of the round is limited to them. Each `id` has to be a DocSpace room id. | [optional] 
**KnowledgeRoom** | [**AiKnowledgeRoomRef**](AiKnowledgeRoomRef.md) | A single knowledge room, as an older client sends it. Read only when `knowledgeRooms` is absent; send `knowledgeRooms` instead. | [optional] 
**FolderContext** | [**AiFolderContextRef**](AiFolderContextRef.md) | The folder connected to the chat as the round's context. It becomes the location the model is told the user works in, and the entry the round is attributed to. | [optional] 
**EntityId** | **string** | The entry the round is attributed to. A hint, resolved against the caller's own access. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

