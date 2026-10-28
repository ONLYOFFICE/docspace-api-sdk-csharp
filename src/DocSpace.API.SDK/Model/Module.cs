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
    /// The descriptor of a portal module: what it is called, where it starts and how it is pictured.
    /// </summary>
    [DataContract(Name = "Module")]
    public partial class Module : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="Module" /> class.
        /// </summary>
        /// <param name="id">The identifier of the module. It is the same in every portal and in every language, so use it rather than the  title to tell modules apart..</param>
        /// <param name="appName">The short system name of the module, the one that appears in its addresses and in the portal configuration.  Unlike the title it is not translated..</param>
        /// <param name="title">The display name of the module, already translated for the calling account, so it changes with the language  and must not be compared against a fixed string..</param>
        /// <param name="link">The address of the start page of the module, to be opened in a browser rather than called as an API..</param>
        /// <param name="iconUrl">The address of the small icon of the module, meant for a menu entry..</param>
        /// <param name="imageUrl">The address of the large image of the module, meant for a tile or a start screen..</param>
        /// <param name="helpUrl">The address of the help section of the module. It is empty when the portal publishes no help for it..</param>
        /// <param name="description">The one-line description of the module shown next to its title, translated for the calling account..</param>
        /// <param name="isPrimary">Whether the portal opens this module first when no other destination is given..</param>
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
        /// The identifier of the module. It is the same in every portal and in every language, so use it rather than the  title to tell modules apart.
        /// </summary>
        /// <example>e67be73d-f9ae-4ce1-8fec-1880cb518cb4</example>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// The short system name of the module, the one that appears in its addresses and in the portal configuration.  Unlike the title it is not translated.
        /// </summary>
        /// <example>files</example>
        [DataMember(Name = "appName", EmitDefaultValue = true)]
        public string AppName { get; set; }

        /// <summary>
        /// The display name of the module, already translated for the calling account, so it changes with the language  and must not be compared against a fixed string.
        /// </summary>
        /// <example>Documents</example>
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The address of the start page of the module, to be opened in a browser rather than called as an API.
        /// </summary>
        /// <example>https://example.com</example>
        [DataMember(Name = "link", EmitDefaultValue = true)]
        public string Link { get; set; }

        /// <summary>
        /// The address of the small icon of the module, meant for a menu entry.
        /// </summary>
        /// <example>https://example.com/icon.svg</example>
        [DataMember(Name = "iconUrl", EmitDefaultValue = true)]
        public string IconUrl { get; set; }

        /// <summary>
        /// The address of the large image of the module, meant for a tile or a start screen.
        /// </summary>
        /// <example>https://example.com/image.png</example>
        [DataMember(Name = "imageUrl", EmitDefaultValue = true)]
        public string ImageUrl { get; set; }

        /// <summary>
        /// The address of the help section of the module. It is empty when the portal publishes no help for it.
        /// </summary>
        /// <example>https://example.com/help</example>
        [DataMember(Name = "helpUrl", EmitDefaultValue = true)]
        public string HelpUrl { get; set; }

        /// <summary>
        /// The one-line description of the module shown next to its title, translated for the calling account.
        /// </summary>
        /// <example>File management</example>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Whether the portal opens this module first when no other destination is given.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "isPrimary", EmitDefaultValue = true)]
        public bool IsPrimary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
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
