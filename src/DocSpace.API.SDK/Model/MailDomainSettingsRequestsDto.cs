// (c) Copyright Ascensio System SIA 2026
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


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using FileParameter = DocSpace.API.SDK.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.API.SDK.Client.OpenAPIDateConverter;

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// Which email domains the portal treats as already verified, and how their users join.
    /// </summary>
    [DataContract(Name = "MailDomainSettingsRequestsDto")]
    public partial class MailDomainSettingsRequestsDto : IValidatableObject
    {

        /// <summary>
        /// How trusted domains are decided: no domain is trusted, every domain is, or only the ones listed in &#x60;domains&#x60;.  Only the custom mode reads &#x60;domains&#x60;; under the other two the list is ignored rather than refused.
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
        /// <param name="type">How trusted domains are decided: no domain is trusted, every domain is, or only the ones listed in &#x60;domains&#x60;.  Only the custom mode reads &#x60;domains&#x60;; under the other two the list is ignored rather than refused. (required).</param>
        /// <param name="domains">The trusted domains, as bare hostnames such as &#x60;example.com&#x60; without a scheme or an &#x60;@&#x60;. This is the whole  list that is to hold afterwards and not a list of additions. Each entry is lowercased before it is stored,  and one entry that is not a valid hostname - or an empty list in the custom mode - fails the whole call  without saving anything. (required).</param>
        /// <param name="inviteUsersAsVisitors">What a user joining through a trusted domain becomes: &#x60;true&#x60; admits them as a guest, &#x60;false&#x60; as a full  member. It applies to joins made from now on and does not change anybody who has already joined. (required).</param>
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
        /// The trusted domains, as bare hostnames such as &#x60;example.com&#x60; without a scheme or an &#x60;@&#x60;. This is the whole  list that is to hold afterwards and not a list of additions. Each entry is lowercased before it is stored,  and one entry that is not a valid hostname - or an empty list in the custom mode - fails the whole call  without saving anything.
        /// </summary>
        /// <example>["example.com","company.com"]</example>
        [DataMember(Name = "domains", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Domains { get; set; }

        /// <summary>
        /// What a user joining through a trusted domain becomes: &#x60;true&#x60; admits them as a guest, &#x60;false&#x60; as a full  member. It applies to joins made from now on and does not change anybody who has already joined.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "inviteUsersAsVisitors", IsRequired = true, EmitDefaultValue = true)]
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
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
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
