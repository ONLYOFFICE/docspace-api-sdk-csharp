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
    /// The generic file entry information.
    /// </summary>
    [DataContract(Name = "FileEntryDtoInteger")]
    public partial class FileEntryDtoInteger : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Access
        /// </summary>
        [DataMember(Name = "access", EmitDefaultValue = false)]
        public FileShare? Access { get; set; }

        /// <summary>
        /// Gets or Sets RootFolderType
        /// </summary>
        [DataMember(Name = "rootFolderType", EmitDefaultValue = false)]
        public FolderType? RootFolderType { get; set; }

        /// <summary>
        /// Gets or Sets ParentRoomType
        /// </summary>
        [DataMember(Name = "parentRoomType", EmitDefaultValue = false)]
        public FolderType? ParentRoomType { get; set; }

        /// <summary>
        /// Gets or Sets FileEntryType
        /// </summary>
        [DataMember(Name = "fileEntryType", EmitDefaultValue = false)]
        public FileEntryType? FileEntryType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FileEntryDtoInteger" /> class.
        /// </summary>
        /// <param name="title">The file entry title..</param>
        /// <param name="access">access.</param>
        /// <param name="sharedBy">sharedBy.</param>
        /// <param name="ownedBy">ownedBy.</param>
        /// <param name="shared">Specifies if the file entry is shared via link or not..</param>
        /// <param name="sharedForUser">Specifies if the file entry is shared for user or not..</param>
        /// <param name="parentShared">Indicates whether the parent entity is shared..</param>
        /// <param name="shortWebUrl">The short Web URL..</param>
        /// <param name="created">created.</param>
        /// <param name="createdBy">createdBy.</param>
        /// <param name="updated">updated.</param>
        /// <param name="autoDelete">autoDelete.</param>
        /// <param name="rootFolderType">rootFolderType.</param>
        /// <param name="parentRoomType">parentRoomType.</param>
        /// <param name="updatedBy">updatedBy.</param>
        /// <param name="providerItem">Specifies if the file entry provider is specified or not..</param>
        /// <param name="providerKey">The provider key of the file entry..</param>
        /// <param name="providerId">The provider ID of the file entry..</param>
        /// <param name="order">The order of the file entry..</param>
        /// <param name="isFavorite">Specifies if the file is a favorite or not..</param>
        /// <param name="fileEntryType">fileEntryType.</param>
        /// <param name="id">The file entry ID..</param>
        /// <param name="rootFolderId">The root folder ID of the file entry..</param>
        /// <param name="originId">The origin ID of the file entry..</param>
        /// <param name="originRoomId">The origin room ID of the file entry..</param>
        /// <param name="originTitle">The origin title of the file entry..</param>
        /// <param name="originRoomTitle">The origin room title of the file entry..</param>
        /// <param name="canShare">Specifies if the file entry can be shared or not..</param>
        /// <param name="shareSettings">shareSettings.</param>
        /// <param name="security">security.</param>
        /// <param name="availableShareRights">availableShareRights.</param>
        /// <param name="requestToken">The request token of the file entry..</param>
        /// <param name="external">Specifies if the folder can be accessed via an external link or not..</param>
        /// <param name="expirationDate">expirationDate.</param>
        /// <param name="isLinkExpired">Indicates whether the shareable link associated with the file or folder has expired..</param>
        public FileEntryDtoInteger(string title = default, FileShare? access = default, EmployeeDto sharedBy = default, EmployeeDto ownedBy = default, bool shared = default, bool sharedForUser = default, bool parentShared = default, string shortWebUrl = default, ApiDateTime created = default, EmployeeDto createdBy = default, ApiDateTime updated = default, ApiDateTime autoDelete = default, FolderType? rootFolderType = default, FolderType? parentRoomType = default, EmployeeDto updatedBy = default, bool? providerItem = default, string providerKey = default, int? providerId = default, string order = default, bool? isFavorite = default, FileEntryType? fileEntryType = default, int id = default, int rootFolderId = default, int originId = default, int originRoomId = default, string originTitle = default, string originRoomTitle = default, bool canShare = default, FolderDtoIntegerShareSettings shareSettings = default, FolderDtoIntegerSecurity security = default, FolderDtoIntegerAvailableShareRights availableShareRights = default, string requestToken = default, bool? external = default, ApiDateTime expirationDate = default, bool? isLinkExpired = default)
        {
            this.Title = title;
            this.Access = access;
            this.SharedBy = sharedBy;
            this.OwnedBy = ownedBy;
            this.Shared = shared;
            this.SharedForUser = sharedForUser;
            this.ParentShared = parentShared;
            this.ShortWebUrl = shortWebUrl;
            this.Created = created;
            this.CreatedBy = createdBy;
            this.Updated = updated;
            this.AutoDelete = autoDelete;
            this.RootFolderType = rootFolderType;
            this.ParentRoomType = parentRoomType;
            this.UpdatedBy = updatedBy;
            this.ProviderItem = providerItem;
            this.ProviderKey = providerKey;
            this.ProviderId = providerId;
            this.Order = order;
            this.IsFavorite = isFavorite;
            this.FileEntryType = fileEntryType;
            this.Id = id;
            this.RootFolderId = rootFolderId;
            this.OriginId = originId;
            this.OriginRoomId = originRoomId;
            this.OriginTitle = originTitle;
            this.OriginRoomTitle = originRoomTitle;
            this.CanShare = canShare;
            this.ShareSettings = shareSettings;
            this.Security = security;
            this.AvailableShareRights = availableShareRights;
            this.RequestToken = requestToken;
            this.External = external;
            this.ExpirationDate = expirationDate;
            this.IsLinkExpired = isLinkExpired;
        }

        /// <summary>
        /// The file entry title.
        /// </summary>
        /// <value>The file entry title.</value>
        /*
        <example>Some title.txt</example>
        */
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Gets or Sets SharedBy
        /// </summary>
        [DataMember(Name = "sharedBy", EmitDefaultValue = false)]
        public EmployeeDto SharedBy { get; set; }

        /// <summary>
        /// Gets or Sets OwnedBy
        /// </summary>
        [DataMember(Name = "ownedBy", EmitDefaultValue = false)]
        public EmployeeDto OwnedBy { get; set; }

        /// <summary>
        /// Specifies if the file entry is shared via link or not.
        /// </summary>
        /// <value>Specifies if the file entry is shared via link or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "shared", EmitDefaultValue = true)]
        public bool Shared { get; set; }

        /// <summary>
        /// Specifies if the file entry is shared for user or not.
        /// </summary>
        /// <value>Specifies if the file entry is shared for user or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "sharedForUser", EmitDefaultValue = true)]
        public bool SharedForUser { get; set; }

        /// <summary>
        /// Indicates whether the parent entity is shared.
        /// </summary>
        /// <value>Indicates whether the parent entity is shared.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "parentShared", EmitDefaultValue = true)]
        public bool ParentShared { get; set; }

        /// <summary>
        /// The short Web URL.
        /// </summary>
        /// <value>The short Web URL.</value>
        /*
        <example>http://localhost/s/abc123</example>
        */
        [DataMember(Name = "shortWebUrl", EmitDefaultValue = true)]
        public string ShortWebUrl { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", EmitDefaultValue = false)]
        public ApiDateTime Created { get; set; }

        /// <summary>
        /// Gets or Sets CreatedBy
        /// </summary>
        [DataMember(Name = "createdBy", EmitDefaultValue = false)]
        public EmployeeDto CreatedBy { get; set; }

        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name = "updated", EmitDefaultValue = false)]
        public ApiDateTime Updated { get; set; }

        /// <summary>
        /// Gets or Sets AutoDelete
        /// </summary>
        [DataMember(Name = "autoDelete", EmitDefaultValue = false)]
        public ApiDateTime AutoDelete { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedBy
        /// </summary>
        [DataMember(Name = "updatedBy", EmitDefaultValue = false)]
        public EmployeeDto UpdatedBy { get; set; }

        /// <summary>
        /// Specifies if the file entry provider is specified or not.
        /// </summary>
        /// <value>Specifies if the file entry provider is specified or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "providerItem", EmitDefaultValue = true)]
        public bool? ProviderItem { get; set; }

        /// <summary>
        /// The provider key of the file entry.
        /// </summary>
        /// <value>The provider key of the file entry.</value>
        /*
        <example>google-drive</example>
        */
        [DataMember(Name = "providerKey", EmitDefaultValue = true)]
        public string ProviderKey { get; set; }

        /// <summary>
        /// The provider ID of the file entry.
        /// </summary>
        /// <value>The provider ID of the file entry.</value>
        /*
        <example>1</example>
        */
        [DataMember(Name = "providerId", EmitDefaultValue = true)]
        public int? ProviderId { get; set; }

        /// <summary>
        /// The order of the file entry.
        /// </summary>
        /// <value>The order of the file entry.</value>
        /*
        <example>1</example>
        */
        [DataMember(Name = "order", EmitDefaultValue = true)]
        public string Order { get; set; }

        /// <summary>
        /// Specifies if the file is a favorite or not.
        /// </summary>
        /// <value>Specifies if the file is a favorite or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "isFavorite", EmitDefaultValue = true)]
        public bool? IsFavorite { get; set; }

        /// <summary>
        /// The file entry ID.
        /// </summary>
        /// <value>The file entry ID.</value>
        /*
        <example>10</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The root folder ID of the file entry.
        /// </summary>
        /// <value>The root folder ID of the file entry.</value>
        /*
        <example>1</example>
        */
        [DataMember(Name = "rootFolderId", EmitDefaultValue = false)]
        public int RootFolderId { get; set; }

        /// <summary>
        /// The origin ID of the file entry.
        /// </summary>
        /// <value>The origin ID of the file entry.</value>
        /*
        <example>12</example>
        */
        [DataMember(Name = "originId", EmitDefaultValue = false)]
        public int OriginId { get; set; }

        /// <summary>
        /// The origin room ID of the file entry.
        /// </summary>
        /// <value>The origin room ID of the file entry.</value>
        /*
        <example>22</example>
        */
        [DataMember(Name = "originRoomId", EmitDefaultValue = false)]
        public int OriginRoomId { get; set; }

        /// <summary>
        /// The origin title of the file entry.
        /// </summary>
        /// <value>The origin title of the file entry.</value>
        /*
        <example>Original Title</example>
        */
        [DataMember(Name = "originTitle", EmitDefaultValue = true)]
        public string OriginTitle { get; set; }

        /// <summary>
        /// The origin room title of the file entry.
        /// </summary>
        /// <value>The origin room title of the file entry.</value>
        /*
        <example>Original Room</example>
        */
        [DataMember(Name = "originRoomTitle", EmitDefaultValue = true)]
        public string OriginRoomTitle { get; set; }

        /// <summary>
        /// Specifies if the file entry can be shared or not.
        /// </summary>
        /// <value>Specifies if the file entry can be shared or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "canShare", EmitDefaultValue = true)]
        public bool CanShare { get; set; }

        /// <summary>
        /// Gets or Sets ShareSettings
        /// </summary>
        [DataMember(Name = "shareSettings", EmitDefaultValue = true)]
        public FolderDtoIntegerShareSettings ShareSettings { get; set; }

        /// <summary>
        /// Gets or Sets Security
        /// </summary>
        [DataMember(Name = "security", EmitDefaultValue = true)]
        public FolderDtoIntegerSecurity Security { get; set; }

        /// <summary>
        /// Gets or Sets AvailableShareRights
        /// </summary>
        [DataMember(Name = "availableShareRights", EmitDefaultValue = true)]
        public FolderDtoIntegerAvailableShareRights AvailableShareRights { get; set; }

        /// <summary>
        /// The request token of the file entry.
        /// </summary>
        /// <value>The request token of the file entry.</value>
        /*
        <example>token-abc-123</example>
        */
        [DataMember(Name = "requestToken", EmitDefaultValue = true)]
        public string RequestToken { get; set; }

        /// <summary>
        /// Specifies if the folder can be accessed via an external link or not.
        /// </summary>
        /// <value>Specifies if the folder can be accessed via an external link or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "external", EmitDefaultValue = true)]
        public bool? External { get; set; }

        /// <summary>
        /// Gets or Sets ExpirationDate
        /// </summary>
        [DataMember(Name = "expirationDate", EmitDefaultValue = false)]
        public ApiDateTime ExpirationDate { get; set; }

        /// <summary>
        /// Indicates whether the shareable link associated with the file or folder has expired.
        /// </summary>
        /// <value>Indicates whether the shareable link associated with the file or folder has expired.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "isLinkExpired", EmitDefaultValue = true)]
        public bool? IsLinkExpired { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileEntryDtoInteger {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Access: ").Append(Access).Append("\n");
            sb.Append("  SharedBy: ").Append(SharedBy).Append("\n");
            sb.Append("  OwnedBy: ").Append(OwnedBy).Append("\n");
            sb.Append("  Shared: ").Append(Shared).Append("\n");
            sb.Append("  SharedForUser: ").Append(SharedForUser).Append("\n");
            sb.Append("  ParentShared: ").Append(ParentShared).Append("\n");
            sb.Append("  ShortWebUrl: ").Append(ShortWebUrl).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  AutoDelete: ").Append(AutoDelete).Append("\n");
            sb.Append("  RootFolderType: ").Append(RootFolderType).Append("\n");
            sb.Append("  ParentRoomType: ").Append(ParentRoomType).Append("\n");
            sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
            sb.Append("  ProviderItem: ").Append(ProviderItem).Append("\n");
            sb.Append("  ProviderKey: ").Append(ProviderKey).Append("\n");
            sb.Append("  ProviderId: ").Append(ProviderId).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
            sb.Append("  IsFavorite: ").Append(IsFavorite).Append("\n");
            sb.Append("  FileEntryType: ").Append(FileEntryType).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RootFolderId: ").Append(RootFolderId).Append("\n");
            sb.Append("  OriginId: ").Append(OriginId).Append("\n");
            sb.Append("  OriginRoomId: ").Append(OriginRoomId).Append("\n");
            sb.Append("  OriginTitle: ").Append(OriginTitle).Append("\n");
            sb.Append("  OriginRoomTitle: ").Append(OriginRoomTitle).Append("\n");
            sb.Append("  CanShare: ").Append(CanShare).Append("\n");
            sb.Append("  ShareSettings: ").Append(ShareSettings).Append("\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
            sb.Append("  AvailableShareRights: ").Append(AvailableShareRights).Append("\n");
            sb.Append("  RequestToken: ").Append(RequestToken).Append("\n");
            sb.Append("  External: ").Append(External).Append("\n");
            sb.Append("  ExpirationDate: ").Append(ExpirationDate).Append("\n");
            sb.Append("  IsLinkExpired: ").Append(IsLinkExpired).Append("\n");
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
