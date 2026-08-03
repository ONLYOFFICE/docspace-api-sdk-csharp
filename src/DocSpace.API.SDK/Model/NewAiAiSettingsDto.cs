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
    [DataContract(Name = "NewAiAiSettingsDto")]
    public partial class NewAiAiSettingsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiAiSettingsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewAiAiSettingsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewAiAiSettingsDto" /> class.
        /// </summary>
        /// <param name="vectorizationEnabled">Indicates whether document vectorization is enabled..</param>
        /// <param name="vectorizationNeedReset">Indicates whether the embedding provider API key needs to be reconfigured..</param>
        /// <param name="aiReady">Indicates whether the AI subsystem is fully configured and operational..</param>
        /// <param name="embeddingModel">The name of the embedding model used for document vectorization. (required).</param>
        /// <param name="systemAiEnabled">Indicates whether the system-level AI provider is enabled..</param>
        /// <param name="recommendedModelForForms">The identifier of the model recommended for form generation..</param>
        public NewAiAiSettingsDto(bool vectorizationEnabled = default, bool vectorizationNeedReset = default, bool aiReady = default, string embeddingModel = default, bool systemAiEnabled = default, string recommendedModelForForms = default)
        {
            // to ensure "embeddingModel" is required (not null)
            if (embeddingModel == null)
            {
                throw new ArgumentNullException("embeddingModel is a required property for NewAiAiSettingsDto and cannot be null");
            }
            this.EmbeddingModel = embeddingModel;
            this.VectorizationEnabled = vectorizationEnabled;
            this.VectorizationNeedReset = vectorizationNeedReset;
            this.AiReady = aiReady;
            this.SystemAiEnabled = systemAiEnabled;
            this.RecommendedModelForForms = recommendedModelForForms;
        }

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
        /// The name of the embedding model used for document vectorization.
        /// </summary>
        /// <value>The name of the embedding model used for document vectorization.</value>
        /*
        <example>text-embedding-3-small</example>
        */
        [DataMember(Name = "embeddingModel", IsRequired = true, EmitDefaultValue = true)]
        public string EmbeddingModel { get; set; }

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
        /// The identifier of the model recommended for form generation.
        /// </summary>
        /// <value>The identifier of the model recommended for form generation.</value>
        /*
        <example>gpt-5.4</example>
        */
        [DataMember(Name = "recommendedModelForForms", EmitDefaultValue = true)]
        public string RecommendedModelForForms { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewAiAiSettingsDto {\n");
            sb.Append("  VectorizationEnabled: ").Append(VectorizationEnabled).Append("\n");
            sb.Append("  VectorizationNeedReset: ").Append(VectorizationNeedReset).Append("\n");
            sb.Append("  AiReady: ").Append(AiReady).Append("\n");
            sb.Append("  EmbeddingModel: ").Append(EmbeddingModel).Append("\n");
            sb.Append("  SystemAiEnabled: ").Append(SystemAiEnabled).Append("\n");
            sb.Append("  RecommendedModelForForms: ").Append(RecommendedModelForForms).Append("\n");
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
