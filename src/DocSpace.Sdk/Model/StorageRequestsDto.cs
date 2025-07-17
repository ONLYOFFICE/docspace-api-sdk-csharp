/**
 *
 * (c) Copyright Ascensio System SIA 2025
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The request parameters for configuring the storage module settings.
    /// </summary>
    [DataContract(Name = "StorageRequestsDto")]
    public partial class StorageRequestsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageRequestsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StorageRequestsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StorageRequestsDto" /> class.
        /// </summary>
        /// <param name="module">The name for the storage module to be configured. (required).</param>
        /// <param name="props">The list of configuration key-value pairs for the storage module..</param>
        public StorageRequestsDto(string module = default, List<ItemKeyValuePairStringString> props = default)
        {
            // to ensure "module" is required (not null)
            if (module == null)
            {
                throw new ArgumentNullException("module is a required property for StorageRequestsDto and cannot be null");
            }
            this.Module = module;
            this.Props = props;
        }

        /// <summary>
        /// The name for the storage module to be configured.
        /// </summary>
        /// <value>The name for the storage module to be configured.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "module", IsRequired = true, EmitDefaultValue = true)]
        public string Module { get; set; }

        /// <summary>
        /// The list of configuration key-value pairs for the storage module.
        /// </summary>
        /// <value>The list of configuration key-value pairs for the storage module.</value>
        [DataMember(Name = "props", EmitDefaultValue = true)]
        public List<ItemKeyValuePairStringString> Props { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StorageRequestsDto {\n");
            sb.Append("  Module: ").Append(Module).Append("\n");
            sb.Append("  Props: ").Append(Props).Append("\n");
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
