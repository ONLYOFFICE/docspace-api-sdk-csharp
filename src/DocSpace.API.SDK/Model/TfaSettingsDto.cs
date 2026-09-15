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
    /// One two-factor authentication method the portal offers, with the portal-wide state of that method.
    /// </summary>
    [DataContract(Name = "TfaSettingsDto")]
    public partial class TfaSettingsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TfaSettingsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TfaSettingsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TfaSettingsDto" /> class.
        /// </summary>
        /// <param name="id">Which method this entry describes: &#x60;sms&#x60; for a code sent by text message, &#x60;app&#x60; for a code from an  authenticator application. It is the value &#x60;PUT api/2.0/settings/tfaapp&#x60; takes as its &#x60;type&#x60;, and no other  value ever appears here. (required).</param>
        /// <param name="title">The label for the method in the portal language, meant for a button or a radio option. It is not stable  enough to branch on - match &#x60;id&#x60; for that. (required).</param>
        /// <param name="enabled">Whether this method is the portal&#39;s current policy. At most one entry can have it set, and none has it  while the portal challenges nobody. It says nothing about the caller&#39;s own account, which may be exempt  through &#x60;trustedIps&#x60; or forced through &#x60;mandatoryUsers&#x60;. (required).</param>
        /// <param name="available">Whether the method could be switched on at all. For &#x60;sms&#x60; it is &#x60;false&#x60; until the installation has a  working SMS provider, so a method can be offered here and still be impossible to enable; for &#x60;app&#x60; it is  always &#x60;true&#x60;. (required).</param>
        /// <param name="trustedIps">The addresses that skip the challenge, each either a single address, a &#x60;from-to&#x60; pair or a CIDR range. It  is empty when no address is exempt, which means every account is challenged..</param>
        /// <param name="mandatoryUsers">The accounts that are challenged even from a trusted address, by user ID. Empty means the exemption in  &#x60;trustedIps&#x60; holds for everyone..</param>
        /// <param name="mandatoryGroups">The groups whose members are challenged even from a trusted address, by group ID, with the same reading of  an empty list as &#x60;mandatoryUsers&#x60;..</param>
        public TfaSettingsDto(string id = default, string title = default, bool enabled = default, bool available = default, List<string> trustedIps = default, List<Guid> mandatoryUsers = default, List<Guid> mandatoryGroups = default)
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for TfaSettingsDto and cannot be null");
            }
            this.Id = id;
            // to ensure "title" is required (not null)
            if (title == null)
            {
                throw new ArgumentNullException("title is a required property for TfaSettingsDto and cannot be null");
            }
            this.Title = title;
            this.Enabled = enabled;
            this.Available = available;
            this.TrustedIps = trustedIps;
            this.MandatoryUsers = mandatoryUsers;
            this.MandatoryGroups = mandatoryGroups;
        }

        /// <summary>
        /// Which method this entry describes: &#x60;sms&#x60; for a code sent by text message, &#x60;app&#x60; for a code from an  authenticator application. It is the value &#x60;PUT api/2.0/settings/tfaapp&#x60; takes as its &#x60;type&#x60;, and no other  value ever appears here.
        /// </summary>
        /// <example>app</example>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The label for the method in the portal language, meant for a button or a radio option. It is not stable  enough to branch on - match &#x60;id&#x60; for that.
        /// </summary>
        /// <example>Authenticator app</example>
        [DataMember(Name = "title", IsRequired = true, EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Whether this method is the portal&#39;s current policy. At most one entry can have it set, and none has it  while the portal challenges nobody. It says nothing about the caller&#39;s own account, which may be exempt  through &#x60;trustedIps&#x60; or forced through &#x60;mandatoryUsers&#x60;.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "enabled", IsRequired = true, EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Whether the method could be switched on at all. For &#x60;sms&#x60; it is &#x60;false&#x60; until the installation has a  working SMS provider, so a method can be offered here and still be impossible to enable; for &#x60;app&#x60; it is  always &#x60;true&#x60;.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "available", IsRequired = true, EmitDefaultValue = true)]
        public bool Available { get; set; }

        /// <summary>
        /// The addresses that skip the challenge, each either a single address, a &#x60;from-to&#x60; pair or a CIDR range. It  is empty when no address is exempt, which means every account is challenged.
        /// </summary>
        /// <example>["192.0.2.0/24"]</example>
        [DataMember(Name = "trustedIps", EmitDefaultValue = true)]
        public List<string> TrustedIps { get; set; }

        /// <summary>
        /// The accounts that are challenged even from a trusted address, by user ID. Empty means the exemption in  &#x60;trustedIps&#x60; holds for everyone.
        /// </summary>
        /// <example>["00000000-0000-0000-0000-000000000000"]</example>
        [DataMember(Name = "mandatoryUsers", EmitDefaultValue = true)]
        public List<Guid> MandatoryUsers { get; set; }

        /// <summary>
        /// The groups whose members are challenged even from a trusted address, by group ID, with the same reading of  an empty list as &#x60;mandatoryUsers&#x60;.
        /// </summary>
        /// <example>["00000000-0000-0000-0000-000000000000"]</example>
        [DataMember(Name = "mandatoryGroups", EmitDefaultValue = true)]
        public List<Guid> MandatoryGroups { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TfaSettingsDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Available: ").Append(Available).Append("\n");
            sb.Append("  TrustedIps: ").Append(TrustedIps).Append("\n");
            sb.Append("  MandatoryUsers: ").Append(MandatoryUsers).Append("\n");
            sb.Append("  MandatoryGroups: ").Append(MandatoryGroups).Append("\n");
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
