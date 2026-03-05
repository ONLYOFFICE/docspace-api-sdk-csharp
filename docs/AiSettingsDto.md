# DocSpace.API.SDK.Model.AiSettingsDto
The AI module settings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WebSearchEnabled** | **bool** | Indicates whether web search is enabled for AI chat sessions. | [optional] 
**WebSearchNeedReset** | **bool** | Indicates whether the web search API key needs to be reconfigured. | [optional] 
**VectorizationEnabled** | **bool** | Indicates whether document vectorization is enabled. | [optional] 
**VectorizationNeedReset** | **bool** | Indicates whether the embedding provider API key needs to be reconfigured. | [optional] 
**AiReady** | **bool** | Indicates whether the AI subsystem is fully configured and operational. | [optional] 
**AiReadyNeedReset** | **bool** | Indicates whether the AI provider API key needs to be reconfigured. | [optional] 
**PortalMcpServerId** | **Guid?** | The unique identifier of the portal-level MCP server, if configured. | [optional] 
**EmbeddingModel** | **string** | The name of the embedding model used for document vectorization. | 
**ModelAliases** | **Dictionary&lt;string, string&gt;** | Mapping of model identifiers to human-readable aliases. | 
**KnowledgeSearchToolName** | **string** | The tool name used by the AI assistant for knowledge base search. | 
**WebSearchToolName** | **string** | The tool name used by the AI assistant for web search. | 
**WebCrawlingToolName** | **string** | The tool name used by the AI assistant for web page crawling. | 
**GenerateDocxToolName** | **string** | The tool name used by the AI to launch docx creation in the editor. | 
**GenerateFormToolName** | **string** | The tool name used by the AI assistant to launch form creation in the editor. | 
**GeneratePresentationToolName** | **string** | The tool name used by the AI assistant to launch presentation creation in the editor. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

