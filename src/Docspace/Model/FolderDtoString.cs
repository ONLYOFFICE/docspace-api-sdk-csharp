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
    /// The folder parameters.
    /// </summary>
    [DataContract(Name = "FolderDtoString")]
    public partial class FolderDtoString : IValidatableObject
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
        /// Gets or Sets RoomType
        /// </summary>
        [DataMember(Name = "roomType", EmitDefaultValue = false)]
        public RoomType? RoomType { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public FolderType? Type { get; set; }

        /// <summary>
        /// Gets or Sets FileEntryType
        /// </summary>
        [DataMember(Name = "fileEntryType", EmitDefaultValue = false)]
        public FileEntryType? FileEntryType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FolderDtoString" /> class.
        /// </summary>
        /// <param name="title">The file entry title..</param>
        /// <param name="access">access.</param>
        /// <param name="shared">Specifies if the file entry is shared or not..</param>
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
        /// <param name="id">The file entry ID..</param>
        /// <param name="rootFolderId">The root folder ID of the file entry..</param>
        /// <param name="originId">The origin ID of the file entry..</param>
        /// <param name="originRoomId">The origin room ID of the file entry..</param>
        /// <param name="originTitle">The origin title of the file entry..</param>
        /// <param name="originRoomTitle">The origin room title of the file entry..</param>
        /// <param name="canShare">Specifies if the file entry can be shared or not..</param>
        /// <param name="security">security.</param>
        /// <param name="requestToken">The request token of the file entry..</param>
        /// <param name="parentId">The parent folder ID of the folder..</param>
        /// <param name="filesCount">The number of files that the folder contains..</param>
        /// <param name="foldersCount">The number of folders that the folder contains..</param>
        /// <param name="isShareable">Specifies if the folder can be shared or not..</param>
        /// <param name="isFavorite">Specifies if the folder is favorite or not..</param>
        /// <param name="varNew">The new element index in the folder..</param>
        /// <param name="mute">Specifies if the folder notifications are enabled or not..</param>
        /// <param name="tags">The list of tags of the folder..</param>
        /// <param name="logo">logo.</param>
        /// <param name="pinned">Specifies if the folder is pinned or not..</param>
        /// <param name="roomType">roomType.</param>
        /// <param name="varPrivate">Specifies if the folder is private or not..</param>
        /// <param name="indexing">Specifies if the folder is indexed or not..</param>
        /// <param name="denyDownload">Specifies if the folder can be downloaded or not..</param>
        /// <param name="lifetime">lifetime.</param>
        /// <param name="watermark">watermark.</param>
        /// <param name="type">type.</param>
        /// <param name="inRoom">Specifies if the folder is placed in the room or not..</param>
        /// <param name="quotaLimit">The folder quota limit..</param>
        /// <param name="isCustomQuota">Specifies if the folder room has a custom quota or not..</param>
        /// <param name="usedSpace">How much folder space is used (counter)..</param>
        /// <param name="external">Specifies if the folder can be accessed via an external link or not..</param>
        /// <param name="passwordProtected">Specifies if the folder is password protected or not..</param>
        /// <param name="expired">Specifies if an external link to the folder is expired or not..</param>
        /// <param name="fileEntryType">fileEntryType.</param>
        public FolderDtoString(string title = default, FileShare? access = default, bool shared = default, ApiDateTime created = default, EmployeeDto createdBy = default, ApiDateTime updated = default, ApiDateTime autoDelete = default, FolderType? rootFolderType = default, FolderType? parentRoomType = default, EmployeeDto updatedBy = default, bool? providerItem = default, string providerKey = default, int? providerId = default, string order = default, string id = default, string rootFolderId = default, string originId = default, string originRoomId = default, string originTitle = default, string originRoomTitle = default, bool canShare = default, FileDtoIntegerSecurity security = default, string requestToken = default, string parentId = default, int filesCount = default, int foldersCount = default, bool? isShareable = default, bool? isFavorite = default, int varNew = default, bool mute = default, List<string> tags = default, Logo logo = default, bool pinned = default, RoomType? roomType = default, bool varPrivate = default, bool indexing = default, bool denyDownload = default, RoomDataLifetimeDto lifetime = default, WatermarkDto watermark = default, FolderType? type = default, bool? inRoom = default, long? quotaLimit = default, bool? isCustomQuota = default, long? usedSpace = default, bool? external = default, bool? passwordProtected = default, bool? expired = default, FileEntryType? fileEntryType = default)
        {
            this.Title = title;
            this.Access = access;
            this.Shared = shared;
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
            this.Id = id;
            this.RootFolderId = rootFolderId;
            this.OriginId = originId;
            this.OriginRoomId = originRoomId;
            this.OriginTitle = originTitle;
            this.OriginRoomTitle = originRoomTitle;
            this.CanShare = canShare;
            this.Security = security;
            this.RequestToken = requestToken;
            this.ParentId = parentId;
            this.FilesCount = filesCount;
            this.FoldersCount = foldersCount;
            this.IsShareable = isShareable;
            this.IsFavorite = isFavorite;
            this.New = varNew;
            this.Mute = mute;
            this.Tags = tags;
            this.Logo = logo;
            this.Pinned = pinned;
            this.RoomType = roomType;
            this.Private = varPrivate;
            this.Indexing = indexing;
            this.DenyDownload = denyDownload;
            this.Lifetime = lifetime;
            this.Watermark = watermark;
            this.Type = type;
            this.InRoom = inRoom;
            this.QuotaLimit = quotaLimit;
            this.IsCustomQuota = isCustomQuota;
            this.UsedSpace = usedSpace;
            this.External = external;
            this.PasswordProtected = passwordProtected;
            this.Expired = expired;
            this.FileEntryType = fileEntryType;
        }

        /// <summary>
        /// The file entry title.
        /// </summary>
        /// <value>The file entry title.</value>
        /*
        <example>Some titile.txt/ Some title</example>
        */
        [DataMember(Name = "title", EmitDefaultValue = true)]
        public string Title { get; set; }

        /// <summary>
        /// Specifies if the file entry is shared or not.
        /// </summary>
        /// <value>Specifies if the file entry is shared or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "shared", EmitDefaultValue = true)]
        public bool Shared { get; set; }

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
        <example>true</example>
        */
        [DataMember(Name = "providerItem", EmitDefaultValue = true)]
        public bool? ProviderItem { get; set; }

        /// <summary>
        /// The provider key of the file entry.
        /// </summary>
        /// <value>The provider key of the file entry.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "providerKey", EmitDefaultValue = true)]
        public string ProviderKey { get; set; }

        /// <summary>
        /// The provider ID of the file entry.
        /// </summary>
        /// <value>The provider ID of the file entry.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "providerId", EmitDefaultValue = true)]
        public int? ProviderId { get; set; }

        /// <summary>
        /// The order of the file entry.
        /// </summary>
        /// <value>The order of the file entry.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "order", EmitDefaultValue = true)]
        public string Order { get; set; }

        /// <summary>
        /// The file entry ID.
        /// </summary>
        /// <value>The file entry ID.</value>
        /*
        <example>10</example>
        */
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The root folder ID of the file entry.
        /// </summary>
        /// <value>The root folder ID of the file entry.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "rootFolderId", EmitDefaultValue = true)]
        public string RootFolderId { get; set; }

        /// <summary>
        /// The origin ID of the file entry.
        /// </summary>
        /// <value>The origin ID of the file entry.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "originId", EmitDefaultValue = true)]
        public string OriginId { get; set; }

        /// <summary>
        /// The origin room ID of the file entry.
        /// </summary>
        /// <value>The origin room ID of the file entry.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "originRoomId", EmitDefaultValue = true)]
        public string OriginRoomId { get; set; }

        /// <summary>
        /// The origin title of the file entry.
        /// </summary>
        /// <value>The origin title of the file entry.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "originTitle", EmitDefaultValue = true)]
        public string OriginTitle { get; set; }

        /// <summary>
        /// The origin room title of the file entry.
        /// </summary>
        /// <value>The origin room title of the file entry.</value>
        /*
        <example>some text</example>
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
        /// Gets or Sets Security
        /// </summary>
        [DataMember(Name = "security", EmitDefaultValue = true)]
        public FileDtoIntegerSecurity Security { get; set; }

        /// <summary>
        /// The request token of the file entry.
        /// </summary>
        /// <value>The request token of the file entry.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "requestToken", EmitDefaultValue = true)]
        public string RequestToken { get; set; }

        /// <summary>
        /// The parent folder ID of the folder.
        /// </summary>
        /// <value>The parent folder ID of the folder.</value>
        /*
        <example>10</example>
        */
        [DataMember(Name = "parentId", EmitDefaultValue = true)]
        public string ParentId { get; set; }

        /// <summary>
        /// The number of files that the folder contains.
        /// </summary>
        /// <value>The number of files that the folder contains.</value>
        /*
        <example>5</example>
        */
        [DataMember(Name = "filesCount", EmitDefaultValue = false)]
        public int FilesCount { get; set; }

        /// <summary>
        /// The number of folders that the folder contains.
        /// </summary>
        /// <value>The number of folders that the folder contains.</value>
        /*
        <example>7</example>
        */
        [DataMember(Name = "foldersCount", EmitDefaultValue = false)]
        public int FoldersCount { get; set; }

        /// <summary>
        /// Specifies if the folder can be shared or not.
        /// </summary>
        /// <value>Specifies if the folder can be shared or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isShareable", EmitDefaultValue = true)]
        public bool? IsShareable { get; set; }

        /// <summary>
        /// Specifies if the folder is favorite or not.
        /// </summary>
        /// <value>Specifies if the folder is favorite or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isFavorite", EmitDefaultValue = true)]
        public bool? IsFavorite { get; set; }

        /// <summary>
        /// The new element index in the folder.
        /// </summary>
        /// <value>The new element index in the folder.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "new", EmitDefaultValue = false)]
        public int New { get; set; }

        /// <summary>
        /// Specifies if the folder notifications are enabled or not.
        /// </summary>
        /// <value>Specifies if the folder notifications are enabled or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "mute", EmitDefaultValue = true)]
        public bool Mute { get; set; }

        /// <summary>
        /// The list of tags of the folder.
        /// </summary>
        /// <value>The list of tags of the folder.</value>
        /*
        <example>[&quot;some text&quot;]</example>
        */
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets Logo
        /// </summary>
        [DataMember(Name = "logo", EmitDefaultValue = false)]
        public Logo Logo { get; set; }

        /// <summary>
        /// Specifies if the folder is pinned or not.
        /// </summary>
        /// <value>Specifies if the folder is pinned or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "pinned", EmitDefaultValue = true)]
        public bool Pinned { get; set; }

        /// <summary>
        /// Specifies if the folder is private or not.
        /// </summary>
        /// <value>Specifies if the folder is private or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "private", EmitDefaultValue = true)]
        public bool Private { get; set; }

        /// <summary>
        /// Specifies if the folder is indexed or not.
        /// </summary>
        /// <value>Specifies if the folder is indexed or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "indexing", EmitDefaultValue = true)]
        public bool Indexing { get; set; }

        /// <summary>
        /// Specifies if the folder can be downloaded or not.
        /// </summary>
        /// <value>Specifies if the folder can be downloaded or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "denyDownload", EmitDefaultValue = true)]
        public bool DenyDownload { get; set; }

        /// <summary>
        /// Gets or Sets Lifetime
        /// </summary>
        [DataMember(Name = "lifetime", EmitDefaultValue = false)]
        public RoomDataLifetimeDto Lifetime { get; set; }

        /// <summary>
        /// Gets or Sets Watermark
        /// </summary>
        [DataMember(Name = "watermark", EmitDefaultValue = false)]
        public WatermarkDto Watermark { get; set; }

        /// <summary>
        /// Specifies if the folder is placed in the room or not.
        /// </summary>
        /// <value>Specifies if the folder is placed in the room or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "inRoom", EmitDefaultValue = true)]
        public bool? InRoom { get; set; }

        /// <summary>
        /// The folder quota limit.
        /// </summary>
        /// <value>The folder quota limit.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "quotaLimit", EmitDefaultValue = true)]
        public long? QuotaLimit { get; set; }

        /// <summary>
        /// Specifies if the folder room has a custom quota or not.
        /// </summary>
        /// <value>Specifies if the folder room has a custom quota or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "isCustomQuota", EmitDefaultValue = true)]
        public bool? IsCustomQuota { get; set; }

        /// <summary>
        /// How much folder space is used (counter).
        /// </summary>
        /// <value>How much folder space is used (counter).</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "usedSpace", EmitDefaultValue = true)]
        public long? UsedSpace { get; set; }

        /// <summary>
        /// Specifies if the folder can be accessed via an external link or not.
        /// </summary>
        /// <value>Specifies if the folder can be accessed via an external link or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "external", EmitDefaultValue = true)]
        public bool? External { get; set; }

        /// <summary>
        /// Specifies if the folder is password protected or not.
        /// </summary>
        /// <value>Specifies if the folder is password protected or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "passwordProtected", EmitDefaultValue = true)]
        public bool? PasswordProtected { get; set; }

        /// <summary>
        /// Specifies if an external link to the folder is expired or not.
        /// </summary>
        /// <value>Specifies if an external link to the folder is expired or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "expired", EmitDefaultValue = true)]
        public bool? Expired { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FolderDtoString {\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  Access: ").Append(Access).Append("\n");
            sb.Append("  Shared: ").Append(Shared).Append("\n");
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
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RootFolderId: ").Append(RootFolderId).Append("\n");
            sb.Append("  OriginId: ").Append(OriginId).Append("\n");
            sb.Append("  OriginRoomId: ").Append(OriginRoomId).Append("\n");
            sb.Append("  OriginTitle: ").Append(OriginTitle).Append("\n");
            sb.Append("  OriginRoomTitle: ").Append(OriginRoomTitle).Append("\n");
            sb.Append("  CanShare: ").Append(CanShare).Append("\n");
            sb.Append("  Security: ").Append(Security).Append("\n");
            sb.Append("  RequestToken: ").Append(RequestToken).Append("\n");
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  FilesCount: ").Append(FilesCount).Append("\n");
            sb.Append("  FoldersCount: ").Append(FoldersCount).Append("\n");
            sb.Append("  IsShareable: ").Append(IsShareable).Append("\n");
            sb.Append("  IsFavorite: ").Append(IsFavorite).Append("\n");
            sb.Append("  New: ").Append(New).Append("\n");
            sb.Append("  Mute: ").Append(Mute).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  Logo: ").Append(Logo).Append("\n");
            sb.Append("  Pinned: ").Append(Pinned).Append("\n");
            sb.Append("  RoomType: ").Append(RoomType).Append("\n");
            sb.Append("  Private: ").Append(Private).Append("\n");
            sb.Append("  Indexing: ").Append(Indexing).Append("\n");
            sb.Append("  DenyDownload: ").Append(DenyDownload).Append("\n");
            sb.Append("  Lifetime: ").Append(Lifetime).Append("\n");
            sb.Append("  Watermark: ").Append(Watermark).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  InRoom: ").Append(InRoom).Append("\n");
            sb.Append("  QuotaLimit: ").Append(QuotaLimit).Append("\n");
            sb.Append("  IsCustomQuota: ").Append(IsCustomQuota).Append("\n");
            sb.Append("  UsedSpace: ").Append(UsedSpace).Append("\n");
            sb.Append("  External: ").Append(External).Append("\n");
            sb.Append("  PasswordProtected: ").Append(PasswordProtected).Append("\n");
            sb.Append("  Expired: ").Append(Expired).Append("\n");
            sb.Append("  FileEntryType: ").Append(FileEntryType).Append("\n");
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
