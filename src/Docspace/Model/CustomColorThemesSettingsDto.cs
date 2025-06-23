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
    /// The custom color themes settings.
    /// </summary>
    [DataContract(Name = "CustomColorThemesSettingsDto")]
    public partial class CustomColorThemesSettingsDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomColorThemesSettingsDto" /> class.
        /// </summary>
        /// <param name="themes">The list of the custom color themes..</param>
        /// <param name="selected">Specifies whether the custom color theme is selected..</param>
        /// <param name="limit">The maximum number of the custom color themes..</param>
        public CustomColorThemesSettingsDto(List<CustomColorThemesSettingsItem> themes = default, int selected = default, int limit = default)
        {
            this.Themes = themes;
            this.Selected = selected;
            this.Limit = limit;
        }

        /// <summary>
        /// The list of the custom color themes.
        /// </summary>
        /// <value>The list of the custom color themes.</value>
        [DataMember(Name = "themes", EmitDefaultValue = true)]
        public List<CustomColorThemesSettingsItem> Themes { get; set; }

        /// <summary>
        /// Specifies whether the custom color theme is selected.
        /// </summary>
        /// <value>Specifies whether the custom color theme is selected.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "selected", EmitDefaultValue = false)]
        public int Selected { get; set; }

        /// <summary>
        /// The maximum number of the custom color themes.
        /// </summary>
        /// <value>The maximum number of the custom color themes.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public int Limit { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomColorThemesSettingsDto {\n");
            sb.Append("  Themes: ").Append(Themes).Append("\n");
            sb.Append("  Selected: ").Append(Selected).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
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
