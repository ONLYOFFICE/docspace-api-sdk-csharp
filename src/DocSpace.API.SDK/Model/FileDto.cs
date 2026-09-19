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
    /// A stored file as the calling account sees it: where it lives, which revision this is, how it can be opened and  what the portal is currently doing with it.
    /// </summary>
    [DataContract(Name = "FileDto")]
    public partial class FileDto : FileEntryDto, IValidatableObject
    {

        /// <summary>
        /// What the portal is currently doing with the file and how the caller stands towards it - open in the editor,  unread, being converted, and so on. The value is a bit mask that combines those states, so a file can report a  number that matches none of the published members on its own.
        /// </summary>
        [DataMember(Name = "fileStatus", EmitDefaultValue = false)]
        public FileStatus? FileStatus { get; set; }

        /// <summary>
        /// The broad kind of content, worked out from the extension, which is what a client uses to pick an icon or a  viewer without parsing &#x60;fileExst&#x60; itself.
        /// </summary>
        [DataMember(Name = "fileType", EmitDefaultValue = false)]
        public FileType? FileType { get; set; }

        /// <summary>
        /// How far the preview image has got. Only the created state means &#x60;thumbnailUrl&#x60; holds an address; the others  mean there is none, either because it is still being produced or because this format has no preview.
        /// </summary>
        [DataMember(Name = "thumbnailStatus", EmitDefaultValue = false)]
        public Thumbnail? ThumbnailStatus { get; set; }

        /// <summary>
        /// How far the filling of this form has got for the calling account, and whose turn it is now. It is worked out  only inside a virtual data room, where filling runs in steps; everywhere else it stays at the none value.
        /// </summary>
        [DataMember(Name = "formFillingStatus", EmitDefaultValue = false)]
        public FormFillingStatus? FormFillingStatus { get; set; }

        /// <summary>
        /// How far the indexing of the file&#39;s content for AI search has got. It is null for a file that has never been  queued for indexing, which is every file while the feature is off for the portal.
        /// </summary>
        [DataMember(Name = "vectorizationStatus", EmitDefaultValue = false)]
        public VectorizationStatus? VectorizationStatus { get; set; }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="FileDto" /> class.
        /// </summary>
        /// <param name="folderId">The folder the file is stored in. When the file was reached through a share and the caller cannot open its  real parent, the identifier of the Shared with me section is reported instead, so this is where the file is  visible rather than where it physically sits..</param>
        /// <param name="version">The revision this entry describes. It starts at 1 and moves to the next number each time new content is stored  over the file, except for an editing session opened against the file itself, which replaces the content and  keeps the number. &#x60;GET api/2.0/files/file/{fileId}/history&#x60; lists them all..</param>
        /// <param name="versionGroup">Groups revisions that belong together, which is how a history can fold a long editing session into one entry:  versions saved inside one session share this number, and an upload over the file starts a new group..</param>
        /// <param name="contentLength">The size already formatted for display, with a unit and the separators of the caller&#39;s language. Read  &#x60;pureContentLength&#x60; for a number to calculate with..</param>
        /// <param name="pureContentLength">The size of the stored content in bytes, and null for an empty file..</param>
        /// <param name="fileStatus">What the portal is currently doing with the file and how the caller stands towards it - open in the editor,  unread, being converted, and so on. The value is a bit mask that combines those states, so a file can report a  number that matches none of the published members on its own..</param>
        /// <param name="editingBy">The accounts that have the file open in the editor at this moment, as account identifier to display name, and  empty when nobody has. The all-zero identifier stands for people who came in through an external link without  signing in, and its name carries their number in brackets when there is more than one..</param>
        /// <param name="mute">Not a property of the file at all: it repeats, inverted, the calling account&#39;s own switch for new-item badges,  so it is the same in every entry of one answer. True means that account has badges turned off..</param>
        /// <param name="viewUrl">The address that returns the bytes of the file - a download, in spite of the name; &#x60;webUrl&#x60; is the address a  person opens. When the file was reached through an external link the address carries the key of that link, so  it keeps working without signing in..</param>
        /// <param name="webUrl">The page that opens the file in a browser: the editor for a format the portal edits, the media viewer for  pictures, audio and video, and the download address for a format it cannot show at all..</param>
        /// <param name="fileType">The broad kind of content, worked out from the extension, which is what a client uses to pick an icon or a  viewer without parsing &#x60;fileExst&#x60; itself..</param>
        /// <param name="fileExst">The extension of the stored file, leading dot included and always lower case. For a format the portal keeps in  a converted shape this is the extension it is served under, not the one it was uploaded with..</param>
        /// <param name="comment">The note kept with this revision. The portal writes it itself for revisions it creates, an upload over an  existing file among them, and an editor stores the note a person typed when saving a version..</param>
        /// <param name="encrypted">True for a file in a private room, whose content the server never sees and which therefore cannot be converted  or taken over by an upload. Null, rather than false, for an ordinary file..</param>
        /// <param name="thumbnailUrl">The address of the generated preview image. It is filled in only while &#x60;thumbnailStatus&#x60; says the preview has  been created, and it carries a suffix that changes with the file, so an image cached for an earlier revision  is not reused..</param>
        /// <param name="thumbnailStatus">How far the preview image has got. Only the created state means &#x60;thumbnailUrl&#x60; holds an address; the others  mean there is none, either because it is still being produced or because this format has no preview..</param>
        /// <param name="locked">True while the file is held under a lock that stops anyone but its holder from editing it, and null rather  than false when there is no lock. &#x60;lockedBy&#x60; names the holder unless the caller is the holder..</param>
        /// <param name="lockedBy">The display name of the account holding the lock, and null when the caller holds it - so &#x60;locked&#x60; true  together with no name here means the lock is the caller&#39;s own..</param>
        /// <param name="hasDraft">For a fillable PDF form, whether the caller already has a filling draft of it, in which case &#x60;draftLocation&#x60;  says where that draft lives. Null for anything that is not a form..</param>
        /// <param name="formFillingStatus">How far the filling of this form has got for the calling account, and whose turn it is now. It is worked out  only inside a virtual data room, where filling runs in steps; everywhere else it stays at the none value..</param>
        /// <param name="isForm">Whether the PDF is a fillable form rather than a plain document. When the stored classification does not say,  the portal opens the file to find out, so the answer is reliable for a PDF and null for anything else..</param>
        /// <param name="customFilterEnabled">True while a spreadsheet is in the mode where each person sorts and filters their own view without changing  what the others see, and null rather than false when it is not..</param>
        /// <param name="customFilterEnabledBy">The display name of the account that turned that mode on, and null when the caller turned it on themselves..</param>
        /// <param name="startFilling">For a form in a room for filling, whether it has been released for filling; until then it is still being  prepared and only the people running the room work with it. Null for a file this does not apply to..</param>
        /// <param name="isFillingPreparing">True during the short window in which a released form is still being written out by the editor. Neither  filling nor editing is accepted while it lasts, so a client should wait and read the file again..</param>
        /// <param name="inProcessFolderId">Left empty by the portal: the folder holding the caller&#39;s draft is reported in &#x60;draftLocation&#x60; instead..</param>
        /// <param name="inProcessFolderTitle">Left empty by the portal, like the identifier beside it; the draft&#39;s folder is named in &#x60;draftLocation&#x60;..</param>
        /// <param name="resultsFolderId">The folder that collects the completed copies of this form. It is filled in only for the original form of a  room for filling, and only for a caller allowed to work with that form; null everywhere else..</param>
        /// <param name="draftLocation">Where the caller&#39;s own filling draft of this form is kept. Null when there is no draft yet, which is the same  thing &#x60;hasDraft&#x60; reports..</param>
        /// <param name="viewAccessibility">viewAccessibility.</param>
        /// <param name="lastOpened">The moment the caller last opened the file. It is kept per account and is what orders the Recent section, so  it is null for a file this account has never opened. Written with the offset of the portal&#39;s time zone..</param>
        /// <param name="expired">The moment the file falls under the lifetime rule of the room holding it and is removed. It is counted from  the first revision rather than the latest one, so editing a file does not postpone it, and it is null when the  room sets no lifetime. Written with the offset of the portal&#39;s time zone..</param>
        /// <param name="vectorizationStatus">How far the indexing of the file&#39;s content for AI search has got. It is null for a file that has never been  queued for indexing, which is every file while the feature is off for the portal..</param>
        /// <param name="externalDbTableName">The table collecting the submitted values of this form in the external database configured for its room. The  field is left out of the answer entirely when the form has no such table..</param>
        /// <param name="dimensions">The pixel size of the picture, measured by reading the stored file rather than taken from any stored metadata.  Null for anything that is not a picture the portal can show, and also when the file could not be read..</param>
        public FileDto(int folderId = default, int version = default, int versionGroup = default, string contentLength = default, long? pureContentLength = default, FileStatus? fileStatus = default, Dictionary<string, string> editingBy = default, bool mute = default, string viewUrl = default, string webUrl = default, FileType? fileType = default, string fileExst = default, string comment = default, bool? encrypted = default, string thumbnailUrl = default, Thumbnail? thumbnailStatus = default, bool? locked = default, string lockedBy = default, bool? hasDraft = default, FormFillingStatus? formFillingStatus = default, bool? isForm = default, bool? customFilterEnabled = default, string customFilterEnabledBy = default, bool? startFilling = default, bool? isFillingPreparing = default, int? inProcessFolderId = default, string inProcessFolderTitle = default, int? resultsFolderId = default, DraftLocation draftLocation = default, FileDtoAllOfViewAccessibility viewAccessibility = default, ApiDateTime lastOpened = default, ApiDateTime expired = default, VectorizationStatus? vectorizationStatus = default, string externalDbTableName = default, Size dimensions = default)
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
        /// The folder the file is stored in. When the file was reached through a share and the caller cannot open its  real parent, the identifier of the Shared with me section is reported instead, so this is where the file is  visible rather than where it physically sits.
        /// </summary>
        /// <example>10</example>
        [DataMember(Name = "folderId", EmitDefaultValue = false)]
        public int FolderId { get; set; }

        /// <summary>
        /// The revision this entry describes. It starts at 1 and moves to the next number each time new content is stored  over the file, except for an editing session opened against the file itself, which replaces the content and  keeps the number. &#x60;GET api/2.0/files/file/{fileId}/history&#x60; lists them all.
        /// </summary>
        /// <example>3</example>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public int @Version { get; set; }

        /// <summary>
        /// Groups revisions that belong together, which is how a history can fold a long editing session into one entry:  versions saved inside one session share this number, and an upload over the file starts a new group.
        /// </summary>
        /// <example>1</example>
        [DataMember(Name = "versionGroup", EmitDefaultValue = false)]
        public int VersionGroup { get; set; }

        /// <summary>
        /// The size already formatted for display, with a unit and the separators of the caller&#39;s language. Read  &#x60;pureContentLength&#x60; for a number to calculate with.
        /// </summary>
        /// <example>1.29 MB</example>
        [DataMember(Name = "contentLength", EmitDefaultValue = true)]
        public string ContentLength { get; set; }

        /// <summary>
        /// The size of the stored content in bytes, and null for an empty file.
        /// </summary>
        /// <example>1352001</example>
        [DataMember(Name = "pureContentLength", EmitDefaultValue = true)]
        public long? PureContentLength { get; set; }

        /// <summary>
        /// The accounts that have the file open in the editor at this moment, as account identifier to display name, and  empty when nobody has. The all-zero identifier stands for people who came in through an external link without  signing in, and its name carries their number in brackets when there is more than one.
        /// </summary>
        /// <example>{"9a1e28c4-51f2-4f6b-b0a3-0c21e7f2a7d1":"John Doe"}</example>
        [DataMember(Name = "editingBy", EmitDefaultValue = false)]
        public Dictionary<string, string> EditingBy { get; set; }

        /// <summary>
        /// Not a property of the file at all: it repeats, inverted, the calling account&#39;s own switch for new-item badges,  so it is the same in every entry of one answer. True means that account has badges turned off.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "mute", EmitDefaultValue = true)]
        public bool Mute { get; set; }

        /// <summary>
        /// The address that returns the bytes of the file - a download, in spite of the name; &#x60;webUrl&#x60; is the address a  person opens. When the file was reached through an external link the address carries the key of that link, so  it keeps working without signing in.
        /// </summary>
        /// <example>https://example.com/filehandler.ashx?action=download&amp;fileid=2221</example>
        [DataMember(Name = "viewUrl", EmitDefaultValue = true)]
        public string ViewUrl { get; set; }

        /// <summary>
        /// The page that opens the file in a browser: the editor for a format the portal edits, the media viewer for  pictures, audio and video, and the download address for a format it cannot show at all.
        /// </summary>
        /// <example>https://example.com/doceditor?fileid=2221</example>
        [DataMember(Name = "webUrl", EmitDefaultValue = true)]
        public string WebUrl { get; set; }

        /// <summary>
        /// The extension of the stored file, leading dot included and always lower case. For a format the portal keeps in  a converted shape this is the extension it is served under, not the one it was uploaded with.
        /// </summary>
        /// <example>.docx</example>
        [DataMember(Name = "fileExst", EmitDefaultValue = true)]
        public string FileExst { get; set; }

        /// <summary>
        /// The note kept with this revision. The portal writes it itself for revisions it creates, an upload over an  existing file among them, and an editor stores the note a person typed when saving a version.
        /// </summary>
        /// <example>Uploaded file</example>
        [DataMember(Name = "comment", EmitDefaultValue = true)]
        public string Comment { get; set; }

        /// <summary>
        /// True for a file in a private room, whose content the server never sees and which therefore cannot be converted  or taken over by an upload. Null, rather than false, for an ordinary file.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "encrypted", EmitDefaultValue = true)]
        public bool? Encrypted { get; set; }

        /// <summary>
        /// The address of the generated preview image. It is filled in only while &#x60;thumbnailStatus&#x60; says the preview has  been created, and it carries a suffix that changes with the file, so an image cached for an earlier revision  is not reused.
        /// </summary>
        /// <example>https://example.com/filehandler.ashx?action=thumb&amp;fileid=2221</example>
        [DataMember(Name = "thumbnailUrl", EmitDefaultValue = true)]
        public string ThumbnailUrl { get; set; }

        /// <summary>
        /// True while the file is held under a lock that stops anyone but its holder from editing it, and null rather  than false when there is no lock. &#x60;lockedBy&#x60; names the holder unless the caller is the holder.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "locked", EmitDefaultValue = true)]
        public bool? Locked { get; set; }

        /// <summary>
        /// The display name of the account holding the lock, and null when the caller holds it - so &#x60;locked&#x60; true  together with no name here means the lock is the caller&#39;s own.
        /// </summary>
        /// <example>John Doe</example>
        [DataMember(Name = "lockedBy", EmitDefaultValue = true)]
        public string LockedBy { get; set; }

        /// <summary>
        /// For a fillable PDF form, whether the caller already has a filling draft of it, in which case &#x60;draftLocation&#x60;  says where that draft lives. Null for anything that is not a form.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "hasDraft", EmitDefaultValue = true)]
        public bool? HasDraft { get; set; }

        /// <summary>
        /// Whether the PDF is a fillable form rather than a plain document. When the stored classification does not say,  the portal opens the file to find out, so the answer is reliable for a PDF and null for anything else.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "isForm", EmitDefaultValue = true)]
        public bool? IsForm { get; set; }

        /// <summary>
        /// True while a spreadsheet is in the mode where each person sorts and filters their own view without changing  what the others see, and null rather than false when it is not.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "customFilterEnabled", EmitDefaultValue = true)]
        public bool? CustomFilterEnabled { get; set; }

        /// <summary>
        /// The display name of the account that turned that mode on, and null when the caller turned it on themselves.
        /// </summary>
        /// <example>John Doe</example>
        [DataMember(Name = "customFilterEnabledBy", EmitDefaultValue = true)]
        public string CustomFilterEnabledBy { get; set; }

        /// <summary>
        /// For a form in a room for filling, whether it has been released for filling; until then it is still being  prepared and only the people running the room work with it. Null for a file this does not apply to.
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "startFilling", EmitDefaultValue = true)]
        public bool? StartFilling { get; set; }

        /// <summary>
        /// True during the short window in which a released form is still being written out by the editor. Neither  filling nor editing is accepted while it lasts, so a client should wait and read the file again.
        /// </summary>
        /// <example>false</example>
        [DataMember(Name = "isFillingPreparing", EmitDefaultValue = true)]
        public bool? IsFillingPreparing { get; set; }

        /// <summary>
        /// Left empty by the portal: the folder holding the caller&#39;s draft is reported in &#x60;draftLocation&#x60; instead.
        /// </summary>
        /// <example>10</example>
        [DataMember(Name = "inProcessFolderId", EmitDefaultValue = true)]
        public int? InProcessFolderId { get; set; }

        /// <summary>
        /// Left empty by the portal, like the identifier beside it; the draft&#39;s folder is named in &#x60;draftLocation&#x60;.
        /// </summary>
        /// <example>In Process</example>
        [DataMember(Name = "inProcessFolderTitle", EmitDefaultValue = true)]
        public string InProcessFolderTitle { get; set; }

        /// <summary>
        /// The folder that collects the completed copies of this form. It is filled in only for the original form of a  room for filling, and only for a caller allowed to work with that form; null everywhere else.
        /// </summary>
        /// <example>55</example>
        [DataMember(Name = "resultsFolderId", EmitDefaultValue = true)]
        public int? ResultsFolderId { get; set; }

        /// <summary>
        /// Where the caller&#39;s own filling draft of this form is kept. Null when there is no draft yet, which is the same  thing &#x60;hasDraft&#x60; reports.
        /// </summary>
        [DataMember(Name = "draftLocation", EmitDefaultValue = false)]
        public DraftLocation DraftLocation { get; set; }

        /// <summary>
        /// Gets or Sets ViewAccessibility
        /// </summary>
        [DataMember(Name = "viewAccessibility", EmitDefaultValue = true)]
        public FileDtoAllOfViewAccessibility ViewAccessibility { get; set; }

        /// <summary>
        /// The moment the caller last opened the file. It is kept per account and is what orders the Recent section, so  it is null for a file this account has never opened. Written with the offset of the portal&#39;s time zone.
        /// </summary>
        [DataMember(Name = "lastOpened", EmitDefaultValue = false)]
        public ApiDateTime LastOpened { get; set; }

        /// <summary>
        /// The moment the file falls under the lifetime rule of the room holding it and is removed. It is counted from  the first revision rather than the latest one, so editing a file does not postpone it, and it is null when the  room sets no lifetime. Written with the offset of the portal&#39;s time zone.
        /// </summary>
        [DataMember(Name = "expired", EmitDefaultValue = false)]
        public ApiDateTime Expired { get; set; }

        /// <summary>
        /// The table collecting the submitted values of this form in the external database configured for its room. The  field is left out of the answer entirely when the form has no such table.
        /// </summary>
        /// <example>form_123_v1</example>
        [DataMember(Name = "externalDbTableName", EmitDefaultValue = true)]
        public string ExternalDbTableName { get; set; }

        /// <summary>
        /// The pixel size of the picture, measured by reading the stored file rather than taken from any stored metadata.  Null for anything that is not a picture the portal can show, and also when the file could not be read.
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
            sb.Append("class FileDto {\n");
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
