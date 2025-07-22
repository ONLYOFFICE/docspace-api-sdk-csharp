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

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// The custom color theme color parameters.
    /// </summary>
    [DataContract(Name = "CustomColorThemesSettingsColorItem")]
    public partial class CustomColorThemesSettingsColorItem : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomColorThemesSettingsColorItem" /> class.
        /// </summary>
        /// <param name="accent">The accent color..</param>
        /// <param name="buttons">The button color..</param>
        public CustomColorThemesSettingsColorItem(string accent = default, string buttons = default)
        {
            this.Accent = accent;
            this.Buttons = buttons;
        }

        /// <summary>
        /// The accent color.
        /// </summary>
        /// <value>The accent color.</value>
        /*
        <example>#4781D1</example>
        */
        [DataMember(Name = "accent", EmitDefaultValue = true)]
        public string Accent { get; set; }

        /// <summary>
        /// The button color.
        /// </summary>
        /// <value>The button color.</value>
        /*
        <example>#5299E0</example>
        */
        [DataMember(Name = "buttons", EmitDefaultValue = true)]
        public string Buttons { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CustomColorThemesSettingsColorItem {\n");
            sb.Append("  Accent: ").Append(Accent).Append("\n");
            sb.Append("  Buttons: ").Append(Buttons).Append("\n");
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
