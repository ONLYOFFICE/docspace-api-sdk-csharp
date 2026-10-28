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
    /// How a spreadsheet converted to PDF is laid out on the page. A field left out takes the document service default.
    /// </summary>
    [DataContract(Name = "ConvertSpreadsheetLayoutRequest")]
    public partial class ConvertSpreadsheetLayoutRequest : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConvertSpreadsheetLayoutRequest" /> class.
        /// </summary>
        /// <param name="ignorePrintArea">Whether the print area chosen in the spreadsheet is ignored; false converts only that area..</param>
        /// <param name="orientation">The page orientation of the output PDF file: portrait or landscape..</param>
        /// <param name="fitToHeight">The number of pages the converted area is fitted into in height; 0 does not fit it..</param>
        /// <param name="scale">The scale of the output PDF file, in percent..</param>
        /// <param name="fitToWidth">The number of pages the converted area is fitted into in width; 0 does not fit it..</param>
        /// <param name="headings">Whether the row and column headings are printed in the output PDF file..</param>
        /// <param name="gridLines">Whether the grid lines are printed in the output PDF file..</param>
        /// <param name="margins">The margins of the output PDF file..</param>
        /// <param name="pageSize">The page size of the output PDF file..</param>
        public ConvertSpreadsheetLayoutRequest(bool? ignorePrintArea = default, string orientation = default, int? fitToHeight = default, int? scale = default, int? fitToWidth = default, bool? headings = default, bool? gridLines = default, ConvertSpreadsheetMarginsRequest margins = default, ConvertSpreadsheetPageSizeRequest pageSize = default)
        {
            this.IgnorePrintArea = ignorePrintArea;
            this.Orientation = orientation;
            this.FitToHeight = fitToHeight;
            this.Scale = scale;
            this.FitToWidth = fitToWidth;
            this.Headings = headings;
            this.GridLines = gridLines;
            this.Margins = margins;
            this.PageSize = pageSize;
        }

        /// <summary>
        /// Whether the print area chosen in the spreadsheet is ignored; false converts only that area.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "ignorePrintArea", EmitDefaultValue = true)]
        public bool? IgnorePrintArea { get; set; }

        /// <summary>
        /// The page orientation of the output PDF file: portrait or landscape.
        /// </summary>
        /// <example>landscape</example>
        [DataMember(Name = "orientation", EmitDefaultValue = true)]
        public string Orientation { get; set; }

        /// <summary>
        /// The number of pages the converted area is fitted into in height; 0 does not fit it.
        /// </summary>
        /// <example>0</example>
        [DataMember(Name = "fitToHeight", EmitDefaultValue = true)]
        public int? FitToHeight { get; set; }

        /// <summary>
        /// The scale of the output PDF file, in percent.
        /// </summary>
        /// <example>100</example>
        [DataMember(Name = "scale", EmitDefaultValue = true)]
        public int? Scale { get; set; }

        /// <summary>
        /// The number of pages the converted area is fitted into in width; 0 does not fit it.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "fitToWidth", EmitDefaultValue = true)]
        public int? FitToWidth { get; set; }

        /// <summary>
        /// Whether the row and column headings are printed in the output PDF file.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "headings", EmitDefaultValue = true)]
        public bool? Headings { get; set; }

        /// <summary>
        /// Whether the grid lines are printed in the output PDF file.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "gridLines", EmitDefaultValue = true)]
        public bool? GridLines { get; set; }

        /// <summary>
        /// The margins of the output PDF file.
        /// </summary>
        [DataMember(Name = "margins", EmitDefaultValue = false)]
        public ConvertSpreadsheetMarginsRequest Margins { get; set; }

        /// <summary>
        /// The page size of the output PDF file.
        /// </summary>
        [DataMember(Name = "pageSize", EmitDefaultValue = false)]
        public ConvertSpreadsheetPageSizeRequest PageSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConvertSpreadsheetLayoutRequest {\n");
            sb.Append("  IgnorePrintArea: ").Append(IgnorePrintArea).Append("\n");
            sb.Append("  Orientation: ").Append(Orientation).Append("\n");
            sb.Append("  FitToHeight: ").Append(FitToHeight).Append("\n");
            sb.Append("  Scale: ").Append(Scale).Append("\n");
            sb.Append("  FitToWidth: ").Append(FitToWidth).Append("\n");
            sb.Append("  Headings: ").Append(Headings).Append("\n");
            sb.Append("  GridLines: ").Append(GridLines).Append("\n");
            sb.Append("  Margins: ").Append(Margins).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
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
