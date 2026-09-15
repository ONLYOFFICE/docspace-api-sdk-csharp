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
    /// One branding logo slot of the portal: the size it is drawn at, and where its images are served from.
    /// </summary>
    [DataContract(Name = "WhiteLabelItemDto")]
    public partial class WhiteLabelItemDto : IValidatableObject
    {

        /// <summary>
        /// Which branding slot this entry describes. &#x60;Notification&#x60; is part of the type but never appears here: that  logo is derived from the login-page one and used only in letters.
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public WhiteLabelLogoType? Type { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WhiteLabelItemDto" /> class.
        /// </summary>
        /// <param name="type">Which branding slot this entry describes. &#x60;Notification&#x60; is part of the type but never appears here: that  logo is derived from the login-page one and used only in letters..</param>
        /// <param name="name">The stable name of the same slot, which is what &#x60;GET api/2.0/settings/whitelabel/logos/isdefault&#x60; keys its  entries by. It is a name to match on, not a file name..</param>
        /// <param name="size">The pixel box the slot is drawn in. Only &#x60;width&#x60; and &#x60;height&#x60; carry information here; the resize flags and  offsets alongside them are left at their defaults and say nothing about how an uploaded image is treated..</param>
        /// <param name="path">The absolute URLs to render the slot from, one per theme..</param>
        public WhiteLabelItemDto(WhiteLabelLogoType? type = default, string name = default, WhiteLabelItemSizeDto size = default, WhiteLabelItemPathDto path = default)
        {
            this.Type = type;
            this.Name = name;
            this.Size = size;
            this.Path = path;
        }

        /// <summary>
        /// The stable name of the same slot, which is what &#x60;GET api/2.0/settings/whitelabel/logos/isdefault&#x60; keys its  entries by. It is a name to match on, not a file name.
        /// </summary>
        /// <example>LightSmall</example>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The pixel box the slot is drawn in. Only &#x60;width&#x60; and &#x60;height&#x60; carry information here; the resize flags and  offsets alongside them are left at their defaults and say nothing about how an uploaded image is treated.
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public WhiteLabelItemSizeDto Size { get; set; }

        /// <summary>
        /// The absolute URLs to render the slot from, one per theme.
        /// </summary>
        [DataMember(Name = "path", EmitDefaultValue = false)]
        public WhiteLabelItemPathDto Path { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WhiteLabelItemDto {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
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
