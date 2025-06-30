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
    /// The module information.
    /// </summary>
    [DataContract(Name = "Module")]
    public partial class Module : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Module" /> class.
        /// </summary>
        /// <param name="id">The module ID..</param>
        /// <param name="appName">The module product class name..</param>
        /// <param name="title">The module product class name..</param>
        /// <param name="link">The URL to the module start page..</param>
        /// <param name="iconUrl">The module icon URL..</param>
        /// <param name="imageUrl">The module large image URL..</param>
        /// <param name="helpUrl">The module help URL..</param>
        /// <param name="description">The module description..</param>
        /// <param name="isPrimary">Specifies if the module is primary or not..</param>
        public Module(Guid id = default, string appName = default, string title = default, string link = default, string iconUrl = default, string imageUrl = default, string helpUrl = default, string description = default, bool isPrimary = default)
        {
            this.Id = id;
            this.AppName = appName;
            this.Title = title;
            this.Link = link;
            this.IconUrl = iconUrl;
            this.ImageUrl = imageUrl;
            this.HelpUrl = helpUrl;
            this.Description = description;
            this.IsPrimary = isPrimary;
        }

        /// <summary>
        /// The module ID.
        /// </summary>
        /// <value>The module ID.</value>
        /*
        <example>aae1e103-bca5-9fa1-ba8c-42058b4abf28</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// The module product class name.
        /// </summary>
        /// <value>The module product class name.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "appName", EmitDefaultValue = true)]
        public string AppName { get; set; }

        /// <summary>
        /// The module product class name.
        /// </summary>
        /// <value>The module product class name.</value>
        /*
        <example>legacy_1080p_small_wooden_mouse</example>
        */
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The URL to the module start page.
        /// </summary>
        /// <value>The URL to the module start page.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "link", EmitDefaultValue = true)]
        public string Link { get; set; }

        /// <summary>
        /// The module icon URL.
        /// </summary>
        /// <value>The module icon URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "iconUrl", EmitDefaultValue = true)]
        public string IconUrl { get; set; }

        /// <summary>
        /// The module large image URL.
        /// </summary>
        /// <value>The module large image URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "imageUrl", EmitDefaultValue = true)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// The module help URL.
        /// </summary>
        /// <value>The module help URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "helpUrl", EmitDefaultValue = true)]
        public string HelpUrl { get; set; }

        /// <summary>
        /// The module description.
        /// </summary>
        /// <value>The module description.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Specifies if the module is primary or not.
        /// </summary>
        /// <value>Specifies if the module is primary or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isPrimary", EmitDefaultValue = true)]
        public bool IsPrimary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Module {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  AppName: ").Append(AppName).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
            sb.Append("  IconUrl: ").Append(IconUrl).Append("\n");
            sb.Append("  ImageUrl: ").Append(ImageUrl).Append("\n");
            sb.Append("  HelpUrl: ").Append(HelpUrl).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  IsPrimary: ").Append(IsPrimary).Append("\n");
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
