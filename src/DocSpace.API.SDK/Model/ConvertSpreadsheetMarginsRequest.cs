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
    /// The margins of the output PDF file, each a length with its unit: mm, cm or in.
    /// </summary>
    [DataContract(Name = "ConvertSpreadsheetMarginsRequest")]
    public partial class ConvertSpreadsheetMarginsRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertSpreadsheetMarginsRequest" /> class.
        /// </summary>
        /// <param name="left">The left margin of the output PDF file..</param>
        /// <param name="right">The right margin of the output PDF file..</param>
        /// <param name="top">The top margin of the output PDF file..</param>
        /// <param name="bottom">The bottom margin of the output PDF file..</param>
        public ConvertSpreadsheetMarginsRequest(string left = default, string right = default, string top = default, string bottom = default)
        {
            this.Left = left;
            this.Right = right;
            this.Top = top;
            this.Bottom = bottom;
        }

        /// <summary>
        /// The left margin of the output PDF file.
        /// </summary>
        /// <example>0.7in</example>
        [DataMember(Name = "left", EmitDefaultValue = true)]
        public string Left { get; set; }

        /// <summary>
        /// The right margin of the output PDF file.
        /// </summary>
        /// <example>0.7in</example>
        [DataMember(Name = "right", EmitDefaultValue = true)]
        public string Right { get; set; }

        /// <summary>
        /// The top margin of the output PDF file.
        /// </summary>
        /// <example>0.75in</example>
        [DataMember(Name = "top", EmitDefaultValue = true)]
        public string Top { get; set; }

        /// <summary>
        /// The bottom margin of the output PDF file.
        /// </summary>
        /// <example>0.75in</example>
        [DataMember(Name = "bottom", EmitDefaultValue = true)]
        public string Bottom { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConvertSpreadsheetMarginsRequest {\n");
            sb.Append("  Left: ").Append(Left).Append("\n");
            sb.Append("  Right: ").Append(Right).Append("\n");
            sb.Append("  Top: ").Append(Top).Append("\n");
            sb.Append("  Bottom: ").Append(Bottom).Append("\n");
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
