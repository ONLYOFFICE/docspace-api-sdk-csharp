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
    /// The external sharing policy of the portal as it now stands.
    /// </summary>
    [DataContract(Name = "ExternalSharingSettingsDto")]
    public partial class ExternalSharingSettingsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalSharingSettingsDto" /> class.
        /// </summary>
        /// <param name="externalShare">Whether links that open a file or a room without a portal account may be created. While it is false the portal  also reports sharing on social networks as off and the default link type as internal, whatever was asked for..</param>
        /// <param name="defaultShareLinkInternal">The kind of link the portal offers first: true means a link only accounts of this portal can open, false one  that anyone holding it can open..</param>
        /// <param name="externalShareApplyToDocuments">Whether the restriction covers personal documents. It only has an effect while external sharing is off, so a  true here with sharing allowed restricts nothing..</param>
        /// <param name="externalShareApplyToRooms">Whether the restriction covers rooms, including the creation of new public ones. It only has an effect while  external sharing is off..</param>
        /// <param name="blockExistingLinksOnRestrict">Whether links created before the restriction stop opening as well. With false they keep working and only new  ones are refused..</param>
        public ExternalSharingSettingsDto(bool externalShare = default, bool defaultShareLinkInternal = default, bool externalShareApplyToDocuments = default, bool externalShareApplyToRooms = default, bool blockExistingLinksOnRestrict = default)
        {
            this.ExternalShare = externalShare;
            this.DefaultShareLinkInternal = defaultShareLinkInternal;
            this.ExternalShareApplyToDocuments = externalShareApplyToDocuments;
            this.ExternalShareApplyToRooms = externalShareApplyToRooms;
            this.BlockExistingLinksOnRestrict = blockExistingLinksOnRestrict;
        }

        /// <summary>
        /// Whether links that open a file or a room without a portal account may be created. While it is false the portal  also reports sharing on social networks as off and the default link type as internal, whatever was asked for.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "externalShare", EmitDefaultValue = true)]
        public bool ExternalShare { get; set; }

        /// <summary>
        /// The kind of link the portal offers first: true means a link only accounts of this portal can open, false one  that anyone holding it can open.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "defaultShareLinkInternal", EmitDefaultValue = true)]
        public bool DefaultShareLinkInternal { get; set; }

        /// <summary>
        /// Whether the restriction covers personal documents. It only has an effect while external sharing is off, so a  true here with sharing allowed restricts nothing.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "externalShareApplyToDocuments", EmitDefaultValue = true)]
        public bool ExternalShareApplyToDocuments { get; set; }

        /// <summary>
        /// Whether the restriction covers rooms, including the creation of new public ones. It only has an effect while  external sharing is off.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "externalShareApplyToRooms", EmitDefaultValue = true)]
        public bool ExternalShareApplyToRooms { get; set; }

        /// <summary>
        /// Whether links created before the restriction stop opening as well. With false they keep working and only new  ones are refused.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "blockExistingLinksOnRestrict", EmitDefaultValue = true)]
        public bool BlockExistingLinksOnRestrict { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExternalSharingSettingsDto {\n");
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
