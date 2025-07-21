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


 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
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
            var sb = new StringBuilder();
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
