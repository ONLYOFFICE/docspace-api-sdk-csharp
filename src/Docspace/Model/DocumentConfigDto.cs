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
using FileParameter = DocSpace.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.Client.OpenAPIDateConverter;

namespace DocSpace.Model
{
    /// <summary>
    /// The document config parameters.
    /// </summary>
    [DataContract(Name = "DocumentConfigDto")]
    public partial class DocumentConfigDto : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentConfigDto" /> class.
        /// </summary>
        /// <param name="fileType">The file type of the document..</param>
        /// <param name="info">info.</param>
        /// <param name="isLinkedForMe">Specifies if the documnet is linked for current user..</param>
        /// <param name="key">The document key..</param>
        /// <param name="permissions">permissions.</param>
        /// <param name="sharedLinkParam">The shared link parameter of the document..</param>
        /// <param name="sharedLinkKey">The shared link key of the document..</param>
        /// <param name="referenceData">referenceData.</param>
        /// <param name="title">The document title..</param>
        /// <param name="url">The document url..</param>
        /// <param name="isForm">Indicates whether this is a form..</param>
        /// <param name="options">options.</param>
        public DocumentConfigDto(string fileType = default, InfoConfigDto info = default, bool isLinkedForMe = default, string key = default, PermissionsConfig permissions = default, string sharedLinkParam = default, string sharedLinkKey = default, FileReferenceData referenceData = default, string title = default, string url = default, bool isForm = default, Options options = default)
        {
            this.FileType = fileType;
            this.Info = info;
            this.IsLinkedForMe = isLinkedForMe;
            this.Key = key;
            this.Permissions = permissions;
            this.SharedLinkParam = sharedLinkParam;
            this.SharedLinkKey = sharedLinkKey;
            this.ReferenceData = referenceData;
            this.Title = title;
            this.Url = url;
            this.IsForm = isForm;
            this.Options = options;
        }

        /// <summary>
        /// The file type of the document.
        /// </summary>
        /// <value>The file type of the document.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "fileType", EmitDefaultValue = true)]
        public string FileType { get; set; }

        /// <summary>
        /// Gets or Sets Info
        /// </summary>
        [DataMember(Name = "info", EmitDefaultValue = false)]
        public InfoConfigDto Info { get; set; }

        /// <summary>
        /// Specifies if the documnet is linked for current user.
        /// </summary>
        /// <value>Specifies if the documnet is linked for current user.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isLinkedForMe", EmitDefaultValue = true)]
        public bool IsLinkedForMe { get; set; }

        /// <summary>
        /// The document key.
        /// </summary>
        /// <value>The document key.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "key", EmitDefaultValue = true)]
        public string Key { get; set; }

        /// <summary>
        /// Gets or Sets Permissions
        /// </summary>
        [DataMember(Name = "permissions", EmitDefaultValue = false)]
        public PermissionsConfig Permissions { get; set; }

        /// <summary>
        /// The shared link parameter of the document.
        /// </summary>
        /// <value>The shared link parameter of the document.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "sharedLinkParam", EmitDefaultValue = true)]
        public string SharedLinkParam { get; set; }

        /// <summary>
        /// The shared link key of the document.
        /// </summary>
        /// <value>The shared link key of the document.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "sharedLinkKey", EmitDefaultValue = true)]
        public string SharedLinkKey { get; set; }

        /// <summary>
        /// Gets or Sets ReferenceData
        /// </summary>
        [DataMember(Name = "referenceData", EmitDefaultValue = false)]
        public FileReferenceData ReferenceData { get; set; }

        /// <summary>
        /// The document title.
        /// </summary>
        /// <value>The document title.</value>
        /*
        <example>legacy_1080p_small_wooden_mouse</example>
        */
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// The document url.
        /// </summary>
        /// <value>The document url.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "url", EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Indicates whether this is a form.
        /// </summary>
        /// <value>Indicates whether this is a form.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isForm", EmitDefaultValue = true)]
        public bool IsForm { get; set; }

        /// <summary>
        /// Gets or Sets Options
        /// </summary>
        [DataMember(Name = "options", EmitDefaultValue = false)]
        public Options Options { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DocumentConfigDto {\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
            sb.Append("  Info: ").Append(Info).Append("\n");
            sb.Append("  IsLinkedForMe: ").Append(IsLinkedForMe).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
            sb.Append("  Permissions: ").Append(Permissions).Append("\n");
            sb.Append("  SharedLinkParam: ").Append(SharedLinkParam).Append("\n");
            sb.Append("  SharedLinkKey: ").Append(SharedLinkKey).Append("\n");
            sb.Append("  ReferenceData: ").Append(ReferenceData).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  IsForm: ").Append(IsForm).Append("\n");
            sb.Append("  Options: ").Append(Options).Append("\n");
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
