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
    /// The logo config parameters.
    /// </summary>
    [DataContract(Name = "LogoConfigDto")]
    public partial class LogoConfigDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LogoConfigDto" /> class.
        /// </summary>
        /// <param name="image">The image of the logo..</param>
        /// <param name="imageDark">The dark image of the logo..</param>
        /// <param name="imageLight">The light image of the logo..</param>
        /// <param name="imageEmbedded">The embedded image of the logo..</param>
        /// <param name="url">The url link of the logo..</param>
        /// <param name="visible">Specifies if the logo is visible..</param>
        public LogoConfigDto(string image = default, string imageDark = default, string imageLight = default, string imageEmbedded = default, string url = default, bool visible = default)
        {
            this.Image = image;
            this.ImageDark = imageDark;
            this.ImageLight = imageLight;
            this.ImageEmbedded = imageEmbedded;
            this.Url = url;
            this.Visible = visible;
        }

        /// <summary>
        /// The image of the logo.
        /// </summary>
        /// <value>The image of the logo.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "image", EmitDefaultValue = true)]
        public string Image { get; set; }

        /// <summary>
        /// The dark image of the logo.
        /// </summary>
        /// <value>The dark image of the logo.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "imageDark", EmitDefaultValue = true)]
        public string ImageDark { get; set; }

        /// <summary>
        /// The light image of the logo.
        /// </summary>
        /// <value>The light image of the logo.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "imageLight", EmitDefaultValue = true)]
        public string ImageLight { get; set; }

        /// <summary>
        /// The embedded image of the logo.
        /// </summary>
        /// <value>The embedded image of the logo.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "imageEmbedded", EmitDefaultValue = true)]
        public string ImageEmbedded { get; set; }

        /// <summary>
        /// The url link of the logo.
        /// </summary>
        /// <value>The url link of the logo.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Specifies if the logo is visible.
        /// </summary>
        /// <value>Specifies if the logo is visible.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "visible", EmitDefaultValue = true)]
        public bool Visible { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogoConfigDto {\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  ImageDark: ").Append(ImageDark).Append("\n");
            sb.Append("  ImageLight: ").Append(ImageLight).Append("\n");
            sb.Append("  ImageEmbedded: ").Append(ImageEmbedded).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Visible: ").Append(Visible).Append("\n");
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
