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
    /// The logo the editor shows, resolved for the file type and the layout of this opening.
    /// </summary>
    [DataContract(Name = "LogoConfigDto")]
    public partial class LogoConfigDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LogoConfigDto" /> class.
        /// </summary>
        /// <param name="image">The logo for the current layout and file type, as the portal branding defines it..</param>
        /// <param name="imageDark">The variant for a dark interface theme..</param>
        /// <param name="imageLight">The variant for a light interface theme..</param>
        /// <param name="imageEmbedded">The variant for the framed viewer. It is empty in every layout but the embedded one..</param>
        /// <param name="url">Where clicking the logo takes the user..</param>
        /// <param name="visible">Whether the logo is shown at all; the mobile layout hides it..</param>
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
        /// The logo for the current layout and file type, as the portal branding defines it.
        /// </summary>
        /// <example>https://portal.example.com/logo/editor.png</example>
        [DataMember(Name = "image", EmitDefaultValue = true)]
        public string Image { get; set; }

        /// <summary>
        /// The variant for a dark interface theme.
        /// </summary>
        /// <example>https://portal.example.com/logo/editor-dark.png</example>
        [DataMember(Name = "imageDark", EmitDefaultValue = true)]
        public string ImageDark { get; set; }

        /// <summary>
        /// The variant for a light interface theme.
        /// </summary>
        /// <example>https://portal.example.com/logo/editor-light.png</example>
        [DataMember(Name = "imageLight", EmitDefaultValue = true)]
        public string ImageLight { get; set; }

        /// <summary>
        /// The variant for the framed viewer. It is empty in every layout but the embedded one.
        /// </summary>
        /// <example>https://portal.example.com/logo/editor-embedded.png</example>
        [DataMember(Name = "imageEmbedded", EmitDefaultValue = true)]
        public string ImageEmbedded { get; set; }

        /// <summary>
        /// Where clicking the logo takes the user.
        /// </summary>
        /// <example>https://portal.example.com</example>
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Whether the logo is shown at all; the mobile layout hides it.
        /// </summary>
        /// <example>true</example>
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
