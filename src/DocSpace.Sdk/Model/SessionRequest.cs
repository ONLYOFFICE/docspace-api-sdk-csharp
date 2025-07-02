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
    /// The session request parameters.
    /// </summary>
    [DataContract(Name = "SessionRequest")]
    public partial class SessionRequest : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SessionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SessionRequest" /> class.
        /// </summary>
        /// <param name="fileName">The file name. (required).</param>
        /// <param name="fileSize">The file size..</param>
        /// <param name="relativePath">The relative path to the file..</param>
        /// <param name="createOn">createOn.</param>
        /// <param name="encrypted">Specifies whether the file is encrypted or not..</param>
        /// <param name="createNewIfExist">Specifies whether to create a new file if it already exists..</param>
        public SessionRequest(string fileName = default, long fileSize = default, string relativePath = default, ApiDateTime createOn = default, bool encrypted = default, bool createNewIfExist = default)
        {
            // to ensure "fileName" is required (not null)
            if (fileName == null)
            {
                throw new ArgumentNullException("fileName is a required property for SessionRequest and cannot be null");
            }
            this.FileName = fileName;
            this.FileSize = fileSize;
            this.RelativePath = relativePath;
            this.CreateOn = createOn;
            this.Encrypted = encrypted;
            this.CreateNewIfExist = createNewIfExist;
        }

        /// <summary>
        /// The file name.
        /// </summary>
        /// <value>The file name.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "fileName", IsRequired = true, EmitDefaultValue = true)]
        public string FileName { get; set; }

        /// <summary>
        /// The file size.
        /// </summary>
        /// <value>The file size.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "fileSize", EmitDefaultValue = false)]
        public long FileSize { get; set; }

        /// <summary>
        /// The relative path to the file.
        /// </summary>
        /// <value>The relative path to the file.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "relativePath", EmitDefaultValue = true)]
        public string RelativePath { get; set; }

        /// <summary>
        /// Gets or Sets CreateOn
        /// </summary>
        [DataMember(Name = "createOn", EmitDefaultValue = false)]
        public ApiDateTime CreateOn { get; set; }

        /// <summary>
        /// Specifies whether the file is encrypted or not.
        /// </summary>
        /// <value>Specifies whether the file is encrypted or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "encrypted", EmitDefaultValue = true)]
        public bool Encrypted { get; set; }

        /// <summary>
        /// Specifies whether to create a new file if it already exists.
        /// </summary>
        /// <value>Specifies whether to create a new file if it already exists.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "createNewIfExist", EmitDefaultValue = true)]
        public bool CreateNewIfExist { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SessionRequest {\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  FileSize: ").Append(FileSize).Append("\n");
            sb.Append("  RelativePath: ").Append(RelativePath).Append("\n");
            sb.Append("  CreateOn: ").Append(CreateOn).Append("\n");
            sb.Append("  Encrypted: ").Append(Encrypted).Append("\n");
            sb.Append("  CreateNewIfExist: ").Append(CreateNewIfExist).Append("\n");
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
