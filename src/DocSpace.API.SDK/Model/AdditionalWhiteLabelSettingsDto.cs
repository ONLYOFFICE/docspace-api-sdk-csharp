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
    /// Which of the ONLYOFFICE help and community entries the interface may offer, installation-wide.
    /// </summary>
    [DataContract(Name = "AdditionalWhiteLabelSettingsDto")]
    public partial class AdditionalWhiteLabelSettingsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalWhiteLabelSettingsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AdditionalWhiteLabelSettingsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionalWhiteLabelSettingsDto" /> class.
        /// </summary>
        /// <param name="startDocsEnabled">Whether the sample documents that ONLYOFFICE ships may be placed in a new user&#39;s Documents. Unlike the link  flags below it depends on nothing that has to be configured, so its built-in value is always &#x60;true&#x60;. (required).</param>
        /// <param name="helpCenterEnabled">Whether the interface may offer the Help Center entry. It is &#x60;false&#x60; both when the entry was switched off  for the installation and when the installation configures no Help Center address at all; the addresses  themselves are not part of this answer and arrive in &#x60;externalResources&#x60; of &#x60;GET api/2.0/settings&#x60;. (required).</param>
        /// <param name="feedbackAndSupportEnabled">Whether the interface may offer the Feedback and Support entry, &#x60;false&#x60; for the same two reasons as  &#x60;helpCenterEnabled&#x60;. (required).</param>
        /// <param name="userForumEnabled">Whether the interface may offer the user forum entry, &#x60;false&#x60; for the same two reasons as  &#x60;helpCenterEnabled&#x60;. (required).</param>
        /// <param name="videoGuidesEnabled">Whether the interface may offer the Video Guides entry, &#x60;false&#x60; for the same two reasons as  &#x60;helpCenterEnabled&#x60;. (required).</param>
        /// <param name="licenseAgreementsEnabled">Whether the interface may offer the License Agreements entry, &#x60;false&#x60; for the same two reasons as  &#x60;helpCenterEnabled&#x60;. (required).</param>
        /// <param name="isDefault">Whether all six flags still hold the values the installation starts out with. It turns &#x60;false&#x60; as soon as  one of them is saved differently and &#x60;true&#x60; again after &#x60;DELETE api/2.0/settings/rebranding/additional&#x60;.  Because a link flag starts out off when no address is configured for it, &#x60;true&#x60; does not mean every entry  is on. (required).</param>
        public AdditionalWhiteLabelSettingsDto(bool startDocsEnabled = default, bool helpCenterEnabled = default, bool feedbackAndSupportEnabled = default, bool userForumEnabled = default, bool videoGuidesEnabled = default, bool licenseAgreementsEnabled = default, bool isDefault = default)
        {
            this.StartDocsEnabled = startDocsEnabled;
            this.HelpCenterEnabled = helpCenterEnabled;
            this.FeedbackAndSupportEnabled = feedbackAndSupportEnabled;
            this.UserForumEnabled = userForumEnabled;
            this.VideoGuidesEnabled = videoGuidesEnabled;
            this.LicenseAgreementsEnabled = licenseAgreementsEnabled;
            this.IsDefault = isDefault;
        }

        /// <summary>
        /// Whether the sample documents that ONLYOFFICE ships may be placed in a new user&#39;s Documents. Unlike the link  flags below it depends on nothing that has to be configured, so its built-in value is always &#x60;true&#x60;.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "startDocsEnabled", IsRequired = true, EmitDefaultValue = true)]
        public bool StartDocsEnabled { get; set; }

        /// <summary>
        /// Whether the interface may offer the Help Center entry. It is &#x60;false&#x60; both when the entry was switched off  for the installation and when the installation configures no Help Center address at all; the addresses  themselves are not part of this answer and arrive in &#x60;externalResources&#x60; of &#x60;GET api/2.0/settings&#x60;.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "helpCenterEnabled", IsRequired = true, EmitDefaultValue = true)]
        public bool HelpCenterEnabled { get; set; }

        /// <summary>
        /// Whether the interface may offer the Feedback and Support entry, &#x60;false&#x60; for the same two reasons as  &#x60;helpCenterEnabled&#x60;.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "feedbackAndSupportEnabled", IsRequired = true, EmitDefaultValue = true)]
        public bool FeedbackAndSupportEnabled { get; set; }

        /// <summary>
        /// Whether the interface may offer the user forum entry, &#x60;false&#x60; for the same two reasons as  &#x60;helpCenterEnabled&#x60;.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "userForumEnabled", IsRequired = true, EmitDefaultValue = true)]
        public bool UserForumEnabled { get; set; }

        /// <summary>
        /// Whether the interface may offer the Video Guides entry, &#x60;false&#x60; for the same two reasons as  &#x60;helpCenterEnabled&#x60;.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "videoGuidesEnabled", IsRequired = true, EmitDefaultValue = true)]
        public bool VideoGuidesEnabled { get; set; }

        /// <summary>
        /// Whether the interface may offer the License Agreements entry, &#x60;false&#x60; for the same two reasons as  &#x60;helpCenterEnabled&#x60;.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "licenseAgreementsEnabled", IsRequired = true, EmitDefaultValue = true)]
        public bool LicenseAgreementsEnabled { get; set; }

        /// <summary>
        /// Whether all six flags still hold the values the installation starts out with. It turns &#x60;false&#x60; as soon as  one of them is saved differently and &#x60;true&#x60; again after &#x60;DELETE api/2.0/settings/rebranding/additional&#x60;.  Because a link flag starts out off when no address is configured for it, &#x60;true&#x60; does not mean every entry  is on.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isDefault", IsRequired = true, EmitDefaultValue = true)]
        public bool IsDefault { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AdditionalWhiteLabelSettingsDto {\n");
            sb.Append("  StartDocsEnabled: ").Append(StartDocsEnabled).Append("\n");
            sb.Append("  HelpCenterEnabled: ").Append(HelpCenterEnabled).Append("\n");
            sb.Append("  FeedbackAndSupportEnabled: ").Append(FeedbackAndSupportEnabled).Append("\n");
            sb.Append("  UserForumEnabled: ").Append(UserForumEnabled).Append("\n");
            sb.Append("  VideoGuidesEnabled: ").Append(VideoGuidesEnabled).Append("\n");
            sb.Append("  LicenseAgreementsEnabled: ").Append(LicenseAgreementsEnabled).Append("\n");
            sb.Append("  IsDefault: ").Append(IsDefault).Append("\n");
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
