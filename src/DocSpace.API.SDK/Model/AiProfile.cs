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
    /// Complete AI provider + model configuration saved by the user. Profiles are the primary way users save and reuse provider configurations.
    /// </summary>
    [DataContract(Name = "AiProfile")]
    public partial class AiProfile : IValidatableObject
    {

        /// <summary>
        /// Selects the response-format parser used by the &#x60;external&#x60; provider. Ignored for any other &#x60;providerType&#x60;.  Supported values are &#x60;openai&#x60;, &#x60;anthropic&#x60;, &#x60;mistral&#x60; and &#x60;openrouter&#x60;. Remaining values (&#x60;genai&#x60;, &#x60;stabilityai&#x60;, …) are accepted by the type but not yet implemented; passing one raises an error at request time.
        /// </summary>
        [DataMember(Name = "basedOn", EmitDefaultValue = false)]
        public AiBuiltinProviderType? BasedOn { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AiProfile" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AiProfile() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AiProfile" /> class.
        /// </summary>
        /// <param name="id">Unique profile identifier (UUID). (required).</param>
        /// <param name="name">User-defined profile display name. (required).</param>
        /// <param name="providerType">Provider type for this profile. Use &#x60;external&#x60; to delegate all HTTP transport to &#x60;PlatformAdapter.externalFetch&#x60; while reusing an existing provider&#39;s response parser — see &#x60;Profile.basedOn&#x60; for the format selector. (required).</param>
        /// <param name="basedOn">Selects the response-format parser used by the &#x60;external&#x60; provider. Ignored for any other &#x60;providerType&#x60;.  Supported values are &#x60;openai&#x60;, &#x60;anthropic&#x60;, &#x60;mistral&#x60; and &#x60;openrouter&#x60;. Remaining values (&#x60;genai&#x60;, &#x60;stabilityai&#x60;, …) are accepted by the type but not yet implemented; passing one raises an error at request time..</param>
        /// <param name="baseUrl">Base URL of the provider API. (required).</param>
        /// <param name="key">API key or token. Optional for local providers..</param>
        /// <param name="headers">Extra HTTP headers sent with every request to this provider. Merged into the SDK client&#39;s default headers; an explicit &#x60;Authorization&#x60; here wins over the one derived from &#x60;key&#x60;. Honoured by the OpenAI-family providers..</param>
        /// <param name="modelId">Selected model ID within this provider. (required).</param>
        /// <param name="reasoning">Whether extended thinking is enabled for this profile&#39;s model..</param>
        /// <param name="capabilities">Bitmask of capabilities supported by the selected model..</param>
        /// <param name="canUseTool">Result of the live tool-capability probe performed at create time and on changes to &#x60;modelId&#x60; / &#x60;providerType&#x60; / &#x60;baseUrl&#x60;. &#x60;undefined&#x60; means the probe has never run for this profile (legacy record)..</param>
        /// <param name="useResponsesApi">Result of the live Responses-API probe (parallel to &#x60;canUseTool&#x60;). &#x60;true&#x60; means the model speaks &#x60;/v1/responses&#x60; and the OpenAI provider must route through &#x60;client.responses.create&#x60; — required for gpt-5+ reasoning models that reject &#x60;reasoning_effort&#x60; together with &#x60;tools&#x60; on &#x60;/v1/chat/completions&#x60;. Probed at create time and whenever &#x60;modelId&#x60; / &#x60;providerType&#x60; / &#x60;baseUrl&#x60; change. &#x60;undefined&#x60; means the probe never ran (legacy record) — readers treat that as &#x60;false&#x60;..</param>
        /// <param name="isCloudProvider">Whether this profile uses a cloud-hosted provider (e.g. ONLYOFFICE DocSpace)..</param>
        /// <param name="useProxy">Route every provider request through the host&#39;s &#x60;fetchProxy&#x60; instead of the global &#x60;fetch&#x60;. Useful when the host runs the widget in a sandbox without direct network access (CORS, custom auth, etc.). Has no effect when the &#x60;PlatformAdapter.fetchProxy&#x60; is not configured..</param>
        /// <param name="createdAt">Creation timestamp (ms since epoch). Used to sort the AI models list newest-first..</param>
        public AiProfile(string id = default, string name = default, AiProviderType providerType = default, AiBuiltinProviderType? basedOn = default, string baseUrl = default, string key = default, Dictionary<string, string> headers = default, string modelId = default, bool reasoning = default, decimal capabilities = default, bool canUseTool = default, bool useResponsesApi = default, bool isCloudProvider = default, bool useProxy = default, decimal createdAt = default)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for AiProfile and cannot be null");
            }
            this.Id = id;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AiProfile and cannot be null");
            }
            this.Name = name;
            // to ensure "providerType" is required (not null)
            if (providerType == null)
            {
                throw new ArgumentNullException("providerType is a required property for AiProfile and cannot be null");
            }
            this.ProviderType = providerType;
            // to ensure "baseUrl" is required (not null)
            if (baseUrl == null)
            {
                throw new ArgumentNullException("baseUrl is a required property for AiProfile and cannot be null");
            }
            this.BaseUrl = baseUrl;
            // to ensure "modelId" is required (not null)
            if (modelId == null)
            {
                throw new ArgumentNullException("modelId is a required property for AiProfile and cannot be null");
            }
            this.ModelId = modelId;
            this.BasedOn = basedOn;
            this.Key = key;
            this.Headers = headers;
            this.Reasoning = reasoning;
            this.Capabilities = capabilities;
            this.CanUseTool = canUseTool;
            this.UseResponsesApi = useResponsesApi;
            this.IsCloudProvider = isCloudProvider;
            this.UseProxy = useProxy;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Unique profile identifier (UUID).
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// User-defined profile display name.
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Provider type for this profile. Use &#x60;external&#x60; to delegate all HTTP transport to &#x60;PlatformAdapter.externalFetch&#x60; while reusing an existing provider&#39;s response parser — see &#x60;Profile.basedOn&#x60; for the format selector.
        /// </summary>
        [DataMember(Name = "providerType", IsRequired = true, EmitDefaultValue = true)]
        public AiProviderType ProviderType { get; set; }

        /// <summary>
        /// Base URL of the provider API.
        /// </summary>
        [DataMember(Name = "baseUrl", IsRequired = true, EmitDefaultValue = true)]
        public string BaseUrl { get; set; }

        /// <summary>
        /// API key or token. Optional for local providers.
        /// </summary>
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Extra HTTP headers sent with every request to this provider. Merged into the SDK client&#39;s default headers; an explicit &#x60;Authorization&#x60; here wins over the one derived from &#x60;key&#x60;. Honoured by the OpenAI-family providers.
        /// </summary>
        [DataMember(Name = "headers", EmitDefaultValue = false)]
        public Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// Selected model ID within this provider.
        /// </summary>
        [DataMember(Name = "modelId", IsRequired = true, EmitDefaultValue = true)]
        public string ModelId { get; set; }

        /// <summary>
        /// Whether extended thinking is enabled for this profile&#39;s model.
        /// </summary>
        [DataMember(Name = "reasoning", EmitDefaultValue = true)]
        public bool Reasoning { get; set; }

        /// <summary>
        /// Bitmask of capabilities supported by the selected model.
        /// </summary>
        [DataMember(Name = "capabilities", EmitDefaultValue = false)]
        public decimal Capabilities { get; set; }

        /// <summary>
        /// Result of the live tool-capability probe performed at create time and on changes to &#x60;modelId&#x60; / &#x60;providerType&#x60; / &#x60;baseUrl&#x60;. &#x60;undefined&#x60; means the probe has never run for this profile (legacy record).
        /// </summary>
        [DataMember(Name = "canUseTool", EmitDefaultValue = true)]
        public bool CanUseTool { get; set; }

        /// <summary>
        /// Result of the live Responses-API probe (parallel to &#x60;canUseTool&#x60;). &#x60;true&#x60; means the model speaks &#x60;/v1/responses&#x60; and the OpenAI provider must route through &#x60;client.responses.create&#x60; — required for gpt-5+ reasoning models that reject &#x60;reasoning_effort&#x60; together with &#x60;tools&#x60; on &#x60;/v1/chat/completions&#x60;. Probed at create time and whenever &#x60;modelId&#x60; / &#x60;providerType&#x60; / &#x60;baseUrl&#x60; change. &#x60;undefined&#x60; means the probe never ran (legacy record) — readers treat that as &#x60;false&#x60;.
        /// </summary>
        [DataMember(Name = "useResponsesApi", EmitDefaultValue = true)]
        public bool UseResponsesApi { get; set; }

        /// <summary>
        /// Whether this profile uses a cloud-hosted provider (e.g. ONLYOFFICE DocSpace).
        /// </summary>
        [DataMember(Name = "isCloudProvider", EmitDefaultValue = true)]
        public bool IsCloudProvider { get; set; }

        /// <summary>
        /// Route every provider request through the host&#39;s &#x60;fetchProxy&#x60; instead of the global &#x60;fetch&#x60;. Useful when the host runs the widget in a sandbox without direct network access (CORS, custom auth, etc.). Has no effect when the &#x60;PlatformAdapter.fetchProxy&#x60; is not configured.
        /// </summary>
        [DataMember(Name = "useProxy", EmitDefaultValue = true)]
        public bool UseProxy { get; set; }

        /// <summary>
        /// Creation timestamp (ms since epoch). Used to sort the AI models list newest-first.
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public decimal CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AiProfile {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ProviderType: ").Append(ProviderType).Append("\n");
            sb.Append("  BasedOn: ").Append(BasedOn).Append("\n");
            sb.Append("  BaseUrl: ").Append(BaseUrl).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  ModelId: ").Append(ModelId).Append("\n");
            sb.Append("  Reasoning: ").Append(Reasoning).Append("\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
            sb.Append("  CanUseTool: ").Append(CanUseTool).Append("\n");
            sb.Append("  UseResponsesApi: ").Append(UseResponsesApi).Append("\n");
            sb.Append("  IsCloudProvider: ").Append(IsCloudProvider).Append("\n");
            sb.Append("  UseProxy: ").Append(UseProxy).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
