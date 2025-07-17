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
    /// IMagickGeometry
    /// </summary>
    [DataContract(Name = "IMagickGeometry")]
    public partial class IMagickGeometry : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="IMagickGeometry" /> class.
        /// </summary>
        /// <param name="fillArea">fillArea.</param>
        /// <param name="greater">greater.</param>
        /// <param name="height">height.</param>
        /// <param name="ignoreAspectRatio">ignoreAspectRatio.</param>
        /// <param name="isPercentage">isPercentage.</param>
        /// <param name="less">less.</param>
        /// <param name="limitPixels">limitPixels.</param>
        /// <param name="width">width.</param>
        /// <param name="x">x.</param>
        /// <param name="y">y.</param>
        public IMagickGeometry(bool fillArea = default, bool greater = default, int height = default, bool ignoreAspectRatio = default, bool isPercentage = default, bool less = default, bool limitPixels = default, int width = default, int x = default, int y = default)
        {
            this.FillArea = fillArea;
            this.Greater = greater;
            this.Height = height;
            this.IgnoreAspectRatio = ignoreAspectRatio;
            this.IsPercentage = isPercentage;
            this.Less = less;
            this.LimitPixels = limitPixels;
            this.Width = width;
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Gets or Sets AspectRatio
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "aspectRatio", EmitDefaultValue = true)]
        public bool AspectRatio { get; private set; }

        /// <summary>
        /// Returns false as AspectRatio should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeAspectRatio()
        {
            return false;
        }
        /// <summary>
        /// Gets or Sets FillArea
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "fillArea", EmitDefaultValue = true)]
        public bool FillArea { get; set; }

        /// <summary>
        /// Gets or Sets Greater
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "greater", EmitDefaultValue = true)]
        public bool Greater { get; set; }

        /// <summary>
        /// Gets or Sets Height
        /// </summary>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        public int Height { get; set; }

        /// <summary>
        /// Gets or Sets IgnoreAspectRatio
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "ignoreAspectRatio", EmitDefaultValue = true)]
        public bool IgnoreAspectRatio { get; set; }

        /// <summary>
        /// Gets or Sets IsPercentage
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isPercentage", EmitDefaultValue = true)]
        public bool IsPercentage { get; set; }

        /// <summary>
        /// Gets or Sets Less
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "less", EmitDefaultValue = true)]
        public bool Less { get; set; }

        /// <summary>
        /// Gets or Sets LimitPixels
        /// </summary>
        /*
        <example>true</example>
        */
        [DataMember(Name = "limitPixels", EmitDefaultValue = true)]
        public bool LimitPixels { get; set; }

        /// <summary>
        /// Gets or Sets Width
        /// </summary>
        [DataMember(Name = "width", EmitDefaultValue = false)]
        public int Width { get; set; }

        /// <summary>
        /// Gets or Sets X
        /// </summary>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "x", EmitDefaultValue = false)]
        public int X { get; set; }

        /// <summary>
        /// Gets or Sets Y
        /// </summary>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "y", EmitDefaultValue = false)]
        public int Y { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IMagickGeometry {\n");
            sb.Append("  AspectRatio: ").Append(AspectRatio).Append("\n");
            sb.Append("  FillArea: ").Append(FillArea).Append("\n");
            sb.Append("  Greater: ").Append(Greater).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  IgnoreAspectRatio: ").Append(IgnoreAspectRatio).Append("\n");
            sb.Append("  IsPercentage: ").Append(IsPercentage).Append("\n");
            sb.Append("  Less: ").Append(Less).Append("\n");
            sb.Append("  LimitPixels: ").Append(LimitPixels).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
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
