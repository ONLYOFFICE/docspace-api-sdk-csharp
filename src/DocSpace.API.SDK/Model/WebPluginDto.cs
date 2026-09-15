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
    /// One web plugin available to the portal: its manifest, where to load it from, and the state the portal keeps.
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
        /// <param name="name">The plugin&#39;s manifest name, which is what every other operation of this group addresses it by and what  makes it unique within the portal - an installation-wide plugin wins the name over a portal one. (required).</param>
        /// <param name="version">The plugin&#39;s own version from its manifest. The portal does not compare it against anything; it is there  for a person to read. (required).</param>
        /// <param name="minDocSpaceVersion">The oldest portal version the plugin declares it works with. It is a claim from the manifest and is not  enforced, so a plugin can be loaded on an older portal and simply misbehave; compare it with the &#x60;version&#x60;  of &#x60;GET api/2.0/settings&#x60;..</param>
        /// <param name="description">The plugin&#39;s description from its manifest, in the language the manifest was written in. The translations  of it are in &#x60;descriptionLocale&#x60;. (required).</param>
        /// <param name="license">The licence the plugin is published under, as its manifest states it. Nothing checks it. (required).</param>
        /// <param name="author">Who wrote the plugin, as its manifest states it - not the portal member who uploaded it, who is  &#x60;createBy&#x60;. (required).</param>
        /// <param name="homePage">The plugin&#39;s own page, for a person to read more about it. It is empty when the manifest names none. (required).</param>
        /// <param name="pluginName">The global the plugin registers itself under in the browser once its script has run, which is how a  client reaches it. It is distinct from &#x60;name&#x60;, the identifier the portal uses. (required).</param>
        /// <param name="scopes">Which parts of the interface the plugin hooks into, as one comma-separated string rather than a list. (required).</param>
        /// <param name="image">The plugin&#39;s icon exactly as its manifest declares it, which is normally a file name inside the plugin&#39;s  own package rather than an absolute address - resolve it against the directory &#x60;url&#x60; points into. (required).</param>
        /// <param name="createBy">The portal member who uploaded the plugin. For a plugin that ships with the installation it is an empty  profile, since no member put it there. (required).</param>
        /// <param name="createOn">When the plugin was uploaded. It stays at its zero value for a plugin that ships with the installation. (required).</param>
        /// <param name="enabled">Whether the portal loads the plugin. It is the state this portal stored, so an installation-wide plugin  can be on for one portal and off for another. (required).</param>
        /// <param name="system">Whether the plugin ships with the installation rather than having been uploaded here. A system plugin  cannot be deleted through &#x60;DELETE api/2.0/settings/webplugins/{name}&#x60;, only switched off. (required).</param>
        /// <param name="url">The address of the plugin&#39;s script, which a client loads to run it. It ends in a &#x60;hash&#x60; query taken from  &#x60;version&#x60;, so the address changes whenever the plugin is updated and an old one may be cached. (required).</param>
        /// <param name="cssUrl">The absolute address of the plugin&#39;s stylesheet, empty for a plugin that ships none. (required).</param>
        /// <param name="settings">The settings string the portal keeps for the plugin, stored and returned verbatim - only the plugin knows  its shape. It is empty until &#x60;PUT api/2.0/settings/webplugins/{name}&#x60; saves one. (required).</param>
        /// <param name="nameLocale">The plugin&#39;s name translated, keyed by culture name. A culture that is missing falls back to &#x60;name&#x60;, and  the whole map is empty for a plugin that ships no translations..</param>
        /// <param name="descriptionLocale">The plugin&#39;s description translated, keyed the same way as &#x60;nameLocale&#x60; and falling back to  &#x60;description&#x60;..</param>
        /// <param name="runtime">How the script at &#x60;url&#x60; is to be loaded - as an ES module or as a classic script. It is empty for a  plugin whose manifest does not say, which a client treats as a classic script..</param>
        public WebPluginDto(string name = default, string version = default, string minDocSpaceVersion = default, string description = default, string license = default, string author = default, string homePage = default, string pluginName = default, string scopes = default, string image = default, EmployeeDto createBy = default, DateTime createOn = default, bool enabled = default, bool @system = default, string url = default, string cssUrl = default, string settings = default, Dictionary<string, string> nameLocale = default, Dictionary<string, string> descriptionLocale = default, string runtime = default)
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
            // to ensure "cssUrl" is required (not null)
            if (cssUrl == null)
            {
                throw new ArgumentNullException("cssUrl is a required property for WebPluginDto and cannot be null");
            }
            this.CssUrl = cssUrl;
            // to ensure "settings" is required (not null)
            if (settings == null)
            {
                throw new ArgumentNullException("settings is a required property for WebPluginDto and cannot be null");
            }
            this.Settings = settings;
            this.MinDocSpaceVersion = minDocSpaceVersion;
            this.NameLocale = nameLocale;
            this.DescriptionLocale = descriptionLocale;
            this.Runtime = runtime;
        }

        /// <summary>
        /// The plugin&#39;s manifest name, which is what every other operation of this group addresses it by and what  makes it unique within the portal - an installation-wide plugin wins the name over a portal one.
        /// </summary>
        /// <example>Example Plugin</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The plugin&#39;s own version from its manifest. The portal does not compare it against anything; it is there  for a person to read.
        /// </summary>
        /// <example>1.0.0</example>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public string @Version { get; set; }

        /// <summary>
        /// The oldest portal version the plugin declares it works with. It is a claim from the manifest and is not  enforced, so a plugin can be loaded on an older portal and simply misbehave; compare it with the &#x60;version&#x60;  of &#x60;GET api/2.0/settings&#x60;.
        /// </summary>
        /// <example>12.0.0</example>
        [DataMember(Name = "minDocSpaceVersion", EmitDefaultValue = true)]
        public string MinDocSpaceVersion { get; set; }

        /// <summary>
        /// The plugin&#39;s description from its manifest, in the language the manifest was written in. The translations  of it are in &#x60;descriptionLocale&#x60;.
        /// </summary>
        /// <example>A plugin that provides additional functionality</example>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The licence the plugin is published under, as its manifest states it. Nothing checks it.
        /// </summary>
        /// <example>MIT</example>
        [DataMember(Name = "license", IsRequired = true, EmitDefaultValue = true)]
        public string License { get; set; }

        /// <summary>
        /// Who wrote the plugin, as its manifest states it - not the portal member who uploaded it, who is  &#x60;createBy&#x60;.
        /// </summary>
        /// <example>ONLYOFFICE</example>
        [DataMember(Name = "author", IsRequired = true, EmitDefaultValue = true)]
        public string Author { get; set; }

        /// <summary>
        /// The plugin&#39;s own page, for a person to read more about it. It is empty when the manifest names none.
        /// </summary>
        /// <example>https://example.com</example>
        [DataMember(Name = "homePage", IsRequired = true, EmitDefaultValue = true)]
        public string HomePage { get; set; }

        /// <summary>
        /// The global the plugin registers itself under in the browser once its script has run, which is how a  client reaches it. It is distinct from &#x60;name&#x60;, the identifier the portal uses.
        /// </summary>
        /// <example>examplePlugin</example>
        [DataMember(Name = "pluginName", IsRequired = true, EmitDefaultValue = true)]
        public string PluginName { get; set; }

        /// <summary>
        /// Which parts of the interface the plugin hooks into, as one comma-separated string rather than a list.
        /// </summary>
        /// <example>Files,Rooms</example>
        [DataMember(Name = "scopes", IsRequired = true, EmitDefaultValue = true)]
        public string Scopes { get; set; }

        /// <summary>
        /// The plugin&#39;s icon exactly as its manifest declares it, which is normally a file name inside the plugin&#39;s  own package rather than an absolute address - resolve it against the directory &#x60;url&#x60; points into.
        /// </summary>
        /// <example>icon.svg</example>
        [DataMember(Name = "image", IsRequired = true, EmitDefaultValue = true)]
        public string Image { get; set; }

        /// <summary>
        /// The portal member who uploaded the plugin. For a plugin that ships with the installation it is an empty  profile, since no member put it there.
        /// </summary>
        [DataMember(Name = "createBy", IsRequired = true, EmitDefaultValue = true)]
        public EmployeeDto CreateBy { get; set; }

        /// <summary>
        /// When the plugin was uploaded. It stays at its zero value for a plugin that ships with the installation.
        /// </summary>
        /// <example>2024-01-15T10:30:00Z</example>
        [DataMember(Name = "createOn", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreateOn { get; set; }

        /// <summary>
        /// Whether the portal loads the plugin. It is the state this portal stored, so an installation-wide plugin  can be on for one portal and off for another.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "enabled", IsRequired = true, EmitDefaultValue = true)]
        public bool Enabled { get; set; }

        /// <summary>
        /// Whether the plugin ships with the installation rather than having been uploaded here. A system plugin  cannot be deleted through &#x60;DELETE api/2.0/settings/webplugins/{name}&#x60;, only switched off.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "system", IsRequired = true, EmitDefaultValue = true)]
        public bool System { get; set; }

        /// <summary>
        /// The address of the plugin&#39;s script, which a client loads to run it. It ends in a &#x60;hash&#x60; query taken from  &#x60;version&#x60;, so the address changes whenever the plugin is updated and an old one may be cached.
        /// </summary>
        /// <example>https://example.com/plugin.js</example>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// The absolute address of the plugin&#39;s stylesheet, empty for a plugin that ships none.
        /// </summary>
        /// <example>https://example.com/plugin.css</example>
        [DataMember(Name = "cssUrl", IsRequired = true, EmitDefaultValue = true)]
        public string CssUrl { get; set; }

        /// <summary>
        /// The settings string the portal keeps for the plugin, stored and returned verbatim - only the plugin knows  its shape. It is empty until &#x60;PUT api/2.0/settings/webplugins/{name}&#x60; saves one.
        /// </summary>
        /// <example>{"theme":"dark"}</example>
        [DataMember(Name = "settings", IsRequired = true, EmitDefaultValue = true)]
        public string Settings { get; set; }

        /// <summary>
        /// The plugin&#39;s name translated, keyed by culture name. A culture that is missing falls back to &#x60;name&#x60;, and  the whole map is empty for a plugin that ships no translations.
        /// </summary>
        /// <example>{"en-US":"Example plugin","de-DE":"Beispiel-Plugin"}</example>
        [DataMember(Name = "nameLocale", EmitDefaultValue = false)]
        public Dictionary<string, string> NameLocale { get; set; }

        /// <summary>
        /// The plugin&#39;s description translated, keyed the same way as &#x60;nameLocale&#x60; and falling back to  &#x60;description&#x60;.
        /// </summary>
        /// <example>{"en-US":"Adds extra actions","de-DE":"Fugt Aktionen hinzu"}</example>
        [DataMember(Name = "descriptionLocale", EmitDefaultValue = false)]
        public Dictionary<string, string> DescriptionLocale { get; set; }

        /// <summary>
        /// How the script at &#x60;url&#x60; is to be loaded - as an ES module or as a classic script. It is empty for a  plugin whose manifest does not say, which a client treats as a classic script.
        /// </summary>
        /// <example>module</example>
        [DataMember(Name = "runtime", EmitDefaultValue = true)]
        public string Runtime { get; set; }

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
            sb.Append("  CssUrl: ").Append(CssUrl).Append("\n");
            sb.Append("  Settings: ").Append(Settings).Append("\n");
            sb.Append("  NameLocale: ").Append(NameLocale).Append("\n");
            sb.Append("  DescriptionLocale: ").Append(DescriptionLocale).Append("\n");
            sb.Append("  Runtime: ").Append(Runtime).Append("\n");
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
