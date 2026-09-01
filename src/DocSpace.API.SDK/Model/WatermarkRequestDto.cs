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
    /// The request parameters for adding watermarks.
    /// </summary>
    [DataContract(Name = "WatermarkRequestDto")]
    public partial class WatermarkRequestDto : IValidatableObject
    {

        /// <summary>
        /// Specifies whether to display the following addditional information or not: username, user email, user IP address, current date and room name.
        /// </summary>
        [DataMember(Name = "additions", EmitDefaultValue = false)]
        public WatermarkAdditions? Additions { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkRequestDto" /> class.
        /// </summary>
        /// <param name="enabled">Specifies whether watermarks are on or off..</param>
        /// <param name="additions">Specifies whether to display the following addditional information or not: username, user email, user IP address, current date and room name..</param>
        /// <param name="text">The watermark text..</param>
        /// <param name="rotate">The watermark text and image rotate angle..</param>
        /// <param name="imageScale">The watermark image scale..</param>
        /// <param name="imageUrl">The path to the temporary image file..</param>
        /// <param name="imageHeight">The watermark image height..</param>
        /// <param name="imageWidth">The watermark image width..</param>
        public WatermarkRequestDto(bool? enabled = default, WatermarkAdditions? additions = default, string text = default, int rotate = default, int imageScale = default, string imageUrl = default, double imageHeight = default, double imageWidth = default)
        {
            this.Enabled = enabled;
            this.Additions = additions;
            this.Text = text;
            this.Rotate = rotate;
            this.ImageScale = imageScale;
            this.ImageUrl = imageUrl;
            this.ImageHeight = imageHeight;
            this.ImageWidth = imageWidth;
        }

        /// <summary>
        /// Specifies whether watermarks are on or off.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The watermark text.
        /// </summary>
        /// <example>Confidential</example>
        [DataMember(Name = "text", EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// The watermark text and image rotate angle.
        /// </summary>
        /// <example>-45</example>
        [DataMember(Name = "rotate", EmitDefaultValue = false)]
        public int Rotate { get; set; }

        /// <summary>
        /// The watermark image scale.
        /// </summary>
        /// <example>100</example>
        [DataMember(Name = "imageScale", EmitDefaultValue = false)]
        public int ImageScale { get; set; }

        /// <summary>
        /// The path to the temporary image file.
        /// </summary>
        /// <example>/tmp/watermark.png</example>
        [DataMember(Name = "imageUrl", EmitDefaultValue = true)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// The watermark image height.
        /// </summary>
        /// <example>100.0</example>
        [DataMember(Name = "imageHeight", EmitDefaultValue = false)]
        public double ImageHeight { get; set; }

        /// <summary>
        /// The watermark image width.
        /// </summary>
        /// <example>200.0</example>
        [DataMember(Name = "imageWidth", EmitDefaultValue = false)]
        public double ImageWidth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WatermarkRequestDto {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Additions: ").Append(Additions).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Rotate: ").Append(Rotate).Append("\n");
            sb.Append("  ImageScale: ").Append(ImageScale).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  ImageHeight: ").Append(ImageHeight).Append("\n");
            sb.Append("  ImageWidth: ").Append(ImageWidth).Append("\n");
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
            // Text (string) maxLength
            if (this.Text != null && this.Text.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Text, length must be less than 255.", new [] { "Text" });
            }

            // Text (string) minLength
            if (this.Text != null && this.Text.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Text, length must be greater than 0.", new [] { "Text" });
            }

            yield break;
        }

    }


}
