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
    /// The parameters for checking file conversion.
    /// </summary>
    [DataContract(Name = "CheckConversionRequestDtoInteger")]
    public partial class CheckConversionRequestDtoInteger : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckConversionRequestDtoInteger" /> class.
        /// </summary>
        /// <param name="fileId">The file ID to check conversion proccess..</param>
        /// <param name="sync">Specifies if the conversion process is synchronous or not..</param>
        /// <param name="startConvert">Specifies whether to start a conversion process or not..</param>
        /// <param name="varVersion">The file version that is converted..</param>
        /// <param name="password">The password of the converted file..</param>
        /// <param name="outputType">The conversion output type..</param>
        /// <param name="createNewIfExist">Specifies whether to create a new file if it exists or not..</param>
        public CheckConversionRequestDtoInteger(int fileId = default, bool sync = default, bool startConvert = default, int varVersion = default, string password = default, string outputType = default, bool createNewIfExist = default)
        {
            this.FileId = fileId;
            this.Sync = sync;
            this.StartConvert = startConvert;
            this.VarVersion = varVersion;
            this.Password = password;
            this.OutputType = outputType;
            this.CreateNewIfExist = createNewIfExist;
        }

        /// <summary>
        /// The file ID to check conversion proccess.
        /// </summary>
        /// <value>The file ID to check conversion proccess.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "fileId", EmitDefaultValue = false)]
        public int FileId { get; set; }

        /// <summary>
        /// Specifies if the conversion process is synchronous or not.
        /// </summary>
        /// <value>Specifies if the conversion process is synchronous or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "sync", EmitDefaultValue = true)]
        public bool Sync { get; set; }

        /// <summary>
        /// Specifies whether to start a conversion process or not.
        /// </summary>
        /// <value>Specifies whether to start a conversion process or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "startConvert", EmitDefaultValue = true)]
        public bool StartConvert { get; set; }

        /// <summary>
        /// The file version that is converted.
        /// </summary>
        /// <value>The file version that is converted.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int VarVersion { get; set; }

        /// <summary>
        /// The password of the converted file.
        /// </summary>
        /// <value>The password of the converted file.</value>
        /*
        <example>vfmf2vO1Kp</example>
        */
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// The conversion output type.
        /// </summary>
        /// <value>The conversion output type.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "outputType", EmitDefaultValue = true)]
        public string OutputType { get; set; }

        /// <summary>
        /// Specifies whether to create a new file if it exists or not.
        /// </summary>
        /// <value>Specifies whether to create a new file if it exists or not.</value>
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
            sb.Append("class CheckConversionRequestDtoInteger {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  Sync: ").Append(Sync).Append("\n");
            sb.Append("  StartConvert: ").Append(StartConvert).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  OutputType: ").Append(OutputType).Append("\n");
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
