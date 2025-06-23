// (c) Copyright Ascensio System SIA 2009-2025
// 
// This program is a free software product.
// You can redistribute it and/or modify it under the terms
// of the GNU Affero General Public License (AGPL) version 3 as published by the Free Software
// Foundation. In accordance with Section 7(a) of the GNU AGPL its Section 15 shall be amended
// to the effect that Ascensio System SIA expressly excludes the warranty of non-infringement of
// any third-party rights.
// 
// This program is distributed WITHOUT ANY WARRANTY, without even the implied warranty
// of MERCHANTABILITY or FITNESS FOR A PARTICULAR  PURPOSE. For details, see
// the GNU AGPL at: http://www.gnu.org/licenses/agpl-3.0.html
// 
// You can contact Ascensio System SIA at Lubanas st. 125a-25, Riga, Latvia, EU, LV-1021.
// 
// The  interactive user interfaces in modified source and object code versions of the Program must
// display Appropriate Legal Notices, as required under Section 5 of the GNU AGPL version 3.
// 
// Pursuant to Section 7(b) of the License you must retain the original Product logo when
// distributing the program. Pursuant to Section 7(e) we decline to grant you any rights under
// trademark law for use of our trademarks.
// 
// All the Product's GUI elements, including illustrations and icon sets, as well as technical writing
// content are licensed under the terms of the Creative Commons Attribution-ShareAlike 4.0
// International. See the License terms at http://creativecommons.org/licenses/by-sa/4.0/legalcode


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
using FileParameter = Docspace.Client.FileParameter;
using OpenAPIDateConverter = Docspace.Client.OpenAPIDateConverter;

namespace Docspace.Model
{
    /// <summary>
    /// The user parameters.
    /// </summary>
    [DataContract(Name = "EmployeeDto")]
    public partial class EmployeeDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmployeeDto" /> class.
        /// </summary>
        /// <param name="id">The user ID..</param>
        /// <param name="displayName">The user display name..</param>
        /// <param name="title">The user title..</param>
        /// <param name="avatar">The user avatar..</param>
        /// <param name="avatarOriginal">The user original size avatar..</param>
        /// <param name="avatarMax">The user maximum size avatar..</param>
        /// <param name="avatarMedium">The user medium size avatar..</param>
        /// <param name="avatarSmall">The user small size avatar..</param>
        /// <param name="profileUrl">The user profile URL..</param>
        /// <param name="hasAvatar">Specifies if the user has an avatar or not..</param>
        /// <param name="isAnonim">Specifies if the user is anonymous or not..</param>
        public EmployeeDto(Guid id = default, string displayName = default, string title = default, string avatar = default, string avatarOriginal = default, string avatarMax = default, string avatarMedium = default, string avatarSmall = default, string profileUrl = default, bool hasAvatar = default, bool isAnonim = default)
        {
            this.Id = id;
            this.DisplayName = displayName;
            this.Title = title;
            this.Avatar = avatar;
            this.AvatarOriginal = avatarOriginal;
            this.AvatarMax = avatarMax;
            this.AvatarMedium = avatarMedium;
            this.AvatarSmall = avatarSmall;
            this.ProfileUrl = profileUrl;
            this.HasAvatar = hasAvatar;
            this.IsAnonim = isAnonim;
        }

        /// <summary>
        /// The user ID.
        /// </summary>
        /// <value>The user ID.</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// The user display name.
        /// </summary>
        /// <value>The user display name.</value>
        /*
        <example>Mike Zanyatski</example>
        */
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// The user title.
        /// </summary>
        /// <value>The user title.</value>
        /*
        <example>Manager</example>
        */
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The user avatar.
        /// </summary>
        /// <value>The user avatar.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "avatar", EmitDefaultValue = true)]
        public string Avatar { get; set; }

        /// <summary>
        /// The user original size avatar.
        /// </summary>
        /// <value>The user original size avatar.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "avatarOriginal", EmitDefaultValue = true)]
        public string AvatarOriginal { get; set; }

        /// <summary>
        /// The user maximum size avatar.
        /// </summary>
        /// <value>The user maximum size avatar.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "avatarMax", EmitDefaultValue = true)]
        public string AvatarMax { get; set; }

        /// <summary>
        /// The user medium size avatar.
        /// </summary>
        /// <value>The user medium size avatar.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "avatarMedium", EmitDefaultValue = true)]
        public string AvatarMedium { get; set; }

        /// <summary>
        /// The user small size avatar.
        /// </summary>
        /// <value>The user small size avatar.</value>
        /*
        <example>url to small avatar</example>
        */
        [DataMember(Name = "avatarSmall", EmitDefaultValue = true)]
        public string AvatarSmall { get; set; }

        /// <summary>
        /// The user profile URL.
        /// </summary>
        /// <value>The user profile URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "profileUrl", EmitDefaultValue = true)]
        public string ProfileUrl { get; set; }

        /// <summary>
        /// Specifies if the user has an avatar or not.
        /// </summary>
        /// <value>Specifies if the user has an avatar or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "hasAvatar", EmitDefaultValue = true)]
        public bool HasAvatar { get; set; }

        /// <summary>
        /// Specifies if the user is anonymous or not.
        /// </summary>
        /// <value>Specifies if the user is anonymous or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isAnonim", EmitDefaultValue = true)]
        public bool IsAnonim { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmployeeDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Avatar: ").Append(Avatar).Append("\n");
            sb.Append("  AvatarOriginal: ").Append(AvatarOriginal).Append("\n");
            sb.Append("  AvatarMax: ").Append(AvatarMax).Append("\n");
            sb.Append("  AvatarMedium: ").Append(AvatarMedium).Append("\n");
            sb.Append("  AvatarSmall: ").Append(AvatarSmall).Append("\n");
            sb.Append("  ProfileUrl: ").Append(ProfileUrl).Append("\n");
            sb.Append("  HasAvatar: ").Append(HasAvatar).Append("\n");
            sb.Append("  IsAnonim: ").Append(IsAnonim).Append("\n");
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
