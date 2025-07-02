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
    /// The folder content information.
    /// </summary>
    [DataContract(Name = "FolderContentDtoInteger")]
    public partial class FolderContentDtoInteger : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FolderContentDtoInteger" /> class.
        /// </summary>
        /// <param name="files">The list of files in the folder..</param>
        /// <param name="folders">The list of folders in the folder..</param>
        /// <param name="current">current.</param>
        /// <param name="pathParts">The folder path..</param>
        /// <param name="startIndex">The folder start index..</param>
        /// <param name="count">The number of folder elements..</param>
        /// <param name="total">The total number of elements in the folder..</param>
        /// <param name="varNew">The new element index in the folder..</param>
        public FolderContentDtoInteger(List<FileEntryDto> files = default, List<FileEntryDto> folders = default, FolderDtoInteger current = default, Object pathParts = default, int startIndex = default, int count = default, int total = default, int varNew = default)
        {
            this.Files = files;
            this.Folders = folders;
            this.Current = current;
            this.PathParts = pathParts;
            this.StartIndex = startIndex;
            this.Count = count;
            this.Total = total;
            this.New = varNew;
        }

        /// <summary>
        /// The list of files in the folder.
        /// </summary>
        /// <value>The list of files in the folder.</value>
        [DataMember(Name = "files", EmitDefaultValue = true)]
        public List<FileEntryDto> Files { get; set; }

        /// <summary>
        /// The list of folders in the folder.
        /// </summary>
        /// <value>The list of folders in the folder.</value>
        [DataMember(Name = "folders", EmitDefaultValue = true)]
        public List<FileEntryDto> Folders { get; set; }

        /// <summary>
        /// Gets or Sets Current
        /// </summary>
        [DataMember(Name = "current", EmitDefaultValue = false)]
        public FolderDtoInteger Current { get; set; }

        /// <summary>
        /// The folder path.
        /// </summary>
        /// <value>The folder path.</value>
        /*
        <example>{key &#x3D; &quot;Key&quot;, path &#x3D; &quot;//path//to//folder&quot;}</example>
        */
        [DataMember(Name = "pathParts", EmitDefaultValue = true)]
        public Object PathParts { get; set; }

        /// <summary>
        /// The folder start index.
        /// </summary>
        /// <value>The folder start index.</value>
        /*
        <example>0</example>
        */
        [DataMember(Name = "startIndex", EmitDefaultValue = false)]
        public int StartIndex { get; set; }

        /// <summary>
        /// The number of folder elements.
        /// </summary>
        /// <value>The number of folder elements.</value>
        /*
        <example>4</example>
        */
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public int Count { get; set; }

        /// <summary>
        /// The total number of elements in the folder.
        /// </summary>
        /// <value>The total number of elements in the folder.</value>
        /*
        <example>4</example>
        */
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public int Total { get; set; }

        /// <summary>
        /// The new element index in the folder.
        /// </summary>
        /// <value>The new element index in the folder.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "new", EmitDefaultValue = false)]
        public int New { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FolderContentDtoInteger {\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
            sb.Append("  Folders: ").Append(Folders).Append("\n");
            sb.Append("  Current: ").Append(Current).Append("\n");
            sb.Append("  PathParts: ").Append(PathParts).Append("\n");
            sb.Append("  StartIndex: ").Append(StartIndex).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  New: ").Append(New).Append("\n");
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
