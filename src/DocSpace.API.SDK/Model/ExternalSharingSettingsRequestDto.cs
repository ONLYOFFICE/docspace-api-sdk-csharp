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
    /// The Access Control external sharing settings request parameters.
    /// </summary>
    [DataContract(Name = "ExternalSharingSettingsRequestDto")]
    public partial class ExternalSharingSettingsRequestDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalSharingSettingsRequestDto" /> class.
        /// </summary>
        /// <param name="externalShare">Specifies whether external (public) link creation is allowed..</param>
        /// <param name="defaultShareLinkInternal">Specifies the default sharing link type: true &#x3D; DocSpace users only, false &#x3D; Anyone with the link.  Relevant only when ExternalShare is true..</param>
        /// <param name="externalShareApplyToDocuments">When external sharing is restricted, specifies whether to apply the restriction to the My Documents section.  Relevant only when ExternalShare is false..</param>
        /// <param name="externalShareApplyToRooms">When external sharing is restricted, specifies whether to apply the restriction to the Rooms section.  Relevant only when ExternalShare is false..</param>
        /// <param name="blockExistingLinksOnRestrict">When external sharing is restricted, specifies whether to block existing public links immediately.  Relevant only when ExternalShare is false..</param>
        public ExternalSharingSettingsRequestDto(bool externalShare = default, bool defaultShareLinkInternal = default, bool externalShareApplyToDocuments = default, bool externalShareApplyToRooms = default, bool blockExistingLinksOnRestrict = default)
        {
            this.ExternalShare = externalShare;
            this.DefaultShareLinkInternal = defaultShareLinkInternal;
            this.ExternalShareApplyToDocuments = externalShareApplyToDocuments;
            this.ExternalShareApplyToRooms = externalShareApplyToRooms;
            this.BlockExistingLinksOnRestrict = blockExistingLinksOnRestrict;
        }

        /// <summary>
        /// Specifies whether external (public) link creation is allowed.
        /// </summary>
        /// <value>Specifies whether external (public) link creation is allowed.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "externalShare", EmitDefaultValue = true)]
        public bool ExternalShare { get; set; }

        /// <summary>
        /// Specifies the default sharing link type: true &#x3D; DocSpace users only, false &#x3D; Anyone with the link.  Relevant only when ExternalShare is true.
        /// </summary>
        /// <value>Specifies the default sharing link type: true &#x3D; DocSpace users only, false &#x3D; Anyone with the link.  Relevant only when ExternalShare is true.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "defaultShareLinkInternal", EmitDefaultValue = true)]
        public bool DefaultShareLinkInternal { get; set; }

        /// <summary>
        /// When external sharing is restricted, specifies whether to apply the restriction to the My Documents section.  Relevant only when ExternalShare is false.
        /// </summary>
        /// <value>When external sharing is restricted, specifies whether to apply the restriction to the My Documents section.  Relevant only when ExternalShare is false.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "externalShareApplyToDocuments", EmitDefaultValue = true)]
        public bool ExternalShareApplyToDocuments { get; set; }

        /// <summary>
        /// When external sharing is restricted, specifies whether to apply the restriction to the Rooms section.  Relevant only when ExternalShare is false.
        /// </summary>
        /// <value>When external sharing is restricted, specifies whether to apply the restriction to the Rooms section.  Relevant only when ExternalShare is false.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "externalShareApplyToRooms", EmitDefaultValue = true)]
        public bool ExternalShareApplyToRooms { get; set; }

        /// <summary>
        /// When external sharing is restricted, specifies whether to block existing public links immediately.  Relevant only when ExternalShare is false.
        /// </summary>
        /// <value>When external sharing is restricted, specifies whether to block existing public links immediately.  Relevant only when ExternalShare is false.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "blockExistingLinksOnRestrict", EmitDefaultValue = true)]
        public bool BlockExistingLinksOnRestrict { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalSharingSettingsRequestDto {\n");
            sb.Append("  ExternalShare: ").Append(ExternalShare).Append("\n");
            sb.Append("  DefaultShareLinkInternal: ").Append(DefaultShareLinkInternal).Append("\n");
            sb.Append("  ExternalShareApplyToDocuments: ").Append(ExternalShareApplyToDocuments).Append("\n");
            sb.Append("  ExternalShareApplyToRooms: ").Append(ExternalShareApplyToRooms).Append("\n");
            sb.Append("  BlockExistingLinksOnRestrict: ").Append(BlockExistingLinksOnRestrict).Append("\n");
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
