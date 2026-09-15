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
    /// How the editors behave for this opening: the mode, the language, the interface, and who is editing.
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
        /// <param name="callbackUrl">Where the editors post the document back to when they save it. A client must not call it itself; it is the  address the document service uses..</param>
        /// <param name="coEditing">How co-editing starts out for this session and whether the user may switch it in the interface..</param>
        /// <param name="createUrl">Where the editor sends the user when they ask for a new document of the same type. It is empty when creating  one is not offered here..</param>
        /// <param name="customization">How the editor interface is dressed for this portal, this document and this layout..</param>
        /// <param name="embedded">The addresses the framed viewer needs. It is filled in only for the embedded layout..</param>
        /// <param name="encryptionKeys">The caller&#39;s end-to-end encryption keys, added only when the document lies in a private room, so that the  editors can decrypt it in the browser. It is empty everywhere else..</param>
        /// <param name="lang">The culture the editor interface is shown in, taken from the profile of the caller. (required).</param>
        /// <param name="mode">&#x60;edit&#x60; when this session may write the document, &#x60;view&#x60; when it may only read it. (required).</param>
        /// <param name="modeWrite">Whether this session may write; it is what the mode above says in one word..</param>
        /// <param name="plugins">Which editor plugins are offered. The portal currently offers none, so the list inside comes back empty..</param>
        /// <param name="recent">The documents offered in the editor&#39;s recent list. It is left out altogether when there is nothing to offer..</param>
        /// <param name="templates">Always empty: the portal no longer passes creation templates through the editor configuration..</param>
        /// <param name="user">The account the editors attribute changes to. It is empty for an anonymous session opened through an external  link, and the editors then ask for a name themselves..</param>
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
        /// Where the editors post the document back to when they save it. A client must not call it itself; it is the  address the document service uses.
        /// </summary>
        /// <example>https://portal.example.com/filehandler.ashx?action=track&amp;fileid=512</example>
        [DataMember(Name = "callbackUrl", EmitDefaultValue = true)]
        public string CallbackUrl { get; set; }

        /// <summary>
        /// How co-editing starts out for this session and whether the user may switch it in the interface.
        /// </summary>
        [DataMember(Name = "coEditing", EmitDefaultValue = false)]
        public CoEditingConfig CoEditing { get; set; }

        /// <summary>
        /// Where the editor sends the user when they ask for a new document of the same type. It is empty when creating  one is not offered here.
        /// </summary>
        /// <example>https://portal.example.com/products/files/?action=create&amp;doctype=word</example>
        [DataMember(Name = "createUrl", EmitDefaultValue = true)]
        public string CreateUrl { get; set; }

        /// <summary>
        /// How the editor interface is dressed for this portal, this document and this layout.
        /// </summary>
        [DataMember(Name = "customization", EmitDefaultValue = false)]
        public CustomizationConfigDto Customization { get; set; }

        /// <summary>
        /// The addresses the framed viewer needs. It is filled in only for the embedded layout.
        /// </summary>
        [DataMember(Name = "embedded", EmitDefaultValue = false)]
        public EmbeddedConfig Embedded { get; set; }

        /// <summary>
        /// The caller&#39;s end-to-end encryption keys, added only when the document lies in a private room, so that the  editors can decrypt it in the browser. It is empty everywhere else.
        /// </summary>
        [DataMember(Name = "encryptionKeys", EmitDefaultValue = true)]
        public List<EncryptionKeyDto> EncryptionKeys { get; set; }

        /// <summary>
        /// The culture the editor interface is shown in, taken from the profile of the caller.
        /// </summary>
        /// <example>en-US</example>
        [DataMember(Name = "lang", IsRequired = true, EmitDefaultValue = true)]
        public string Lang { get; set; }

        /// <summary>
        /// &#x60;edit&#x60; when this session may write the document, &#x60;view&#x60; when it may only read it.
        /// </summary>
        /// <example>edit</example>
        [DataMember(Name = "mode", IsRequired = true, EmitDefaultValue = true)]
        public string Mode { get; set; }

        /// <summary>
        /// Whether this session may write; it is what the mode above says in one word.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "modeWrite", EmitDefaultValue = true)]
        public bool ModeWrite { get; set; }

        /// <summary>
        /// Which editor plugins are offered. The portal currently offers none, so the list inside comes back empty.
        /// </summary>
        [DataMember(Name = "plugins", EmitDefaultValue = false)]
        public PluginsConfig Plugins { get; set; }

        /// <summary>
        /// The documents offered in the editor&#39;s recent list. It is left out altogether when there is nothing to offer.
        /// </summary>
        /// <example>[]</example>
        [DataMember(Name = "recent", EmitDefaultValue = true)]
        public List<RecentConfig> Recent { get; set; }

        /// <summary>
        /// Always empty: the portal no longer passes creation templates through the editor configuration.
        /// </summary>
        /// <example>[]</example>
        [DataMember(Name = "templates", EmitDefaultValue = true)]
        public List<TemplatesConfig> Templates { get; set; }

        /// <summary>
        /// The account the editors attribute changes to. It is empty for an anonymous session opened through an external  link, and the editors then ask for a name themselves.
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
