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
    /// The web plugin information.
    /// </summary>
    [DataContract(Name = "WebPluginDto")]
    public partial class WebPluginDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebPluginDto" /> class.
        /// </summary>
        /// <param name="name">The web plugin name..</param>
        /// <param name="varVersion">The web plugin version..</param>
        /// <param name="description">The web plugin description..</param>
        /// <param name="license">The web plugin license..</param>
        /// <param name="author">The web plugin author..</param>
        /// <param name="homePage">The web plugin home page URL..</param>
        /// <param name="pluginName">The name by which the web plugin is registered in the window object..</param>
        /// <param name="scopes">The web plugin scopes..</param>
        /// <param name="image">The web plugin image..</param>
        /// <param name="createBy">createBy.</param>
        /// <param name="createOn">The date and time when the web plugin was created..</param>
        /// <param name="enabled">Specifies if the web plugin is enabled or not..</param>
        /// <param name="varSystem">Specifies if the web plugin is system or not..</param>
        /// <param name="url">The web plugin URL..</param>
        /// <param name="settings">The web plugin settings..</param>
        public WebPluginDto(string name = default, string varVersion = default, string description = default, string license = default, string author = default, string homePage = default, string pluginName = default, string scopes = default, string image = default, EmployeeDto createBy = default, DateTime createOn = default, bool enabled = default, bool varSystem = default, string url = default, string settings = default)
        {
            this.Name = name;
            this.VarVersion = varVersion;
            this.Description = description;
            this.License = license;
            this.Author = author;
            this.HomePage = homePage;
            this.PluginName = pluginName;
            this.Scopes = scopes;
            this.Image = image;
            this.CreateBy = createBy;
            this.CreateOn = createOn;
            this.Enabled = enabled;
            this.System = varSystem;
            this.Url = url;
            this.Settings = settings;
        }

        /// <summary>
        /// The web plugin name.
        /// </summary>
        /// <value>The web plugin name.</value>
        /*
        <example>Winfield Upton</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The web plugin version.
        /// </summary>
        /// <value>The web plugin version.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "version", EmitDefaultValue = true)]
        public string VarVersion { get; set; }

        /// <summary>
        /// The web plugin description.
        /// </summary>
        /// <value>The web plugin description.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The web plugin license.
        /// </summary>
        /// <value>The web plugin license.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "license", EmitDefaultValue = true)]
        public string License { get; set; }

        /// <summary>
        /// The web plugin author.
        /// </summary>
        /// <value>The web plugin author.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "author", EmitDefaultValue = true)]
        public string Author { get; set; }

        /// <summary>
        /// The web plugin home page URL.
        /// </summary>
        /// <value>The web plugin home page URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "homePage", EmitDefaultValue = true)]
        public string HomePage { get; set; }

        /// <summary>
        /// The name by which the web plugin is registered in the window object.
        /// </summary>
        /// <value>The name by which the web plugin is registered in the window object.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "pluginName", EmitDefaultValue = true)]
        public string PluginName { get; set; }

        /// <summary>
        /// The web plugin scopes.
        /// </summary>
        /// <value>The web plugin scopes.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "scopes", EmitDefaultValue = true)]
        public string Scopes { get; set; }

        /// <summary>
        /// The web plugin image.
        /// </summary>
        /// <value>The web plugin image.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "image", EmitDefaultValue = true)]
        public string Image { get; set; }

        /// <summary>
        /// Gets or Sets CreateBy
        /// </summary>
        [DataMember(Name = "createBy", EmitDefaultValue = false)]
        public EmployeeDto CreateBy { get; set; }

        /// <summary>
        /// The date and time when the web plugin was created.
        /// </summary>
        /// <value>The date and time when the web plugin was created.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "createOn", EmitDefaultValue = false)]
        public DateTime CreateOn { get; set; }

        /// <summary>
        /// Specifies if the web plugin is enabled or not.
        /// </summary>
        /// <value>Specifies if the web plugin is enabled or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "enabled", EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Specifies if the web plugin is system or not.
        /// </summary>
        /// <value>Specifies if the web plugin is system or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "system", EmitDefaultValue = true)]
        public bool System { get; set; }

        /// <summary>
        /// The web plugin URL.
        /// </summary>
        /// <value>The web plugin URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// The web plugin settings.
        /// </summary>
        /// <value>The web plugin settings.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "settings", EmitDefaultValue = true)]
        public string Settings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebPluginDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  License: ").Append(License).Append("\n");
            sb.Append("  Author: ").Append(Author).Append("\n");
            sb.Append("  HomePage: ").Append(HomePage).Append("\n");
            sb.Append("  PluginName: ").Append(PluginName).Append("\n");
            sb.Append("  Scopes: ").Append(Scopes).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  CreateBy: ").Append(CreateBy).Append("\n");
            sb.Append("  CreateOn: ").Append(CreateOn).Append("\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  System: ").Append(System).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
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
