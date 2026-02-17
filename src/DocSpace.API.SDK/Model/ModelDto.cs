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
    /// ModelDto
    /// </summary>
    [DataContract(Name = "ModelDto")]
    public partial class ModelDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ModelDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelDto" /> class.
        /// </summary>
        /// <param name="providerId">The unique identifier of the AI provider that offers this model..</param>
        /// <param name="providerTitle">The human-readable display name of the AI provider (e.g., OpenAI, Anthropic). (required).</param>
        /// <param name="modelId">The model identifier as recognized by the AI provider (e.g., gpt-4o, claude-sonnet-4-20250514). (required).</param>
        public ModelDto(int providerId = default, string providerTitle = default, string modelId = default)
        {
            // to ensure "providerTitle" is required (not null)
            if (providerTitle == null)
            {
                throw new ArgumentNullException("providerTitle is a required property for ModelDto and cannot be null");
            }
            this.ProviderTitle = providerTitle;
            // to ensure "modelId" is required (not null)
            if (modelId == null)
            {
                throw new ArgumentNullException("modelId is a required property for ModelDto and cannot be null");
            }
            this.ModelId = modelId;
            this.ProviderId = providerId;
        }

        /// <summary>
        /// The unique identifier of the AI provider that offers this model.
        /// </summary>
        /// <value>The unique identifier of the AI provider that offers this model.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "providerId", EmitDefaultValue = false)]
        public int ProviderId { get; set; }

        /// <summary>
        /// The human-readable display name of the AI provider (e.g., OpenAI, Anthropic).
        /// </summary>
        /// <value>The human-readable display name of the AI provider (e.g., OpenAI, Anthropic).</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "providerTitle", IsRequired = true, EmitDefaultValue = true)]
        public string ProviderTitle { get; set; }

        /// <summary>
        /// The model identifier as recognized by the AI provider (e.g., gpt-4o, claude-sonnet-4-20250514).
        /// </summary>
        /// <value>The model identifier as recognized by the AI provider (e.g., gpt-4o, claude-sonnet-4-20250514).</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "modelId", IsRequired = true, EmitDefaultValue = true)]
        public string ModelId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelDto {\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  ProviderTitle: ").Append(ProviderTitle).Append("\n");
            sb.Append("  ModelId: ").Append(ModelId).Append("\n");
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
