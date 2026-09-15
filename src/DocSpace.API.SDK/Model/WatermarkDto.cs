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
    /// The watermark drawn over the documents of a room while they are viewed and printed.
    /// </summary>
    [DataContract(Name = "WatermarkDto")]
    public partial class WatermarkDto : IValidatableObject
    {

        /// <summary>
        /// Which details of the reader and of the room are stamped alongside the text. The values combine, so a number  that is not a member on its own is the sum of several of them, and 0 means that only the text is stamped.
        /// </summary>
        [DataMember(Name = "additions", IsRequired = true, EmitDefaultValue = true)]
        public WatermarkAdditions Additions { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WatermarkDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkDto" /> class.
        /// </summary>
        /// <param name="additions">Which details of the reader and of the room are stamped alongside the text. The values combine, so a number  that is not a member on its own is the sum of several of them, and 0 means that only the text is stamped. (required).</param>
        /// <param name="text">The fixed line drawn over the document, printed before the details selected alongside it. Empty when the room  stamps an image instead..</param>
        /// <param name="rotate">How far the stamp is turned, in degrees, with negative values turning it anticlockwise and 0 drawing it  horizontally. (required).</param>
        /// <param name="imageScale">How large the image is drawn, as a percentage of its own size. It is 0 for a text watermark, where nothing is  scaled. (required).</param>
        /// <param name="imageUrl">The address the stamped picture is served from, inside the storage of the room. Empty for a text watermark..</param>
        /// <param name="imageHeight">The height the picture is drawn with, in pixels, kept together with the width so that the proportions survive.  It is 0 for a text watermark. (required).</param>
        /// <param name="imageWidth">The width the picture is drawn with, in pixels, kept together with the height so that the proportions survive.  It is 0 for a text watermark. (required).</param>
        public WatermarkDto(WatermarkAdditions additions = default, string text = default, int rotate = default, int imageScale = default, string imageUrl = default, double imageHeight = default, double imageWidth = default)
        {
            this.Additions = additions;
            this.Rotate = rotate;
            this.ImageScale = imageScale;
            this.ImageHeight = imageHeight;
            this.ImageWidth = imageWidth;
            this.Text = text;
            this.ImageUrl = imageUrl;
        }

        /// <summary>
        /// The fixed line drawn over the document, printed before the details selected alongside it. Empty when the room  stamps an image instead.
        /// </summary>
        /// <example>Confidential</example>
        [DataMember(Name = "text", EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// How far the stamp is turned, in degrees, with negative values turning it anticlockwise and 0 drawing it  horizontally.
        /// </summary>
        /// <example>-45</example>
        [DataMember(Name = "rotate", IsRequired = true, EmitDefaultValue = true)]
        public int Rotate { get; set; }

        /// <summary>
        /// How large the image is drawn, as a percentage of its own size. It is 0 for a text watermark, where nothing is  scaled.
        /// </summary>
        /// <example>100</example>
        [DataMember(Name = "imageScale", IsRequired = true, EmitDefaultValue = true)]
        public int ImageScale { get; set; }

        /// <summary>
        /// The address the stamped picture is served from, inside the storage of the room. Empty for a text watermark.
        /// </summary>
        /// <example>https://portal.example.com/storage/watermark_a1b2c3.png</example>
        [DataMember(Name = "imageUrl", EmitDefaultValue = true)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// The height the picture is drawn with, in pixels, kept together with the width so that the proportions survive.  It is 0 for a text watermark.
        /// </summary>
        /// <example>100.0</example>
        [DataMember(Name = "imageHeight", IsRequired = true, EmitDefaultValue = true)]
        public double ImageHeight { get; set; }

        /// <summary>
        /// The width the picture is drawn with, in pixels, kept together with the height so that the proportions survive.  It is 0 for a text watermark.
        /// </summary>
        /// <example>200.0</example>
        [DataMember(Name = "imageWidth", IsRequired = true, EmitDefaultValue = true)]
        public double ImageWidth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WatermarkDto {\n");
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
            yield break;
        }

    }


}
