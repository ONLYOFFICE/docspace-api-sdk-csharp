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
    /// The form gallery parameters.
    /// </summary>
    [DataContract(Name = "FormGalleryDto")]
    public partial class FormGalleryDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormGalleryDto" /> class.
        /// </summary>
        /// <param name="path">The form gallery path..</param>
        /// <param name="domain">The form gallery domain..</param>
        /// <param name="ext">The form gallery extension..</param>
        /// <param name="uploadPath">The form gallery upload path..</param>
        /// <param name="uploadDomain">The form gallery upload domain..</param>
        /// <param name="uploadExt">The form gallery upload extension..</param>
        /// <param name="uploadDashboard">The form gallery upload dashboard..</param>
        public FormGalleryDto(string path = default, string domain = default, string ext = default, string uploadPath = default, string uploadDomain = default, string uploadExt = default, string uploadDashboard = default)
        {
            this.Path = path;
            this.Domain = domain;
            this.Ext = ext;
            this.UploadPath = uploadPath;
            this.UploadDomain = uploadDomain;
            this.UploadExt = uploadExt;
            this.UploadDashboard = uploadDashboard;
        }

        /// <summary>
        /// The form gallery path.
        /// </summary>
        /// <value>The form gallery path.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "path", EmitDefaultValue = true)]
        public string Path { get; set; }

        /// <summary>
        /// The form gallery domain.
        /// </summary>
        /// <value>The form gallery domain.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "domain", EmitDefaultValue = true)]
        public string Domain { get; set; }

        /// <summary>
        /// The form gallery extension.
        /// </summary>
        /// <value>The form gallery extension.</value>
        /*
        <example>.txt</example>
        */
        [DataMember(Name = "ext", EmitDefaultValue = true)]
        public string Ext { get; set; }

        /// <summary>
        /// The form gallery upload path.
        /// </summary>
        /// <value>The form gallery upload path.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "uploadPath", EmitDefaultValue = true)]
        public string UploadPath { get; set; }

        /// <summary>
        /// The form gallery upload domain.
        /// </summary>
        /// <value>The form gallery upload domain.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "uploadDomain", EmitDefaultValue = true)]
        public string UploadDomain { get; set; }

        /// <summary>
        /// The form gallery upload extension.
        /// </summary>
        /// <value>The form gallery upload extension.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "uploadExt", EmitDefaultValue = true)]
        public string UploadExt { get; set; }

        /// <summary>
        /// The form gallery upload dashboard.
        /// </summary>
        /// <value>The form gallery upload dashboard.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "uploadDashboard", EmitDefaultValue = true)]
        public string UploadDashboard { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FormGalleryDto {\n");
            sb.Append("  Path: ").Append(Path).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  Ext: ").Append(Ext).Append("\n");
            sb.Append("  UploadPath: ").Append(UploadPath).Append("\n");
            sb.Append("  UploadDomain: ").Append(UploadDomain).Append("\n");
            sb.Append("  UploadExt: ").Append(UploadExt).Append("\n");
            sb.Append("  UploadDashboard: ").Append(UploadDashboard).Append("\n");
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
