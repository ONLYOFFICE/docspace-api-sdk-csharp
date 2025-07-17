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
    /// The tenant audit settings parameters.
    /// </summary>
    [DataContract(Name = "TenantAuditSettings")]
    public partial class TenantAuditSettings : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantAuditSettings" /> class.
        /// </summary>
        /// <param name="loginHistoryLifeTime">The login history lifetime..</param>
        /// <param name="auditTrailLifeTime">The audit trail lifetime..</param>
        /// <param name="lastModified">lastModified.</param>
        public TenantAuditSettings(int loginHistoryLifeTime = default, int auditTrailLifeTime = default, DateTime lastModified = default)
        {
            this.LoginHistoryLifeTime = loginHistoryLifeTime;
            this.AuditTrailLifeTime = auditTrailLifeTime;
            this.LastModified = lastModified;
        }

        /// <summary>
        /// The login history lifetime.
        /// </summary>
        /// <value>The login history lifetime.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "loginHistoryLifeTime", EmitDefaultValue = false)]
        public int LoginHistoryLifeTime { get; set; }

        /// <summary>
        /// The audit trail lifetime.
        /// </summary>
        /// <value>The audit trail lifetime.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "auditTrailLifeTime", EmitDefaultValue = false)]
        public int AuditTrailLifeTime { get; set; }

        /// <summary>
        /// Gets or Sets LastModified
        /// </summary>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "lastModified", EmitDefaultValue = false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenantAuditSettings {\n");
            sb.Append("  LoginHistoryLifeTime: ").Append(LoginHistoryLifeTime).Append("\n");
            sb.Append("  AuditTrailLifeTime: ").Append(AuditTrailLifeTime).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
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
