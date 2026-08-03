# DocSpace.API.SDK.Model.NewAiChatEvent
Discriminated event emitted by the streaming methods of  {@link  AIEngine } . The engine never invokes user-supplied middleware or callbacks directly — every observable side-effect is encoded as a  {@link  ChatEvent }  so the same stream can be replayed over SSE, WebSocket, or in-process.  Pause point: `tool-call-pending` is the only stop. The UI must execute the tool itself (consulting `autoAllow` to decide between the silent path and the approve dialog) and resume via  {@link  AIEngine.approveToolCall }  or  {@link  AIEngine.denyToolCall } .  Other variants are pure data:  - `message-start` / `message-delta` / `message-end` — assistant   reply lifecycle. - `message-incomplete` — the provider returned an error or   incomplete status. - `thread-title` — auto-generated title ready for a new thread.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Emitted once per `sendWithStream` call, immediately after the user message has been persisted by storage and before the assistant stream starts. Carries the storage-assigned `id` and `createdAt`. The UI uses it to render the user bubble — no client-side optimistic placeholder is needed, which keeps the runtime tree free of phantom nodes from index-fallback ids. | 
**Message** | [**NewAiThreadMessageLike**](NewAiThreadMessageLike.md) |  | [optional] 
**MessageId** | **string** |  | [optional] 
**Idx** | **decimal** |  | [optional] 
**ThreadId** | **string** |  | [optional] 
**AutoAllow** | **bool** | The consumer should execute the tool without prompting the user. True when the tool is in the persisted always-allow list, or the tool itself opts in via `TMCPItem.requireApproval === false` (host tools default to this). For a client-side tool with a server-side engine, this lets the engine return the pending call already flagged auto-allow so the client runs it and streams the result back without a dialog round-trip. | [optional] 
**ServerExecuted** | **bool** | Set when the tool is served by a server-side system source: the consumer must NOT execute it locally — only show the approval UI (unless `autoAllow`) and resume via `approveToolCall` (no `result` needed) / `denyToolCall`. The engine runs it in-engine. | [optional] 
**Title** | **string** |  | [optional] 
**ProfileId** | **string** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

