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
    /// User invitation settings
    /// </summary>
    [DataContract(Name = "TenantUserInvitationSettingsRequestDto")]
    public partial class TenantUserInvitationSettingsRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="TenantUserInvitationSettingsRequestDto" /> class.
        /// </summary>
        /// <param name="allowInvitingMembers">Allow invite new DocSpace members through the Contacts section..</param>
        /// <param name="allowInvitingGuests">Allow all DocSpace members to invite external guests to rooms..</param>
        public TenantUserInvitationSettingsRequestDto(bool allowInvitingMembers = default, bool allowInvitingGuests = default)
        {
            this.AllowInvitingMembers = allowInvitingMembers;
            this.AllowInvitingGuests = allowInvitingGuests;
        }

        /// <summary>
        /// Allow invite new DocSpace members through the Contacts section.
        /// </summary>
        /// <value>Allow invite new DocSpace members through the Contacts section.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "allowInvitingMembers", EmitDefaultValue = true)]
        public bool AllowInvitingMembers { get; set; }

        /// <summary>
        /// Allow all DocSpace members to invite external guests to rooms.
        /// </summary>
        /// <value>Allow all DocSpace members to invite external guests to rooms.</value>
        /*
        <example>true</example>
        */
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
