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


 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The editor configuration parameters.
    /// </summary>
    [DataContract(Name = "EditorConfigurationDto")]
    public partial class EditorConfigurationDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EditorConfigurationDto" /> class.
        /// </summary>
        /// <param name="callbackUrl">The callback URL of the editor..</param>
        /// <param name="coEditing">coEditing.</param>
        /// <param name="createUrl">The creation URL of the editor..</param>
        /// <param name="customization">customization.</param>
        /// <param name="embedded">embedded.</param>
        /// <param name="encryptionKeys">encryptionKeys.</param>
        /// <param name="lang">The language of the editor configuration..</param>
        /// <param name="mode">The mode of the editor configuration..</param>
        /// <param name="modeWrite">Specifies if the mode is write of the editor configuration..</param>
        /// <param name="plugins">plugins.</param>
        /// <param name="recent">The recent configuration of the editor..</param>
        /// <param name="templates">The templates of the editor configuration..</param>
        /// <param name="user">user.</param>
        public EditorConfigurationDto(string callbackUrl = default, CoEditingConfig coEditing = default, string createUrl = default, CustomizationConfigDto customization = default, EmbeddedConfig embedded = default, EncryptionKeysConfig encryptionKeys = default, string lang = default, string mode = default, bool modeWrite = default, PluginsConfig plugins = default, List<RecentConfig> recent = default, List<TemplatesConfig> templates = default, UserConfig user = default)
        {
            this.CallbackUrl = callbackUrl;
            this.CoEditing = coEditing;
            this.CreateUrl = createUrl;
            this.Customization = customization;
            this.Embedded = embedded;
            this.EncryptionKeys = encryptionKeys;
            this.Lang = lang;
            this.Mode = mode;
            this.ModeWrite = modeWrite;
            this.Plugins = plugins;
            this.Recent = recent;
            this.Templates = templates;
            this.User = user;
        }

        /// <summary>
        /// The callback URL of the editor.
        /// </summary>
        /// <value>The callback URL of the editor.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "callbackUrl", EmitDefaultValue = true)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// Gets or Sets CoEditing
        /// </summary>
        [DataMember(Name = "coEditing", EmitDefaultValue = false)]
        public CoEditingConfig CoEditing { get; set; }

        /// <summary>
        /// The creation URL of the editor.
        /// </summary>
        /// <value>The creation URL of the editor.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "createUrl", EmitDefaultValue = true)]
        public string CreateUrl { get; set; }

        /// <summary>
        /// Gets or Sets Customization
        /// </summary>
        [DataMember(Name = "customization", EmitDefaultValue = false)]
        public CustomizationConfigDto Customization { get; set; }

        /// <summary>
        /// Gets or Sets Embedded
        /// </summary>
        [DataMember(Name = "embedded", EmitDefaultValue = false)]
        public EmbeddedConfig Embedded { get; set; }

        /// <summary>
        /// Gets or Sets EncryptionKeys
        /// </summary>
        [DataMember(Name = "encryptionKeys", EmitDefaultValue = false)]
        public EncryptionKeysConfig EncryptionKeys { get; set; }

        /// <summary>
        /// The language of the editor configuration.
        /// </summary>
        /// <value>The language of the editor configuration.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "lang", EmitDefaultValue = true)]
        public string Lang { get; set; }

        /// <summary>
        /// The mode of the editor configuration.
        /// </summary>
        /// <value>The mode of the editor configuration.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "mode", EmitDefaultValue = true)]
        public string Mode { get; set; }

        /// <summary>
        /// Specifies if the mode is write of the editor configuration.
        /// </summary>
        /// <value>Specifies if the mode is write of the editor configuration.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "modeWrite", EmitDefaultValue = true)]
        public bool ModeWrite { get; set; }

        /// <summary>
        /// Gets or Sets Plugins
        /// </summary>
        [DataMember(Name = "plugins", EmitDefaultValue = false)]
        public PluginsConfig Plugins { get; set; }

        /// <summary>
        /// The recent configuration of the editor.
        /// </summary>
        /// <value>The recent configuration of the editor.</value>
        [DataMember(Name = "recent", EmitDefaultValue = true)]
        public List<RecentConfig> Recent { get; set; }

        /// <summary>
        /// The templates of the editor configuration.
        /// </summary>
        /// <value>The templates of the editor configuration.</value>
        [DataMember(Name = "templates", EmitDefaultValue = true)]
        public List<TemplatesConfig> Templates { get; set; }

        /// <summary>
        /// Gets or Sets User
        /// </summary>
        [DataMember(Name = "user", EmitDefaultValue = false)]
        public UserConfig User { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EditorConfigurationDto {\n");
            sb.Append("  CallbackUrl: ").Append(CallbackUrl).Append("\n");
            sb.Append("  CoEditing: ").Append(CoEditing).Append("\n");
            sb.Append("  CreateUrl: ").Append(CreateUrl).Append("\n");
            sb.Append("  Customization: ").Append(Customization).Append("\n");
            sb.Append("  Embedded: ").Append(Embedded).Append("\n");
            sb.Append("  EncryptionKeys: ").Append(EncryptionKeys).Append("\n");
            sb.Append("  Lang: ").Append(Lang).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  ModeWrite: ").Append(ModeWrite).Append("\n");
            sb.Append("  Plugins: ").Append(Plugins).Append("\n");
            sb.Append("  Recent: ").Append(Recent).Append("\n");
            sb.Append("  Templates: ").Append(Templates).Append("\n");
            sb.Append("  User: ").Append(User).Append("\n");
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
