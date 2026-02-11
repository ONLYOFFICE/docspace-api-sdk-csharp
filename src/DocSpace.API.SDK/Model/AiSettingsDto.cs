// (c) Copyright Ascensio System SIA 2025
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

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// AiSettingsDto
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
        /// <param name="webSearchEnabled">webSearchEnabled.</param>
        /// <param name="webSearchNeedReset">webSearchNeedReset.</param>
        /// <param name="vectorizationEnabled">vectorizationEnabled.</param>
        /// <param name="vectorizationNeedReset">vectorizationNeedReset.</param>
        /// <param name="aiReady">aiReady.</param>
        /// <param name="aiReadyNeedReset">aiReadyNeedReset.</param>
        /// <param name="portalMcpServerId">portalMcpServerId.</param>
        /// <param name="embeddingModel">embeddingModel (required).</param>
        /// <param name="knowledgeSearchToolName">knowledgeSearchToolName (required).</param>
        /// <param name="webSearchToolName">webSearchToolName (required).</param>
        /// <param name="webCrawlingToolName">webCrawlingToolName (required).</param>
        public AiSettingsDto(bool webSearchEnabled = default, bool webSearchNeedReset = default, bool vectorizationEnabled = default, bool vectorizationNeedReset = default, bool aiReady = default, bool aiReadyNeedReset = default, Guid? portalMcpServerId = default, string embeddingModel = default, string knowledgeSearchToolName = default, string webSearchToolName = default, string webCrawlingToolName = default)
        {
            // to ensure "embeddingModel" is required (not null)
            if (embeddingModel == null)
            {
                throw new ArgumentNullException("embeddingModel is a required property for AiSettingsDto and cannot be null");
            }
            this.EmbeddingModel = embeddingModel;
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
            this.WebSearchEnabled = webSearchEnabled;
            this.WebSearchNeedReset = webSearchNeedReset;
            this.VectorizationEnabled = vectorizationEnabled;
            this.VectorizationNeedReset = vectorizationNeedReset;
            this.AiReady = aiReady;
            this.AiReadyNeedReset = aiReadyNeedReset;
            this.PortalMcpServerId = portalMcpServerId;
        }

        /// <summary>
        /// Gets or Sets WebSearchEnabled
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "webSearchEnabled", EmitDefaultValue = true)]
        public bool WebSearchEnabled { get; set; }

        /// <summary>
        /// Gets or Sets WebSearchNeedReset
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "webSearchNeedReset", EmitDefaultValue = true)]
        public bool WebSearchNeedReset { get; set; }

        /// <summary>
        /// Gets or Sets VectorizationEnabled
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "vectorizationEnabled", EmitDefaultValue = true)]
        public bool VectorizationEnabled { get; set; }

        /// <summary>
        /// Gets or Sets VectorizationNeedReset
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "vectorizationNeedReset", EmitDefaultValue = true)]
        public bool VectorizationNeedReset { get; set; }

        /// <summary>
        /// Gets or Sets AiReady
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "aiReady", EmitDefaultValue = true)]
        public bool AiReady { get; set; }

        /// <summary>
        /// Gets or Sets AiReadyNeedReset
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "aiReadyNeedReset", EmitDefaultValue = true)]
        public bool AiReadyNeedReset { get; set; }

        /// <summary>
        /// Gets or Sets PortalMcpServerId
        /// </summary>
        /*
        <example>75a5f745-f697-4418-b38d-0fe0d277e258</example>
        */
        [DataMember(Name = "portalMcpServerId", EmitDefaultValue = true)]
        public Guid? PortalMcpServerId { get; set; }

        /// <summary>
        /// Gets or Sets EmbeddingModel
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "embeddingModel", IsRequired = true, EmitDefaultValue = true)]
        public string EmbeddingModel { get; set; }

        /// <summary>
        /// Gets or Sets KnowledgeSearchToolName
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "knowledgeSearchToolName", IsRequired = true, EmitDefaultValue = true)]
        public string KnowledgeSearchToolName { get; set; }

        /// <summary>
        /// Gets or Sets WebSearchToolName
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "webSearchToolName", IsRequired = true, EmitDefaultValue = true)]
        public string WebSearchToolName { get; set; }

        /// <summary>
        /// Gets or Sets WebCrawlingToolName
        /// </summary>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "webCrawlingToolName", IsRequired = true, EmitDefaultValue = true)]
        public string WebCrawlingToolName { get; set; }

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
            sb.Append("  KnowledgeSearchToolName: ").Append(KnowledgeSearchToolName).Append("\n");
            sb.Append("  WebSearchToolName: ").Append(WebSearchToolName).Append("\n");
            sb.Append("  WebCrawlingToolName: ").Append(WebCrawlingToolName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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
