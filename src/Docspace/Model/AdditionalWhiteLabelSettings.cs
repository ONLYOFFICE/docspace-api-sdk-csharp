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
using FileParameter = DocSpace.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.Client.OpenAPIDateConverter;

namespace DocSpace.Model
{
    /// <summary>
    /// The additional white label settings.
    /// </summary>
    [DataContract(Name = "AdditionalWhiteLabelSettings")]
    public partial class AdditionalWhiteLabelSettings : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalWhiteLabelSettings" /> class.
        /// </summary>
        /// <param name="startDocsEnabled">Specifies if the sample documents are displayed or hidden..</param>
        /// <param name="helpCenterEnabled">Specifies if the Help Center link is available or not..</param>
        /// <param name="feedbackAndSupportEnabled">Specifies if the \&quot;Feedback &amp; Support\&quot; link is available or not..</param>
        /// <param name="userForumEnabled">Specifies if the user forum is available or not..</param>
        /// <param name="videoGuidesEnabled">Specifies if the Video Guides link is available or not..</param>
        /// <param name="licenseAgreementsEnabled">Specifies if the License Agreements link is available or not..</param>
        /// <param name="lastModified">lastModified.</param>
        public AdditionalWhiteLabelSettings(bool startDocsEnabled = default, bool helpCenterEnabled = default, bool feedbackAndSupportEnabled = default, bool userForumEnabled = default, bool videoGuidesEnabled = default, bool licenseAgreementsEnabled = default, DateTime lastModified = default)
        {
            this.StartDocsEnabled = startDocsEnabled;
            this.HelpCenterEnabled = helpCenterEnabled;
            this.FeedbackAndSupportEnabled = feedbackAndSupportEnabled;
            this.UserForumEnabled = userForumEnabled;
            this.VideoGuidesEnabled = videoGuidesEnabled;
            this.LicenseAgreementsEnabled = licenseAgreementsEnabled;
            this.LastModified = lastModified;
        }

        /// <summary>
        /// Specifies if the sample documents are displayed or hidden.
        /// </summary>
        /// <value>Specifies if the sample documents are displayed or hidden.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "startDocsEnabled", EmitDefaultValue = true)]
        public bool StartDocsEnabled { get; set; }

        /// <summary>
        /// Specifies if the Help Center link is available or not.
        /// </summary>
        /// <value>Specifies if the Help Center link is available or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "helpCenterEnabled", EmitDefaultValue = true)]
        public bool HelpCenterEnabled { get; set; }

        /// <summary>
        /// Specifies if the \&quot;Feedback &amp; Support\&quot; link is available or not.
        /// </summary>
        /// <value>Specifies if the \&quot;Feedback &amp; Support\&quot; link is available or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "feedbackAndSupportEnabled", EmitDefaultValue = true)]
        public bool FeedbackAndSupportEnabled { get; set; }

        /// <summary>
        /// Specifies if the user forum is available or not.
        /// </summary>
        /// <value>Specifies if the user forum is available or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "userForumEnabled", EmitDefaultValue = true)]
        public bool UserForumEnabled { get; set; }

        /// <summary>
        /// Specifies if the Video Guides link is available or not.
        /// </summary>
        /// <value>Specifies if the Video Guides link is available or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "videoGuidesEnabled", EmitDefaultValue = true)]
        public bool VideoGuidesEnabled { get; set; }

        /// <summary>
        /// Specifies if the License Agreements link is available or not.
        /// </summary>
        /// <value>Specifies if the License Agreements link is available or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "licenseAgreementsEnabled", EmitDefaultValue = true)]
        public bool LicenseAgreementsEnabled { get; set; }

        /// <summary>
        /// Gets or Sets LastModified
        /// </summary>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "lastModified", EmitDefaultValue = false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AdditionalWhiteLabelSettings {\n");
            sb.Append("  StartDocsEnabled: ").Append(StartDocsEnabled).Append("\n");
            sb.Append("  HelpCenterEnabled: ").Append(HelpCenterEnabled).Append("\n");
            sb.Append("  FeedbackAndSupportEnabled: ").Append(FeedbackAndSupportEnabled).Append("\n");
            sb.Append("  UserForumEnabled: ").Append(UserForumEnabled).Append("\n");
            sb.Append("  VideoGuidesEnabled: ").Append(VideoGuidesEnabled).Append("\n");
            sb.Append("  LicenseAgreementsEnabled: ").Append(LicenseAgreementsEnabled).Append("\n");
            sb.Append("  LastModified: ").Append(LastModified).Append("\n");
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
