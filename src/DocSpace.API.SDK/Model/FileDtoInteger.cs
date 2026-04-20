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
    /// The file parameters.
    /// </summary>
    [DataContract(Name = "FileDtoInteger")]
    public partial class FileDtoInteger : IValidatableObject
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
        /// Gets or Sets FileStatus
        /// </summary>
        [DataMember(Name = "fileStatus", EmitDefaultValue = false)]
        public FileStatus? FileStatus { get; set; }

        /// <summary>
        /// Gets or Sets FileType
        /// </summary>
        [DataMember(Name = "fileType", EmitDefaultValue = false)]
        public FileType? FileType { get; set; }

        /// <summary>
        /// Gets or Sets ThumbnailStatus
        /// </summary>
        [DataMember(Name = "thumbnailStatus", EmitDefaultValue = false)]
        public Thumbnail? ThumbnailStatus { get; set; }

        /// <summary>
        /// Gets or Sets FormFillingStatus
        /// </summary>
        [DataMember(Name = "formFillingStatus", EmitDefaultValue = false)]
        public FormFillingStatus? FormFillingStatus { get; set; }

        /// <summary>
        /// Gets or Sets FileEntryType
        /// </summary>
        [DataMember(Name = "fileEntryType", EmitDefaultValue = false)]
        public FileEntryType? FileEntryType { get; set; }

        /// <summary>
        /// Gets or Sets VectorizationStatus
        /// </summary>
        [DataMember(Name = "vectorizationStatus", EmitDefaultValue = false)]
        public VectorizationStatus? VectorizationStatus { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FileDtoInteger" /> class.
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
        /// <param name="folderId">The folder ID where the file is located..</param>
        /// <param name="version">The file version..</param>
        /// <param name="versionGroup">The version group of the file..</param>
        /// <param name="contentLength">The content length of the file..</param>
        /// <param name="pureContentLength">The pure content length of the file..</param>
        /// <param name="fileStatus">fileStatus.</param>
        /// <param name="editingBy">The list of users editing the file..</param>
        /// <param name="mute">Specifies if the file is muted or not..</param>
        /// <param name="viewUrl">The URL link to view the file..</param>
        /// <param name="webUrl">The Web URL link to the file..</param>
        /// <param name="fileType">fileType.</param>
        /// <param name="fileExst">The file extension..</param>
        /// <param name="comment">The comment to the file..</param>
        /// <param name="encrypted">Specifies if the file is encrypted or not..</param>
        /// <param name="thumbnailUrl">The thumbnail URL of the file..</param>
        /// <param name="thumbnailStatus">thumbnailStatus.</param>
        /// <param name="locked">Specifies if the file is locked or not..</param>
        /// <param name="lockedBy">The user ID of the person who locked the file..</param>
        /// <param name="hasDraft">Specifies if the file has a draft or not..</param>
        /// <param name="formFillingStatus">formFillingStatus.</param>
        /// <param name="isForm">Specifies if the file is a form or not..</param>
        /// <param name="customFilterEnabled">Specifies if the Custom Filter editing mode is enabled for a file or not..</param>
        /// <param name="customFilterEnabledBy">The name of the user who enabled a Custom Filter editing mode for a file..</param>
        /// <param name="startFilling">Specifies if the filling has started or not..</param>
        /// <param name="isFillingPreparing">Specifies if the form filling has started but the file is still being saved by the document editor. Filling and editing are not allowed..</param>
        /// <param name="inProcessFolderId">The InProcess folder ID of the file..</param>
        /// <param name="inProcessFolderTitle">The InProcess folder title of the file..</param>
        /// <param name="draftLocation">draftLocation.</param>
        /// <param name="viewAccessibility">viewAccessibility.</param>
        /// <param name="lastOpened">lastOpened.</param>
        /// <param name="expired">expired.</param>
        /// <param name="fileEntryType">fileEntryType.</param>
        /// <param name="vectorizationStatus">vectorizationStatus.</param>
        /// <param name="dimensions">dimensions.</param>
        public FileDtoInteger(string title = default, FileShare? access = default, EmployeeDto sharedBy = default, EmployeeDto ownedBy = default, bool shared = default, bool sharedForUser = default, bool parentShared = default, string shortWebUrl = default, ApiDateTime created = default, EmployeeDto createdBy = default, ApiDateTime updated = default, ApiDateTime autoDelete = default, FolderType? rootFolderType = default, FolderType? parentRoomType = default, EmployeeDto updatedBy = default, bool? providerItem = default, string providerKey = default, int? providerId = default, string order = default, bool? isFavorite = default, int id = default, int rootFolderId = default, int originId = default, int originRoomId = default, string originTitle = default, string originRoomTitle = default, bool canShare = default, FolderDtoIntegerShareSettings shareSettings = default, FolderDtoIntegerSecurity security = default, FolderDtoIntegerAvailableShareRights availableShareRights = default, string requestToken = default, bool? external = default, ApiDateTime expirationDate = default, bool? isLinkExpired = default, int folderId = default, int version = default, int versionGroup = default, string contentLength = default, long? pureContentLength = default, FileStatus? fileStatus = default, Dictionary<string, string> editingBy = default, bool mute = default, string viewUrl = default, string webUrl = default, FileType? fileType = default, string fileExst = default, string comment = default, bool? encrypted = default, string thumbnailUrl = default, Thumbnail? thumbnailStatus = default, bool? locked = default, string lockedBy = default, bool? hasDraft = default, FormFillingStatus? formFillingStatus = default, bool? isForm = default, bool? customFilterEnabled = default, string customFilterEnabledBy = default, bool? startFilling = default, bool? isFillingPreparing = default, int? inProcessFolderId = default, string inProcessFolderTitle = default, DraftLocationInteger draftLocation = default, FileDtoIntegerViewAccessibility viewAccessibility = default, ApiDateTime lastOpened = default, ApiDateTime expired = default, FileEntryType? fileEntryType = default, VectorizationStatus? vectorizationStatus = default, Size dimensions = default)
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
            this.FolderId = folderId;
            this.@Version = version;
            this.VersionGroup = versionGroup;
            this.ContentLength = contentLength;
            this.PureContentLength = pureContentLength;
            this.FileStatus = fileStatus;
            this.EditingBy = editingBy;
            this.Mute = mute;
            this.ViewUrl = viewUrl;
            this.WebUrl = webUrl;
            this.FileType = fileType;
            this.FileExst = fileExst;
            this.Comment = comment;
            this.Encrypted = encrypted;
            this.ThumbnailUrl = thumbnailUrl;
            this.ThumbnailStatus = thumbnailStatus;
            this.Locked = locked;
            this.LockedBy = lockedBy;
            this.HasDraft = hasDraft;
            this.FormFillingStatus = formFillingStatus;
            this.IsForm = isForm;
            this.CustomFilterEnabled = customFilterEnabled;
            this.CustomFilterEnabledBy = customFilterEnabledBy;
            this.StartFilling = startFilling;
            this.IsFillingPreparing = isFillingPreparing;
            this.InProcessFolderId = inProcessFolderId;
            this.InProcessFolderTitle = inProcessFolderTitle;
            this.DraftLocation = draftLocation;
            this.ViewAccessibility = viewAccessibility;
            this.LastOpened = lastOpened;
            this.Expired = expired;
            this.FileEntryType = fileEntryType;
            this.VectorizationStatus = vectorizationStatus;
            this.Dimensions = dimensions;
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
        /// The folder ID where the file is located.
        /// </summary>
        /// <value>The folder ID where the file is located.</value>
        /*
        <example>10</example>
        */
        [DataMember(Name = "folderId", EmitDefaultValue = false)]
        public int FolderId { get; set; }

        /// <summary>
        /// The file version.
        /// </summary>
        /// <value>The file version.</value>
        /*
        <example>3</example>
        */
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int @Version { get; set; }

        /// <summary>
        /// The version group of the file.
        /// </summary>
        /// <value>The version group of the file.</value>
        /*
        <example>1</example>
        */
        [DataMember(Name = "versionGroup", EmitDefaultValue = false)]
        public int VersionGroup { get; set; }

        /// <summary>
        /// The content length of the file.
        /// </summary>
        /// <value>The content length of the file.</value>
        /*
        <example>12345</example>
        */
        [DataMember(Name = "contentLength", EmitDefaultValue = true)]
        public string ContentLength { get; set; }

        /// <summary>
        /// The pure content length of the file.
        /// </summary>
        /// <value>The pure content length of the file.</value>
        /*
        <example>12345</example>
        */
        [DataMember(Name = "pureContentLength", EmitDefaultValue = true)]
        public long? PureContentLength { get; set; }

        /// <summary>
        /// The list of users editing the file.
        /// </summary>
        /// <value>The list of users editing the file.</value>
        /*
        <example>{"00000000-0000-0000-0000-000000000000":"John Doe"}</example>
        */
        [DataMember(Name = "editingBy", EmitDefaultValue = true)]
        public Dictionary<string, string> EditingBy { get; set; }

        /// <summary>
        /// Specifies if the file is muted or not.
        /// </summary>
        /// <value>Specifies if the file is muted or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "mute", EmitDefaultValue = true)]
        public bool Mute { get; set; }

        /// <summary>
        /// The URL link to view the file.
        /// </summary>
        /// <value>The URL link to view the file.</value>
        /*
        <example>https://www.onlyoffice.com/viewfile?fileid=2221</example>
        */
        [DataMember(Name = "viewUrl", EmitDefaultValue = true)]
        public string ViewUrl { get; set; }

        /// <summary>
        /// The Web URL link to the file.
        /// </summary>
        /// <value>The Web URL link to the file.</value>
        /*
        <example>http://localhost/files/document.docx</example>
        */
        [DataMember(Name = "webUrl", EmitDefaultValue = true)]
        public string WebUrl { get; set; }

        /// <summary>
        /// The file extension.
        /// </summary>
        /// <value>The file extension.</value>
        /*
        <example>.txt</example>
        */
        [DataMember(Name = "fileExst", EmitDefaultValue = true)]
        public string FileExst { get; set; }

        /// <summary>
        /// The comment to the file.
        /// </summary>
        /// <value>The comment to the file.</value>
        /*
        <example>This is a comment</example>
        */
        [DataMember(Name = "comment", EmitDefaultValue = true)]
        public string Comment { get; set; }

        /// <summary>
        /// Specifies if the file is encrypted or not.
        /// </summary>
        /// <value>Specifies if the file is encrypted or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "encrypted", EmitDefaultValue = true)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// The thumbnail URL of the file.
        /// </summary>
        /// <value>The thumbnail URL of the file.</value>
        /*
        <example>http://localhost/thumbnails/file.png</example>
        */
        [DataMember(Name = "thumbnailUrl", EmitDefaultValue = true)]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// Specifies if the file is locked or not.
        /// </summary>
        /// <value>Specifies if the file is locked or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "locked", EmitDefaultValue = true)]
        public bool? Locked { get; set; }

        /// <summary>
        /// The user ID of the person who locked the file.
        /// </summary>
        /// <value>The user ID of the person who locked the file.</value>
        /*
        <example>00000000-0000-0000-0000-000000000000</example>
        */
        [DataMember(Name = "lockedBy", EmitDefaultValue = true)]
        public string LockedBy { get; set; }

        /// <summary>
        /// Specifies if the file has a draft or not.
        /// </summary>
        /// <value>Specifies if the file has a draft or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "hasDraft", EmitDefaultValue = true)]
        public bool? HasDraft { get; set; }

        /// <summary>
        /// Specifies if the file is a form or not.
        /// </summary>
        /// <value>Specifies if the file is a form or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "isForm", EmitDefaultValue = true)]
        public bool? IsForm { get; set; }

        /// <summary>
        /// Specifies if the Custom Filter editing mode is enabled for a file or not.
        /// </summary>
        /// <value>Specifies if the Custom Filter editing mode is enabled for a file or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "customFilterEnabled", EmitDefaultValue = true)]
        public bool? CustomFilterEnabled { get; set; }

        /// <summary>
        /// The name of the user who enabled a Custom Filter editing mode for a file.
        /// </summary>
        /// <value>The name of the user who enabled a Custom Filter editing mode for a file.</value>
        /*
        <example>John Doe</example>
        */
        [DataMember(Name = "customFilterEnabledBy", EmitDefaultValue = true)]
        public string CustomFilterEnabledBy { get; set; }

        /// <summary>
        /// Specifies if the filling has started or not.
        /// </summary>
        /// <value>Specifies if the filling has started or not.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "startFilling", EmitDefaultValue = true)]
        public bool? StartFilling { get; set; }

        /// <summary>
        /// Specifies if the form filling has started but the file is still being saved by the document editor. Filling and editing are not allowed.
        /// </summary>
        /// <value>Specifies if the form filling has started but the file is still being saved by the document editor. Filling and editing are not allowed.</value>
        /*
        <example>false</example>
        */
        [DataMember(Name = "isFillingPreparing", EmitDefaultValue = true)]
        public bool? IsFillingPreparing { get; set; }

        /// <summary>
        /// The InProcess folder ID of the file.
        /// </summary>
        /// <value>The InProcess folder ID of the file.</value>
        /*
        <example>10</example>
        */
        [DataMember(Name = "inProcessFolderId", EmitDefaultValue = true)]
        public int? InProcessFolderId { get; set; }

        /// <summary>
        /// The InProcess folder title of the file.
        /// </summary>
        /// <value>The InProcess folder title of the file.</value>
        /*
        <example>In Process</example>
        */
        [DataMember(Name = "inProcessFolderTitle", EmitDefaultValue = true)]
        public string InProcessFolderTitle { get; set; }

        /// <summary>
        /// Gets or Sets DraftLocation
        /// </summary>
        [DataMember(Name = "draftLocation", EmitDefaultValue = false)]
        public DraftLocationInteger DraftLocation { get; set; }

        /// <summary>
        /// Gets or Sets ViewAccessibility
        /// </summary>
        [DataMember(Name = "viewAccessibility", EmitDefaultValue = true)]
        public FileDtoIntegerViewAccessibility ViewAccessibility { get; set; }

        /// <summary>
        /// Gets or Sets LastOpened
        /// </summary>
        [DataMember(Name = "lastOpened", EmitDefaultValue = false)]
        public ApiDateTime LastOpened { get; set; }

        /// <summary>
        /// Gets or Sets Expired
        /// </summary>
        [DataMember(Name = "expired", EmitDefaultValue = false)]
        public ApiDateTime Expired { get; set; }

        /// <summary>
        /// Gets or Sets Dimensions
        /// </summary>
        [DataMember(Name = "dimensions", EmitDefaultValue = false)]
        public Size Dimensions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FileDtoInteger {\n");
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
            sb.Append("  FolderId: ").Append(FolderId).Append("\n");
            sb.Append("  @Version: ").Append(@Version).Append("\n");
            sb.Append("  VersionGroup: ").Append(VersionGroup).Append("\n");
            sb.Append("  ContentLength: ").Append(ContentLength).Append("\n");
            sb.Append("  PureContentLength: ").Append(PureContentLength).Append("\n");
            sb.Append("  FileStatus: ").Append(FileStatus).Append("\n");
            sb.Append("  EditingBy: ").Append(EditingBy).Append("\n");
            sb.Append("  Mute: ").Append(Mute).Append("\n");
            sb.Append("  ViewUrl: ").Append(ViewUrl).Append("\n");
            sb.Append("  WebUrl: ").Append(WebUrl).Append("\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
            sb.Append("  FileExst: ").Append(FileExst).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  Encrypted: ").Append(Encrypted).Append("\n");
            sb.Append("  ThumbnailUrl: ").Append(ThumbnailUrl).Append("\n");
            sb.Append("  ThumbnailStatus: ").Append(ThumbnailStatus).Append("\n");
            sb.Append("  Locked: ").Append(Locked).Append("\n");
            sb.Append("  LockedBy: ").Append(LockedBy).Append("\n");
            sb.Append("  HasDraft: ").Append(HasDraft).Append("\n");
            sb.Append("  FormFillingStatus: ").Append(FormFillingStatus).Append("\n");
            sb.Append("  IsForm: ").Append(IsForm).Append("\n");
            sb.Append("  CustomFilterEnabled: ").Append(CustomFilterEnabled).Append("\n");
            sb.Append("  CustomFilterEnabledBy: ").Append(CustomFilterEnabledBy).Append("\n");
            sb.Append("  StartFilling: ").Append(StartFilling).Append("\n");
            sb.Append("  IsFillingPreparing: ").Append(IsFillingPreparing).Append("\n");
            sb.Append("  InProcessFolderId: ").Append(InProcessFolderId).Append("\n");
            sb.Append("  InProcessFolderTitle: ").Append(InProcessFolderTitle).Append("\n");
            sb.Append("  DraftLocation: ").Append(DraftLocation).Append("\n");
            sb.Append("  ViewAccessibility: ").Append(ViewAccessibility).Append("\n");
            sb.Append("  LastOpened: ").Append(LastOpened).Append("\n");
            sb.Append("  Expired: ").Append(Expired).Append("\n");
            sb.Append("  FileEntryType: ").Append(FileEntryType).Append("\n");
            sb.Append("  VectorizationStatus: ").Append(VectorizationStatus).Append("\n");
            sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
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
