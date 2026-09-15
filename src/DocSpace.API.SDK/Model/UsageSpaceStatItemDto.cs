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
    /// The storage one category of a portal module occupies, in the form a statistics page prints it.
    /// </summary>
    [DataContract(Name = "UsageSpaceStatItemDto")]
    public partial class UsageSpaceStatItemDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="UsageSpaceStatItemDto" /> class.
        /// </summary>
        /// <param name="name">The category name in the portal language, HTML-escaped and ready to be rendered as text. What a category  stands for depends on the module asked about - for the Documents module it is a room type..</param>
        /// <param name="icon">The path of the icon to render beside the name, relative to the portal address. It is empty for a category  that ships no icon..</param>
        /// <param name="disabled">Whether the category is switched off for this portal. A disabled category still reports the space it  occupies, so it is worth showing greyed out rather than dropping..</param>
        /// <param name="size">The occupied space already formatted for display, with its unit and in the portal language - &#x60;0 Byte&#x60; for  an empty category. It is not a byte count and must not be parsed; the raw numbers live in the quota  reported by &#x60;GET api/2.0/portal/quota&#x60;..</param>
        /// <param name="url">The portal page that lists the contents of this category, relative to the portal address, so a statistics  page can link through to it. It is empty for a category with no page of its own..</param>
        public UsageSpaceStatItemDto(string name = default, string icon = default, bool disabled = default, string size = default, string url = default)
        {
            this.Name = name;
            this.Icon = icon;
            this.Disabled = disabled;
            this.Size = size;
            this.Url = url;
        }

        /// <summary>
        /// The category name in the portal language, HTML-escaped and ready to be rendered as text. What a category  stands for depends on the module asked about - for the Documents module it is a room type.
        /// </summary>
        /// <example>Collaboration rooms</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The path of the icon to render beside the name, relative to the portal address. It is empty for a category  that ships no icon.
        /// </summary>
        /// <example>/images/icons/rooms.svg</example>
        [DataMember(Name = "icon", EmitDefaultValue = true)]
        public string Icon { get; set; }

        /// <summary>
        /// Whether the category is switched off for this portal. A disabled category still reports the space it  occupies, so it is worth showing greyed out rather than dropping.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "disabled", EmitDefaultValue = true)]
        public bool Disabled { get; set; }

        /// <summary>
        /// The occupied space already formatted for display, with its unit and in the portal language - &#x60;0 Byte&#x60; for  an empty category. It is not a byte count and must not be parsed; the raw numbers live in the quota  reported by &#x60;GET api/2.0/portal/quota&#x60;.
        /// </summary>
        /// <example>1.5 GB</example>
        [DataMember(Name = "size", EmitDefaultValue = true)]
        public string Size { get; set; }

        /// <summary>
        /// The portal page that lists the contents of this category, relative to the portal address, so a statistics  page can link through to it. It is empty for a category with no page of its own.
        /// </summary>
        /// <example>/rooms/shared</example>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UsageSpaceStatItemDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  Disabled: ").Append(Disabled).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
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
