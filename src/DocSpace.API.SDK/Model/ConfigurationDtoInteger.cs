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
    /// The configuration parameters.
    /// </summary>
    [DataContract(Name = "ConfigurationDtoInteger")]
    public partial class ConfigurationDtoInteger : IValidatableObject
    {

        /// <summary>
        /// The editor type.
        /// </summary>
        [DataMember(Name = "editorType", IsRequired = true, EmitDefaultValue = true)]
        public EditorType EditorType { get; set; }

        /// <summary>
        /// The start filling mode.
        /// </summary>
        [DataMember(Name = "startFillingMode", EmitDefaultValue = false)]
        public StartFillingMode? StartFillingMode { get; set; }

        /// <summary>
        /// Indicates which quota scope has been exceeded.
        /// </summary>
        [DataMember(Name = "quotaExceededScope", EmitDefaultValue = false)]
        public QuotaScope? QuotaExceededScope { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationDtoInteger" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConfigurationDtoInteger() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationDtoInteger" /> class.
        /// </summary>
        /// <param name="document">The document configuration. (required).</param>
        /// <param name="documentType">The document type. (required).</param>
        /// <param name="editorConfig">The editor configuration. (required).</param>
        /// <param name="editorType">The editor type. (required).</param>
        /// <param name="editorUrl">The editor URL. (required).</param>
        /// <param name="token">The token of the file configuration..</param>
        /// <param name="type">The platform type..</param>
        /// <param name="file">The file parameters. (required).</param>
        /// <param name="errorMessage">The error message..</param>
        /// <param name="startFilling">Specifies if the file filling has started or not..</param>
        /// <param name="fillingStatus">The file filling status..</param>
        /// <param name="startFillingMode">The start filling mode..</param>
        /// <param name="fillingSessionId">The file filling session ID..</param>
        /// <param name="quotaExceededScope">Indicates which quota scope has been exceeded..</param>
        /// <param name="generationToolCallState">The generation tool call state. Used to run the agent flow in the editor..</param>
        public ConfigurationDtoInteger(DocumentConfigDto document = default, string documentType = default, EditorConfigurationDto editorConfig = default, EditorType editorType = default, string editorUrl = default, string token = default, string type = default, FileDtoInteger file = default, string errorMessage = default, bool? startFilling = default, bool? fillingStatus = default, StartFillingMode? startFillingMode = default, string fillingSessionId = default, QuotaScope? quotaExceededScope = default, EditorToolCallStateDto generationToolCallState = default)
        {
            // to ensure "document" is required (not null)
            if (document == null)
            {
                throw new ArgumentNullException("document is a required property for ConfigurationDtoInteger and cannot be null");
            }
            this.Document = document;
            // to ensure "documentType" is required (not null)
            if (documentType == null)
            {
                throw new ArgumentNullException("documentType is a required property for ConfigurationDtoInteger and cannot be null");
            }
            this.DocumentType = documentType;
            // to ensure "editorConfig" is required (not null)
            if (editorConfig == null)
            {
                throw new ArgumentNullException("editorConfig is a required property for ConfigurationDtoInteger and cannot be null");
            }
            this.EditorConfig = editorConfig;
            this.EditorType = editorType;
            // to ensure "editorUrl" is required (not null)
            if (editorUrl == null)
            {
                throw new ArgumentNullException("editorUrl is a required property for ConfigurationDtoInteger and cannot be null");
            }
            this.EditorUrl = editorUrl;
            // to ensure "file" is required (not null)
            if (file == null)
            {
                throw new ArgumentNullException("file is a required property for ConfigurationDtoInteger and cannot be null");
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
        /// The document configuration.
        /// </summary>
        [DataMember(Name = "document", IsRequired = true, EmitDefaultValue = true)]
        public DocumentConfigDto Document { get; set; }

        /// <summary>
        /// The document type.
        /// </summary>
        /// <example>word</example>
        [DataMember(Name = "documentType", IsRequired = true, EmitDefaultValue = true)]
        public string DocumentType { get; set; }

        /// <summary>
        /// The editor configuration.
        /// </summary>
        [DataMember(Name = "editorConfig", IsRequired = true, EmitDefaultValue = true)]
        public EditorConfigurationDto EditorConfig { get; set; }

        /// <summary>
        /// The editor URL.
        /// </summary>
        /// <example>http://localhost/editor</example>
        [DataMember(Name = "editorUrl", IsRequired = true, EmitDefaultValue = true)]
        public string EditorUrl { get; set; }

        /// <summary>
        /// The token of the file configuration.
        /// </summary>
        /// <example>token-abc-123</example>
        [DataMember(Name = "token", EmitDefaultValue = true)]
        public string Token { get; set; }

        /// <summary>
        /// The platform type.
        /// </summary>
        /// <example>desktop</example>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// The file parameters.
        /// </summary>
        [DataMember(Name = "file", IsRequired = true, EmitDefaultValue = true)]
        public FileDtoInteger File { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        /// <example>Configuration error</example>
        [DataMember(Name = "errorMessage", EmitDefaultValue = true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Specifies if the file filling has started or not.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "startFilling", EmitDefaultValue = true)]
        public bool? StartFilling { get; set; }

        /// <summary>
        /// The file filling status.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "fillingStatus", EmitDefaultValue = true)]
        public bool? FillingStatus { get; set; }

        /// <summary>
        /// The file filling session ID.
        /// </summary>
        /// <example>session-123-456</example>
        [DataMember(Name = "fillingSessionId", EmitDefaultValue = true)]
        public string FillingSessionId { get; set; }

        /// <summary>
        /// The generation tool call state. Used to run the agent flow in the editor.
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
            sb.Append("class ConfigurationDtoInteger {\n");
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
