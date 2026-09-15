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
    /// Whether the portal still lets its members invite new members and new guests.
    /// </summary>
    [DataContract(Name = "TenantUserInvitationSettingsRequestDto")]
    public partial class TenantUserInvitationSettingsRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantUserInvitationSettingsRequestDto" /> class.
        /// </summary>
        /// <param name="allowInvitingMembers">Whether new DocSpace members may be invited through the Contacts section. Switching it off only stops new  invitations being created; links already issued keep working and members already invited stay..</param>
        /// <param name="allowInvitingGuests">Whether every DocSpace member, and not only an administrator, may invite external guests into rooms.  Switching it off leaves the guests already invited in place..</param>
        public TenantUserInvitationSettingsRequestDto(bool allowInvitingMembers = default, bool allowInvitingGuests = default)
        {
            this.AllowInvitingMembers = allowInvitingMembers;
            this.AllowInvitingGuests = allowInvitingGuests;
        }

        /// <summary>
        /// Whether new DocSpace members may be invited through the Contacts section. Switching it off only stops new  invitations being created; links already issued keep working and members already invited stay.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "allowInvitingMembers", EmitDefaultValue = true)]
        public bool AllowInvitingMembers { get; set; }

        /// <summary>
        /// Whether every DocSpace member, and not only an administrator, may invite external guests into rooms.  Switching it off leaves the guests already invited in place.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "allowInvitingGuests", EmitDefaultValue = true)]
        public bool AllowInvitingGuests { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TenantUserInvitationSettingsRequestDto {\n");
            sb.Append("  AllowInvitingMembers: ").Append(AllowInvitingMembers).Append("\n");
            sb.Append("  AllowInvitingGuests: ").Append(AllowInvitingGuests).Append("\n");
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
