/**
 *
 * (c) Copyright Ascensio System SIA 2025
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The text run parameters.
    /// </summary>
    [DataContract(Name = "Run")]
    public partial class Run : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Run" /> class.
        /// </summary>
        /// <param name="fill">The fill color of the text run in RGB format..</param>
        /// <param name="text">The run text..</param>
        /// <param name="fontSize">The font size of the text run in points..</param>
        public Run(List<int> fill = default, string text = default, string fontSize = default)
        {
            this.Fill = fill;
            this.Text = text;
            this.FontSize = fontSize;
        }

        /// <summary>
        /// The fill color of the text run in RGB format.
        /// </summary>
        /// <value>The fill color of the text run in RGB format.</value>
        /*
        <example>[1234]</example>
        */
        [DataMember(Name = "fill", EmitDefaultValue = true)]
        public List<int> Fill { get; set; }

        /// <summary>
        /// The run text.
        /// </summary>
        /// <value>The run text.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "text", EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// The font size of the text run in points.
        /// </summary>
        /// <value>The font size of the text run in points.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "font-size", EmitDefaultValue = true)]
        public string FontSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Run {\n");
            sb.Append("  Fill: ").Append(Fill).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  FontSize: ").Append(FontSize).Append("\n");
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
