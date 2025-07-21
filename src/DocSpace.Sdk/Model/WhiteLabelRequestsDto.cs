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
    /// The request parameters for configuring the white label branding settings.
    /// </summary>
    [DataContract(Name = "WhiteLabelRequestsDto")]
    public partial class WhiteLabelRequestsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WhiteLabelRequestsDto" /> class.
        /// </summary>
        /// <param name="logoText">The text to display alongside or in place of the logo..</param>
        /// <param name="logo">The white label tenant IDs with their logos (light or dark)..</param>
        public WhiteLabelRequestsDto(string logoText = default, List<ItemKeyValuePairStringLogoRequestsDto> logo = default)
        {
            this.LogoText = logoText;
            this.Logo = logo;
        }

        /// <summary>
        /// The text to display alongside or in place of the logo.
        /// </summary>
        /// <value>The text to display alongside or in place of the logo.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "logoText", EmitDefaultValue = true)]
        public string LogoText { get; set; }

        /// <summary>
        /// The white label tenant IDs with their logos (light or dark).
        /// </summary>
        /// <value>The white label tenant IDs with their logos (light or dark).</value>
        [DataMember(Name = "logo", EmitDefaultValue = true)]
        public List<ItemKeyValuePairStringLogoRequestsDto> Logo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WhiteLabelRequestsDto {\n");
            sb.Append("  LogoText: ").Append(LogoText).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
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
            // LogoText (string) maxLength
            if (this.LogoText != null && this.LogoText.Length > 40)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LogoText, length must be less than 40.", new [] { "LogoText" });
            }

            // LogoText (string) minLength
            if (this.LogoText != null && this.LogoText.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LogoText, length must be greater than 0.", new [] { "LogoText" });
            }

            yield break;
        }
    }


}
