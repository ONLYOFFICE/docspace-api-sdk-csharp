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
    /// Default AI provider information.
    /// </summary>
    [DataContract(Name = "DefaultProviderDto")]
    public partial class DefaultProviderDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultProviderDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DefaultProviderDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultProviderDto" /> class.
        /// </summary>
        /// <param name="providerId">AI provider identifier..</param>
        /// <param name="defaultModel">Default model identifier used with this provider. (required).</param>
        /// <param name="providerTitle">AI provider title..</param>
        public DefaultProviderDto(int providerId = default, string defaultModel = default, string providerTitle = default)
        {
            // to ensure "defaultModel" is required (not null)
            if (defaultModel == null)
            {
                throw new ArgumentNullException("defaultModel is a required property for DefaultProviderDto and cannot be null");
            }
            this.DefaultModel = defaultModel;
            this.ProviderId = providerId;
            this.ProviderTitle = providerTitle;
        }

        /// <summary>
        /// AI provider identifier.
        /// </summary>
        /// <value>AI provider identifier.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "providerId", EmitDefaultValue = false)]
        public int ProviderId { get; set; }

        /// <summary>
        /// Default model identifier used with this provider.
        /// </summary>
        /// <value>Default model identifier used with this provider.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "defaultModel", IsRequired = true, EmitDefaultValue = true)]
        public string DefaultModel { get; set; }

        /// <summary>
        /// AI provider title.
        /// </summary>
        /// <value>AI provider title.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "providerTitle", EmitDefaultValue = true)]
        public string ProviderTitle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DefaultProviderDto {\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  DefaultModel: ").Append(DefaultModel).Append("\n");
            sb.Append("  ProviderTitle: ").Append(ProviderTitle).Append("\n");
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
