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
    /// The pixel box a logo slot is drawn in, in the shape the imaging library reports a geometry.
    /// </summary>
    [DataContract(Name = "WhiteLabelItemSizeDto")]
    public partial class WhiteLabelItemSizeDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WhiteLabelItemSizeDto" /> class.
        /// </summary>
        /// <param name="aspectRatio">Whether the numbers are to be read as an aspect ratio rather than as pixels. Always &#x60;false&#x60; on the sizes  this API reports..</param>
        /// <param name="fillArea">Whether an image would be scaled to cover the box rather than to fit inside it. Always &#x60;false&#x60; here..</param>
        /// <param name="greater">Whether scaling would apply only to an image larger than the box. Always &#x60;false&#x60; here..</param>
        /// <param name="height">The height of the box in pixels - one of the two fields of this object that carry information..</param>
        /// <param name="ignoreAspectRatio">Whether scaling would be allowed to distort the image. Always &#x60;false&#x60; here..</param>
        /// <param name="isPercentage">Whether &#x60;width&#x60; and &#x60;height&#x60; are to be read as percentages. Always &#x60;false&#x60; here, so both are pixels..</param>
        /// <param name="less">Whether scaling would apply only to an image smaller than the box. Always &#x60;false&#x60; here..</param>
        /// <param name="limitPixels">Whether the box is to be read as a total pixel-area budget instead of as two dimensions. Always &#x60;false&#x60;  here..</param>
        /// <param name="width">The width of the box in pixels - the other field of this object that carries information..</param>
        /// <param name="x">The horizontal offset of the box from the origin. Always &#x60;0&#x60; here..</param>
        /// <param name="y">The vertical offset of the box from the origin. Always &#x60;0&#x60; here..</param>
        public WhiteLabelItemSizeDto(bool aspectRatio = default, bool fillArea = default, bool greater = default, int height = default, bool ignoreAspectRatio = default, bool isPercentage = default, bool less = default, bool limitPixels = default, int width = default, int x = default, int y = default)
        {
            this.AspectRatio = aspectRatio;
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
        /// Whether the numbers are to be read as an aspect ratio rather than as pixels. Always &#x60;false&#x60; on the sizes  this API reports.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "aspectRatio", EmitDefaultValue = true)]
        public bool AspectRatio { get; set; }

        /// <summary>
        /// Whether an image would be scaled to cover the box rather than to fit inside it. Always &#x60;false&#x60; here.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "fillArea", EmitDefaultValue = true)]
        public bool FillArea { get; set; }

        /// <summary>
        /// Whether scaling would apply only to an image larger than the box. Always &#x60;false&#x60; here.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "greater", EmitDefaultValue = true)]
        public bool Greater { get; set; }

        /// <summary>
        /// The height of the box in pixels - one of the two fields of this object that carry information.
        /// </summary>
        /// <example>48</example>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        public int Height { get; set; }

        /// <summary>
        /// Whether scaling would be allowed to distort the image. Always &#x60;false&#x60; here.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "ignoreAspectRatio", EmitDefaultValue = true)]
        public bool IgnoreAspectRatio { get; set; }

        /// <summary>
        /// Whether &#x60;width&#x60; and &#x60;height&#x60; are to be read as percentages. Always &#x60;false&#x60; here, so both are pixels.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isPercentage", EmitDefaultValue = true)]
        public bool IsPercentage { get; set; }

        /// <summary>
        /// Whether scaling would apply only to an image smaller than the box. Always &#x60;false&#x60; here.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "less", EmitDefaultValue = true)]
        public bool Less { get; set; }

        /// <summary>
        /// Whether the box is to be read as a total pixel-area budget instead of as two dimensions. Always &#x60;false&#x60;  here.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "limitPixels", EmitDefaultValue = true)]
        public bool LimitPixels { get; set; }

        /// <summary>
        /// The width of the box in pixels - the other field of this object that carries information.
        /// </summary>
        /// <example>422</example>
        [DataMember(Name = "width", EmitDefaultValue = false)]
        public int Width { get; set; }

        /// <summary>
        /// The horizontal offset of the box from the origin. Always &#x60;0&#x60; here.
        /// </summary>
        /// <example>0</example>
        [DataMember(Name = "x", EmitDefaultValue = false)]
        public int X { get; set; }

        /// <summary>
        /// The vertical offset of the box from the origin. Always &#x60;0&#x60; here.
        /// </summary>
        /// <example>0</example>
        [DataMember(Name = "y", EmitDefaultValue = false)]
        public int Y { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WhiteLabelItemSizeDto {\n");
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
