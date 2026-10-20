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
    /// The layout of forms printed as pdf documents or images.
    /// </summary>
    [DataContract(Name = "ConvertDocumentLayoutRequest")]
    public partial class ConvertDocumentLayoutRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertDocumentLayoutRequest" /> class.
        /// </summary>
        /// <param name="drawPlaceHolders">Whether an empty form field shows its placeholder text in the result; false leaves it blank..</param>
        /// <param name="drawFormHighlight">Whether form fields keep their highlight colour in the result; false draws them without it..</param>
        /// <param name="isPrint">Whether the print mode is turned on. It only applies to a docx converted into pdf: with the print mode off  the highlight flag does nothing and the placeholder flag saves the forms in the pdf..</param>
        public ConvertDocumentLayoutRequest(bool? drawPlaceHolders = default, bool? drawFormHighlight = default, bool? isPrint = default)
        {
            this.DrawPlaceHolders = drawPlaceHolders;
            this.DrawFormHighlight = drawFormHighlight;
            this.IsPrint = isPrint;
        }

        /// <summary>
        /// Whether an empty form field shows its placeholder text in the result; false leaves it blank.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "drawPlaceHolders", EmitDefaultValue = true)]
        public bool? DrawPlaceHolders { get; set; }

        /// <summary>
        /// Whether form fields keep their highlight colour in the result; false draws them without it.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "drawFormHighlight", EmitDefaultValue = true)]
        public bool? DrawFormHighlight { get; set; }

        /// <summary>
        /// Whether the print mode is turned on. It only applies to a docx converted into pdf: with the print mode off  the highlight flag does nothing and the placeholder flag saves the forms in the pdf.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "isPrint", EmitDefaultValue = true)]
        public bool? IsPrint { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConvertDocumentLayoutRequest {\n");
            sb.Append("  DrawPlaceHolders: ").Append(DrawPlaceHolders).Append("\n");
            sb.Append("  DrawFormHighlight: ").Append(DrawFormHighlight).Append("\n");
            sb.Append("  IsPrint: ").Append(IsPrint).Append("\n");
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
