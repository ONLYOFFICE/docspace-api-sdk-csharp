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
        /// Initializes a new instance of the <see cref="FileDtoInteger" /> class.
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
        /// <param name="folderId">The folder ID where the file is located..</param>
        /// <param name="varVersion">The file version..</param>
        /// <param name="versionGroup">The version group of the file..</param>
        /// <param name="contentLength">The content length of the file..</param>
        /// <param name="pureContentLength">The pure content length of the file..</param>
        /// <param name="fileStatus">fileStatus.</param>
        /// <param name="mute">Specifies if the file is muted or not..</param>
        /// <param name="viewUrl">The URL link to view the file..</param>
        /// <param name="webUrl">The Web URL link to the file..</param>
        /// <param name="shortWebUrl">The short Web URL..</param>
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
        /// <param name="inProcessFolderId">The InProcess folder ID of the file..</param>
        /// <param name="inProcessFolderTitle">The InProcess folder title of the file..</param>
        /// <param name="draftLocation">draftLocation.</param>
        /// <param name="viewAccessibility">viewAccessibility.</param>
        /// <param name="availableExternalRights">The available external rights of the file..</param>
        /// <param name="lastOpened">lastOpened.</param>
        /// <param name="expired">expired.</param>
        /// <param name="fileEntryType">fileEntryType.</param>
        public FileDtoInteger(string title = default, FileShare? access = default, bool shared = default, ApiDateTime created = default, EmployeeDto createdBy = default, ApiDateTime updated = default, ApiDateTime autoDelete = default, FolderType? rootFolderType = default, FolderType? parentRoomType = default, EmployeeDto updatedBy = default, bool? providerItem = default, string providerKey = default, int? providerId = default, string order = default, int id = default, int rootFolderId = default, int originId = default, int originRoomId = default, string originTitle = default, string originRoomTitle = default, bool canShare = default, FileDtoIntegerSecurity security = default, string requestToken = default, int folderId = default, int varVersion = default, int versionGroup = default, string contentLength = default, long? pureContentLength = default, FileStatus? fileStatus = default, bool mute = default, string viewUrl = default, string webUrl = default, string shortWebUrl = default, FileType? fileType = default, string fileExst = default, string comment = default, bool? encrypted = default, string thumbnailUrl = default, Thumbnail? thumbnailStatus = default, bool? locked = default, string lockedBy = default, bool? hasDraft = default, FormFillingStatus? formFillingStatus = default, bool? isForm = default, bool? customFilterEnabled = default, string customFilterEnabledBy = default, bool? startFilling = default, int? inProcessFolderId = default, string inProcessFolderTitle = default, DraftLocationInteger draftLocation = default, FileDtoIntegerViewAccessibility viewAccessibility = default, Dictionary<string, bool> availableExternalRights = default, ApiDateTime lastOpened = default, ApiDateTime expired = default, FileEntryType? fileEntryType = default)
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
            this.FolderId = folderId;
            this.VarVersion = varVersion;
            this.VersionGroup = versionGroup;
            this.ContentLength = contentLength;
            this.PureContentLength = pureContentLength;
            this.FileStatus = fileStatus;
            this.Mute = mute;
            this.ViewUrl = viewUrl;
            this.WebUrl = webUrl;
            this.ShortWebUrl = shortWebUrl;
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
            this.InProcessFolderId = inProcessFolderId;
            this.InProcessFolderTitle = inProcessFolderTitle;
            this.DraftLocation = draftLocation;
            this.ViewAccessibility = viewAccessibility;
            this.AvailableExternalRights = availableExternalRights;
            this.LastOpened = lastOpened;
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
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// The root folder ID of the file entry.
        /// </summary>
        /// <value>The root folder ID of the file entry.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "rootFolderId", EmitDefaultValue = false)]
        public int RootFolderId { get; set; }

        /// <summary>
        /// The origin ID of the file entry.
        /// </summary>
        /// <value>The origin ID of the file entry.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "originId", EmitDefaultValue = false)]
        public int OriginId { get; set; }

        /// <summary>
        /// The origin room ID of the file entry.
        /// </summary>
        /// <value>The origin room ID of the file entry.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "originRoomId", EmitDefaultValue = false)]
        public int OriginRoomId { get; set; }

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
        /// The folder ID where the file is located.
        /// </summary>
        /// <value>The folder ID where the file is located.</value>
        /*
        <example>9846</example>
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
        public int VarVersion { get; set; }

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
        <example>1234</example>
        */
        [DataMember(Name = "pureContentLength", EmitDefaultValue = true)]
        public long? PureContentLength { get; set; }

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
        <example>https://www.onlyoffice.com/viewfile?fileid&#x3D;2221</example>
        */
        [DataMember(Name = "viewUrl", EmitDefaultValue = true)]
        public string ViewUrl { get; set; }

        /// <summary>
        /// The Web URL link to the file.
        /// </summary>
        /// <value>The Web URL link to the file.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "webUrl", EmitDefaultValue = true)]
        public string WebUrl { get; set; }

        /// <summary>
        /// The short Web URL.
        /// </summary>
        /// <value>The short Web URL.</value>
        /*
        <example>some text</example>
        */
        [DataMember(Name = "shortWebUrl", EmitDefaultValue = true)]
        public string ShortWebUrl { get; set; }

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
        <example>some text</example>
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
        <example>some text</example>
        */
        [DataMember(Name = "thumbnailUrl", EmitDefaultValue = true)]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// Specifies if the file is locked or not.
        /// </summary>
        /// <value>Specifies if the file is locked or not.</value>
        /*
        <example>true</example>
        */
        [DataMember(Name = "locked", EmitDefaultValue = true)]
        public bool? Locked { get; set; }

        /// <summary>
        /// The user ID of the person who locked the file.
        /// </summary>
        /// <value>The user ID of the person who locked the file.</value>
        /*
        <example>some text</example>
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
        <example>true</example>
        */
        [DataMember(Name = "customFilterEnabled", EmitDefaultValue = true)]
        public bool? CustomFilterEnabled { get; set; }

        /// <summary>
        /// The name of the user who enabled a Custom Filter editing mode for a file.
        /// </summary>
        /// <value>The name of the user who enabled a Custom Filter editing mode for a file.</value>
        /*
        <example>some text</example>
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
        /// The InProcess folder ID of the file.
        /// </summary>
        /// <value>The InProcess folder ID of the file.</value>
        /*
        <example>1234</example>
        */
        [DataMember(Name = "inProcessFolderId", EmitDefaultValue = true)]
        public int? InProcessFolderId { get; set; }

        /// <summary>
        /// The InProcess folder title of the file.
        /// </summary>
        /// <value>The InProcess folder title of the file.</value>
        /*
        <example>some text</example>
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
        /// The available external rights of the file.
        /// </summary>
        /// <value>The available external rights of the file.</value>
        /*
        <example>[{&quot;key&quot;:&quot;some text&quot;,&quot;value&quot;:true}]</example>
        */
        [DataMember(Name = "availableExternalRights", EmitDefaultValue = true)]
        public Dictionary<string, bool> AvailableExternalRights { get; set; }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FileDtoInteger {\n");
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
            sb.Append("  FolderId: ").Append(FolderId).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  VersionGroup: ").Append(VersionGroup).Append("\n");
            sb.Append("  ContentLength: ").Append(ContentLength).Append("\n");
            sb.Append("  PureContentLength: ").Append(PureContentLength).Append("\n");
            sb.Append("  FileStatus: ").Append(FileStatus).Append("\n");
            sb.Append("  Mute: ").Append(Mute).Append("\n");
            sb.Append("  ViewUrl: ").Append(ViewUrl).Append("\n");
            sb.Append("  WebUrl: ").Append(WebUrl).Append("\n");
            sb.Append("  ShortWebUrl: ").Append(ShortWebUrl).Append("\n");
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
            sb.Append("  InProcessFolderId: ").Append(InProcessFolderId).Append("\n");
            sb.Append("  InProcessFolderTitle: ").Append(InProcessFolderTitle).Append("\n");
            sb.Append("  DraftLocation: ").Append(DraftLocation).Append("\n");
            sb.Append("  ViewAccessibility: ").Append(ViewAccessibility).Append("\n");
            sb.Append("  AvailableExternalRights: ").Append(AvailableExternalRights).Append("\n");
            sb.Append("  LastOpened: ").Append(LastOpened).Append("\n");
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
