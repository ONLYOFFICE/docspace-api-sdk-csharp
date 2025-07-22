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

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// The request parameters for inviting users.
    /// </summary>
    [DataContract(Name = "InviteUsersRequestDto")]
    public partial class InviteUsersRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="InviteUsersRequestDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InviteUsersRequestDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InviteUsersRequestDto" /> class.
        /// </summary>
        /// <param name="invitations">The list of user invitations. (required).</param>
        /// <param name="culture">The culture code of invitations..</param>
        public InviteUsersRequestDto(List<UserInvitationRequestDto> invitations = default, string culture = default)
        {
            // to ensure "invitations" is required (not null)
            if (invitations == null)
            {
                throw new ArgumentNullException("invitations is a required property for InviteUsersRequestDto and cannot be null");
            }
            this.Invitations = invitations;
            this.Culture = culture;
        }

        /// <summary>
        /// The list of user invitations.
        /// </summary>
        /// <value>The list of user invitations.</value>
        [DataMember(Name = "invitations", IsRequired = true, EmitDefaultValue = true)]
        public List<UserInvitationRequestDto> Invitations { get; set; }

        /// <summary>
        /// The culture code of invitations.
        /// </summary>
        /// <value>The culture code of invitations.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "culture", EmitDefaultValue = true)]
        public string Culture { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InviteUsersRequestDto {\n");
            sb.Append("  Invitations: ").Append(Invitations).Append("\n");
            sb.Append("  Culture: ").Append(Culture).Append("\n");
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
