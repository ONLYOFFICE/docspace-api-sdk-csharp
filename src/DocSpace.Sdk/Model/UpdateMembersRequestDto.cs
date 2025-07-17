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
    /// The request parameters for updating the user information.
    /// </summary>
    [DataContract(Name = "UpdateMembersRequestDto")]
    public partial class UpdateMembersRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateMembersRequestDto" /> class.
        /// </summary>
        /// <param name="userIds">The list of user IDs..</param>
        /// <param name="resendAll">Specifies whether to resend invitation letters to all the users or not..</param>
        public UpdateMembersRequestDto(List<Guid> userIds = default, bool resendAll = default)
        {
            this.UserIds = userIds;
            this.ResendAll = resendAll;
        }

        /// <summary>
        /// The list of user IDs.
        /// </summary>
        /// <value>The list of user IDs.</value>
        /*
        <example>[&quot;75a5f745-f697-4418-b38d-0fe0d277e258&quot;]</example>
        */
        [DataMember(Name = "userIds", EmitDefaultValue = true)]
        public List<Guid> UserIds { get; set; }

        /// <summary>
        /// Specifies whether to resend invitation letters to all the users or not.
        /// </summary>
        /// <value>Specifies whether to resend invitation letters to all the users or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "resendAll", EmitDefaultValue = true)]
        public bool ResendAll { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateMembersRequestDto {\n");
            sb.Append("  UserIds: ").Append(UserIds).Append("\n");
            sb.Append("  ResendAll: ").Append(ResendAll).Append("\n");
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
