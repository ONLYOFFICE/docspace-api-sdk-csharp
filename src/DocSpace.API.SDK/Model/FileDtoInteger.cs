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
    public partial class FileDtoInteger : FileEntryDtoInteger, IValidatableObject
    {

        /// <summary>
        /// The current status of the file.
        /// </summary>
        [DataMember(Name = "fileStatus", EmitDefaultValue = false)]
        public FileStatus? FileStatus { get; set; }

        /// <summary>
        /// The file type.
        /// </summary>
        [DataMember(Name = "fileType", EmitDefaultValue = false)]
        public FileType? FileType { get; set; }

        /// <summary>
        /// The current thumbnail status of the file.
        /// </summary>
        [DataMember(Name = "thumbnailStatus", EmitDefaultValue = false)]
        public Thumbnail? ThumbnailStatus { get; set; }

        /// <summary>
        /// The status of the form filling process.
        /// </summary>
        [DataMember(Name = "formFillingStatus", EmitDefaultValue = false)]
        public FormFillingStatus? FormFillingStatus { get; set; }

        /// <summary>
        /// The vectorization status of the file.
        /// </summary>
        [DataMember(Name = "vectorizationStatus", EmitDefaultValue = false)]
        public VectorizationStatus? VectorizationStatus { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FileDtoInteger" /> class.
        /// </summary>
        /// <param name="folderId">The folder ID where the file is located..</param>
        /// <param name="version">The file version..</param>
        /// <param name="versionGroup">The version group of the file..</param>
        /// <param name="contentLength">The content length of the file..</param>
        /// <param name="pureContentLength">The pure content length of the file..</param>
        /// <param name="fileStatus">The current status of the file..</param>
        /// <param name="editingBy">The list of users editing the file..</param>
        /// <param name="mute">Specifies if the file is muted or not..</param>
        /// <param name="viewUrl">The URL link to view the file..</param>
        /// <param name="webUrl">The Web URL link to the file..</param>
        /// <param name="fileType">The file type..</param>
        /// <param name="fileExst">The file extension..</param>
        /// <param name="comment">The comment to the file..</param>
        /// <param name="encrypted">Specifies if the file is encrypted or not..</param>
        /// <param name="thumbnailUrl">The thumbnail URL of the file..</param>
        /// <param name="thumbnailStatus">The current thumbnail status of the file..</param>
        /// <param name="locked">Specifies if the file is locked or not..</param>
        /// <param name="lockedBy">The user ID of the person who locked the file..</param>
        /// <param name="hasDraft">Specifies if the file has a draft or not..</param>
        /// <param name="formFillingStatus">The status of the form filling process..</param>
        /// <param name="isForm">Specifies if the file is a form or not..</param>
        /// <param name="customFilterEnabled">Specifies if the Custom Filter editing mode is enabled for a file or not..</param>
        /// <param name="customFilterEnabledBy">The name of the user who enabled a Custom Filter editing mode for a file..</param>
        /// <param name="startFilling">Specifies if the filling has started or not..</param>
        /// <param name="isFillingPreparing">Specifies if the form filling has started but the file is still being saved by the document editor. Filling and editing are not allowed..</param>
        /// <param name="inProcessFolderId">The InProcess folder ID of the file..</param>
        /// <param name="inProcessFolderTitle">The InProcess folder title of the file..</param>
        /// <param name="resultsFolderId">The ID of the FormFillingFolderDone folder that corresponds to this original form..</param>
        /// <param name="draftLocation">The file draft information with its location..</param>
        /// <param name="viewAccessibility">viewAccessibility.</param>
        /// <param name="lastOpened">The time when the file was last opened..</param>
        /// <param name="expired">The date when the file will be expired..</param>
        /// <param name="vectorizationStatus">The vectorization status of the file..</param>
        /// <param name="externalDbTableName">The name of the table in the external database that corresponds to this form..</param>
        /// <param name="dimensions">Represents dimensions with width and height values..</param>
        public FileDtoInteger(int folderId = default, int version = default, int versionGroup = default, string contentLength = default, long? pureContentLength = default, FileStatus? fileStatus = default, Dictionary<string, string> editingBy = default, bool mute = default, string viewUrl = default, string webUrl = default, FileType? fileType = default, string fileExst = default, string comment = default, bool? encrypted = default, string thumbnailUrl = default, Thumbnail? thumbnailStatus = default, bool? locked = default, string lockedBy = default, bool? hasDraft = default, FormFillingStatus? formFillingStatus = default, bool? isForm = default, bool? customFilterEnabled = default, string customFilterEnabledBy = default, bool? startFilling = default, bool? isFillingPreparing = default, int? inProcessFolderId = default, string inProcessFolderTitle = default, int? resultsFolderId = default, DraftLocationInteger draftLocation = default, FileDtoIntegerAllOfViewAccessibility viewAccessibility = default, ApiDateTime lastOpened = default, ApiDateTime expired = default, VectorizationStatus? vectorizationStatus = default, string externalDbTableName = default, Size dimensions = default)
        {
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
            this.ResultsFolderId = resultsFolderId;
            this.DraftLocation = draftLocation;
            this.ViewAccessibility = viewAccessibility;
            this.LastOpened = lastOpened;
            this.Expired = expired;
            this.VectorizationStatus = vectorizationStatus;
            this.ExternalDbTableName = externalDbTableName;
            this.Dimensions = dimensions;
        }

        /// <summary>
        /// The folder ID where the file is located.
        /// </summary>
        /// <example>10</example>
        [DataMember(Name = "folderId", EmitDefaultValue = false)]
        public int FolderId { get; set; }

        /// <summary>
        /// The file version.
        /// </summary>
        /// <example>3</example>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int @Version { get; set; }

        /// <summary>
        /// The version group of the file.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "versionGroup", EmitDefaultValue = false)]
        public int VersionGroup { get; set; }

        /// <summary>
        /// The content length of the file.
        /// </summary>
        /// <example>12345</example>
        [DataMember(Name = "contentLength", EmitDefaultValue = true)]
        public string ContentLength { get; set; }

        /// <summary>
        /// The pure content length of the file.
        /// </summary>
        /// <example>12345</example>
        [DataMember(Name = "pureContentLength", EmitDefaultValue = true)]
        public long? PureContentLength { get; set; }

        /// <summary>
        /// The list of users editing the file.
        /// </summary>
        /// <example>{"00000000-0000-0000-0000-000000000000":"John Doe"}</example>
        [DataMember(Name = "editingBy", EmitDefaultValue = false)]
        public Dictionary<string, string> EditingBy { get; set; }

        /// <summary>
        /// Specifies if the file is muted or not.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "mute", EmitDefaultValue = true)]
        public bool Mute { get; set; }

        /// <summary>
        /// The URL link to view the file.
        /// </summary>
        /// <example>https://www.onlyoffice.com/viewfile?fileid=2221</example>
        [DataMember(Name = "viewUrl", EmitDefaultValue = true)]
        public string ViewUrl { get; set; }

        /// <summary>
        /// The Web URL link to the file.
        /// </summary>
        /// <example>http://localhost/files/document.docx</example>
        [DataMember(Name = "webUrl", EmitDefaultValue = true)]
        public string WebUrl { get; set; }

        /// <summary>
        /// The file extension.
        /// </summary>
        /// <example>.txt</example>
        [DataMember(Name = "fileExst", EmitDefaultValue = true)]
        public string FileExst { get; set; }

        /// <summary>
        /// The comment to the file.
        /// </summary>
        /// <example>This is a comment</example>
        [DataMember(Name = "comment", EmitDefaultValue = true)]
        public string Comment { get; set; }

        /// <summary>
        /// Specifies if the file is encrypted or not.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "encrypted", EmitDefaultValue = true)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// The thumbnail URL of the file.
        /// </summary>
        /// <example>http://localhost/thumbnails/file.png</example>
        [DataMember(Name = "thumbnailUrl", EmitDefaultValue = true)]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// Specifies if the file is locked or not.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "locked", EmitDefaultValue = true)]
        public bool? Locked { get; set; }

        /// <summary>
        /// The user ID of the person who locked the file.
        /// </summary>
        /// <example>00000000-0000-0000-0000-000000000000</example>
        [DataMember(Name = "lockedBy", EmitDefaultValue = true)]
        public string LockedBy { get; set; }

        /// <summary>
        /// Specifies if the file has a draft or not.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "hasDraft", EmitDefaultValue = true)]
        public bool? HasDraft { get; set; }

        /// <summary>
        /// Specifies if the file is a form or not.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isForm", EmitDefaultValue = true)]
        public bool? IsForm { get; set; }

        /// <summary>
        /// Specifies if the Custom Filter editing mode is enabled for a file or not.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "customFilterEnabled", EmitDefaultValue = true)]
        public bool? CustomFilterEnabled { get; set; }

        /// <summary>
        /// The name of the user who enabled a Custom Filter editing mode for a file.
        /// </summary>
        /// <example>John Doe</example>
        [DataMember(Name = "customFilterEnabledBy", EmitDefaultValue = true)]
        public string CustomFilterEnabledBy { get; set; }

        /// <summary>
        /// Specifies if the filling has started or not.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "startFilling", EmitDefaultValue = true)]
        public bool? StartFilling { get; set; }

        /// <summary>
        /// Specifies if the form filling has started but the file is still being saved by the document editor. Filling and editing are not allowed.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isFillingPreparing", EmitDefaultValue = true)]
        public bool? IsFillingPreparing { get; set; }

        /// <summary>
        /// The InProcess folder ID of the file.
        /// </summary>
        /// <example>10</example>
        [DataMember(Name = "inProcessFolderId", EmitDefaultValue = true)]
        public int? InProcessFolderId { get; set; }

        /// <summary>
        /// The InProcess folder title of the file.
        /// </summary>
        /// <example>In Process</example>
        [DataMember(Name = "inProcessFolderTitle", EmitDefaultValue = true)]
        public string InProcessFolderTitle { get; set; }

        /// <summary>
        /// The ID of the FormFillingFolderDone folder that corresponds to this original form.
        /// </summary>
        /// <example>55</example>
        [DataMember(Name = "resultsFolderId", EmitDefaultValue = true)]
        public int? ResultsFolderId { get; set; }

        /// <summary>
        /// The file draft information with its location.
        /// </summary>
        [DataMember(Name = "draftLocation", EmitDefaultValue = false)]
        public DraftLocationInteger DraftLocation { get; set; }

        /// <summary>
        /// Gets or Sets ViewAccessibility
        /// </summary>
        [DataMember(Name = "viewAccessibility", EmitDefaultValue = true)]
        public FileDtoIntegerAllOfViewAccessibility ViewAccessibility { get; set; }

        /// <summary>
        /// The time when the file was last opened.
        /// </summary>
        [DataMember(Name = "lastOpened", EmitDefaultValue = false)]
        public ApiDateTime LastOpened { get; set; }

        /// <summary>
        /// The date when the file will be expired.
        /// </summary>
        [DataMember(Name = "expired", EmitDefaultValue = false)]
        public ApiDateTime Expired { get; set; }

        /// <summary>
        /// The name of the table in the external database that corresponds to this form.
        /// </summary>
        /// <example>form_123_v1</example>
        [DataMember(Name = "externalDbTableName", EmitDefaultValue = true)]
        public string ExternalDbTableName { get; set; }

        /// <summary>
        /// Represents dimensions with width and height values.
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
            sb.Append("  ResultsFolderId: ").Append(ResultsFolderId).Append("\n");
            sb.Append("  DraftLocation: ").Append(DraftLocation).Append("\n");
            sb.Append("  ViewAccessibility: ").Append(ViewAccessibility).Append("\n");
            sb.Append("  LastOpened: ").Append(LastOpened).Append("\n");
            sb.Append("  Expired: ").Append(Expired).Append("\n");
            sb.Append("  VectorizationStatus: ").Append(VectorizationStatus).Append("\n");
            sb.Append("  ExternalDbTableName: ").Append(ExternalDbTableName).Append("\n");
            sb.Append("  Dimensions: ").Append(Dimensions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
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
