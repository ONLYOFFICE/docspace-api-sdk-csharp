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
using FileParameter = Docspace.Client.FileParameter;
using OpenAPIDateConverter = Docspace.Client.OpenAPIDateConverter;

namespace Docspace.Model
{
    /// <summary>
    /// The file operation information.
    /// </summary>
    [DataContract(Name = "FileOperationDto")]
    public partial class FileOperationDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Operation
        /// </summary>
        [DataMember(Name = "Operation", EmitDefaultValue = false)]
        public FileOperationType? Operation { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileOperationDto" /> class.
        /// </summary>
        /// <param name="id">The file operation ID..</param>
        /// <param name="operation">operation.</param>
        /// <param name="progress">The file operation progress in percentage..</param>
        /// <param name="error">The file operation error message..</param>
        /// <param name="processed">The file operation processing status..</param>
        /// <param name="finished">Specifies if the file operation is finished or not..</param>
        /// <param name="url">The file operation URL..</param>
        /// <param name="files">The list of files of the file operation..</param>
        /// <param name="folders">The list of folders of the file operation..</param>
        public FileOperationDto(string id = default, FileOperationType? operation = default, int progress = default, string error = default, string processed = default, bool finished = default, string url = default, List<FileEntryDto> files = default, List<FileEntryDto> folders = default)
        {
            this.Id = id;
            this.Operation = operation;
            this.Progress = progress;
            this.Error = error;
            this.Processed = processed;
            this.Finished = finished;
            this.Url = url;
            this.Files = files;
            this.Folders = folders;
        }

        /// <summary>
        /// The file operation ID.
        /// </summary>
        /// <value>The file operation ID.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The file operation progress in percentage.
        /// </summary>
        /// <value>The file operation progress in percentage.</value>
        /*
        <example>100</example>
        */
        [DataMember(Name = "progress", EmitDefaultValue = false)]
        public int Progress { get; set; }

        /// <summary>
        /// The file operation error message.
        /// </summary>
        /// <value>The file operation error message.</value>
        [DataMember(Name = "error", EmitDefaultValue = true)]
        public string Error { get; set; }

        /// <summary>
        /// The file operation processing status.
        /// </summary>
        /// <value>The file operation processing status.</value>
        /*
        <example>1</example>
        */
        [DataMember(Name = "processed", EmitDefaultValue = true)]
        public string Processed { get; set; }

        /// <summary>
        /// Specifies if the file operation is finished or not.
        /// </summary>
        /// <value>Specifies if the file operation is finished or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "finished", EmitDefaultValue = true)]
        public bool Finished { get; set; }

        /// <summary>
        /// The file operation URL.
        /// </summary>
        /// <value>The file operation URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// The list of files of the file operation.
        /// </summary>
        /// <value>The list of files of the file operation.</value>
        [DataMember(Name = "files", EmitDefaultValue = true)]
        public List<FileEntryDto> Files { get; set; }

        /// <summary>
        /// The list of folders of the file operation.
        /// </summary>
        /// <value>The list of folders of the file operation.</value>
        [DataMember(Name = "folders", EmitDefaultValue = true)]
        public List<FileEntryDto> Folders { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FileOperationDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Operation: ").Append(Operation).Append("\n");
            sb.Append("  Progress: ").Append(Progress).Append("\n");
            sb.Append("  Error: ").Append(Error).Append("\n");
            sb.Append("  Processed: ").Append(Processed).Append("\n");
            sb.Append("  Finished: ").Append(Finished).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
            sb.Append("  Folders: ").Append(Folders).Append("\n");
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
