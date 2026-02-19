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
    /// Parameters for configuring the embedding provider.
    /// </summary>
    [DataContract(Name = "SetEmbeddingConfigRequestBody")]
    public partial class SetEmbeddingConfigRequestBody : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public EmbeddingProviderType? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SetEmbeddingConfigRequestBody" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="key">The API key for the selected embedding provider. Pass null to keep the existing key unchanged..</param>
        public SetEmbeddingConfigRequestBody(EmbeddingProviderType? type = default, string key = default)
        {
            this.Type = type;
            this.Key = key;
        }

        /// <summary>
        /// The API key for the selected embedding provider. Pass null to keep the existing key unchanged.
        /// </summary>
        /// <value>The API key for the selected embedding provider. Pass null to keep the existing key unchanged.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "key", EmitDefaultValue = false)]
        public string Key { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SetEmbeddingConfigRequestBody {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
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
