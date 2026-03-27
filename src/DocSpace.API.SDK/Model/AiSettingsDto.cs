// (c) Copyright Ascensio System SIA 2026
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = DocSpace.API.SDK.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.API.SDK.Client.OpenAPIDateConverter;

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// The AI module settings.
    /// </summary>
    [DataContract(Name = "AiSettingsDto")]
    public partial class AiSettingsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiSettingsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiSettingsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiSettingsDto" /> class.
        /// </summary>
        /// <param name="webSearchEnabled">Indicates whether web search is enabled for AI chat sessions..</param>
        /// <param name="webSearchNeedReset">Indicates whether the web search API key needs to be reconfigured..</param>
        /// <param name="vectorizationEnabled">Indicates whether document vectorization is enabled..</param>
        /// <param name="vectorizationNeedReset">Indicates whether the embedding provider API key needs to be reconfigured..</param>
        /// <param name="aiReady">Indicates whether the AI subsystem is fully configured and operational..</param>
        /// <param name="aiReadyNeedReset">Indicates whether the AI provider API key needs to be reconfigured..</param>
        /// <param name="portalMcpServerId">The unique identifier of the portal-level MCP server, if configured..</param>
        /// <param name="embeddingModel">The name of the embedding model used for document vectorization. (required).</param>
        /// <param name="modelAliases">Mapping of model identifiers to human-readable aliases. (required).</param>
        /// <param name="knowledgeSearchToolName">The tool name used by the AI assistant for knowledge base search. (required).</param>
        /// <param name="webSearchToolName">The tool name used by the AI assistant for web search. (required).</param>
        /// <param name="webCrawlingToolName">The tool name used by the AI assistant for web page crawling. (required).</param>
        /// <param name="generateDocxToolName">The tool name used by the AI to launch docx creation in the editor. (required).</param>
        /// <param name="generateFormToolName">The tool name used by the AI assistant to launch form creation in the editor. (required).</param>
        /// <param name="generatePresentationToolName">The tool name used by the AI assistant to launch presentation creation in the editor. (required).</param>
        /// <param name="systemAiEnabled">Indicates whether the system-level AI provider is enabled..</param>
        public AiSettingsDto(bool webSearchEnabled = default, bool webSearchNeedReset = default, bool vectorizationEnabled = default, bool vectorizationNeedReset = default, bool aiReady = default, bool aiReadyNeedReset = default, Guid? portalMcpServerId = default, string embeddingModel = default, Dictionary<string, string> modelAliases = default, string knowledgeSearchToolName = default, string webSearchToolName = default, string webCrawlingToolName = default, string generateDocxToolName = default, string generateFormToolName = default, string generatePresentationToolName = default, bool systemAiEnabled = default)
        {
            // to ensure "embeddingModel" is required (not null)
            if (embeddingModel == null)
            {
                throw new ArgumentNullException("embeddingModel is a required property for AiSettingsDto and cannot be null");
            }
            this.EmbeddingModel = embeddingModel;
            // to ensure "modelAliases" is required (not null)
            if (modelAliases == null)
            {
                throw new ArgumentNullException("modelAliases is a required property for AiSettingsDto and cannot be null");
            }
            this.ModelAliases = modelAliases;
            // to ensure "knowledgeSearchToolName" is required (not null)
            if (knowledgeSearchToolName == null)
            {
                throw new ArgumentNullException("knowledgeSearchToolName is a required property for AiSettingsDto and cannot be null");
            }
            this.KnowledgeSearchToolName = knowledgeSearchToolName;
            // to ensure "webSearchToolName" is required (not null)
            if (webSearchToolName == null)
            {
                throw new ArgumentNullException("webSearchToolName is a required property for AiSettingsDto and cannot be null");
            }
            this.WebSearchToolName = webSearchToolName;
            // to ensure "webCrawlingToolName" is required (not null)
            if (webCrawlingToolName == null)
            {
                throw new ArgumentNullException("webCrawlingToolName is a required property for AiSettingsDto and cannot be null");
            }
            this.WebCrawlingToolName = webCrawlingToolName;
            // to ensure "generateDocxToolName" is required (not null)
            if (generateDocxToolName == null)
            {
                throw new ArgumentNullException("generateDocxToolName is a required property for AiSettingsDto and cannot be null");
            }
            this.GenerateDocxToolName = generateDocxToolName;
            // to ensure "generateFormToolName" is required (not null)
            if (generateFormToolName == null)
            {
                throw new ArgumentNullException("generateFormToolName is a required property for AiSettingsDto and cannot be null");
            }
            this.GenerateFormToolName = generateFormToolName;
            // to ensure "generatePresentationToolName" is required (not null)
            if (generatePresentationToolName == null)
            {
                throw new ArgumentNullException("generatePresentationToolName is a required property for AiSettingsDto and cannot be null");
            }
            this.GeneratePresentationToolName = generatePresentationToolName;
            this.WebSearchEnabled = webSearchEnabled;
            this.WebSearchNeedReset = webSearchNeedReset;
            this.VectorizationEnabled = vectorizationEnabled;
            this.VectorizationNeedReset = vectorizationNeedReset;
            this.AiReady = aiReady;
            this.AiReadyNeedReset = aiReadyNeedReset;
            this.PortalMcpServerId = portalMcpServerId;
            this.SystemAiEnabled = systemAiEnabled;
        }

        /// <summary>
        /// Indicates whether web search is enabled for AI chat sessions.
        /// </summary>
        /// <value>Indicates whether web search is enabled for AI chat sessions.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "webSearchEnabled", EmitDefaultValue = true)]
        public bool WebSearchEnabled { get; set; }

        /// <summary>
        /// Indicates whether the web search API key needs to be reconfigured.
        /// </summary>
        /// <value>Indicates whether the web search API key needs to be reconfigured.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "webSearchNeedReset", EmitDefaultValue = true)]
        public bool WebSearchNeedReset { get; set; }

        /// <summary>
        /// Indicates whether document vectorization is enabled.
        /// </summary>
        /// <value>Indicates whether document vectorization is enabled.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "vectorizationEnabled", EmitDefaultValue = true)]
        public bool VectorizationEnabled { get; set; }

        /// <summary>
        /// Indicates whether the embedding provider API key needs to be reconfigured.
        /// </summary>
        /// <value>Indicates whether the embedding provider API key needs to be reconfigured.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "vectorizationNeedReset", EmitDefaultValue = true)]
        public bool VectorizationNeedReset { get; set; }

        /// <summary>
        /// Indicates whether the AI subsystem is fully configured and operational.
        /// </summary>
        /// <value>Indicates whether the AI subsystem is fully configured and operational.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "aiReady", EmitDefaultValue = true)]
        public bool AiReady { get; set; }

        /// <summary>
        /// Indicates whether the AI provider API key needs to be reconfigured.
        /// </summary>
        /// <value>Indicates whether the AI provider API key needs to be reconfigured.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "aiReadyNeedReset", EmitDefaultValue = true)]
        public bool AiReadyNeedReset { get; set; }

        /// <summary>
        /// The unique identifier of the portal-level MCP server, if configured.
        /// </summary>
        /// <value>The unique identifier of the portal-level MCP server, if configured.</value>
        /*
        <example>00000000-0000-0000-0000-000000000000</example>
        */
        [DataMember(Name = "portalMcpServerId", EmitDefaultValue = true)]
        public Guid? PortalMcpServerId { get; set; }

        /// <summary>
        /// The name of the embedding model used for document vectorization.
        /// </summary>
        /// <value>The name of the embedding model used for document vectorization.</value>
        /*
        <example>text-embedding-3-small</example>
        */
        [DataMember(Name = "embeddingModel", IsRequired = true, EmitDefaultValue = true)]
        public string EmbeddingModel { get; set; }

        /// <summary>
        /// Mapping of model identifiers to human-readable aliases.
        /// </summary>
        /// <value>Mapping of model identifiers to human-readable aliases.</value>
        /*
        <example>{"gpt-5.2":"GPT-5.2","claude-sonnet-4-20250514":"Claude Sonnet 4"}</example>
        */
        [DataMember(Name = "modelAliases", IsRequired = true, EmitDefaultValue = true)]
        public Dictionary<string, string> ModelAliases { get; set; }

        /// <summary>
        /// The tool name used by the AI assistant for knowledge base search.
        /// </summary>
        /// <value>The tool name used by the AI assistant for knowledge base search.</value>
        /*
        <example>knowledge_search</example>
        */
        [DataMember(Name = "knowledgeSearchToolName", IsRequired = true, EmitDefaultValue = true)]
        public string KnowledgeSearchToolName { get; set; }

        /// <summary>
        /// The tool name used by the AI assistant for web search.
        /// </summary>
        /// <value>The tool name used by the AI assistant for web search.</value>
        /*
        <example>web_search</example>
        */
        [DataMember(Name = "webSearchToolName", IsRequired = true, EmitDefaultValue = true)]
        public string WebSearchToolName { get; set; }

        /// <summary>
        /// The tool name used by the AI assistant for web page crawling.
        /// </summary>
        /// <value>The tool name used by the AI assistant for web page crawling.</value>
        /*
        <example>web_crawling</example>
        */
        [DataMember(Name = "webCrawlingToolName", IsRequired = true, EmitDefaultValue = true)]
        public string WebCrawlingToolName { get; set; }

        /// <summary>
        /// The tool name used by the AI to launch docx creation in the editor.
        /// </summary>
        /// <value>The tool name used by the AI to launch docx creation in the editor.</value>
        /*
        <example>generate_docx</example>
        */
        [DataMember(Name = "generateDocxToolName", IsRequired = true, EmitDefaultValue = true)]
        public string GenerateDocxToolName { get; set; }

        /// <summary>
        /// The tool name used by the AI assistant to launch form creation in the editor.
        /// </summary>
        /// <value>The tool name used by the AI assistant to launch form creation in the editor.</value>
        /*
        <example>generate_form</example>
        */
        [DataMember(Name = "generateFormToolName", IsRequired = true, EmitDefaultValue = true)]
        public string GenerateFormToolName { get; set; }

        /// <summary>
        /// The tool name used by the AI assistant to launch presentation creation in the editor.
        /// </summary>
        /// <value>The tool name used by the AI assistant to launch presentation creation in the editor.</value>
        /*
        <example>generate_presentation</example>
        */
        [DataMember(Name = "generatePresentationToolName", IsRequired = true, EmitDefaultValue = true)]
        public string GeneratePresentationToolName { get; set; }

        /// <summary>
        /// Indicates whether the system-level AI provider is enabled.
        /// </summary>
        /// <value>Indicates whether the system-level AI provider is enabled.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "systemAiEnabled", EmitDefaultValue = true)]
        public bool SystemAiEnabled { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiSettingsDto {\n");
            sb.Append("  WebSearchEnabled: ").Append(WebSearchEnabled).Append("\n");
            sb.Append("  WebSearchNeedReset: ").Append(WebSearchNeedReset).Append("\n");
            sb.Append("  VectorizationEnabled: ").Append(VectorizationEnabled).Append("\n");
            sb.Append("  VectorizationNeedReset: ").Append(VectorizationNeedReset).Append("\n");
            sb.Append("  AiReady: ").Append(AiReady).Append("\n");
            sb.Append("  AiReadyNeedReset: ").Append(AiReadyNeedReset).Append("\n");
            sb.Append("  PortalMcpServerId: ").Append(PortalMcpServerId).Append("\n");
            sb.Append("  EmbeddingModel: ").Append(EmbeddingModel).Append("\n");
            sb.Append("  ModelAliases: ").Append(ModelAliases).Append("\n");
            sb.Append("  KnowledgeSearchToolName: ").Append(KnowledgeSearchToolName).Append("\n");
            sb.Append("  WebSearchToolName: ").Append(WebSearchToolName).Append("\n");
            sb.Append("  WebCrawlingToolName: ").Append(WebCrawlingToolName).Append("\n");
            sb.Append("  GenerateDocxToolName: ").Append(GenerateDocxToolName).Append("\n");
            sb.Append("  GenerateFormToolName: ").Append(GenerateFormToolName).Append("\n");
            sb.Append("  GeneratePresentationToolName: ").Append(GeneratePresentationToolName).Append("\n");
            sb.Append("  SystemAiEnabled: ").Append(SystemAiEnabled).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }

    }


}
