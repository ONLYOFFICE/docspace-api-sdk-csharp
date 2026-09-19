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
    /// Everything an editor client needs in order to open one document: the document itself, the editor setup for this  caller, and the signature that lets the editors trust both.
    /// </summary>
    [DataContract(Name = "ConfigurationDto")]
    public partial class ConfigurationDto : IValidatableObject
    {

        /// <summary>
        /// The layout the configuration was actually built for. It echoes the requested one except where the room  overruled it, as the templates folder does by forcing the embedded viewer.
        /// </summary>
        [DataMember(Name = "editorType", IsRequired = true, EmitDefaultValue = true)]
        public EditorType EditorType { get; set; }

        /// <summary>
        /// Which filling button the editor offers: none at all, sharing the form out for others to fill, starting a  filling session, or starting one inside the form-filling room.
        /// </summary>
        [DataMember(Name = "startFillingMode", EmitDefaultValue = false)]
        public StartFillingMode? StartFillingMode { get; set; }

        /// <summary>
        /// Names the quota that ran out - the user, the room or the portal - and is set only when the document had to be  opened read-only because of it.
        /// </summary>
        [DataMember(Name = "quotaExceededScope", EmitDefaultValue = false)]
        public QuotaScope? QuotaExceededScope { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConfigurationDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationDto" /> class.
        /// </summary>
        /// <param name="document">The document as the editors address it: its revision key, title, type, download address and the permissions of  this caller on it. (required).</param>
        /// <param name="documentType">The editor family the file opens in - &#x60;word&#x60;, &#x60;cell&#x60;, &#x60;slide&#x60;, &#x60;pdf&#x60; or &#x60;diagram&#x60;. It comes back empty for a  format no editor handles. (required).</param>
        /// <param name="editorConfig">How the editor is set up for this opening: the mode, the language, the interface customization, the callback  the editors save through, and the account they attribute changes to. (required).</param>
        /// <param name="editorType">The layout the configuration was actually built for. It echoes the requested one except where the room  overruled it, as the templates folder does by forcing the embedded viewer. (required).</param>
        /// <param name="editorUrl">The address of the editor api script the client has to load, with the shard key of this document already  appended. Load it as it is given rather than assembling it by hand. (required).</param>
        /// <param name="token">Signs this whole configuration so that the editors can trust it; anything a client changes in the  configuration invalidates it. It stays empty on a portal that has no signature secret configured for the  document service..</param>
        /// <param name="type">The layout spelled as a lowercase word - &#x60;desktop&#x60;, &#x60;mobile&#x60; or &#x60;embedded&#x60; - the same value the editor type  carries as a number..</param>
        /// <param name="file">The file the configuration was built for, in the same shape the file listings report it. (required).</param>
        /// <param name="errorMessage">Filled in when the document could not be prepared for opening; the rest of the configuration should then not  be handed to the editors..</param>
        /// <param name="startFilling">Whether this caller may start a filling session on the form from inside the editor. It stays empty when the  file is not a form opened where starting is possible at all..</param>
        /// <param name="fillingStatus">True once the caller holds a role in the running filling session of this form. It stays empty outside a  virtual data room, where roles are the only place it is set..</param>
        /// <param name="startFillingMode">Which filling button the editor offers: none at all, sharing the form out for others to fill, starting a  filling session, or starting one inside the form-filling room..</param>
        /// <param name="fillingSessionId">Identifies the filling session this opening belongs to, and is empty when the document is not opened as part  of one. Submissions made in the editor are collected under it..</param>
        /// <param name="quotaExceededScope">Names the quota that ran out - the user, the room or the portal - and is set only when the document had to be  opened read-only because of it..</param>
        /// <param name="generationToolCallState">The generation the editor should run as soon as the document opens. It is set only for a document an AI agent  produced and left waiting for its content, and is empty for every other file..</param>
        public ConfigurationDto(DocumentConfigDto document = default, string documentType = default, EditorConfigurationDto editorConfig = default, EditorType editorType = default, string editorUrl = default, string token = default, string type = default, FileDto file = default, string errorMessage = default, bool? startFilling = default, bool? fillingStatus = default, StartFillingMode? startFillingMode = default, string fillingSessionId = default, QuotaScope? quotaExceededScope = default, EditorToolCallStateDto generationToolCallState = default)
        {
            // to ensure "document" is required (not null)
            if (document == null)
            {
                throw new ArgumentNullException("document is a required property for ConfigurationDto and cannot be null");
            }
            this.Document = document;
            // to ensure "documentType" is required (not null)
            if (documentType == null)
            {
                throw new ArgumentNullException("documentType is a required property for ConfigurationDto and cannot be null");
            }
            this.DocumentType = documentType;
            // to ensure "editorConfig" is required (not null)
            if (editorConfig == null)
            {
                throw new ArgumentNullException("editorConfig is a required property for ConfigurationDto and cannot be null");
            }
            this.EditorConfig = editorConfig;
            this.EditorType = editorType;
            // to ensure "editorUrl" is required (not null)
            if (editorUrl == null)
            {
                throw new ArgumentNullException("editorUrl is a required property for ConfigurationDto and cannot be null");
            }
            this.EditorUrl = editorUrl;
            // to ensure "file" is required (not null)
            if (file == null)
            {
                throw new ArgumentNullException("file is a required property for ConfigurationDto and cannot be null");
            }
            this.File = file;
            this.Token = token;
            this.Type = type;
            this.ErrorMessage = errorMessage;
            this.StartFilling = startFilling;
            this.FillingStatus = fillingStatus;
            this.StartFillingMode = startFillingMode;
            this.FillingSessionId = fillingSessionId;
            this.QuotaExceededScope = quotaExceededScope;
            this.GenerationToolCallState = generationToolCallState;
        }

        /// <summary>
        /// The document as the editors address it: its revision key, title, type, download address and the permissions of  this caller on it.
        /// </summary>
        [DataMember(Name = "document", IsRequired = true, EmitDefaultValue = true)]
        public DocumentConfigDto Document { get; set; }

        /// <summary>
        /// The editor family the file opens in - &#x60;word&#x60;, &#x60;cell&#x60;, &#x60;slide&#x60;, &#x60;pdf&#x60; or &#x60;diagram&#x60;. It comes back empty for a  format no editor handles.
        /// </summary>
        /// <example>word</example>
        [DataMember(Name = "documentType", IsRequired = true, EmitDefaultValue = true)]
        public string DocumentType { get; set; }

        /// <summary>
        /// How the editor is set up for this opening: the mode, the language, the interface customization, the callback  the editors save through, and the account they attribute changes to.
        /// </summary>
        [DataMember(Name = "editorConfig", IsRequired = true, EmitDefaultValue = true)]
        public EditorConfigurationDto EditorConfig { get; set; }

        /// <summary>
        /// The address of the editor api script the client has to load, with the shard key of this document already  appended. Load it as it is given rather than assembling it by hand.
        /// </summary>
        /// <example>https://portal.example.com/web-apps/apps/api/documents/api.js?shardkey=1_512_3</example>
        [DataMember(Name = "editorUrl", IsRequired = true, EmitDefaultValue = true)]
        public string EditorUrl { get; set; }

        /// <summary>
        /// Signs this whole configuration so that the editors can trust it; anything a client changes in the  configuration invalidates it. It stays empty on a portal that has no signature secret configured for the  document service.
        /// </summary>
        /// <example>eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...</example>
        [DataMember(Name = "token", EmitDefaultValue = true)]
        public string Token { get; set; }

        /// <summary>
        /// The layout spelled as a lowercase word - &#x60;desktop&#x60;, &#x60;mobile&#x60; or &#x60;embedded&#x60; - the same value the editor type  carries as a number.
        /// </summary>
        /// <example>desktop</example>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// The file the configuration was built for, in the same shape the file listings report it.
        /// </summary>
        [DataMember(Name = "file", IsRequired = true, EmitDefaultValue = true)]
        public FileDto File { get; set; }

        /// <summary>
        /// Filled in when the document could not be prepared for opening; the rest of the configuration should then not  be handed to the editors.
        /// </summary>
        /// <example>The file is being converted</example>
        [DataMember(Name = "errorMessage", EmitDefaultValue = true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Whether this caller may start a filling session on the form from inside the editor. It stays empty when the  file is not a form opened where starting is possible at all.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "startFilling", EmitDefaultValue = true)]
        public bool? StartFilling { get; set; }

        /// <summary>
        /// True once the caller holds a role in the running filling session of this form. It stays empty outside a  virtual data room, where roles are the only place it is set.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "fillingStatus", EmitDefaultValue = true)]
        public bool? FillingStatus { get; set; }

        /// <summary>
        /// Identifies the filling session this opening belongs to, and is empty when the document is not opened as part  of one. Submissions made in the editor are collected under it.
        /// </summary>
        /// <example>a1b2c3d4-0000-0000-0000-000000000000</example>
        [DataMember(Name = "fillingSessionId", EmitDefaultValue = true)]
        public string FillingSessionId { get; set; }

        /// <summary>
        /// The generation the editor should run as soon as the document opens. It is set only for a document an AI agent  produced and left waiting for its content, and is empty for every other file.
        /// </summary>
        [DataMember(Name = "generationToolCallState", EmitDefaultValue = false)]
        public EditorToolCallStateDto GenerationToolCallState { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ConfigurationDto {\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  EditorConfig: ").Append(EditorConfig).Append("\n");
            sb.Append("  EditorType: ").Append(EditorType).Append("\n");
            sb.Append("  EditorUrl: ").Append(EditorUrl).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  ErrorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  StartFilling: ").Append(StartFilling).Append("\n");
            sb.Append("  FillingStatus: ").Append(FillingStatus).Append("\n");
            sb.Append("  StartFillingMode: ").Append(StartFillingMode).Append("\n");
            sb.Append("  FillingSessionId: ").Append(FillingSessionId).Append("\n");
            sb.Append("  QuotaExceededScope: ").Append(QuotaExceededScope).Append("\n");
            sb.Append("  GenerationToolCallState: ").Append(GenerationToolCallState).Append("\n");
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
