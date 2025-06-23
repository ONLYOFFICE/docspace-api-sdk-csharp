// (c) Copyright Ascensio System SIA 2009-2025
// 
// This program is a free software product.
// You can redistribute it and/or modify it under the terms
// of the GNU Affero General Public License (AGPL) version 3 as published by the Free Software
// Foundation. In accordance with Section 7(a) of the GNU AGPL its Section 15 shall be amended
// to the effect that Ascensio System SIA expressly excludes the warranty of non-infringement of
// any third-party rights.
// 
// This program is distributed WITHOUT ANY WARRANTY, without even the implied warranty
// of MERCHANTABILITY or FITNESS FOR A PARTICULAR  PURPOSE. For details, see
// the GNU AGPL at: http://www.gnu.org/licenses/agpl-3.0.html
// 
// You can contact Ascensio System SIA at Lubanas st. 125a-25, Riga, Latvia, EU, LV-1021.
// 
// The  interactive user interfaces in modified source and object code versions of the Program must
// display Appropriate Legal Notices, as required under Section 5 of the GNU AGPL version 3.
// 
// Pursuant to Section 7(b) of the License you must retain the original Product logo when
// distributing the program. Pursuant to Section 7(e) we decline to grant you any rights under
// trademark law for use of our trademarks.
// 
// All the Product's GUI elements, including illustrations and icon sets, as well as technical writing
// content are licensed under the terms of the Creative Commons Attribution-ShareAlike 4.0
// International. See the License terms at http://creativecommons.org/licenses/by-sa/4.0/legalcode


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
using FileParameter = Docspace.Client.FileParameter;
using OpenAPIDateConverter = Docspace.Client.OpenAPIDateConverter;

namespace Docspace.Model
{
    /// <summary>
    /// The document watermark parameters.
    /// </summary>
    [DataContract(Name = "WatermarkOnDraw")]
    public partial class WatermarkOnDraw : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkOnDraw" /> class.
        /// </summary>
        /// <param name="width">Defines the watermark width measured in millimeters..</param>
        /// <param name="height">Defines the watermark height measured in millimeters..</param>
        /// <param name="margins">Defines the watermark margins measured in millimeters..</param>
        /// <param name="fill">Defines the watermark fill color..</param>
        /// <param name="rotate">Defines the watermark rotation angle..</param>
        /// <param name="transparent">Defines the watermark transparency percentage..</param>
        /// <param name="paragraphs">The list of paragraphs of the watermark..</param>
        public WatermarkOnDraw(double width = default, double height = default, List<int> margins = default, string fill = default, int rotate = default, double transparent = default, List<Paragraph> paragraphs = default)
        {
            this.Width = width;
            this.Height = height;
            this.Margins = margins;
            this.Fill = fill;
            this.Rotate = rotate;
            this.Transparent = transparent;
            this.Paragraphs = paragraphs;
        }

        /// <summary>
        /// Defines the watermark width measured in millimeters.
        /// </summary>
        /// <value>Defines the watermark width measured in millimeters.</value>
        /*
        <example>-8.5</example>
        */
        [DataMember(Name = "width", EmitDefaultValue = false)]
        public double Width { get; set; }

        /// <summary>
        /// Defines the watermark height measured in millimeters.
        /// </summary>
        /// <value>Defines the watermark height measured in millimeters.</value>
        /*
        <example>-8.5</example>
        */
        [DataMember(Name = "height", EmitDefaultValue = false)]
        public double Height { get; set; }

        /// <summary>
        /// Defines the watermark margins measured in millimeters.
        /// </summary>
        /// <value>Defines the watermark margins measured in millimeters.</value>
        /*
        <example>[1234]</example>
        */
        [DataMember(Name = "margins", EmitDefaultValue = true)]
        public List<int> Margins { get; set; }

        /// <summary>
        /// Defines the watermark fill color.
        /// </summary>
        /// <value>Defines the watermark fill color.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "fill", EmitDefaultValue = true)]
        public string Fill { get; set; }

        /// <summary>
        /// Defines the watermark rotation angle.
        /// </summary>
        /// <value>Defines the watermark rotation angle.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "rotate", EmitDefaultValue = false)]
        public int Rotate { get; set; }

        /// <summary>
        /// Defines the watermark transparency percentage.
        /// </summary>
        /// <value>Defines the watermark transparency percentage.</value>
        /*
        <example>-8.5</example>
        */
        [DataMember(Name = "transparent", EmitDefaultValue = false)]
        public double Transparent { get; set; }

        /// <summary>
        /// The list of paragraphs of the watermark.
        /// </summary>
        /// <value>The list of paragraphs of the watermark.</value>
        [DataMember(Name = "paragraphs", EmitDefaultValue = true)]
        public List<Paragraph> Paragraphs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WatermarkOnDraw {\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Margins: ").Append(Margins).Append("\n");
            sb.Append("  Fill: ").Append(Fill).Append("\n");
            sb.Append("  Rotate: ").Append(Rotate).Append("\n");
            sb.Append("  Transparent: ").Append(Transparent).Append("\n");
            sb.Append("  Paragraphs: ").Append(Paragraphs).Append("\n");
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
