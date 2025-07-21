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
    /// The document watermark parameters.
    /// </summary>
    [DataContract(Name = "WatermarkOnDraw")]
    public partial class WatermarkOnDraw : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkOnDraw" /> class.
        /// </summary>
        /// <param name="width">Defines the watermark width measured in millimeters..</param>
        /// <param name="height">Defines the watermark height measured in millimeters..</param>
        /// <param name="margins">Defines the watermark margins measured in millimeters..</param>
        /// <param name="fill">Defines the watermark fill color..</param>
        /// <param name="rotate">Defines the watermark rotation angle..</param>
        /// <param name="transparent">Defines the watermark transparency percentage..</param>
        /// <param name="paragraphs">The list of paragraphs of the watermark..</param>
        public WatermarkOnDraw(double width = default, double height = default, List<int> margins = default, string fill = default, int rotate = default, double transparent = default, List<Paragraph> paragraphs = default)
        {
            this.Width = width;
            this.Height = height;
            this.Margins = margins;
            this.Fill = fill;
            this.Rotate = rotate;
            this.Transparent = transparent;
            this.Paragraphs = paragraphs;
        }

        /// <summary>
        /// Defines the watermark width measured in millimeters.
        /// </summary>
        /// <value>Defines the watermark width measured in millimeters.</value>
        /*
        <example>-8.5</example>
        */
        [DataMember(Name = "width", EmitDefaultValue = false)]
        public double Width { get; set; }

        /// <summary>
        /// Defines the watermark height measured in millimeters.
        /// </summary>
        /// <value>Defines the watermark height measured in millimeters.</value>
        /*
        <example>-8.5</example>
        */
        [DataMember(Name = "height", EmitDefaultValue = false)]
        public double Height { get; set; }

        /// <summary>
        /// Defines the watermark margins measured in millimeters.
        /// </summary>
        /// <value>Defines the watermark margins measured in millimeters.</value>
        /*
        <example>[1234]</example>
        */
        [DataMember(Name = "margins", EmitDefaultValue = true)]
        public List<int> Margins { get; set; }

        /// <summary>
        /// Defines the watermark fill color.
        /// </summary>
        /// <value>Defines the watermark fill color.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "fill", EmitDefaultValue = true)]
        public string Fill { get; set; }

        /// <summary>
        /// Defines the watermark rotation angle.
        /// </summary>
        /// <value>Defines the watermark rotation angle.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "rotate", EmitDefaultValue = false)]
        public int Rotate { get; set; }

        /// <summary>
        /// Defines the watermark transparency percentage.
        /// </summary>
        /// <value>Defines the watermark transparency percentage.</value>
        /*
        <example>-8.5</example>
        */
        [DataMember(Name = "transparent", EmitDefaultValue = false)]
        public double Transparent { get; set; }

        /// <summary>
        /// The list of paragraphs of the watermark.
        /// </summary>
        /// <value>The list of paragraphs of the watermark.</value>
        [DataMember(Name = "paragraphs", EmitDefaultValue = true)]
        public List<Paragraph> Paragraphs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WatermarkOnDraw {\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Margins: ").Append(Margins).Append("\n");
            sb.Append("  Fill: ").Append(Fill).Append("\n");
            sb.Append("  Rotate: ").Append(Rotate).Append("\n");
            sb.Append("  Transparent: ").Append(Transparent).Append("\n");
            sb.Append("  Paragraphs: ").Append(Paragraphs).Append("\n");
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
