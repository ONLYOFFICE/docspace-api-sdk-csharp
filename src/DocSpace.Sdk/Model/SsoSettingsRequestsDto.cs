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
    /// The request parameters for the Single Sign-On (SSO) configuration settings.
    /// </summary>
    [DataContract(Name = "SsoSettingsRequestsDto")]
    public partial class SsoSettingsRequestsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SsoSettingsRequestsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SsoSettingsRequestsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SsoSettingsRequestsDto" /> class.
        /// </summary>
        /// <param name="serializeSettings">The JSON-serialized SSO configuration settings. (required).</param>
        public SsoSettingsRequestsDto(string serializeSettings = default)
        {
            // to ensure "serializeSettings" is required (not null)
            if (serializeSettings == null)
            {
                throw new ArgumentNullException("serializeSettings is a required property for SsoSettingsRequestsDto and cannot be null");
            }
            this.SerializeSettings = serializeSettings;
        }

        /// <summary>
        /// The JSON-serialized SSO configuration settings.
        /// </summary>
        /// <value>The JSON-serialized SSO configuration settings.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "serializeSettings", IsRequired = true, EmitDefaultValue = true)]
        public string SerializeSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SsoSettingsRequestsDto {\n");
            sb.Append("  SerializeSettings: ").Append(SerializeSettings).Append("\n");
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
