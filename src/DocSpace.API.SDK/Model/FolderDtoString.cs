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
        /// Gets or Sets RootRoomType
        /// </summary>
        [DataMember(Name = "rootRoomType", EmitDefaultValue = false)]
        public RoomType? RootRoomType { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FolderDtoString" /> class.
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
        /// <param name="parentId">The parent folder ID of the folder..</param>
        /// <param name="filesCount">The number of files that the folder contains..</param>
        /// <param name="foldersCount">The number of folders that the folder contains..</param>
        /// <param name="isShareable">Specifies if the folder can be shared or not..</param>
        /// <param name="@new">The new element index in the folder..</param>
        /// <param name="mute">Specifies if the folder notifications are enabled or not..</param>
        /// <param name="tags">The list of tags of the folder..</param>
        /// <param name="logo">logo.</param>
        /// <param name="pinned">Specifies if the folder is pinned or not..</param>
        /// <param name="roomType">roomType.</param>
        /// <param name="@private">Specifies if the folder is private or not..</param>
        /// <param name="indexing">Specifies if the folder is indexed or not..</param>
        /// <param name="denyDownload">Specifies if the folder can be downloaded or not..</param>
        /// <param name="lifetime">lifetime.</param>
        /// <param name="watermark">watermark.</param>
        /// <param name="type">type.</param>
        /// <param name="inRoom">Specifies if the folder is placed in the room or not..</param>
        /// <param name="quotaLimit">The folder quota limit..</param>
        /// <param name="isCustomQuota">Specifies if the folder room has a custom quota or not..</param>
        /// <param name="usedSpace">How much folder space is used (counter)..</param>
        /// <param name="passwordProtected">Specifies if the folder is password protected or not..</param>
        /// <param name="expired">Specifies if an external link to the folder is expired or not..</param>
        /// <param name="fileEntryType">fileEntryType.</param>
        /// <param name="chatSettings">chatSettings.</param>
        /// <param name="rootRoomType">rootRoomType.</param>
        /// <param name="saveFormAsXLSX">Specifies whether to save form data as XLSX file..</param>
        /// <param name="sendFormToExternalDB">Specifies whether to send form data to external database..</param>
        public FolderDtoString(string title = default, FileShare? access = default, EmployeeDto sharedBy = default, EmployeeDto ownedBy = default, bool shared = default, bool sharedForUser = default, bool parentShared = default, string shortWebUrl = default, ApiDateTime created = default, EmployeeDto createdBy = default, ApiDateTime updated = default, ApiDateTime autoDelete = default, FolderType? rootFolderType = default, FolderType? parentRoomType = default, EmployeeDto updatedBy = default, bool? providerItem = default, string providerKey = default, int? providerId = default, string order = default, bool? isFavorite = default, string id = default, string rootFolderId = default, string originId = default, string originRoomId = default, string originTitle = default, string originRoomTitle = default, bool canShare = default, FolderDtoIntegerShareSettings shareSettings = default, FolderDtoIntegerSecurity security = default, FolderDtoIntegerAvailableShareRights availableShareRights = default, string requestToken = default, bool? external = default, ApiDateTime expirationDate = default, bool? isLinkExpired = default, string parentId = default, int filesCount = default, int foldersCount = default, bool? isShareable = default, int @new = default, bool mute = default, List<string> tags = default, Logo logo = default, bool pinned = default, RoomType? roomType = default, bool @private = default, bool indexing = default, bool denyDownload = default, RoomDataLifetimeDto lifetime = default, WatermarkDto watermark = default, FolderType? type = default, bool? inRoom = default, long? quotaLimit = default, bool? isCustomQuota = default, long? usedSpace = default, bool? passwordProtected = default, bool? expired = default, FileEntryType? fileEntryType = default, ChatSettingsDto chatSettings = default, RoomType? rootRoomType = default, bool? saveFormAsXLSX = default, bool? sendFormToExternalDB = default)
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
            this.ParentId = parentId;
            this.FilesCount = filesCount;
            this.FoldersCount = foldersCount;
            this.IsShareable = isShareable;
            this.New = @new;
            this.Mute = mute;
            this.Tags = tags;
            this.Logo = logo;
            this.Pinned = pinned;
            this.RoomType = roomType;
            this.Private = @private;
            this.Indexing = indexing;
            this.DenyDownload = denyDownload;
            this.Lifetime = lifetime;
            this.Watermark = watermark;
            this.Type = type;
            this.InRoom = inRoom;
            this.QuotaLimit = quotaLimit;
            this.IsCustomQuota = isCustomQuota;
            this.UsedSpace = usedSpace;
            this.PasswordProtected = passwordProtected;
            this.Expired = expired;
            this.FileEntryType = fileEntryType;
            this.ChatSettings = chatSettings;
            this.RootRoomType = rootRoomType;
            this.SaveFormAsXLSX = saveFormAsXLSX;
            this.SendFormToExternalDB = sendFormToExternalDB;
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
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// The root folder ID of the file entry.
        /// </summary>
        /// <value>The root folder ID of the file entry.</value>
        /*
        <example>1</example>
        */
        [DataMember(Name = "rootFolderId", EmitDefaultValue = true)]
        public string RootFolderId { get; set; }

        /// <summary>
        /// The origin ID of the file entry.
        /// </summary>
        /// <value>The origin ID of the file entry.</value>
        /*
        <example>12</example>
        */
        [DataMember(Name = "originId", EmitDefaultValue = true)]
        public string OriginId { get; set; }

        /// <summary>
        /// The origin room ID of the file entry.
        /// </summary>
        /// <value>The origin room ID of the file entry.</value>
        /*
        <example>22</example>
        */
        [DataMember(Name = "originRoomId", EmitDefaultValue = true)]
        public string OriginRoomId { get; set; }

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
        /// The new element index in the folder.
        /// </summary>
        /// <value>The new element index in the folder.</value>
        /*
        <example>0</example>
        */
        [DataMember(Name = "new", EmitDefaultValue = false)]
        public int New { get; set; }

        /// <summary>
        /// Specifies if the folder notifications are enabled or not.
        /// </summary>
        /// <value>Specifies if the folder notifications are enabled or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "mute", EmitDefaultValue = true)]
        public bool Mute { get; set; }

        /// <summary>
        /// The list of tags of the folder.
        /// </summary>
        /// <value>The list of tags of the folder.</value>
        /*
        <example>["tag1","tag2"]</example>
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
        <example>false</example>
        */
        [DataMember(Name = "pinned", EmitDefaultValue = true)]
        public bool Pinned { get; set; }

        /// <summary>
        /// Specifies if the folder is private or not.
        /// </summary>
        /// <value>Specifies if the folder is private or not.</value>
        /*
        <example>false</example>
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
        <example>false</example>
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
        <example>false</example>
        */
        [DataMember(Name = "inRoom", EmitDefaultValue = true)]
        public bool? InRoom { get; set; }

        /// <summary>
        /// The folder quota limit.
        /// </summary>
        /// <value>The folder quota limit.</value>
        /*
        <example>1073741824</example>
        */
        [DataMember(Name = "quotaLimit", EmitDefaultValue = true)]
        public long? QuotaLimit { get; set; }

        /// <summary>
        /// Specifies if the folder room has a custom quota or not.
        /// </summary>
        /// <value>Specifies if the folder room has a custom quota or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "isCustomQuota", EmitDefaultValue = true)]
        public bool? IsCustomQuota { get; set; }

        /// <summary>
        /// How much folder space is used (counter).
        /// </summary>
        /// <value>How much folder space is used (counter).</value>
        /*
        <example>524288000</example>
        */
        [DataMember(Name = "usedSpace", EmitDefaultValue = true)]
        public long? UsedSpace { get; set; }

        /// <summary>
        /// Specifies if the folder is password protected or not.
        /// </summary>
        /// <value>Specifies if the folder is password protected or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "passwordProtected", EmitDefaultValue = true)]
        public bool? PasswordProtected { get; set; }

        /// <summary>
        /// Specifies if an external link to the folder is expired or not.
        /// </summary>
        /// <value>Specifies if an external link to the folder is expired or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "expired", EmitDefaultValue = true)]
        [Obsolete]
        public bool? Expired { get; set; }

        /// <summary>
        /// Gets or Sets ChatSettings
        /// </summary>
        [DataMember(Name = "chatSettings", EmitDefaultValue = false)]
        public ChatSettingsDto ChatSettings { get; set; }

        /// <summary>
        /// Specifies whether to save form data as XLSX file.
        /// </summary>
        /// <value>Specifies whether to save form data as XLSX file.</value>
        [DataMember(Name = "saveFormAsXLSX", EmitDefaultValue = true)]
        public bool? SaveFormAsXLSX { get; set; }

        /// <summary>
        /// Specifies whether to send form data to external database.
        /// </summary>
        /// <value>Specifies whether to send form data to external database.</value>
        [DataMember(Name = "sendFormToExternalDB", EmitDefaultValue = true)]
        public bool? SendFormToExternalDB { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FolderDtoString {\n");
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
            sb.Append("  ParentId: ").Append(ParentId).Append("\n");
            sb.Append("  FilesCount: ").Append(FilesCount).Append("\n");
            sb.Append("  FoldersCount: ").Append(FoldersCount).Append("\n");
            sb.Append("  IsShareable: ").Append(IsShareable).Append("\n");
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
            sb.Append("  PasswordProtected: ").Append(PasswordProtected).Append("\n");
            sb.Append("  Expired: ").Append(Expired).Append("\n");
            sb.Append("  FileEntryType: ").Append(FileEntryType).Append("\n");
            sb.Append("  ChatSettings: ").Append(ChatSettings).Append("\n");
            sb.Append("  RootRoomType: ").Append(RootRoomType).Append("\n");
            sb.Append("  SaveFormAsXLSX: ").Append(SaveFormAsXLSX).Append("\n");
            sb.Append("  SendFormToExternalDB: ").Append(SendFormToExternalDB).Append("\n");
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
