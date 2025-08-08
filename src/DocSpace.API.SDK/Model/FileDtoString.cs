// (c) Copyright Ascensio System SIA 2025
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

 
 using DocSpace.API.SDK.Client;
 

namespace DocSpace.API.SDK.Model
{
    /// <summary>
    /// The file parameters.
    /// </summary>
    [DataContract(Name = "FileDtoString")]
    public partial class FileDtoString : FileEntryDtoString, IValidatableObject
    {

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
        /// Initializes a new instance of the <see cref="FileDtoString" /> class.
        /// </summary>
        /// <param name="folderId">The folder ID where the file is located..</param>
        /// <param name="version">The file version..</param>
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
        public FileDtoString(string folderId = default, int version = default, int versionGroup = default, string contentLength = default, long? pureContentLength = default, FileStatus? fileStatus = default, bool mute = default, string viewUrl = default, string webUrl = default, string shortWebUrl = default, FileType? fileType = default, string fileExst = default, string comment = default, bool? encrypted = default, string thumbnailUrl = default, Thumbnail? thumbnailStatus = default, bool? locked = default, string lockedBy = default, bool? hasDraft = default, FormFillingStatus? formFillingStatus = default, bool? isForm = default, bool? customFilterEnabled = default, string customFilterEnabledBy = default, bool? startFilling = default, int? inProcessFolderId = default, string inProcessFolderTitle = default, DraftLocationString draftLocation = default, FileDtoIntegerAllOfViewAccessibility viewAccessibility = default, Dictionary<string, bool> availableExternalRights = default, ApiDateTime lastOpened = default, ApiDateTime expired = default)
        {
            this.FolderId = folderId;
            this.@Version = version;
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
        }

        /// <summary>
        /// The folder ID where the file is located.
        /// </summary>
        /// <value>The folder ID where the file is located.</value>
        /*
        <example>9846</example>
        */
        [DataMember(Name = "folderId", EmitDefaultValue = true)]
        public string FolderId { get; set; }

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
        public DraftLocationString DraftLocation { get; set; }

        /// <summary>
        /// Gets or Sets ViewAccessibility
        /// </summary>
        [DataMember(Name = "viewAccessibility", EmitDefaultValue = true)]
        public FileDtoIntegerAllOfViewAccessibility ViewAccessibility { get; set; }

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
            var sb = new StringBuilder();
            sb.Append("class FileDtoString {\n");
            sb.Append("  FolderId: ").Append(FolderId).Append("\n");
            sb.Append("  @Version: ").Append(@Version).Append("\n");
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
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
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
