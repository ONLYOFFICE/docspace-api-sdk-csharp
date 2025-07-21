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
    /// The configuration parameters.
    /// </summary>
    [DataContract(Name = "ConfigurationDtoInteger")]
    public partial class ConfigurationDtoInteger : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets EditorType
        /// </summary>
        [DataMember(Name = "editorType", EmitDefaultValue = false)]
        public EditorType? EditorType { get; set; }

        /// <summary>
        /// Gets or Sets StartFillingMode
        /// </summary>
        [DataMember(Name = "startFillingMode", EmitDefaultValue = false)]
        public StartFillingMode? StartFillingMode { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ConfigurationDtoInteger" /> class.
        /// </summary>
        /// <param name="document">document.</param>
        /// <param name="documentType">The document type..</param>
        /// <param name="editorConfig">editorConfig.</param>
        /// <param name="editorType">editorType.</param>
        /// <param name="editorUrl">The editor URL..</param>
        /// <param name="token">The token of the file configuration..</param>
        /// <param name="type">The platform type..</param>
        /// <param name="file">file.</param>
        /// <param name="errorMessage">The error message..</param>
        /// <param name="startFilling">Specifies if the file filling has started or not..</param>
        /// <param name="fillingStatus">The file filling status..</param>
        /// <param name="startFillingMode">startFillingMode.</param>
        /// <param name="fillingSessionId">The file filling session ID..</param>
        public ConfigurationDtoInteger(DocumentConfigDto document = default, string documentType = default, EditorConfigurationDto editorConfig = default, EditorType? editorType = default, string editorUrl = default, string token = default, string type = default, FileDtoInteger file = default, string errorMessage = default, bool? startFilling = default, bool? fillingStatus = default, StartFillingMode? startFillingMode = default, string fillingSessionId = default)
        {
            this.Document = document;
            this.DocumentType = documentType;
            this.EditorConfig = editorConfig;
            this.EditorType = editorType;
            this.EditorUrl = editorUrl;
            this.Token = token;
            this.Type = type;
            this.File = file;
            this.ErrorMessage = errorMessage;
            this.StartFilling = startFilling;
            this.FillingStatus = fillingStatus;
            this.StartFillingMode = startFillingMode;
            this.FillingSessionId = fillingSessionId;
        }

        /// <summary>
        /// Gets or Sets Document
        /// </summary>
        [DataMember(Name = "document", EmitDefaultValue = false)]
        public DocumentConfigDto Document { get; set; }

        /// <summary>
        /// The document type.
        /// </summary>
        /// <value>The document type.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "documentType", EmitDefaultValue = true)]
        public string DocumentType { get; set; }

        /// <summary>
        /// Gets or Sets EditorConfig
        /// </summary>
        [DataMember(Name = "editorConfig", EmitDefaultValue = false)]
        public EditorConfigurationDto EditorConfig { get; set; }

        /// <summary>
        /// The editor URL.
        /// </summary>
        /// <value>The editor URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "editorUrl", EmitDefaultValue = true)]
        public string EditorUrl { get; set; }

        /// <summary>
        /// The token of the file configuration.
        /// </summary>
        /// <value>The token of the file configuration.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "token", EmitDefaultValue = true)]
        public string Token { get; set; }

        /// <summary>
        /// The platform type.
        /// </summary>
        /// <value>The platform type.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [DataMember(Name = "file", EmitDefaultValue = false)]
        public FileDtoInteger File { get; set; }

        /// <summary>
        /// The error message.
        /// </summary>
        /// <value>The error message.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "errorMessage", EmitDefaultValue = true)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Specifies if the file filling has started or not.
        /// </summary>
        /// <value>Specifies if the file filling has started or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "startFilling", EmitDefaultValue = true)]
        public bool? StartFilling { get; set; }

        /// <summary>
        /// The file filling status.
        /// </summary>
        /// <value>The file filling status.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "fillingStatus", EmitDefaultValue = true)]
        public bool? FillingStatus { get; set; }

        /// <summary>
        /// The file filling session ID.
        /// </summary>
        /// <value>The file filling session ID.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "fillingSessionId", EmitDefaultValue = true)]
        public string FillingSessionId { get; set; }

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
