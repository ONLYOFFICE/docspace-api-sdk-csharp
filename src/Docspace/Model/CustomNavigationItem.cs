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
    /// The custom navigation item parameters.
    /// </summary>
    [DataContract(Name = "CustomNavigationItem")]
    public partial class CustomNavigationItem : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomNavigationItem" /> class.
        /// </summary>
        /// <param name="id">The ID of the custom navigation item..</param>
        /// <param name="label">The label of the custom navigation item..</param>
        /// <param name="url">The URL of the custom navigation item..</param>
        /// <param name="bigImg">The big image of the custom navigation item..</param>
        /// <param name="smallImg">The small image of the custom navigation item..</param>
        /// <param name="showInMenu">Specifies whether to show the custom navigation item in menu or not..</param>
        /// <param name="showOnHomePage">Specifies whether to show the custom navigation item on home page or not..</param>
        public CustomNavigationItem(Guid id = default, string label = default, string url = default, string bigImg = default, string smallImg = default, bool showInMenu = default, bool showOnHomePage = default)
        {
            this.Id = id;
            this.Label = label;
            this.Url = url;
            this.BigImg = bigImg;
            this.SmallImg = smallImg;
            this.ShowInMenu = showInMenu;
            this.ShowOnHomePage = showOnHomePage;
        }

        /// <summary>
        /// The ID of the custom navigation item.
        /// </summary>
        /// <value>The ID of the custom navigation item.</value>
        /*
        <example>aae1e103-bca5-9fa1-ba8c-42058b4abf28</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// The label of the custom navigation item.
        /// </summary>
        /// <value>The label of the custom navigation item.</value>
        /*
        <example>Label</example>
        */
        [DataMember(Name = "label", EmitDefaultValue = true)]
        public string Label { get; set; }

        /// <summary>
        /// The URL of the custom navigation item.
        /// </summary>
        /// <value>The URL of the custom navigation item.</value>
        /*
        <example>Url</example>
        */
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// The big image of the custom navigation item.
        /// </summary>
        /// <value>The big image of the custom navigation item.</value>
        /*
        <example>data:image\/png;base64,iVBORw0KGgoAAAANSUhEUgAAAGQAAABkAgMAAAANjH3HAAAADFBMVEUAAADJycnJycnJycmiuNtHAAAAA3RSTlMAf4C\/aSLHAAAAyElEQVR4Xu3NsQ3CMBSE4YubFB4ilHQegdGSjWACvEpGoEyBYiL05AdnXUGHolx10lf82MmOpfLeo5UoJUhBlpKkRCnhUy7b9XCWkqQMUkYlXVHSf8kTvkHKqKQrSnopg5SRxTMklLmS1MwaSWpmCSQ1MyOzWGZCYrEMEFksA4QqlAFuJJYBcCKxjM3FMySeIfEMC2dMOONCGZZgmdr1ly3TSrJMK9EyJBaaGrHQikYstAiJZRYSyiQEdyg5S8Evckih\/YPscsdej0H6dc0TYw4AAAAASUVORK5CYII&#x3D;</example>
        */
        [DataMember(Name = "bigImg", EmitDefaultValue = true)]
        public string BigImg { get; set; }

        /// <summary>
        /// The small image of the custom navigation item.
        /// </summary>
        /// <value>The small image of the custom navigation item.</value>
        /*
        <example>data:image\/png;base64,iVBORw0KGgoAAAANSUhEUgAAABAAAAAQCAYAAAAf8\/9hAAAAUUlEQVR4AWMY\/KC5o\/cAEP9HxxgKcSpCGELYADyu2E6mAQjNxBlAWPNxkHdwGkBIM3KYYDUAr2ZCAE+oH8eujrAXDsA0k2EAAtDXAGLx4MpsADUgvkRKUlqfAAAAAElFTkSuQmCC</example>
        */
        [DataMember(Name = "smallImg", EmitDefaultValue = true)]
        public string SmallImg { get; set; }

        /// <summary>
        /// Specifies whether to show the custom navigation item in menu or not.
        /// </summary>
        /// <value>Specifies whether to show the custom navigation item in menu or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "showInMenu", EmitDefaultValue = true)]
        public bool ShowInMenu { get; set; }

        /// <summary>
        /// Specifies whether to show the custom navigation item on home page or not.
        /// </summary>
        /// <value>Specifies whether to show the custom navigation item on home page or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "showOnHomePage", EmitDefaultValue = true)]
        public bool ShowOnHomePage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CustomNavigationItem {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Label: ").Append(Label).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  BigImg: ").Append(BigImg).Append("\n");
            sb.Append("  SmallImg: ").Append(SmallImg).Append("\n");
            sb.Append("  ShowInMenu: ").Append(ShowInMenu).Append("\n");
            sb.Append("  ShowOnHomePage: ").Append(ShowOnHomePage).Append("\n");
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
