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
    /// The file sharing information and access rights.
    /// </summary>
    [DataContract(Name = "FileShareDto")]
    public partial class FileShareDto : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Access
        /// </summary>
        [DataMember(Name = "access", EmitDefaultValue = false)]
        public FileShare? Access { get; set; }

        /// <summary>
        /// Gets or Sets SubjectType
        /// </summary>
        [DataMember(Name = "subjectType", EmitDefaultValue = false)]
        public SubjectType? SubjectType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileShareDto" /> class.
        /// </summary>
        /// <param name="access">access.</param>
        /// <param name="sharedTo">The user who has the access to the specified file..</param>
        /// <param name="isLocked">Specifies if the access right is locked or not..</param>
        /// <param name="isOwner">Specifies if the user is an owner of the specified file or not..</param>
        /// <param name="canEditAccess">Specifies if the user can edit the access to the specified file or not..</param>
        /// <param name="subjectType">subjectType.</param>
        public FileShareDto(FileShare? access = default, Object sharedTo = default, bool isLocked = default, bool isOwner = default, bool canEditAccess = default, SubjectType? subjectType = default)
        {
            this.Access = access;
            this.SharedTo = sharedTo;
            this.IsLocked = isLocked;
            this.IsOwner = isOwner;
            this.CanEditAccess = canEditAccess;
            this.SubjectType = subjectType;
        }

        /// <summary>
        /// The user who has the access to the specified file.
        /// </summary>
        /// <value>The user who has the access to the specified file.</value>
        /*
        <example>{&quot;int&quot;:1234,&quot;string&quot;:&quot;some text&quot;,&quot;boolean&quot;:true}</example>
        */
        [DataMember(Name = "sharedTo", EmitDefaultValue = true)]
        public Object SharedTo { get; set; }

        /// <summary>
        /// Specifies if the access right is locked or not.
        /// </summary>
        /// <value>Specifies if the access right is locked or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "isLocked", EmitDefaultValue = true)]
        public bool IsLocked { get; set; }

        /// <summary>
        /// Specifies if the user is an owner of the specified file or not.
        /// </summary>
        /// <value>Specifies if the user is an owner of the specified file or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isOwner", EmitDefaultValue = true)]
        public bool IsOwner { get; set; }

        /// <summary>
        /// Specifies if the user can edit the access to the specified file or not.
        /// </summary>
        /// <value>Specifies if the user can edit the access to the specified file or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "canEditAccess", EmitDefaultValue = true)]
        public bool CanEditAccess { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FileShareDto {\n");
            sb.Append("  Access: ").Append(Access).Append("\n");
            sb.Append("  SharedTo: ").Append(SharedTo).Append("\n");
            sb.Append("  IsLocked: ").Append(IsLocked).Append("\n");
            sb.Append("  IsOwner: ").Append(IsOwner).Append("\n");
            sb.Append("  CanEditAccess: ").Append(CanEditAccess).Append("\n");
            sb.Append("  SubjectType: ").Append(SubjectType).Append("\n");
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
