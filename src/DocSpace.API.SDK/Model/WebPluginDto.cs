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
    /// The web plugin information.
    /// </summary>
    [DataContract(Name = "WebPluginDto")]
    public partial class WebPluginDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="WebPluginDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebPluginDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebPluginDto" /> class.
        /// </summary>
        /// <param name="name">The web plugin name. (required).</param>
        /// <param name="version">The web plugin version. (required).</param>
        /// <param name="minDocSpaceVersion">The minimum version of DocSpace with which the plugin is guaranteed to work..</param>
        /// <param name="description">The web plugin description. (required).</param>
        /// <param name="license">The web plugin license. (required).</param>
        /// <param name="author">The web plugin author. (required).</param>
        /// <param name="homePage">The web plugin home page URL. (required).</param>
        /// <param name="pluginName">The name by which the web plugin is registered in the window object. (required).</param>
        /// <param name="scopes">The web plugin scopes. (required).</param>
        /// <param name="image">The web plugin image. (required).</param>
        /// <param name="createBy">createBy (required).</param>
        /// <param name="createOn">The date and time when the web plugin was created. (required).</param>
        /// <param name="enabled">Specifies if the web plugin is enabled or not. (required).</param>
        /// <param name="@system">Specifies if the web plugin is system or not. (required).</param>
        /// <param name="url">The web plugin URL. (required).</param>
        /// <param name="settings">The web plugin settings. (required).</param>
        public WebPluginDto(string name = default, string version = default, string minDocSpaceVersion = default, string description = default, string license = default, string author = default, string homePage = default, string pluginName = default, string scopes = default, string image = default, EmployeeDto createBy = default, DateTime createOn = default, bool enabled = default, bool @system = default, string url = default, string settings = default)
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for WebPluginDto and cannot be null");
            }
            this.Name = name;
            // to ensure "version" is required (not null)
            if (version == null)
            {
                throw new ArgumentNullException("version is a required property for WebPluginDto and cannot be null");
            }
            this.@Version = version;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for WebPluginDto and cannot be null");
            }
            this.Description = description;
            // to ensure "license" is required (not null)
            if (license == null)
            {
                throw new ArgumentNullException("license is a required property for WebPluginDto and cannot be null");
            }
            this.License = license;
            // to ensure "author" is required (not null)
            if (author == null)
            {
                throw new ArgumentNullException("author is a required property for WebPluginDto and cannot be null");
            }
            this.Author = author;
            // to ensure "homePage" is required (not null)
            if (homePage == null)
            {
                throw new ArgumentNullException("homePage is a required property for WebPluginDto and cannot be null");
            }
            this.HomePage = homePage;
            // to ensure "pluginName" is required (not null)
            if (pluginName == null)
            {
                throw new ArgumentNullException("pluginName is a required property for WebPluginDto and cannot be null");
            }
            this.PluginName = pluginName;
            // to ensure "scopes" is required (not null)
            if (scopes == null)
            {
                throw new ArgumentNullException("scopes is a required property for WebPluginDto and cannot be null");
            }
            this.Scopes = scopes;
            // to ensure "image" is required (not null)
            if (image == null)
            {
                throw new ArgumentNullException("image is a required property for WebPluginDto and cannot be null");
            }
            this.Image = image;
            // to ensure "createBy" is required (not null)
            if (createBy == null)
            {
                throw new ArgumentNullException("createBy is a required property for WebPluginDto and cannot be null");
            }
            this.CreateBy = createBy;
            this.CreateOn = createOn;
            this.Enabled = enabled;
            this.System = @system;
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for WebPluginDto and cannot be null");
            }
            this.Url = url;
            // to ensure "settings" is required (not null)
            if (settings == null)
            {
                throw new ArgumentNullException("settings is a required property for WebPluginDto and cannot be null");
            }
            this.Settings = settings;
            this.MinDocSpaceVersion = minDocSpaceVersion;
        }

        /// <summary>
        /// The web plugin name.
        /// </summary>
        /// <value>The web plugin name.</value>
        /*
        <example>Winfield Upton</example>
        */
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The web plugin version.
        /// </summary>
        /// <value>The web plugin version.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public string @Version { get; set; }

        /// <summary>
        /// The minimum version of DocSpace with which the plugin is guaranteed to work.
        /// </summary>
        /// <value>The minimum version of DocSpace with which the plugin is guaranteed to work.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "minDocSpaceVersion", EmitDefaultValue = true)]
        public string MinDocSpaceVersion { get; set; }

        /// <summary>
        /// The web plugin description.
        /// </summary>
        /// <value>The web plugin description.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The web plugin license.
        /// </summary>
        /// <value>The web plugin license.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "license", IsRequired = true, EmitDefaultValue = true)]
        public string License { get; set; }

        /// <summary>
        /// The web plugin author.
        /// </summary>
        /// <value>The web plugin author.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "author", IsRequired = true, EmitDefaultValue = true)]
        public string Author { get; set; }

        /// <summary>
        /// The web plugin home page URL.
        /// </summary>
        /// <value>The web plugin home page URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "homePage", IsRequired = true, EmitDefaultValue = true)]
        public string HomePage { get; set; }

        /// <summary>
        /// The name by which the web plugin is registered in the window object.
        /// </summary>
        /// <value>The name by which the web plugin is registered in the window object.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "pluginName", IsRequired = true, EmitDefaultValue = true)]
        public string PluginName { get; set; }

        /// <summary>
        /// The web plugin scopes.
        /// </summary>
        /// <value>The web plugin scopes.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "scopes", IsRequired = true, EmitDefaultValue = true)]
        public string Scopes { get; set; }

        /// <summary>
        /// The web plugin image.
        /// </summary>
        /// <value>The web plugin image.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "image", IsRequired = true, EmitDefaultValue = true)]
        public string Image { get; set; }

        /// <summary>
        /// Gets or Sets CreateBy
        /// </summary>
        [DataMember(Name = "createBy", IsRequired = true, EmitDefaultValue = true)]
        public EmployeeDto CreateBy { get; set; }

        /// <summary>
        /// The date and time when the web plugin was created.
        /// </summary>
        /// <value>The date and time when the web plugin was created.</value>
        /*
        <example>2008-04-10T06:30+04:00</example>
        */
        [DataMember(Name = "createOn", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreateOn { get; set; }

        /// <summary>
        /// Specifies if the web plugin is enabled or not.
        /// </summary>
        /// <value>Specifies if the web plugin is enabled or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "enabled", IsRequired = true, EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Specifies if the web plugin is system or not.
        /// </summary>
        /// <value>Specifies if the web plugin is system or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "system", IsRequired = true, EmitDefaultValue = true)]
        public bool System { get; set; }

        /// <summary>
        /// The web plugin URL.
        /// </summary>
        /// <value>The web plugin URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// The web plugin settings.
        /// </summary>
        /// <value>The web plugin settings.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "settings", IsRequired = true, EmitDefaultValue = true)]
        public string Settings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebPluginDto {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  @Version: ").Append(@Version).Append("\n");
            sb.Append("  MinDocSpaceVersion: ").Append(MinDocSpaceVersion).Append("\n");
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
