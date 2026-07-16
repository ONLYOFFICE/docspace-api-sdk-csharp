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
        [DataMember(Name = "fillArea", EmitDefaultValue = true)]
        public bool FillArea { get; set; }

        /// <summary>
        /// Gets or Sets Greater
        /// </summary>
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
        [DataMember(Name = "ignoreAspectRatio", EmitDefaultValue = true)]
        public bool IgnoreAspectRatio { get; set; }

        /// <summary>
        /// Gets or Sets IsPercentage
        /// </summary>
        [DataMember(Name = "isPercentage", EmitDefaultValue = true)]
        public bool IsPercentage { get; set; }

        /// <summary>
        /// Gets or Sets Less
        /// </summary>
        [DataMember(Name = "less", EmitDefaultValue = true)]
        public bool Less { get; set; }

        /// <summary>
        /// Gets or Sets LimitPixels
        /// </summary>
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
        [DataMember(Name = "x", EmitDefaultValue = false)]
        public int X { get; set; }

        /// <summary>
        /// Gets or Sets Y
        /// </summary>
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
