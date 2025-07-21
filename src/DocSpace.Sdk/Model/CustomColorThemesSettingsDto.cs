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
    /// The custom color themes settings.
    /// </summary>
    [DataContract(Name = "CustomColorThemesSettingsDto")]
    public partial class CustomColorThemesSettingsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomColorThemesSettingsDto" /> class.
        /// </summary>
        /// <param name="themes">The list of the custom color themes..</param>
        /// <param name="selected">Specifies whether the custom color theme is selected..</param>
        /// <param name="limit">The maximum number of the custom color themes..</param>
        public CustomColorThemesSettingsDto(List<CustomColorThemesSettingsItem> themes = default, int selected = default, int limit = default)
        {
            this.Themes = themes;
            this.Selected = selected;
            this.Limit = limit;
        }

        /// <summary>
        /// The list of the custom color themes.
        /// </summary>
        /// <value>The list of the custom color themes.</value>
        [DataMember(Name = "themes", EmitDefaultValue = true)]
        public List<CustomColorThemesSettingsItem> Themes { get; set; }

        /// <summary>
        /// Specifies whether the custom color theme is selected.
        /// </summary>
        /// <value>Specifies whether the custom color theme is selected.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "selected", EmitDefaultValue = false)]
        public int Selected { get; set; }

        /// <summary>
        /// The maximum number of the custom color themes.
        /// </summary>
        /// <value>The maximum number of the custom color themes.</value>
        /*
        <example>1234</example>
        */
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
