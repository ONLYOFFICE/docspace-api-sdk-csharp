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
    /// The available external rights of the file entry.
    /// </summary>
    [DataContract(Name = "FileEntryDtoInteger_allOf_availableShareRights")]
    public partial class FileEntryDtoIntegerAllOfAvailableShareRights : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FileEntryDtoIntegerAllOfAvailableShareRights" /> class.
        /// </summary>
        /// <param name="user">user.</param>
        /// <param name="externalLink">externalLink.</param>
        /// <param name="group">group.</param>
        /// <param name="invitationLink">invitationLink.</param>
        /// <param name="primaryExternalLink">primaryExternalLink.</param>
        public FileEntryDtoIntegerAllOfAvailableShareRights(List<string> user = default, List<string> externalLink = default, List<string> group = default, List<string> invitationLink = default, List<string> primaryExternalLink = default)
        {
            this.User = user;
            this.ExternalLink = externalLink;
            this.Group = group;
            this.InvitationLink = invitationLink;
            this.PrimaryExternalLink = primaryExternalLink;
        }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "User", EmitDefaultValue = false)]
        public List<string> User { get; set; }

        /// <summary>
        /// Gets or Sets ExternalLink
        /// </summary>
        [DataMember(Name = "ExternalLink", EmitDefaultValue = false)]
        public List<string> ExternalLink { get; set; }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name = "Group", EmitDefaultValue = false)]
        public List<string> Group { get; set; }

        /// <summary>
        /// Gets or Sets InvitationLink
        /// </summary>
        [DataMember(Name = "InvitationLink", EmitDefaultValue = false)]
        public List<string> InvitationLink { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryExternalLink
        /// </summary>
        [DataMember(Name = "PrimaryExternalLink", EmitDefaultValue = false)]
        public List<string> PrimaryExternalLink { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileEntryDtoIntegerAllOfAvailableShareRights {\n");
            sb.Append("  User: ").Append(User).Append("\n");
            sb.Append("  ExternalLink: ").Append(ExternalLink).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  InvitationLink: ").Append(InvitationLink).Append("\n");
            sb.Append("  PrimaryExternalLink: ").Append(PrimaryExternalLink).Append("\n");
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
