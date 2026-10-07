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
    /// Which help and community resources the interface links to.
    /// </summary>
    [DataContract(Name = "SaveAdditionalResourcesRequest")]
    public partial class SaveAdditionalResourcesRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveAdditionalResourcesRequest" /> class.
        /// </summary>
        /// <param name="startDocsEnabled">Whether the getting-started documents are offered..</param>
        /// <param name="helpCenterEnabled">Whether the help center is linked..</param>
        /// <param name="feedbackAndSupportEnabled">Whether the feedback and support link is shown..</param>
        /// <param name="userForumEnabled">Whether the user forum is linked..</param>
        /// <param name="videoGuidesEnabled">Whether the video guides are linked..</param>
        /// <param name="licenseAgreementsEnabled">Whether the license agreements are linked..</param>
        /// <param name="lastModified">Accepted for compatibility with earlier clients and not read: the server keeps its own value..</param>
        public SaveAdditionalResourcesRequest(bool startDocsEnabled = default, bool helpCenterEnabled = default, bool feedbackAndSupportEnabled = default, bool userForumEnabled = default, bool videoGuidesEnabled = default, bool licenseAgreementsEnabled = default, DateTime lastModified = default)
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
        /// Whether the getting-started documents are offered.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "startDocsEnabled", EmitDefaultValue = true)]
        public bool StartDocsEnabled { get; set; }

        /// <summary>
        /// Whether the help center is linked.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "helpCenterEnabled", EmitDefaultValue = true)]
        public bool HelpCenterEnabled { get; set; }

        /// <summary>
        /// Whether the feedback and support link is shown.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "feedbackAndSupportEnabled", EmitDefaultValue = true)]
        public bool FeedbackAndSupportEnabled { get; set; }

        /// <summary>
        /// Whether the user forum is linked.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "userForumEnabled", EmitDefaultValue = true)]
        public bool UserForumEnabled { get; set; }

        /// <summary>
        /// Whether the video guides are linked.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "videoGuidesEnabled", EmitDefaultValue = true)]
        public bool VideoGuidesEnabled { get; set; }

        /// <summary>
        /// Whether the license agreements are linked.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "licenseAgreementsEnabled", EmitDefaultValue = true)]
        public bool LicenseAgreementsEnabled { get; set; }

        /// <summary>
        /// Accepted for compatibility with earlier clients and not read: the server keeps its own value.
        /// </summary>
        /// <example>2026-01-01T10:00:00</example>
        [DataMember(Name = "lastModified", EmitDefaultValue = false)]
        public DateTime LastModified { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaveAdditionalResourcesRequest {\n");
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
