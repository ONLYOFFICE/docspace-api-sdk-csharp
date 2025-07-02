// (c) Copyright Ascensio System SIA 2009-2025
// 
// This program is a free software product.
// You can redistribute it and/or modify it under the terms
// of the GNU Affero General Public License (AGPL) version 3 as published by the Free Software
// Foundation. In accordance with Section 7(a) of the GNU AGPL its Section 15 shall be amended
// to the effect that Ascensio System SIA expressly excludes the warranty of non-infringement of
// any third-party rights.
// 
// This program is distributed WITHOUT ANY WARRANTY, without even the implied warranty
// of MERCHANTABILITY or FITNESS FOR A PARTICULAR  PURPOSE. For details, see
// the GNU AGPL at: http://www.gnu.org/licenses/agpl-3.0.html
// 
// You can contact Ascensio System SIA at Lubanas st. 125a-25, Riga, Latvia, EU, LV-1021.
// 
// The  interactive user interfaces in modified source and object code versions of the Program must
// display Appropriate Legal Notices, as required under Section 5 of the GNU AGPL version 3.
// 
// Pursuant to Section 7(b) of the License you must retain the original Product logo when
// distributing the program. Pursuant to Section 7(e) we decline to grant you any rights under
// trademark law for use of our trademarks.
// 
// All the Product's GUI elements, including illustrations and icon sets, as well as technical writing
// content are licensed under the terms of the Creative Commons Attribution-ShareAlike 4.0
// International. See the License terms at http://creativecommons.org/licenses/by-sa/4.0/legalcode


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
using FileParameter = DocSpace.Sdk.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.Sdk.Client.OpenAPIDateConverter;

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
        public FilesSettingsDtoInternalFormats(string unknown = default, string archive = default, string video = default, string audio = default, string image = default, string spreadsheet = default, string presentation = default, string document = default, string pdf = default)
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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
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
