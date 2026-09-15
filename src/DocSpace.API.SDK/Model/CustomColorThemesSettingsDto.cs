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
    /// The colour themes the portal offers, which of them is applied, and how many the plan allows.
    /// </summary>
    [DataContract(Name = "CustomColorThemesSettingsDto")]
    public partial class CustomColorThemesSettingsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomColorThemesSettingsDto" /> class.
        /// </summary>
        /// <param name="themes">Every theme the portal can apply, ordered by ID, with the built-in ones first because they were created  first. It is never empty - the built-in themes cannot be deleted - and a custom theme is one whose ID is  higher than the built-in ones..</param>
        /// <param name="selected">The ID of the theme in &#x60;themes&#x60; that is currently applied to the whole portal. Deleting the applied theme  moves it to the lowest remaining ID, so it can change without anyone having chosen a new one..</param>
        /// <param name="limit">How many entries &#x60;themes&#x60; may hold in total, built-in ones included; &#x60;0&#x60; means the plan caps nothing. Once  the cap is reached &#x60;PUT api/2.0/settings/colortheme&#x60; drops a new theme silently instead of failing, so  compare this with the length of &#x60;themes&#x60; to tell whether a save took effect..</param>
        public CustomColorThemesSettingsDto(List<CustomColorThemesSettingsItem> themes = default, int selected = default, int limit = default)
        {
            this.Themes = themes;
            this.Selected = selected;
            this.Limit = limit;
        }

        /// <summary>
        /// Every theme the portal can apply, ordered by ID, with the built-in ones first because they were created  first. It is never empty - the built-in themes cannot be deleted - and a custom theme is one whose ID is  higher than the built-in ones.
        /// </summary>
        /// <example>[{"id":1,"name":"Custom Theme"}]</example>
        [DataMember(Name = "themes", EmitDefaultValue = true)]
        public List<CustomColorThemesSettingsItem> Themes { get; set; }

        /// <summary>
        /// The ID of the theme in &#x60;themes&#x60; that is currently applied to the whole portal. Deleting the applied theme  moves it to the lowest remaining ID, so it can change without anyone having chosen a new one.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "selected", EmitDefaultValue = false)]
        public int Selected { get; set; }

        /// <summary>
        /// How many entries &#x60;themes&#x60; may hold in total, built-in ones included; &#x60;0&#x60; means the plan caps nothing. Once  the cap is reached &#x60;PUT api/2.0/settings/colortheme&#x60; drops a new theme silently instead of failing, so  compare this with the length of &#x60;themes&#x60; to tell whether a save took effect.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public int Limit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomColorThemesSettingsDto {\n");
            sb.Append("  Themes: ").Append(Themes).Append("\n");
            sb.Append("  Selected: ").Append(Selected).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
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
