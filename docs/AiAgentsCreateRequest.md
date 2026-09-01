# DocSpace.API.SDK.Model.AiAgentsCreateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ProfileId** | **string** | Profile id bound to the agent. | 
**Prompt** | **string** | Agent system prompt; stored as the room's `chatSettings.prompt`. | 
**Private** | **bool** | Whether the agent room is private. | [optional] 
**Share** | **List&lt;Object&gt;** | Initial share entries (`FileShareParams`). | [optional] 
**AttachDefaultTools** | **bool** | Whether to attach the default DocSpace MCP tool server. | [optional] 
**Title** | **string** | Agent (room) title. | [optional] 
**Quota** | **decimal** | Room quota in bytes. | [optional] 
**Indexing** | **bool** | Whether room content is indexed for search. | [optional] 
**DenyDownload** | **bool** | Whether downloading room content is denied. | [optional] 
**Lifetime** | **Object** | Room data lifetime policy (`RoomDataLifetimeDto`). | [optional] 
**Watermark** | **Object** | Watermark settings (`WatermarkRequestDto`). | [optional] 
**Logo** | **Object** | Room logo (`LogoRequest`). | [optional] 
**Tags** | **List&lt;string&gt;** | Room tags. | [optional] 
**Color** | **string** | Room accent color. | [optional] 
**Cover** | **string** | Room cover image id. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

