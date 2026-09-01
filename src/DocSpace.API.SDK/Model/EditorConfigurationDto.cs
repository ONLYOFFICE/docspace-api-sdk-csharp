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
    /// The editor configuration parameters.
    /// </summary>
    [DataContract(Name = "EditorConfigurationDto")]
    public partial class EditorConfigurationDto : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="EditorConfigurationDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EditorConfigurationDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EditorConfigurationDto" /> class.
        /// </summary>
        /// <param name="callbackUrl">The callback URL of the editor..</param>
        /// <param name="coEditing">The co-editing configuration parameters..</param>
        /// <param name="createUrl">The creation URL of the editor..</param>
        /// <param name="customization">The customization configuration..</param>
        /// <param name="embedded">The configuration parameters for the embedded document type..</param>
        /// <param name="encryptionKeys">The encryption keys of the editor configuration..</param>
        /// <param name="lang">The language of the editor configuration. (required).</param>
        /// <param name="mode">The mode of the editor configuration. (required).</param>
        /// <param name="modeWrite">Specifies if the mode is write of the editor configuration..</param>
        /// <param name="plugins">The configuration settings to connect the special add-ons..</param>
        /// <param name="recent">The recent configuration of the editor..</param>
        /// <param name="templates">The templates of the editor configuration..</param>
        /// <param name="user">The configuration parameters of the user currently viewing or editing the document..</param>
        public EditorConfigurationDto(string callbackUrl = default, CoEditingConfig coEditing = default, string createUrl = default, CustomizationConfigDto customization = default, EmbeddedConfig embedded = default, List<EncryptionKeyDto> encryptionKeys = default, string lang = default, string mode = default, bool modeWrite = default, PluginsConfig plugins = default, List<RecentConfig> recent = default, List<TemplatesConfig> templates = default, UserConfig user = default)
        {
            // to ensure "lang" is required (not null)
            if (lang == null)
            {
                throw new ArgumentNullException("lang is a required property for EditorConfigurationDto and cannot be null");
            }
            this.Lang = lang;
            // to ensure "mode" is required (not null)
            if (mode == null)
            {
                throw new ArgumentNullException("mode is a required property for EditorConfigurationDto and cannot be null");
            }
            this.Mode = mode;
            this.CallbackUrl = callbackUrl;
            this.CoEditing = coEditing;
            this.CreateUrl = createUrl;
            this.Customization = customization;
            this.Embedded = embedded;
            this.EncryptionKeys = encryptionKeys;
            this.ModeWrite = modeWrite;
            this.Plugins = plugins;
            this.Recent = recent;
            this.Templates = templates;
            this.User = user;
        }

        /// <summary>
        /// The callback URL of the editor.
        /// </summary>
        /// <example>http://localhost/callback</example>
        [DataMember(Name = "callbackUrl", EmitDefaultValue = true)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// The co-editing configuration parameters.
        /// </summary>
        [DataMember(Name = "coEditing", EmitDefaultValue = false)]
        public CoEditingConfig CoEditing { get; set; }

        /// <summary>
        /// The creation URL of the editor.
        /// </summary>
        /// <example>http://localhost/create</example>
        [DataMember(Name = "createUrl", EmitDefaultValue = true)]
        public string CreateUrl { get; set; }

        /// <summary>
        /// The customization configuration.
        /// </summary>
        [DataMember(Name = "customization", EmitDefaultValue = false)]
        public CustomizationConfigDto Customization { get; set; }

        /// <summary>
        /// The configuration parameters for the embedded document type.
        /// </summary>
        [DataMember(Name = "embedded", EmitDefaultValue = false)]
        public EmbeddedConfig Embedded { get; set; }

        /// <summary>
        /// The encryption keys of the editor configuration.
        /// </summary>
        [DataMember(Name = "encryptionKeys", EmitDefaultValue = true)]
        public List<EncryptionKeyDto> EncryptionKeys { get; set; }

        /// <summary>
        /// The language of the editor configuration.
        /// </summary>
        /// <example>en-US</example>
        [DataMember(Name = "lang", IsRequired = true, EmitDefaultValue = true)]
        public string Lang { get; set; }

        /// <summary>
        /// The mode of the editor configuration.
        /// </summary>
        /// <example>edit</example>
        [DataMember(Name = "mode", IsRequired = true, EmitDefaultValue = true)]
        public string Mode { get; set; }

        /// <summary>
        /// Specifies if the mode is write of the editor configuration.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "modeWrite", EmitDefaultValue = true)]
        public bool ModeWrite { get; set; }

        /// <summary>
        /// The configuration settings to connect the special add-ons.
        /// </summary>
        [DataMember(Name = "plugins", EmitDefaultValue = false)]
        public PluginsConfig Plugins { get; set; }

        /// <summary>
        /// The recent configuration of the editor.
        /// </summary>
        /// <example>[]</example>
        [DataMember(Name = "recent", EmitDefaultValue = true)]
        public List<RecentConfig> Recent { get; set; }

        /// <summary>
        /// The templates of the editor configuration.
        /// </summary>
        /// <example>[]</example>
        [DataMember(Name = "templates", EmitDefaultValue = true)]
        public List<TemplatesConfig> Templates { get; set; }

        /// <summary>
        /// The configuration parameters of the user currently viewing or editing the document.
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
