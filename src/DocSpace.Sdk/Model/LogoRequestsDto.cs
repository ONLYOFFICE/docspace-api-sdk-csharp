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
    /// The request parameters for the theme-specific logo configurations.
    /// </summary>
    [DataContract(Name = "LogoRequestsDto")]
    public partial class LogoRequestsDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LogoRequestsDto" /> class.
        /// </summary>
        /// <param name="light">The URL or base64-encoded image data for the light theme logo..</param>
        /// <param name="dark">The URL or base64-encoded image data for the dark theme logo..</param>
        public LogoRequestsDto(string light = default, string dark = default)
        {
            this.Light = light;
            this.Dark = dark;
        }

        /// <summary>
        /// The URL or base64-encoded image data for the light theme logo.
        /// </summary>
        /// <value>The URL or base64-encoded image data for the light theme logo.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "light", EmitDefaultValue = true)]
        public string Light { get; set; }

        /// <summary>
        /// The URL or base64-encoded image data for the dark theme logo.
        /// </summary>
        /// <value>The URL or base64-encoded image data for the dark theme logo.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "dark", EmitDefaultValue = true)]
        public string Dark { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogoRequestsDto {\n");
            sb.Append("  Light: ").Append(Light).Append("\n");
            sb.Append("  Dark: ").Append(Dark).Append("\n");
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
