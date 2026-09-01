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
    /// The white label logo size parameters.
    /// </summary>
    [DataContract(Name = "WhiteLabelItemSizeDto")]
    public partial class WhiteLabelItemSizeDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WhiteLabelItemSizeDto" /> class.
        /// </summary>
        /// <param name="aspectRatio">Specifies whether the size is an aspect ratio..</param>
        /// <param name="fillArea">Specifies whether the logo is resized based on the smallest fitting dimension..</param>
        /// <param name="greater">Specifies whether the logo is resized only if it is greater than the size..</param>
        /// <param name="height">The logo height, in pixels..</param>
        /// <param name="ignoreAspectRatio">Specifies whether the logo is resized without preserving the aspect ratio..</param>
        /// <param name="isPercentage">Specifies whether the width and height are expressed as percentages..</param>
        /// <param name="less">Specifies whether the logo is resized only if it is less than the size..</param>
        /// <param name="limitPixels">Specifies whether the logo is resized using a pixel area count limit..</param>
        /// <param name="width">The logo width, in pixels..</param>
        /// <param name="x">The X offset from the origin, in pixels..</param>
        /// <param name="y">The Y offset from the origin, in pixels..</param>
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
        /// Specifies whether the size is an aspect ratio.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "aspectRatio", EmitDefaultValue = true)]
        public bool AspectRatio { get; set; }

        /// <summary>
        /// Specifies whether the logo is resized based on the smallest fitting dimension.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "fillArea", EmitDefaultValue = true)]
        public bool FillArea { get; set; }

        /// <summary>
        /// Specifies whether the logo is resized only if it is greater than the size.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "greater", EmitDefaultValue = true)]
        public bool Greater { get; set; }

        /// <summary>
        /// The logo height, in pixels.
        /// </summary>
        /// <example>48</example>
        [DataMember(Name = "height", EmitDefaultValue = false)]
        public int Height { get; set; }

        /// <summary>
        /// Specifies whether the logo is resized without preserving the aspect ratio.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "ignoreAspectRatio", EmitDefaultValue = true)]
        public bool IgnoreAspectRatio { get; set; }

        /// <summary>
        /// Specifies whether the width and height are expressed as percentages.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isPercentage", EmitDefaultValue = true)]
        public bool IsPercentage { get; set; }

        /// <summary>
        /// Specifies whether the logo is resized only if it is less than the size.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "less", EmitDefaultValue = true)]
        public bool Less { get; set; }

        /// <summary>
        /// Specifies whether the logo is resized using a pixel area count limit.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "limitPixels", EmitDefaultValue = true)]
        public bool LimitPixels { get; set; }

        /// <summary>
        /// The logo width, in pixels.
        /// </summary>
        /// <example>422</example>
        [DataMember(Name = "width", EmitDefaultValue = false)]
        public int Width { get; set; }

        /// <summary>
        /// The X offset from the origin, in pixels.
        /// </summary>
        /// <example>0</example>
        [DataMember(Name = "x", EmitDefaultValue = false)]
        public int X { get; set; }

        /// <summary>
        /// The Y offset from the origin, in pixels.
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
