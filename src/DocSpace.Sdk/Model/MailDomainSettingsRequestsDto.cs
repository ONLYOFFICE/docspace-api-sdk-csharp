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
    /// The request parameters for configuring trusted mail domains and visitor invitation settings.
    /// </summary>
    [DataContract(Name = "MailDomainSettingsRequestsDto")]
    public partial class MailDomainSettingsRequestsDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TenantTrustedDomainsType Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="MailDomainSettingsRequestsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MailDomainSettingsRequestsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MailDomainSettingsRequestsDto" /> class.
        /// </summary>
        /// <param name="type">type (required).</param>
        /// <param name="domains">The list of authorized email domains that are considered trusted. (required).</param>
        /// <param name="inviteUsersAsVisitors">Specifies the default permission level for the invited users (visitors or not)..</param>
        public MailDomainSettingsRequestsDto(TenantTrustedDomainsType type = default, List<string> domains = default, bool inviteUsersAsVisitors = default)
        {
            this.Type = type;
            // to ensure "domains" is required (not null)
            if (domains == null)
            {
                throw new ArgumentNullException("domains is a required property for MailDomainSettingsRequestsDto and cannot be null");
            }
            this.Domains = domains;
            this.InviteUsersAsVisitors = inviteUsersAsVisitors;
        }

        /// <summary>
        /// The list of authorized email domains that are considered trusted.
        /// </summary>
        /// <value>The list of authorized email domains that are considered trusted.</value>
        /*
        <example>[&quot;some text&quot;]</example>
        */
        [DataMember(Name = "domains", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Domains { get; set; }

        /// <summary>
        /// Specifies the default permission level for the invited users (visitors or not).
        /// </summary>
        /// <value>Specifies the default permission level for the invited users (visitors or not).</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "inviteUsersAsVisitors", EmitDefaultValue = true)]
        public bool InviteUsersAsVisitors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MailDomainSettingsRequestsDto {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Domains: ").Append(Domains).Append("\n");
            sb.Append("  InviteUsersAsVisitors: ").Append(InviteUsersAsVisitors).Append("\n");
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
