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
    /// The tenant entity quota settings.
    /// </summary>
    [DataContract(Name = "TenantEntityQuotaSettings")]
    public partial class TenantEntityQuotaSettings : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantEntityQuotaSettings" /> class.
        /// </summary>
        /// <param name="enableQuota">Specifies if the quota is enabled for the tenant entity or not..</param>
        /// <param name="defaultQuota">The default quota of the tenant entity..</param>
        /// <param name="lastRecalculateDate">The date of the last quota recalculation..</param>
        public TenantEntityQuotaSettings(bool enableQuota = default, long defaultQuota = default, DateTime? lastRecalculateDate = default)
        {
            this.EnableQuota = enableQuota;
            this.DefaultQuota = defaultQuota;
            this.LastRecalculateDate = lastRecalculateDate;
        }

        /// <summary>
        /// Specifies if the quota is enabled for the tenant entity or not.
        /// </summary>
        /// <value>Specifies if the quota is enabled for the tenant entity or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "enableQuota", EmitDefaultValue = true)]
        public bool EnableQuota { get; set; }

        /// <summary>
        /// The default quota of the tenant entity.
        /// </summary>
        /// <value>The default quota of the tenant entity.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "defaultQuota", EmitDefaultValue = false)]
        public long DefaultQuota { get; set; }

        /// <summary>
        /// The date of the last quota recalculation.
        /// </summary>
        /// <value>The date of the last quota recalculation.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "lastRecalculateDate", EmitDefaultValue = true)]
        public DateTime? LastRecalculateDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenantEntityQuotaSettings {\n");
            sb.Append("  EnableQuota: ").Append(EnableQuota).Append("\n");
            sb.Append("  DefaultQuota: ").Append(DefaultQuota).Append("\n");
            sb.Append("  LastRecalculateDate: ").Append(LastRecalculateDate).Append("\n");
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
