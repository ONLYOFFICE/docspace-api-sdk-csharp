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
    /// The watermark settings.
    /// </summary>
    [DataContract(Name = "WatermarkDto")]
    public partial class WatermarkDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Additions
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
        /// <param name="additions">additions (required).</param>
        /// <param name="text">The watermark text..</param>
        /// <param name="rotate">The watermark text and image rotate. (required).</param>
        /// <param name="imageScale">The watermark image scale. (required).</param>
        /// <param name="imageUrl">The watermark image url..</param>
        /// <param name="imageHeight">The watermark image height. (required).</param>
        /// <param name="imageWidth">The watermark image width. (required).</param>
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
        /// The watermark text.
        /// </summary>
        /// <value>The watermark text.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "text", EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// The watermark text and image rotate.
        /// </summary>
        /// <value>The watermark text and image rotate.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "rotate", IsRequired = true, EmitDefaultValue = true)]
        public int Rotate { get; set; }

        /// <summary>
        /// The watermark image scale.
        /// </summary>
        /// <value>The watermark image scale.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "imageScale", IsRequired = true, EmitDefaultValue = true)]
        public int ImageScale { get; set; }

        /// <summary>
        /// The watermark image url.
        /// </summary>
        /// <value>The watermark image url.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "imageUrl", EmitDefaultValue = true)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// The watermark image height.
        /// </summary>
        /// <value>The watermark image height.</value>
        /*
        <example>-8.5</example>
        */
        [DataMember(Name = "imageHeight", IsRequired = true, EmitDefaultValue = true)]
        public double ImageHeight { get; set; }

        /// <summary>
        /// The watermark image width.
        /// </summary>
        /// <value>The watermark image width.</value>
        /*
        <example>-8.5</example>
        */
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
