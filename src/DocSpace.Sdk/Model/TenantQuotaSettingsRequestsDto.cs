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


 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The request parameters for managing the tenant storage quota settings in a multi-tenant system.
    /// </summary>
    [DataContract(Name = "TenantQuotaSettingsRequestsDto")]
    public partial class TenantQuotaSettingsRequestsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantQuotaSettingsRequestsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TenantQuotaSettingsRequestsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantQuotaSettingsRequestsDto" /> class.
        /// </summary>
        /// <param name="tenantId">The ID of the tenant whose quota is being configured. (required).</param>
        /// <param name="quota">The storage quota limit in bytes allocated to the tenant..</param>
        public TenantQuotaSettingsRequestsDto(int tenantId = default, long quota = default)
        {
            this.TenantId = tenantId;
            this.Quota = quota;
        }

        /// <summary>
        /// The ID of the tenant whose quota is being configured.
        /// </summary>
        /// <value>The ID of the tenant whose quota is being configured.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "tenantId", IsRequired = true, EmitDefaultValue = true)]
        public int TenantId { get; set; }

        /// <summary>
        /// The storage quota limit in bytes allocated to the tenant.
        /// </summary>
        /// <value>The storage quota limit in bytes allocated to the tenant.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "quota", EmitDefaultValue = false)]
        public long Quota { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenantQuotaSettingsRequestsDto {\n");
            sb.Append("  TenantId: ").Append(TenantId).Append("\n");
            sb.Append("  Quota: ").Append(Quota).Append("\n");
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
