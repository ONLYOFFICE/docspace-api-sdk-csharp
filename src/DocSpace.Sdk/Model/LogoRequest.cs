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
    /// The logo request parameters.
    /// </summary>
    [DataContract(Name = "LogoRequest")]
    public partial class LogoRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="LogoRequest" /> class.
        /// </summary>
        /// <param name="tmpFile">The path to the temporary image file..</param>
        /// <param name="x">The X coordinate of the rectangle starting point..</param>
        /// <param name="y">The Y coordinate of the rectangle starting point..</param>
        /// <param name="width">The rectangle width..</param>
        /// <param name="height">The rectangle height..</param>
        public LogoRequest(string tmpFile = default, int x = default, int y = default, int width = default, int height = default)
        {
            this.TmpFile = tmpFile;
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// The path to the temporary image file.
        /// </summary>
        /// <value>The path to the temporary image file.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "tmpFile", EmitDefaultValue = true)]
        public string TmpFile { get; set; }

        /// <summary>
        /// The X coordinate of the rectangle starting point.
        /// </summary>
        /// <value>The X coordinate of the rectangle starting point.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "x", EmitDefaultValue = false)]
        public int X { get; set; }

        /// <summary>
        /// The Y coordinate of the rectangle starting point.
        /// </summary>
        /// <value>The Y coordinate of the rectangle starting point.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "y", EmitDefaultValue = false)]
        public int Y { get; set; }

        /// <summary>
        /// The rectangle width.
        /// </summary>
        /// <value>The rectangle width.</value>
        [DataMember(Name = "width", EmitDefaultValue = false)]
        public int Width { get; set; }

        /// <summary>
        /// The rectangle height.
        /// </summary>
        /// <value>The rectangle height.</value>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        public int Height { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LogoRequest {\n");
            sb.Append("  TmpFile: ").Append(TmpFile).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
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
