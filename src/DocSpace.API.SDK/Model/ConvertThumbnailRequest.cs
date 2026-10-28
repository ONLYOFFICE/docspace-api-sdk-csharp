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
    /// How a thumbnail is fitted. A field left out takes the document service default.
    /// </summary>
    [DataContract(Name = "ConvertThumbnailRequest")]
    public partial class ConvertThumbnailRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertThumbnailRequest" /> class.
        /// </summary>
        /// <param name="aspect">The mode to fit the image to the height and width specified:  0 - stretch file to fit height and width;  1 - keep the aspect for the image;  2 - convert the metric size of the page into pixels at 96 dpi..</param>
        /// <param name="first">Whether a thumbnail is made of the first page only; false makes one of every page..</param>
        /// <param name="height">The thumbnail height in pixels; not used with aspect 2..</param>
        /// <param name="width">The thumbnail width in pixels; not used with aspect 2..</param>
        public ConvertThumbnailRequest(int? aspect = default, bool? first = default, int? height = default, int? width = default)
        {
            this.Aspect = aspect;
            this.First = first;
            this.Height = height;
            this.Width = width;
        }

        /// <summary>
        /// The mode to fit the image to the height and width specified:  0 - stretch file to fit height and width;  1 - keep the aspect for the image;  2 - convert the metric size of the page into pixels at 96 dpi.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "aspect", EmitDefaultValue = true)]
        public int? Aspect { get; set; }

        /// <summary>
        /// Whether a thumbnail is made of the first page only; false makes one of every page.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "first", EmitDefaultValue = true)]
        public bool? First { get; set; }

        /// <summary>
        /// The thumbnail height in pixels; not used with aspect 2.
        /// </summary>
        /// <example>100</example>
        [DataMember(Name = "height", EmitDefaultValue = true)]
        public int? Height { get; set; }

        /// <summary>
        /// The thumbnail width in pixels; not used with aspect 2.
        /// </summary>
        /// <example>100</example>
        [DataMember(Name = "width", EmitDefaultValue = true)]
        public int? Width { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConvertThumbnailRequest {\n");
            sb.Append("  Aspect: ").Append(Aspect).Append("\n");
            sb.Append("  First: ").Append(First).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
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
