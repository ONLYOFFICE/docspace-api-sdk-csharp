/**
 *
 * (c) Copyright Ascensio System SIA 2025
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 *
 */

 
 using DocSpace.Sdk.Client;
 

namespace DocSpace.Sdk.Model
{
    /// <summary>
    /// The internal file formats.
    /// </summary>
    [DataContract(Name = "FilesSettingsDto_internalFormats")]
    public partial class FilesSettingsDtoInternalFormats : IValidatableObject
    {
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FilesSettingsDtoInternalFormats" /> class.
        /// </summary>
        /// <param name="unknown">unknown.</param>
        /// <param name="archive">archive.</param>
        /// <param name="video">video.</param>
        /// <param name="audio">audio.</param>
        /// <param name="image">image.</param>
        /// <param name="spreadsheet">spreadsheet.</param>
        /// <param name="presentation">presentation.</param>
        /// <param name="document">document.</param>
        /// <param name="pdf">pdf.</param>
        /// <param name="diagram">diagram.</param>
        public FilesSettingsDtoInternalFormats(string unknown = default, string archive = default, string video = default, string audio = default, string image = default, string spreadsheet = default, string presentation = default, string document = default, string pdf = default, string diagram = default)
        {
            this.Unknown = unknown;
            this.Archive = archive;
            this.Video = video;
            this.Audio = audio;
            this.Image = image;
            this.Spreadsheet = spreadsheet;
            this.Presentation = presentation;
            this.Document = document;
            this.Pdf = pdf;
            this.Diagram = diagram;
        }

        /// <summary>
        /// Gets or Sets Unknown
        /// </summary>
        [DataMember(Name = "Unknown", EmitDefaultValue = false)]
        public string Unknown { get; set; }

        /// <summary>
        /// Gets or Sets Archive
        /// </summary>
        [DataMember(Name = "Archive", EmitDefaultValue = false)]
        public string Archive { get; set; }

        /// <summary>
        /// Gets or Sets Video
        /// </summary>
        [DataMember(Name = "Video", EmitDefaultValue = false)]
        public string Video { get; set; }

        /// <summary>
        /// Gets or Sets Audio
        /// </summary>
        [DataMember(Name = "Audio", EmitDefaultValue = false)]
        public string Audio { get; set; }

        /// <summary>
        /// Gets or Sets Image
        /// </summary>
        [DataMember(Name = "Image", EmitDefaultValue = false)]
        public string Image { get; set; }

        /// <summary>
        /// Gets or Sets Spreadsheet
        /// </summary>
        [DataMember(Name = "Spreadsheet", EmitDefaultValue = false)]
        public string Spreadsheet { get; set; }

        /// <summary>
        /// Gets or Sets Presentation
        /// </summary>
        [DataMember(Name = "Presentation", EmitDefaultValue = false)]
        public string Presentation { get; set; }

        /// <summary>
        /// Gets or Sets Document
        /// </summary>
        [DataMember(Name = "Document", EmitDefaultValue = false)]
        public string Document { get; set; }

        /// <summary>
        /// Gets or Sets Pdf
        /// </summary>
        [DataMember(Name = "Pdf", EmitDefaultValue = false)]
        public string Pdf { get; set; }

        /// <summary>
        /// Gets or Sets Diagram
        /// </summary>
        [DataMember(Name = "Diagram", EmitDefaultValue = false)]
        public string Diagram { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilesSettingsDtoInternalFormats {\n");
            sb.Append("  Unknown: ").Append(Unknown).Append("\n");
            sb.Append("  Archive: ").Append(Archive).Append("\n");
            sb.Append("  Video: ").Append(Video).Append("\n");
            sb.Append("  Audio: ").Append(Audio).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  Spreadsheet: ").Append(Spreadsheet).Append("\n");
            sb.Append("  Presentation: ").Append(Presentation).Append("\n");
            sb.Append("  Document: ").Append(Document).Append("\n");
            sb.Append("  Pdf: ").Append(Pdf).Append("\n");
            sb.Append("  Diagram: ").Append(Diagram).Append("\n");
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
