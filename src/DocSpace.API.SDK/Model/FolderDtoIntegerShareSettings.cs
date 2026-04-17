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
    /// A dictionary representing the sharing settings for the file entry.
    /// </summary>
    [DataContract(Name = "FolderDtoInteger_shareSettings")]
    public partial class FolderDtoIntegerShareSettings : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FolderDtoIntegerShareSettings" /> class.
        /// </summary>
        /// <param name="user">user.</param>
        /// <param name="externalLink">externalLink.</param>
        /// <param name="group">group.</param>
        /// <param name="invitationLink">invitationLink.</param>
        /// <param name="primaryExternalLink">primaryExternalLink.</param>
        public FolderDtoIntegerShareSettings(int user = default, int externalLink = default, int group = default, int invitationLink = default, int primaryExternalLink = default)
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
        public int User { get; set; }

        /// <summary>
        /// Gets or Sets ExternalLink
        /// </summary>
        [DataMember(Name = "ExternalLink", EmitDefaultValue = false)]
        public int ExternalLink { get; set; }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name = "Group", EmitDefaultValue = false)]
        public int Group { get; set; }

        /// <summary>
        /// Gets or Sets InvitationLink
        /// </summary>
        [DataMember(Name = "InvitationLink", EmitDefaultValue = false)]
        public int InvitationLink { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryExternalLink
        /// </summary>
        [DataMember(Name = "PrimaryExternalLink", EmitDefaultValue = false)]
        public int PrimaryExternalLink { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FolderDtoIntegerShareSettings {\n");
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
