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
    /// One access entry on a file, a folder or a room: who holds it, at which level, and what the caller may change about  it.
    /// </summary>
    [DataContract(Name = "FileShareDto")]
    public partial class FileShareDto : IValidatableObject
    {

        /// <summary>
        /// The level the subject holds on the entry. On a link entry it is the level the link hands to whoever opens it,  and in a batch answer &#x60;Varies&#x60; means the subject holds different levels on the listed entries.
        /// </summary>
        [DataMember(Name = "access", EmitDefaultValue = false)]
        public FileShare? Access { get; set; }

        /// <summary>
        /// What the entry was given to, which tells which of the three subject fields is filled in: an account, a group,  or one of the kinds of link.
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
        /// <param name="access">The level the subject holds on the entry. On a link entry it is the level the link hands to whoever opens it,  and in a batch answer &#x60;Varies&#x60; means the subject holds different levels on the listed entries..</param>
        /// <param name="sharedTo">sharedTo.</param>
        /// <param name="sharedToUser">The account the entry belongs to. It is filled in only when &#x60;subjectType&#x60; says an account, and is null for a  group entry and for a link..</param>
        /// <param name="sharedToGroup">The portal group the entry belongs to, which hands the level to everybody in it. It is filled in only for a  group entry, and is null otherwise..</param>
        /// <param name="sharedLink">The sharing link the entry stands for, together with everything set on it. It is filled in only for a link  entry, and is null for an account or a group..</param>
        /// <param name="isLocked">Whether this entry is the caller&#39;s own, which is why they cannot change its level. Link entries never report  it. (required).</param>
        /// <param name="isOwner">Whether the subject created the entry the access is given on, and so cannot be removed from it. (required).</param>
        /// <param name="canEditAccess">Whether the caller may change the level of this entry. It is false on the caller&#39;s own entry, on every link,  and whenever the caller may not hand out access at all. (required).</param>
        /// <param name="canEditInternal">Whether the caller may switch this link between being open to anybody and asking the visitor to sign in to the  portal first. (required).</param>
        /// <param name="canEditDenyDownload">Whether the caller may forbid downloading through this link. Only a link of a virtual data room reports true,  and only while the room itself still allows downloads. (required).</param>
        /// <param name="canEditExpirationDate">Whether the caller may move the moment this link stops working. (required).</param>
        /// <param name="canRevoke">Whether the caller may take this entry away altogether, which for a link means deleting the link. (required).</param>
        /// <param name="subjectType">What the entry was given to, which tells which of the three subject fields is filled in: an account, a group,  or one of the kinds of link. (required).</param>
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
        /// The account the entry belongs to. It is filled in only when &#x60;subjectType&#x60; says an account, and is null for a  group entry and for a link.
        /// </summary>
        [DataMember(Name = "sharedToUser", EmitDefaultValue = false)]
        public EmployeeFullDto SharedToUser { get; set; }

        /// <summary>
        /// The portal group the entry belongs to, which hands the level to everybody in it. It is filled in only for a  group entry, and is null otherwise.
        /// </summary>
        [DataMember(Name = "sharedToGroup", EmitDefaultValue = false)]
        public GroupSummaryDto SharedToGroup { get; set; }

        /// <summary>
        /// The sharing link the entry stands for, together with everything set on it. It is filled in only for a link  entry, and is null for an account or a group.
        /// </summary>
        [DataMember(Name = "sharedLink", EmitDefaultValue = false)]
        public FileShareLink SharedLink { get; set; }

        /// <summary>
        /// Whether this entry is the caller&#39;s own, which is why they cannot change its level. Link entries never report  it.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isLocked", IsRequired = true, EmitDefaultValue = true)]
        public bool IsLocked { get; set; }

        /// <summary>
        /// Whether the subject created the entry the access is given on, and so cannot be removed from it.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isOwner", IsRequired = true, EmitDefaultValue = true)]
        public bool IsOwner { get; set; }

        /// <summary>
        /// Whether the caller may change the level of this entry. It is false on the caller&#39;s own entry, on every link,  and whenever the caller may not hand out access at all.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "canEditAccess", IsRequired = true, EmitDefaultValue = true)]
        public bool CanEditAccess { get; set; }

        /// <summary>
        /// Whether the caller may switch this link between being open to anybody and asking the visitor to sign in to the  portal first.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "canEditInternal", IsRequired = true, EmitDefaultValue = true)]
        public bool CanEditInternal { get; set; }

        /// <summary>
        /// Whether the caller may forbid downloading through this link. Only a link of a virtual data room reports true,  and only while the room itself still allows downloads.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "canEditDenyDownload", IsRequired = true, EmitDefaultValue = true)]
        public bool CanEditDenyDownload { get; set; }

        /// <summary>
        /// Whether the caller may move the moment this link stops working.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "canEditExpirationDate", IsRequired = true, EmitDefaultValue = true)]
        public bool CanEditExpirationDate { get; set; }

        /// <summary>
        /// Whether the caller may take this entry away altogether, which for a link means deleting the link.
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
