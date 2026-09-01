// (c) Copyright Ascensio System SIA 2026
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.


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
using FileParameter = DocSpace.API.SDK.Client.FileParameter;
using OpenAPIDateConverter = DocSpace.API.SDK.Client.OpenAPIDateConverter;

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// The file sharing information and access rights.
    /// </summary>
    [DataContract(Name = "FileShareDto")]
    public partial class FileShareDto : IValidatableObject
    {

        /// <summary>
        /// The access rights type.
        /// </summary>
        [DataMember(Name = "access", EmitDefaultValue = false)]
        public FileShare? Access { get; set; }

        /// <summary>
        /// The subject type of the access right.
        /// </summary>
        [DataMember(Name = "subjectType", IsRequired = true, EmitDefaultValue = true)]
        public SubjectType SubjectType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FileShareDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileShareDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileShareDto" /> class.
        /// </summary>
        /// <param name="access">The access rights type..</param>
        /// <param name="sharedTo">sharedTo.</param>
        /// <param name="sharedToUser">The full list of user parameters..</param>
        /// <param name="sharedToGroup">The group summary parameters..</param>
        /// <param name="sharedLink">The user who has the access to the specified file..</param>
        /// <param name="isLocked">Specifies if the access right is locked or not. (required).</param>
        /// <param name="isOwner">Specifies if the user is an owner of the specified file or not. (required).</param>
        /// <param name="canEditAccess">Specifies if the user can edit the access to the specified file or not. (required).</param>
        /// <param name="canEditInternal">Indicates whether internal editing permissions are granted. (required).</param>
        /// <param name="canEditDenyDownload">Determines whether the user has permission to modify the deny download setting for the file share. (required).</param>
        /// <param name="canEditExpirationDate">Indicates whether the expiration date of access permissions can be edited. (required).</param>
        /// <param name="canRevoke">Specifies whether the file sharing access can be revoked by the current user. (required).</param>
        /// <param name="subjectType">The subject type of the access right. (required).</param>
        public FileShareDto(FileShare? access = default, Object sharedTo = default, EmployeeFullDto sharedToUser = default, GroupSummaryDto sharedToGroup = default, FileShareLink sharedLink = default, bool isLocked = default, bool isOwner = default, bool canEditAccess = default, bool canEditInternal = default, bool canEditDenyDownload = default, bool canEditExpirationDate = default, bool canRevoke = default, SubjectType subjectType = default)
        {
            this.IsLocked = isLocked;
            this.IsOwner = isOwner;
            this.CanEditAccess = canEditAccess;
            this.CanEditInternal = canEditInternal;
            this.CanEditDenyDownload = canEditDenyDownload;
            this.CanEditExpirationDate = canEditExpirationDate;
            this.CanRevoke = canRevoke;
            this.SubjectType = subjectType;
            this.Access = access;
            this.SharedTo = sharedTo;
            this.SharedToUser = sharedToUser;
            this.SharedToGroup = sharedToGroup;
            this.SharedLink = sharedLink;
        }

        /// <summary>
        /// Gets or Sets SharedTo
        /// </summary>
        [DataMember(Name = "sharedTo", EmitDefaultValue = true)]
        public Object SharedTo { get; set; }

        /// <summary>
        /// The full list of user parameters.
        /// </summary>
        [DataMember(Name = "sharedToUser", EmitDefaultValue = false)]
        public EmployeeFullDto SharedToUser { get; set; }

        /// <summary>
        /// The group summary parameters.
        /// </summary>
        [DataMember(Name = "sharedToGroup", EmitDefaultValue = false)]
        public GroupSummaryDto SharedToGroup { get; set; }

        /// <summary>
        /// The user who has the access to the specified file.
        /// </summary>
        [DataMember(Name = "sharedLink", EmitDefaultValue = false)]
        public FileShareLink SharedLink { get; set; }

        /// <summary>
        /// Specifies if the access right is locked or not.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isLocked", IsRequired = true, EmitDefaultValue = true)]
        public bool IsLocked { get; set; }

        /// <summary>
        /// Specifies if the user is an owner of the specified file or not.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isOwner", IsRequired = true, EmitDefaultValue = true)]
        public bool IsOwner { get; set; }

        /// <summary>
        /// Specifies if the user can edit the access to the specified file or not.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "canEditAccess", IsRequired = true, EmitDefaultValue = true)]
        public bool CanEditAccess { get; set; }

        /// <summary>
        /// Indicates whether internal editing permissions are granted.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "canEditInternal", IsRequired = true, EmitDefaultValue = true)]
        public bool CanEditInternal { get; set; }

        /// <summary>
        /// Determines whether the user has permission to modify the deny download setting for the file share.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "canEditDenyDownload", IsRequired = true, EmitDefaultValue = true)]
        public bool CanEditDenyDownload { get; set; }

        /// <summary>
        /// Indicates whether the expiration date of access permissions can be edited.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "canEditExpirationDate", IsRequired = true, EmitDefaultValue = true)]
        public bool CanEditExpirationDate { get; set; }

        /// <summary>
        /// Specifies whether the file sharing access can be revoked by the current user.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "canRevoke", IsRequired = true, EmitDefaultValue = true)]
        public bool CanRevoke { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileShareDto {\n");
            sb.Append("  Access: ").Append(Access).Append("\n");
            sb.Append("  SharedTo: ").Append(SharedTo).Append("\n");
            sb.Append("  SharedToUser: ").Append(SharedToUser).Append("\n");
            sb.Append("  SharedToGroup: ").Append(SharedToGroup).Append("\n");
            sb.Append("  SharedLink: ").Append(SharedLink).Append("\n");
            sb.Append("  IsLocked: ").Append(IsLocked).Append("\n");
            sb.Append("  IsOwner: ").Append(IsOwner).Append("\n");
            sb.Append("  CanEditAccess: ").Append(CanEditAccess).Append("\n");
            sb.Append("  CanEditInternal: ").Append(CanEditInternal).Append("\n");
            sb.Append("  CanEditDenyDownload: ").Append(CanEditDenyDownload).Append("\n");
            sb.Append("  CanEditExpirationDate: ").Append(CanEditExpirationDate).Append("\n");
            sb.Append("  CanRevoke: ").Append(CanRevoke).Append("\n");
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
