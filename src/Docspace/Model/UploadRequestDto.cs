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
    /// The request parameters for uploading a file.
    /// </summary>
    [DataContract(Name = "UploadRequestDto")]
    public partial class UploadRequestDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadRequestDto" /> class.
        /// </summary>
        /// <param name="file">The file to be uploaded..</param>
        /// <param name="contentType">contentType.</param>
        /// <param name="contentDisposition">contentDisposition.</param>
        /// <param name="files">The list of files when specified as multipart/form-data..</param>
        /// <param name="createNewIfExist">Specifies whether to create the new file if it already exists or not..</param>
        /// <param name="storeOriginalFileFlag">Specifies whether to upload documents in the original formats as well or not..</param>
        /// <param name="keepConvertStatus">Specifies whether to keep the file converting status or not..</param>
        /// <param name="stream">The request input stream..</param>
        public UploadRequestDto(FileParameter file = default, ContentType contentType = default, ContentDisposition contentDisposition = default, List<FileParameter> files = default, bool createNewIfExist = default, bool? storeOriginalFileFlag = default, bool keepConvertStatus = default, FileParameter stream = default)
        {
            this.File = file;
            this.ContentType = contentType;
            this.ContentDisposition = contentDisposition;
            this.Files = files;
            this.CreateNewIfExist = createNewIfExist;
            this.StoreOriginalFileFlag = storeOriginalFileFlag;
            this.KeepConvertStatus = keepConvertStatus;
            this.Stream = stream;
        }

        /// <summary>
        /// The file to be uploaded.
        /// </summary>
        /// <value>The file to be uploaded.</value>
        [DataMember(Name = "file", EmitDefaultValue = true)]
        public FileParameter File { get; set; }

        /// <summary>
        /// Gets or Sets ContentType
        /// </summary>
        [DataMember(Name = "contentType", EmitDefaultValue = false)]
        public ContentType ContentType { get; set; }

        /// <summary>
        /// Gets or Sets ContentDisposition
        /// </summary>
        [DataMember(Name = "contentDisposition", EmitDefaultValue = false)]
        public ContentDisposition ContentDisposition { get; set; }

        /// <summary>
        /// The list of files when specified as multipart/form-data.
        /// </summary>
        /// <value>The list of files when specified as multipart/form-data.</value>
        [DataMember(Name = "files", EmitDefaultValue = true)]
        public List<FileParameter> Files { get; set; }

        /// <summary>
        /// Specifies whether to create the new file if it already exists or not.
        /// </summary>
        /// <value>Specifies whether to create the new file if it already exists or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "createNewIfExist", EmitDefaultValue = true)]
        public bool CreateNewIfExist { get; set; }

        /// <summary>
        /// Specifies whether to upload documents in the original formats as well or not.
        /// </summary>
        /// <value>Specifies whether to upload documents in the original formats as well or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "storeOriginalFileFlag", EmitDefaultValue = true)]
        public bool? StoreOriginalFileFlag { get; set; }

        /// <summary>
        /// Specifies whether to keep the file converting status or not.
        /// </summary>
        /// <value>Specifies whether to keep the file converting status or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "keepConvertStatus", EmitDefaultValue = true)]
        public bool KeepConvertStatus { get; set; }

        /// <summary>
        /// The request input stream.
        /// </summary>
        /// <value>The request input stream.</value>
        [DataMember(Name = "stream", EmitDefaultValue = true)]
        public FileParameter Stream { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UploadRequestDto {\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  ContentDisposition: ").Append(ContentDisposition).Append("\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
            sb.Append("  CreateNewIfExist: ").Append(CreateNewIfExist).Append("\n");
            sb.Append("  StoreOriginalFileFlag: ").Append(StoreOriginalFileFlag).Append("\n");
            sb.Append("  KeepConvertStatus: ").Append(KeepConvertStatus).Append("\n");
            sb.Append("  Stream: ").Append(Stream).Append("\n");
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
