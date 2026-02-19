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
    /// Request parameters for setting the default AI provider.
    /// </summary>
    [DataContract(Name = "SetDefaultProviderRequestDto")]
    public partial class SetDefaultProviderRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SetDefaultProviderRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SetDefaultProviderRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SetDefaultProviderRequestDto" /> class.
        /// </summary>
        /// <param name="providerId">AI provider identifier..</param>
        /// <param name="defaultModel">Default model identifier to use with this provider. (required).</param>
        public SetDefaultProviderRequestDto(int providerId = default, string defaultModel = default)
        {
            // to ensure "defaultModel" is required (not null)
            if (defaultModel == null)
            {
                throw new ArgumentNullException("defaultModel is a required property for SetDefaultProviderRequestDto and cannot be null");
            }
            this.DefaultModel = defaultModel;
            this.ProviderId = providerId;
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
        /// Default model identifier to use with this provider.
        /// </summary>
        /// <value>Default model identifier to use with this provider.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "defaultModel", IsRequired = true, EmitDefaultValue = true)]
        public string DefaultModel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetDefaultProviderRequestDto {\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  DefaultModel: ").Append(DefaultModel).Append("\n");
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
            // DefaultModel (string) maxLength
            if (this.DefaultModel != null && this.DefaultModel.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DefaultModel, length must be less than 255.", new [] { "DefaultModel" });
            }

            yield break;
        }

    }


}
