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
    /// The custom colour theme being saved, the theme being selected, or both.
    /// </summary>
    [DataContract(Name = "CustomColorThemesSettingsRequestsDto")]
    public partial class CustomColorThemesSettingsRequestsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomColorThemesSettingsRequestsDto" /> class.
        /// </summary>
        /// <param name="theme">The theme to store, with its accent and button colours for the interface and for the text on it. An &#x60;id&#x60; that  matches a stored custom theme replaces it, an unknown &#x60;id&#x60; appends a new one, and an &#x60;id&#x60; belonging to a  built-in theme is treated as a request for a new custom theme rather than overwriting the built-in one. Once  the plan limit on custom themes is reached a new theme is silently not added, so compare the returned themes  against &#x60;limit&#x60; instead of assuming it was saved. Leave it out to change only the selection..</param>
        /// <param name="selected">The theme the whole portal switches to, by theme ID. An ID matching no stored theme is ignored rather than  refused, and leaving it out keeps the selection as it is..</param>
        public CustomColorThemesSettingsRequestsDto(CustomColorThemesSettingsItem theme = default, int? selected = default)
        {
            this.Theme = theme;
            this.Selected = selected;
        }

        /// <summary>
        /// The theme to store, with its accent and button colours for the interface and for the text on it. An &#x60;id&#x60; that  matches a stored custom theme replaces it, an unknown &#x60;id&#x60; appends a new one, and an &#x60;id&#x60; belonging to a  built-in theme is treated as a request for a new custom theme rather than overwriting the built-in one. Once  the plan limit on custom themes is reached a new theme is silently not added, so compare the returned themes  against &#x60;limit&#x60; instead of assuming it was saved. Leave it out to change only the selection.
        /// </summary>
        [DataMember(Name = "theme", EmitDefaultValue = false)]
        public CustomColorThemesSettingsItem Theme { get; set; }

        /// <summary>
        /// The theme the whole portal switches to, by theme ID. An ID matching no stored theme is ignored rather than  refused, and leaving it out keeps the selection as it is.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "selected", EmitDefaultValue = true)]
        public int? Selected { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomColorThemesSettingsRequestsDto {\n");
            sb.Append("  Theme: ").Append(Theme).Append("\n");
            sb.Append("  Selected: ").Append(Selected).Append("\n");
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
