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
    /// The paragraph parameters.
    /// </summary>
    [DataContract(Name = "Paragraph")]
    public partial class Paragraph : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Paragraph" /> class.
        /// </summary>
        /// <param name="align">The paragraph align..</param>
        /// <param name="runs">The list of text runs from the paragraph..</param>
        public Paragraph(int align = default, List<Run> runs = default)
        {
            this.Align = align;
            this.Runs = runs;
        }

        /// <summary>
        /// The paragraph align.
        /// </summary>
        /// <value>The paragraph align.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "align", EmitDefaultValue = false)]
        public int Align { get; set; }

        /// <summary>
        /// The list of text runs from the paragraph.
        /// </summary>
        /// <value>The list of text runs from the paragraph.</value>
        [DataMember(Name = "runs", EmitDefaultValue = true)]
        public List<Run> Runs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Paragraph {\n");
            sb.Append("  Align: ").Append(Align).Append("\n");
            sb.Append("  Runs: ").Append(Runs).Append("\n");
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
