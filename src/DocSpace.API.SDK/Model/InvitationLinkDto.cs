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
    /// The portal&#39;s standing invitation link for one role: what it grants, how long it lasts, how often it was used.
    /// </summary>
    [DataContract(Name = "InvitationLinkDto")]
    public partial class InvitationLinkDto : IValidatableObject
    {

        /// <summary>
        /// The role an account gets by joining through this link. A portal keeps at most one link per role, and the  role of an existing link cannot be changed - the link has to be deleted and created again.
        /// </summary>
        [DataMember(Name = "employeeType", IsRequired = true, EmitDefaultValue = true)]
        public EmployeeType EmployeeType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InvitationLinkDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InvitationLinkDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvitationLinkDto" /> class.
        /// </summary>
        /// <param name="id">The identifier to address the link by in &#x60;PUT api/2.0/portal/users/invitationlink&#x60; and  &#x60;DELETE api/2.0/portal/users/invitationlink&#x60;. It survives a change of deadline or use limit, so it is  worth storing rather than re-reading..</param>
        /// <param name="employeeType">The role an account gets by joining through this link. A portal keeps at most one link per role, and the  role of an existing link cannot be changed - the link has to be deleted and created again. (required).</param>
        /// <param name="expiration">When the link stops working, in the portal time zone. It is empty for a link that never expires, which is  what omitting the deadline on create or update leaves behind..</param>
        /// <param name="isExpired">Whether that deadline has already passed. A link without a deadline always reports &#x60;false&#x60;, and an expired  link is still returned rather than treated as gone - it can be revived by moving &#x60;expiration&#x60;..</param>
        /// <param name="maxUseCount">How many accounts may join through the link in total. It is empty for a link with no use limit, and an  update may not lower it below &#x60;currentUseCount&#x60;..</param>
        /// <param name="currentUseCount">How many accounts have already joined through the link. It only ever grows, and reaching &#x60;maxUseCount&#x60;  retires the link as surely as a passed deadline..</param>
        /// <param name="url">The shortened address to hand to the people being invited. It is signed for the account that read it, so  two administrators are given two different URLs for one and the same link and both of them work; the &#x60;id&#x60;  above, not this string, is what identifies the link..</param>
        public InvitationLinkDto(Guid id = default, EmployeeType employeeType = default, ApiDateTime expiration = default, bool isExpired = default, int? maxUseCount = default, int currentUseCount = default, string url = default)
        {
            this.EmployeeType = employeeType;
            this.Id = id;
            this.Expiration = expiration;
            this.IsExpired = isExpired;
            this.MaxUseCount = maxUseCount;
            this.CurrentUseCount = currentUseCount;
            this.Url = url;
        }

        /// <summary>
        /// The identifier to address the link by in &#x60;PUT api/2.0/portal/users/invitationlink&#x60; and  &#x60;DELETE api/2.0/portal/users/invitationlink&#x60;. It survives a change of deadline or use limit, so it is  worth storing rather than re-reading.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000000</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// When the link stops working, in the portal time zone. It is empty for a link that never expires, which is  what omitting the deadline on create or update leaves behind.
        /// </summary>
        [DataMember(Name = "expiration", EmitDefaultValue = false)]
        public ApiDateTime Expiration { get; set; }

        /// <summary>
        /// Whether that deadline has already passed. A link without a deadline always reports &#x60;false&#x60;, and an expired  link is still returned rather than treated as gone - it can be revived by moving &#x60;expiration&#x60;.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "isExpired", EmitDefaultValue = true)]
        public bool IsExpired { get; set; }

        /// <summary>
        /// How many accounts may join through the link in total. It is empty for a link with no use limit, and an  update may not lower it below &#x60;currentUseCount&#x60;.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "maxUseCount", EmitDefaultValue = true)]
        public int? MaxUseCount { get; set; }

        /// <summary>
        /// How many accounts have already joined through the link. It only ever grows, and reaching &#x60;maxUseCount&#x60;  retires the link as surely as a passed deadline.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "currentUseCount", EmitDefaultValue = false)]
        public int CurrentUseCount { get; set; }

        /// <summary>
        /// The shortened address to hand to the people being invited. It is signed for the account that read it, so  two administrators are given two different URLs for one and the same link and both of them work; the &#x60;id&#x60;  above, not this string, is what identifies the link.
        /// </summary>
        /// <example>https://example.com</example>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InvitationLinkDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EmployeeType: ").Append(EmployeeType).Append("\n");
            sb.Append("  Expiration: ").Append(Expiration).Append("\n");
            sb.Append("  IsExpired: ").Append(IsExpired).Append("\n");
            sb.Append("  MaxUseCount: ").Append(MaxUseCount).Append("\n");
            sb.Append("  CurrentUseCount: ").Append(CurrentUseCount).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
