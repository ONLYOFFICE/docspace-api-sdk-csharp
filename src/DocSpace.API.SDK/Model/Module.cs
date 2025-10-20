// (c) Copyright Ascensio System SIA 2025
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

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
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
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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
