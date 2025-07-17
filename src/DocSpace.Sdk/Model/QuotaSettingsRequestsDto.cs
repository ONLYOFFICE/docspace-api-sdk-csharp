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
    /// The request parameters for managing the user storage quota configurations.
    /// </summary>
    [DataContract(Name = "QuotaSettingsRequestsDto")]
    public partial class QuotaSettingsRequestsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaSettingsRequestsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected QuotaSettingsRequestsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="QuotaSettingsRequestsDto" /> class.
        /// </summary>
        /// <param name="enableQuota">Specifies whether the storage quota restrictions are enabled..</param>
        /// <param name="defaultQuota">defaultQuota (required).</param>
        public QuotaSettingsRequestsDto(bool enableQuota = default, QuotaSettingsRequestsDtoDefaultQuota defaultQuota = default)
        {
            // to ensure "defaultQuota" is required (not null)
            if (defaultQuota == null)
            {
                throw new ArgumentNullException("defaultQuota is a required property for QuotaSettingsRequestsDto and cannot be null");
            }
            this.DefaultQuota = defaultQuota;
            this.EnableQuota = enableQuota;
        }

        /// <summary>
        /// Specifies whether the storage quota restrictions are enabled.
        /// </summary>
        /// <value>Specifies whether the storage quota restrictions are enabled.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "enableQuota", EmitDefaultValue = true)]
        public bool EnableQuota { get; set; }

        /// <summary>
        /// Gets or Sets DefaultQuota
        /// </summary>
        [DataMember(Name = "defaultQuota", IsRequired = true, EmitDefaultValue = true)]
        public QuotaSettingsRequestsDtoDefaultQuota DefaultQuota { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QuotaSettingsRequestsDto {\n");
            sb.Append("  EnableQuota: ").Append(EnableQuota).Append("\n");
            sb.Append("  DefaultQuota: ").Append(DefaultQuota).Append("\n");
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
