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
    /// The request parameters for managing the portal theme settings.
    /// </summary>
    [DataContract(Name = "CustomColorThemesSettingsRequestsDto")]
    public partial class CustomColorThemesSettingsRequestsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomColorThemesSettingsRequestsDto" /> class.
        /// </summary>
        /// <param name="theme">theme.</param>
        /// <param name="selected">Specifies the optional value indicating the selected custom color theme..</param>
        public CustomColorThemesSettingsRequestsDto(CustomColorThemesSettingsItem theme = default, int? selected = default)
        {
            this.Theme = theme;
            this.Selected = selected;
        }

        /// <summary>
        /// Gets or Sets Theme
        /// </summary>
        [DataMember(Name = "theme", EmitDefaultValue = false)]
        public CustomColorThemesSettingsItem Theme { get; set; }

        /// <summary>
        /// Specifies the optional value indicating the selected custom color theme.
        /// </summary>
        /// <value>Specifies the optional value indicating the selected custom color theme.</value>
        /*
        <example>1234</example>
        */
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
