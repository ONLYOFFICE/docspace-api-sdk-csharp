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
    /// A single model settings entry within a provider create or update request.
    /// </summary>
    [DataContract(Name = "ModelSettingsItemDto")]
    public partial class ModelSettingsItemDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelSettingsItemDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ModelSettingsItemDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelSettingsItemDto" /> class.
        /// </summary>
        /// <param name="modelId">The model identifier. (required).</param>
        /// <param name="isEnabled">Whether the model is enabled for use in chat..</param>
        /// <param name="alias">The display name for the model. Only applies to non-recommended models..</param>
        /// <param name="capabilities">capabilities.</param>
        public ModelSettingsItemDto(string modelId = default, bool isEnabled = default, string alias = default, AiModelCapabilities capabilities = default)
        {
            // to ensure "modelId" is required (not null)
            if (modelId == null)
            {
                throw new ArgumentNullException("modelId is a required property for ModelSettingsItemDto and cannot be null");
            }
            this.ModelId = modelId;
            this.IsEnabled = isEnabled;
            this.Alias = alias;
            this.Capabilities = capabilities;
        }

        /// <summary>
        /// The model identifier.
        /// </summary>
        /// <value>The model identifier.</value>
        /*
        <example>claude-opus-4-1-20250805</example>
        */
        [DataMember(Name = "modelId", IsRequired = true, EmitDefaultValue = true)]
        public string ModelId { get; set; }

        /// <summary>
        /// Whether the model is enabled for use in chat.
        /// </summary>
        /// <value>Whether the model is enabled for use in chat.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isEnabled", EmitDefaultValue = true)]
        public bool IsEnabled { get; set; }

        /// <summary>
        /// The display name for the model. Only applies to non-recommended models.
        /// </summary>
        /// <value>The display name for the model. Only applies to non-recommended models.</value>
        /*
        <example>Claude Opus 4.1</example>
        */
        [DataMember(Name = "alias", EmitDefaultValue = true)]
        public string Alias { get; set; }

        /// <summary>
        /// Gets or Sets Capabilities
        /// </summary>
        [DataMember(Name = "capabilities", EmitDefaultValue = false)]
        public AiModelCapabilities Capabilities { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelSettingsItemDto {\n");
            sb.Append("  ModelId: ").Append(ModelId).Append("\n");
            sb.Append("  IsEnabled: ").Append(IsEnabled).Append("\n");
            sb.Append("  Alias: ").Append(Alias).Append("\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
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
            // ModelId (string) maxLength
            if (this.ModelId != null && this.ModelId.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ModelId, length must be less than 255.", new [] { "ModelId" });
            }

            // ModelId (string) minLength
            if (this.ModelId != null && this.ModelId.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ModelId, length must be greater than 1.", new [] { "ModelId" });
            }

            // Alias (string) maxLength
            if (this.Alias != null && this.Alias.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Alias, length must be less than 255.", new [] { "Alias" });
            }

            yield break;
        }

    }


}
