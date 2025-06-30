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
    /// The room logo information.
    /// </summary>
    [DataContract(Name = "Logo")]
    public partial class Logo : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Logo" /> class.
        /// </summary>
        /// <param name="original">The original logo..</param>
        /// <param name="large">The large logo..</param>
        /// <param name="medium">The medium logo..</param>
        /// <param name="small">The small logo..</param>
        /// <param name="color">The logo color..</param>
        /// <param name="cover">cover.</param>
        public Logo(string original = default, string large = default, string medium = default, string small = default, string color = default, LogoCover cover = default)
        {
            this.Original = original;
            this.Large = large;
            this.Medium = medium;
            this.Small = small;
            this.Color = color;
            this.Cover = cover;
        }

        /// <summary>
        /// The original logo.
        /// </summary>
        /// <value>The original logo.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "original", EmitDefaultValue = true)]
        public string Original { get; set; }

        /// <summary>
        /// The large logo.
        /// </summary>
        /// <value>The large logo.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "large", EmitDefaultValue = true)]
        public string Large { get; set; }

        /// <summary>
        /// The medium logo.
        /// </summary>
        /// <value>The medium logo.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "medium", EmitDefaultValue = true)]
        public string Medium { get; set; }

        /// <summary>
        /// The small logo.
        /// </summary>
        /// <value>The small logo.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "small", EmitDefaultValue = true)]
        public string Small { get; set; }

        /// <summary>
        /// The logo color.
        /// </summary>
        /// <value>The logo color.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "color", EmitDefaultValue = true)]
        public string Color { get; set; }

        /// <summary>
        /// Gets or Sets Cover
        /// </summary>
        [DataMember(Name = "cover", EmitDefaultValue = false)]
        public LogoCover Cover { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Logo {\n");
            sb.Append("  Original: ").Append(Original).Append("\n");
            sb.Append("  Large: ").Append(Large).Append("\n");
            sb.Append("  Medium: ").Append(Medium).Append("\n");
            sb.Append("  Small: ").Append(Small).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Cover: ").Append(Cover).Append("\n");
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
