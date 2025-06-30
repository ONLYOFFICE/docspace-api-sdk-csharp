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
using FileParameter = DocSpace.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.Client.OpenAPIDateConverter;

namespace DocSpace.Model
{
    /// <summary>
    /// The request parameters for adding watermarks.
    /// </summary>
    [DataContract(Name = "WatermarkRequestDto")]
    public partial class WatermarkRequestDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Additions
        /// </summary>
        [DataMember(Name = "additions", EmitDefaultValue = false)]
        public WatermarkAdditions? Additions { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WatermarkRequestDto" /> class.
        /// </summary>
        /// <param name="enabled">Specifies whether watermarks are on or off..</param>
        /// <param name="additions">additions.</param>
        /// <param name="text">The watermark text..</param>
        /// <param name="rotate">The watermark text and image rotate angle..</param>
        /// <param name="imageScale">The watermark image scale..</param>
        /// <param name="imageUrl">The path to the temporary image file..</param>
        /// <param name="imageHeight">The watermark image height..</param>
        /// <param name="imageWidth">The watermark image width..</param>
        public WatermarkRequestDto(bool? enabled = default, WatermarkAdditions? additions = default, string text = default, int rotate = default, int imageScale = default, string imageUrl = default, double imageHeight = default, double imageWidth = default)
        {
            this.Enabled = enabled;
            this.Additions = additions;
            this.Text = text;
            this.Rotate = rotate;
            this.ImageScale = imageScale;
            this.ImageUrl = imageUrl;
            this.ImageHeight = imageHeight;
            this.ImageWidth = imageWidth;
        }

        /// <summary>
        /// Specifies whether watermarks are on or off.
        /// </summary>
        /// <value>Specifies whether watermarks are on or off.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The watermark text.
        /// </summary>
        /// <value>The watermark text.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "text", EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// The watermark text and image rotate angle.
        /// </summary>
        /// <value>The watermark text and image rotate angle.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "rotate", EmitDefaultValue = false)]
        public int Rotate { get; set; }

        /// <summary>
        /// The watermark image scale.
        /// </summary>
        /// <value>The watermark image scale.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "imageScale", EmitDefaultValue = false)]
        public int ImageScale { get; set; }

        /// <summary>
        /// The path to the temporary image file.
        /// </summary>
        /// <value>The path to the temporary image file.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "imageUrl", EmitDefaultValue = true)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// The watermark image height.
        /// </summary>
        /// <value>The watermark image height.</value>
        /*
        <example>-8.5</example>
        */
        [DataMember(Name = "imageHeight", EmitDefaultValue = false)]
        public double ImageHeight { get; set; }

        /// <summary>
        /// The watermark image width.
        /// </summary>
        /// <value>The watermark image width.</value>
        /*
        <example>-8.5</example>
        */
        [DataMember(Name = "imageWidth", EmitDefaultValue = false)]
        public double ImageWidth { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WatermarkRequestDto {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  Additions: ").Append(Additions).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Rotate: ").Append(Rotate).Append("\n");
            sb.Append("  ImageScale: ").Append(ImageScale).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  ImageHeight: ").Append(ImageHeight).Append("\n");
            sb.Append("  ImageWidth: ").Append(ImageWidth).Append("\n");
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
            // Text (string) maxLength
            if (this.Text != null && this.Text.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Text, length must be less than 255.", new [] { "Text" });
            }

            // Text (string) minLength
            if (this.Text != null && this.Text.Length < 0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Text, length must be greater than 0.", new [] { "Text" });
            }

            yield break;
        }
    }


}
