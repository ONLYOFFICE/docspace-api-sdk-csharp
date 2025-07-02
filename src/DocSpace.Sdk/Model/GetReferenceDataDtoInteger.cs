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
    /// The request parameters for getting reference data.
    /// </summary>
    [DataContract(Name = "GetReferenceDataDtoInteger")]
    public partial class GetReferenceDataDtoInteger : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetReferenceDataDtoInteger" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GetReferenceDataDtoInteger() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetReferenceDataDtoInteger" /> class.
        /// </summary>
        /// <param name="fileKey">The unique document identifier used by the service to get a link to the file. (required).</param>
        /// <param name="instanceId">The unique system identifier..</param>
        /// <param name="sourceFileId">The source file ID..</param>
        /// <param name="path">The file name or relative path for the formula editor..</param>
        /// <param name="link">The file link..</param>
        public GetReferenceDataDtoInteger(string fileKey = default, string instanceId = default, int sourceFileId = default, string path = default, string link = default)
        {
            // to ensure "fileKey" is required (not null)
            if (fileKey == null)
            {
                throw new ArgumentNullException("fileKey is a required property for GetReferenceDataDtoInteger and cannot be null");
            }
            this.FileKey = fileKey;
            this.InstanceId = instanceId;
            this.SourceFileId = sourceFileId;
            this.Path = path;
            this.Link = link;
        }

        /// <summary>
        /// The unique document identifier used by the service to get a link to the file.
        /// </summary>
        /// <value>The unique document identifier used by the service to get a link to the file.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "fileKey", IsRequired = true, EmitDefaultValue = true)]
        public string FileKey { get; set; }

        /// <summary>
        /// The unique system identifier.
        /// </summary>
        /// <value>The unique system identifier.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "instanceId", EmitDefaultValue = true)]
        public string InstanceId { get; set; }

        /// <summary>
        /// The source file ID.
        /// </summary>
        /// <value>The source file ID.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "sourceFileId", EmitDefaultValue = false)]
        public int SourceFileId { get; set; }

        /// <summary>
        /// The file name or relative path for the formula editor.
        /// </summary>
        /// <value>The file name or relative path for the formula editor.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "path", EmitDefaultValue = true)]
        public string Path { get; set; }

        /// <summary>
        /// The file link.
        /// </summary>
        /// <value>The file link.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "link", EmitDefaultValue = true)]
        public string Link { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetReferenceDataDtoInteger {\n");
            sb.Append("  FileKey: ").Append(FileKey).Append("\n");
            sb.Append("  InstanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  SourceFileId: ").Append(SourceFileId).Append("\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Link: ").Append(Link).Append("\n");
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
