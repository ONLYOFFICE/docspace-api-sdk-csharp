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
    /// The parameters for copying a file.
    /// </summary>
    [DataContract(Name = "CopyAsJsonElement")]
    public partial class CopyAsJsonElement : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CopyAsJsonElement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CopyAsJsonElement() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CopyAsJsonElement" /> class.
        /// </summary>
        /// <param name="destTitle">The copied file name. (required).</param>
        /// <param name="destFolderId">destFolderId (required).</param>
        /// <param name="enableExternalExt">Specifies whether to allow creating the copied file of an external extension or not..</param>
        /// <param name="password">The copied file password..</param>
        /// <param name="toForm">Specifies whether to convert the file to form or not..</param>
        public CopyAsJsonElement(string destTitle = default, CopyAsJsonElementDestFolderId destFolderId = default, bool enableExternalExt = default, string password = default, bool toForm = default)
        {
            // to ensure "destTitle" is required (not null)
            if (destTitle == null)
            {
                throw new ArgumentNullException("destTitle is a required property for CopyAsJsonElement and cannot be null");
            }
            this.DestTitle = destTitle;
            // to ensure "destFolderId" is required (not null)
            if (destFolderId == null)
            {
                throw new ArgumentNullException("destFolderId is a required property for CopyAsJsonElement and cannot be null");
            }
            this.DestFolderId = destFolderId;
            this.EnableExternalExt = enableExternalExt;
            this.Password = password;
            this.ToForm = toForm;
        }

        /// <summary>
        /// The copied file name.
        /// </summary>
        /// <value>The copied file name.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "destTitle", IsRequired = true, EmitDefaultValue = true)]
        public string DestTitle { get; set; }

        /// <summary>
        /// Gets or Sets DestFolderId
        /// </summary>
        [DataMember(Name = "destFolderId", IsRequired = true, EmitDefaultValue = true)]
        public CopyAsJsonElementDestFolderId DestFolderId { get; set; }

        /// <summary>
        /// Specifies whether to allow creating the copied file of an external extension or not.
        /// </summary>
        /// <value>Specifies whether to allow creating the copied file of an external extension or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "enableExternalExt", EmitDefaultValue = true)]
        public bool EnableExternalExt { get; set; }

        /// <summary>
        /// The copied file password.
        /// </summary>
        /// <value>The copied file password.</value>
        /*
        <example>vfmf2vO1Kp</example>
        */
        [DataMember(Name = "password", EmitDefaultValue = true)]
        public string Password { get; set; }

        /// <summary>
        /// Specifies whether to convert the file to form or not.
        /// </summary>
        /// <value>Specifies whether to convert the file to form or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "toForm", EmitDefaultValue = true)]
        public bool ToForm { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CopyAsJsonElement {\n");
            sb.Append("  DestTitle: ").Append(DestTitle).Append("\n");
            sb.Append("  DestFolderId: ").Append(DestFolderId).Append("\n");
            sb.Append("  EnableExternalExt: ").Append(EnableExternalExt).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  ToForm: ").Append(ToForm).Append("\n");
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
